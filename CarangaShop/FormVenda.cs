using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarangaShop {
    public partial class FormVenda : Form {
        private SqlCommand sqlComm;
        private SqlManager sqlMgr;
        private SqlDataReader sqlDataReader;
        private int iRowSelectLV;
        private int iQtdMaximaEstoque;

        public FormVenda() {
            InitializeComponent();

            this.sqlComm = new SqlCommand();
            this.sqlMgr = new SqlManager();

            this.setStartState();
        }


        private void setStartState() {
            try {
                Utils.disableFields(gbInfoNovaVenda);
                Utils.cleanFields(gbEditarQuantidade);
                Utils.disableFields(gbEditarQuantidade);

                bCancelarEditarItem.Enabled = false;
                bAlterarItem.Enabled = false;

                bCancelarVenda.Enabled = false;
                bAdicionarItemVenda.Enabled = false;
                bIncluirItemVenda.Enabled = true;

                this.iRowSelectLV = 0;
                this.iQtdMaximaEstoque = 0;
                progressBar1.Value = 0;

                errorProvider1.Clear();
                lbEmEstoque.Text = "";
                lbEmEstoque.Visible = false;
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }
        }


        private void FormVenda_Load(object sender, EventArgs e) {
            this.tabelaClienteTableAdapter.Fill(this.carangaShopDataSet1.TabelaCliente);
            this.tabelaCategoriaTableAdapter.Fill(this.carangaShopDataSet1.TabelaCategoria);
            this.tabelaFuncionarioTableAdapter.Fill(this.carangaShopDataSet1.TabelaFuncionario);

            // popula campo funcionário com o funcionário logado no momento
            this.sqlMgr.closeConnection();
            this.sqlComm = new SqlCommand("SELECT * FROM TabelaFuncionario WHERE IDFunc = '" + Utils.ID_FUNCIONARIO_LOGADO + "'", SqlManager.CONN);
            this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);

            if (this.sqlDataReader.HasRows) {
                if (this.sqlDataReader.Read()) {
                    String sNomeFunc = this.sqlDataReader["NomeFunc"].ToString();
                    cbFuncionarioVenda.SelectedIndex = cbFuncionarioVenda.FindStringExact(sNomeFunc);
                    cbFuncionarioVenda.Enabled = false;
                }
            }
        }


        private void bIncluirItemVenda_Click(object sender, EventArgs e) {
            Utils.enableFields(gbInfoNovaVenda);

            cbFuncionarioVenda.Enabled = false;
            cbCategoriaVenda.Enabled = true;

            // preenche combobox de marcas que pertencem à categoria selecionada atualmente
            this.filterMarksCombobox();

            // preenche combobox de modelos baseado na marca selecionada atualmente
            this.filterModelsCombobox();

            // preenche combobox de veículos baseado no modelo selecionado atualmente
            this.filterVehiclesCombobox();

            bIncluirItemVenda.Enabled = false;
            bCancelarVenda.Enabled = true;
            bAdicionarItemVenda.Enabled = true;
        }


        private void bAdicionarItemVenda_Click(object sender, EventArgs e) {
            errorProvider1.Clear();

            // <Validações do FORM>
            int iParsedQtd;
            if( !int.TryParse(tbQuantidade.Text, out iParsedQtd)  || int.Parse(tbQuantidade.Text) <= 0 ||  "".Equals(tbQuantidade.Text) ) {
                errorProvider1.SetError(tbQuantidade, "Este valor não pode estar vazio e deve ser um valor numérico maior que zero!");
                return;
            }
            decimal dParsedValorUn;
            if (!decimal.TryParse(tbPrecoUn.Text, out dParsedValorUn) || decimal.Parse(tbPrecoUn.Text) <= 0 || "".Equals(tbPrecoUn.Text)) {
                errorProvider1.SetError(tbPrecoUn, "Este valor não pode estar vazio e deve ser um valor numérico maior que zero!");
                return;
            }
            // </Validações do FORM>

            if ( int.Parse(tbQuantidade.Text) <= 0 ) {
                Utils.showSimpleMessageBox("Aviso", "A quantidade do veículo deve ser maior que zero!", "warning");
                return;
            } else {
                ComboboxItem cbItemSelecionado;
                ComboBox cmb = (ComboBox)cbModeloVenda;
                cbItemSelecionado = (ComboboxItem)cmb.SelectedItem;
                String sModelo = cbItemSelecionado.Text.ToString();

                ComboboxItem cbItemSelecionado2;
                ComboBox cmb2 = (ComboBox)cbVeiculoVenda;
                cbItemSelecionado2 = (ComboboxItem)cmb2.SelectedItem;
                String sVeiculo = cbItemSelecionado2.Text.ToString();

                int iQtdAntiga = 0;
                double dValorAntigo = 0;
                bool bExisteVeiculo = false;
                int iVeiculoEscolhido = int.Parse(this.getSelectedVehicle());
                for (int i=0; i<listView1.Items.Count; i++) {
                    int idRow = int.Parse(listView1.Items[i].SubItems[0].Text);
                    if(idRow == iVeiculoEscolhido) {
                        bExisteVeiculo = true;
                        iQtdAntiga = int.Parse(listView1.Items[i].SubItems[3].Text);
                        int iQtdAtual = iQtdAntiga + int.Parse(tbQuantidade.Text);

                        if(iQtdAtual > this.iQtdMaximaEstoque) {
                            Utils.showSimpleMessageBox("Aviso", "Você não pode incluir na venda uma quantidade do veículo maior que o disponível no estoque!", "warning");
                            return;
                        }

                        dValorAntigo = double.Parse(listView1.Items[i].SubItems[4].Text);
                        double dValorAtual = dValorAntigo + (double.Parse(tbPrecoUn.Text) * int.Parse(tbQuantidade.Text));

                        listView1.Items[i].SubItems[3].Text = iQtdAtual.ToString();
                        listView1.Items[i].SubItems[4].Text = dValorAtual.ToString();
                    }
                }

                if(!bExisteVeiculo) {
                    decimal dValor = int.Parse(tbQuantidade.Text) * decimal.Parse(tbPrecoUn.Text);

                    ListViewItem lvi = new ListViewItem(this.getSelectedVehicle());
                    lvi.SubItems.Add(sModelo);
                    lvi.SubItems.Add(sVeiculo);
                    lvi.SubItems.Add(tbQuantidade.Text);
                    lvi.SubItems.Add(dValor.ToString());
                    listView1.Items.Add(lvi);
                }

                this.setStartState();
            }
        }


        private void bRemoverItemVenda_Click(object sender, EventArgs e) {
            if (listView1.SelectedItems.Count == 0) return;

            listView1.SelectedItems[0].Remove();
            if (listView1.Items.Count == 0) {
                Utils.disableFields(gbEditarQuantidade);
                bCancelarEditarItem.Enabled = false;
                bAlterarItem.Enabled = false;
            }
        }


        private void bRemoverTodosItensVenda_Click(object sender, EventArgs e) {
            if (listView1.Items.Count == 0) return;

            listView1.Items.Clear();
            Utils.disableFields(gbEditarQuantidade);
            bCancelarEditarItem.Enabled = false;
            bAlterarItem.Enabled = false;
        }


        private void bFinalizarVenda_Click(object sender, EventArgs e) {
            if (listView1.Items.Count == 0) {
                Utils.showSimpleMessageBox("Aviso", "Por favor, adicione pelo menos um veículo à sua venda!", "warning");
                return;
            }

            decimal dValue = 0;
            for(int i=0; i<listView1.Items.Count; i++) {
                Utils.dg("=> Somando += " + listView1.Items[i].SubItems[4].Text);
                dValue += decimal.Parse(listView1.Items[i].SubItems[4].Text);
            }
            Utils.dg("TOTAL DA VENDA> " + dValue);

            this.sqlMgr.closeConnection();
            this.sqlComm = new SqlCommand(" INSERT INTO TabelaVenda (DataVenda, ValorTotalVenda, IDFunc, IDCli) " +
                                            " output INSERTED.IDVenda " +
                                            "VALUES (@DataVenda, @ValorTotalVenda, @IDFunc, @IDCli)", SqlManager.CONN);

            this.sqlComm.Parameters.Add("@IDVenda", SqlDbType.Int);
            this.sqlComm.Parameters["@IDVenda"].Value = 0;

            this.sqlComm.Parameters.Add("@DataVenda", SqlDbType.Date);
            this.sqlComm.Parameters["@DataVenda"].Value = DateTime.Now.ToString("yyyy-MM-dd");

            String sFinal = dValue.ToString();
            sFinal = sFinal.Replace(',', '.');
            decimal d;
            decimal.TryParse(sFinal, NumberStyles.Any, CultureInfo.InvariantCulture, out d);
            this.sqlComm.Parameters.Add("@ValorTotalVenda", SqlDbType.Decimal);
            this.sqlComm.Parameters["@ValorTotalVenda"].Value = d;

            this.sqlComm.Parameters.Add("@IDFunc", SqlDbType.Int);
            this.sqlComm.Parameters["@IDFunc"].Value = cbFuncionarioVenda.SelectedValue;

            this.sqlComm.Parameters.Add("@IDCli", SqlDbType.Int);
            this.sqlComm.Parameters["@IDCli"].Value = cbClienteVenda.SelectedValue;

            int iIdVenda_FK = this.sqlMgr.performQueryReturnId(this.sqlComm);

            Utils.dg("############ ID da Venda: " + iIdVenda_FK);
            // ao cadastrar a venda, já existe o valor necessário para fazer a vinculação com os registros de itens de venda
            if (iIdVenda_FK > 0) {
                try {
                    for (int i = 0; i < listView1.Items.Count; i++) {
                        // Incrementa item na venda
                        this.sqlMgr.closeConnection();
                        this.sqlComm = new SqlCommand(" INSERT INTO TabelaItensVenda (QuantItv, ValorTotalItv, IDVei, IDVenda) " +
                                                        "VALUES (@QuantItv, @ValorTotalItv, @IDVei, @IDVenda)", SqlManager.CONN);


                        this.sqlComm.Parameters.Add("@IDItv", SqlDbType.Int);
                        this.sqlComm.Parameters["@IDItv"].Value = 0;

                        this.sqlComm.Parameters.Add("@QuantItv", SqlDbType.Int);
                        this.sqlComm.Parameters["@QuantItv"].Value = int.Parse(listView1.Items[i].SubItems[3].Text);

                        decimal dValue2 = decimal.Parse(listView1.Items[i].SubItems[4].Text) / int.Parse(listView1.Items[i].SubItems[3].Text);
                        String sValorFinal = dValue2.ToString();
                        sValorFinal = sValorFinal.Replace(',', '.');
                        decimal decimal2;
                        decimal.TryParse(sValorFinal, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal2);
                        this.sqlComm.Parameters.Add("@ValorTotalItv", SqlDbType.Decimal);
                        this.sqlComm.Parameters["@ValorTotalItv"].Value = decimal2;

                        this.sqlComm.Parameters.Add("@IDVei", SqlDbType.Int);
                        this.sqlComm.Parameters["@IDVei"].Value = int.Parse(listView1.Items[i].SubItems[0].Text);

                        this.sqlComm.Parameters.Add("@IDVenda", SqlDbType.Int);
                        this.sqlComm.Parameters["@IDVenda"].Value = iIdVenda_FK;

                        this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);

                        Utils.dg("passou saaaaafe até aqui!!!");



                        // Diminui veículo no estoque
                        int iQtdAtual = 0;

                        this.sqlMgr.closeConnection();
                        this.sqlComm = new SqlCommand(" SELECT * FROM TabelaEstoque WHERE IDVei = '" + int.Parse(listView1.Items[i].SubItems[0].Text) + "'", SqlManager.CONN);
                        this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                        if (this.sqlDataReader.HasRows && this.sqlDataReader.Read()) {
                            iQtdAtual = int.Parse(this.sqlDataReader["QuantEst"].ToString());
                        }
                        Utils.dg("passou saaaaafe até aqui (2)!!!");

                        int iQtdFinal = iQtdAtual - int.Parse(listView1.Items[i].SubItems[3].Text);
                        //Utils.dg("Quantidade do veículo era: " + iQtdFinal);
                        //Utils.dg("UPDATE TabelaEstoque " +
                          //          " SET QuantEst = '" + iQtdFinal + "'" +
                            //        " WHERE IDVei = '" + listView1.Items[i].SubItems[0].Text + "'");
                        //return;

                        this.sqlMgr.closeConnection();
                        this.sqlComm = new SqlCommand("UPDATE TabelaEstoque " +
                                                            " SET QuantEst = '" + iQtdFinal + "'" +
                                                            " WHERE IDVei = '" + listView1.Items[i].SubItems[0].Text + "'", SqlManager.CONN);
                        this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                    }


                    Utils.showSimpleMessageBox("Sucesso", "Venda e itens da venda cadastrados com sucesso!", "success");

                    decimal value = 0.00M;
                    value = Convert.ToDecimal(dValue);
                    Utils.dg(value.ToString("C2"));


                    String sDetalhesVenda = "Olá, " + cbClienteVenda.Text + "! Segue neste email os detalhes da venda realizada pelo funcionário " + cbFuncionarioVenda.Text +
                        ", colaborador da CarangaShop! Somando todos os veículos adquiridos, o montante total da sua venda foi de R$ " + value.ToString("C2");
                    Utils.sendEmail(iIdVenda_FK, sDetalhesVenda);

                    int it;
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = 50;
                    for (it = 0; it <= 50; it++) {
                        progressBar1.Value = it;
                    }

                    Utils.showSimpleMessageBox("Sucesso", "Email com os detalhes da venda enviado para: cliente@exemplo.com", "success");
                    progressBar1.Value = 0;

                    this.setStartState();
                    Utils.disableFields(gbInfoNovaVenda);
                    Utils.cleanFields(gbInfoNovaVenda);
                    Utils.disableFields(gbEditarQuantidade);
                    Utils.cleanFields(gbEditarQuantidade);
                    listView1.Items.Clear();
                } catch(Exception ex) {
                    Utils.showSimpleMessageBox("Erro", "Problemas ao cadastrar os itens da venda!", "wrong");
                    Utils.dg(ex.StackTrace);
                }
            } else {
                Utils.showSimpleMessageBox("Erro", "Erro ao cadastrar nova venda!", "wrong");
            }

        }


        private void bCancelarVenda_Click(object sender, EventArgs e) {
            this.setStartState();
        }


        private void bCancelarEditarItem_Click(object sender, EventArgs e) {
            this.setStartState();
        }


        private void bAlterarItem_Click(object sender, EventArgs e) {
            int iQtdAntiga = int.Parse(listView1.Items[this.iRowSelectLV].SubItems[3].Text);
            decimal dValorAntigo = decimal.Parse(listView1.Items[this.iRowSelectLV].SubItems[4].Text);
            decimal dPrecoUnit = dValorAntigo / iQtdAntiga;

            decimal dValorFinal = 0;
            int iQtdNova = int.Parse(tbEditQntItem.Text);
            if( iQtdAntiga != iQtdNova) { // teve alteração
                if(iQtdAntiga > iQtdNova) { // diminuiu a quantidade
                    int iQtdDecremento = iQtdAntiga - iQtdNova;
                    dValorFinal = dValorAntigo - (iQtdDecremento * dPrecoUnit);
                } else { // aumentou a quantidade
                    int iQtdAumento = iQtdNova - iQtdAntiga;
                    dValorFinal = dValorAntigo + (iQtdAumento * dPrecoUnit);
                }

                listView1.Items[this.iRowSelectLV].SubItems[3].Text = tbEditQntItem.Text;
                listView1.Items[this.iRowSelectLV].SubItems[4].Text = dValorFinal.ToString();
            }
        }


        private void tbQuantidade_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) ) {
                e.Handled = true;
            }
        }


        private void listView1_ItemSelectionChanged_1(object sender, ListViewItemSelectionChangedEventArgs e) {
            if (e.IsSelected) {
                try {
                    this.iRowSelectLV = listView1.FocusedItem.Index;
                    tbEditQntItem.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[3].Text;

                    Utils.enableFields(gbEditarQuantidade);
                    bCancelarEditarItem.Enabled = true;
                    bAlterarItem.Enabled = true;
                } catch (Exception ex) {
                    Utils.dg(ex.StackTrace);
                }
            }
        }

        // ----------------

        private void filterMarksCombobox() {

            try {
                int iIdCategoria = int.Parse(cbCategoriaVenda.SelectedValue.ToString());

                bool bAlreadySetted = false;
                if (cbMarcaVenda.Items.Count > 0) cbMarcaVenda.Items.Clear();

                this.sqlMgr.closeConnection();
                this.sqlComm = new SqlCommand("SELECT * FROM TabelaMarca WHERE IdCat = '" + iIdCategoria + "'", SqlManager.CONN);
                this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                if (this.sqlDataReader.HasRows) {
                    while (this.sqlDataReader.Read()) {
                        ComboboxItem cbItem = new ComboboxItem();
                        cbItem.Value = this.sqlDataReader["IDMar"].ToString();
                        cbItem.Text = this.sqlDataReader["NomeMar"].ToString();
                        cbMarcaVenda.Items.Add(cbItem);

                        if (!bAlreadySetted) {
                            cbMarcaVenda.SelectedItem = cbItem;
                            bAlreadySetted = true;
                        }
                    }
                }
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }
        }


        private void filterModelsCombobox() {
            try {
                bAdicionarItemVenda.Enabled = true;
                bool bAlreadySetted = false;
                cbModeloVenda.Enabled = true;
                if (cbModeloVenda.Items.Count > 0) cbModeloVenda.Items.Clear();
                String sIdMarcaSelecionada = this.getSelectedMark();

                this.sqlMgr.closeConnection();
                this.sqlComm = new SqlCommand("SELECT * FROM TabelaModelo WHERE IDMar = '" + sIdMarcaSelecionada + "'", SqlManager.CONN);
                this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                if (this.sqlDataReader.HasRows) {
                    while (this.sqlDataReader.Read()) {
                        ComboboxItem cbItem = new ComboboxItem();
                        cbItem.Value = this.sqlDataReader["IDMod"].ToString();
                        cbItem.Text = this.sqlDataReader["NomeMod"].ToString();
                        cbModeloVenda.Items.Add(cbItem);

                        if (!bAlreadySetted) {
                            cbModeloVenda.SelectedItem = cbItem;
                            bAlreadySetted = true;
                        }
                    }
                } else {
                    cbModeloVenda.Enabled = false;
                    bAdicionarItemVenda.Enabled = false;

                    cbVeiculoVenda.Enabled = false;
                    tbQuantidade.Enabled = false;
                    cbVeiculoVenda.Items.Clear();
                    cbVeiculoVenda.Text = "";
                    tbQuantidade.Text = "";
                    tbPrecoUn.Text = "";
                }
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }
        }


        private void filterVehiclesCombobox() {
            int iMarca = int.Parse(this.getSelectedMark());

            try {
                int iModelo = int.Parse(this.getSelectedModel());
                Utils.dg("[CHEGADA NO MÉTODO fillVehiclesCombobox()] --> Marca: " + iMarca + "  &&  --> Modelo: " + iModelo);


                if (iMarca > 0 && iModelo > 0) {
                    try {
                        bAdicionarItemVenda.Enabled = true;
                        cbVeiculoVenda.Enabled = true;
                        if (cbVeiculoVenda.Items.Count > 0) cbVeiculoVenda.Items.Clear();
                        bool bAlreadySetted = false;

                        this.sqlMgr.closeConnection();
                        this.sqlComm = new SqlCommand("SELECT * FROM TabelaVeiculo WHERE IDMod = '" + iModelo + "'", SqlManager.CONN);
                        this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                        if (this.sqlDataReader.HasRows) {
                            cbVeiculoVenda.Enabled = true;
                            tbQuantidade.Enabled = true;

                            while (this.sqlDataReader.Read()) {
                                ComboboxItem cbItem = new ComboboxItem();
                                cbItem.Value = this.sqlDataReader["IDVei"].ToString();
                                cbItem.Text = this.sqlDataReader["AnoModeloVei"].ToString() + " - " + this.sqlDataReader["CombustivelVei"].ToString();
                                cbVeiculoVenda.Items.Add(cbItem);

                                if (!bAlreadySetted) {
                                    cbVeiculoVenda.SelectedItem = cbItem;
                                    bAlreadySetted = true;
                                }
                            }

                            // preenche os dois campos referentes ao veículo escolhido
                            this.fillVehicleFields();
                        } else {
                            cbVeiculoVenda.Enabled = false;
                            cbVeiculoVenda.Items.Clear();
                            cbVeiculoVenda.Text = "";

                            tbQuantidade.Enabled = false;
                            tbQuantidade.Text = "";
                            tbPrecoUn.Text = "";

                            bAdicionarItemVenda.Enabled = false;
                        }
                    } catch (Exception ex) {
                        Utils.dg(ex.StackTrace);
                    }


                }

            } catch (Exception ex) {
                Utils.dg("Opa, provavelmente não tinha modelo cadastrado para a marca atual!!");
                Utils.dg(ex.StackTrace);
            }
            
        }


        private void fillVehicleFields() {
            this.sqlMgr.closeConnection();
            this.sqlComm = new SqlCommand("SELECT * FROM TabelaVeiculo v " +
                                            " INNER JOIN TabelaEstoque e ON(e.IDVei = v.IDVei) " +
                                            " WHERE v.IDVei = '" + this.getSelectedVehicle() + "'", SqlManager.CONN);
            this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
            if (this.sqlDataReader.HasRows) {
                while (this.sqlDataReader.Read()) {
                    tbQuantidade.Text = 1.ToString();
                    tbQuantidade.Maximum = int.Parse(this.sqlDataReader["QuantEst"].ToString());

                    lbEmEstoque.Text = "Em estoque: " + this.sqlDataReader["QuantEst"].ToString();
                    lbEmEstoque.Visible = true;
                    this.iQtdMaximaEstoque = int.Parse(this.sqlDataReader["QuantEst"].ToString());

                    tbPrecoUn.Text = this.sqlDataReader["PrecoUnitVei"].ToString();
                    tbPrecoUn.Enabled = false;
                }
            } else {
                cbVeiculoVenda.Enabled = false;
                bAdicionarItemVenda.Enabled = false;
            }
        }


        // ----------------


        private String getSelectedMark() {
            try {
                String sIdMarcaSelecionada;
                ComboboxItem cbItemSelecionado;
                ComboBox cmb = (ComboBox)cbMarcaVenda;
                cbItemSelecionado = (ComboboxItem)cmb.SelectedItem;
                sIdMarcaSelecionada = cbItemSelecionado.Value.ToString();

                return sIdMarcaSelecionada;
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
                return null;
            }
        }


        private String getSelectedModel() {
            try {
                String sIDMod;
                ComboboxItem cbItemSelecionado;
                ComboBox cmb = (ComboBox)cbModeloVenda;
                cbItemSelecionado = (ComboboxItem)cmb.SelectedItem;
                sIDMod = cbItemSelecionado.Value.ToString();

                return sIDMod;
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);

                // se não houver modelo, não tem como haver ano e combustível
                if (cbModeloVenda.Items.Count > 0) cbModeloVenda.Items.Clear();
                cbModeloVenda.Enabled = false;
                cbModeloVenda.Text = "";
                if (cbVeiculoVenda.Items.Count > 0) cbVeiculoVenda.Items.Clear();
                cbVeiculoVenda.Enabled = false;
                cbVeiculoVenda.Text = "";

                return null;
            }
        }


        private String getSelectedVehicle() {
            try {
                String sIDVei;
                ComboboxItem cbItemSelecionado;
                ComboBox cmb = (ComboBox)cbVeiculoVenda;
                cbItemSelecionado = (ComboboxItem)cmb.SelectedItem;
                sIDVei = cbItemSelecionado.Value.ToString();

                return sIDVei;
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
                return null;
            }
        }

            
        // -----------------------

        private void cbCategoriaVenda_SelectedIndexChanged(object sender, EventArgs e) {
            this.filterMarksCombobox();
            this.filterModelsCombobox();

            try {
                this.filterVehiclesCombobox();
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }
        }


        private void cbMarcaVenda_SelectedIndexChanged(object sender, EventArgs e) {
            // executa a consulta ao bd e a atualização dos combobox de nível menor de hierarquia apenas se o usuário que fez a mudança de índice (não o sistema)
            ComboBox cb = (ComboBox)sender;
            if (!cb.Focused) {
                return;
            }

            // realiza um filtro no combobox de modelos baseado na nova marca escolhida
            this.filterModelsCombobox();
            try {
                this.filterVehiclesCombobox();
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }
        }


        private void cbModeloVenda_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBox cb = (ComboBox)sender;
            if (!cb.Focused) {
                return;
            }

            this.filterVehiclesCombobox();
        }


        private void cbVeiculoVenda_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBox cb = (ComboBox)sender;
            if (!cb.Focused) {
                return;
            }

            this.fillVehicleFields();
        }
    }
}
