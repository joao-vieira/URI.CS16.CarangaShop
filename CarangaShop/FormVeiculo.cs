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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarangaShop {
    public partial class FormVeiculo : Form {
        private SqlCommand sqlComm;
        private SqlManager sqlMgr;
        private SqlDataReader sqlDataReader;
        private DataTable dt;
        private int iKeyAPIMarcaAtual;
        private int iIDModeloAtual_FK;
        private String sCategoriaSelecionada;
        private String sURLModeloVeiculoAtual;

        private int iAnoModelo;
        private String sCombustivelModelo;
        private String sKeyAPIVei;
        private String sPrecoModelo;
        private int iDataGridRowSelected;

        public FormVeiculo() {
            InitializeComponent();

            this.sqlComm = new SqlCommand();
            this.sqlMgr = new SqlManager();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.setStartState();
        }


        private void FormVeiculo_Load(object sender, EventArgs e) {
            this.tabelaCategoriaTableAdapter.Fill(this.carangaShopDataSet.TabelaCategoria);
            this.tabelaMarcaTableAdapter.Fill(this.carangaShopDataSet.TabelaMarca);

            // preenche combobox de marcas que pertencem à categoria selecionada atualmente
            this.filterMarksCombobox();

            // preenche combobox de modelos baseado na marca selecionada atualmente
            this.filterModelsCombobox();

            this.refreshDataGrid();
        }


        private void refreshDataGrid() {
            String sQuery = " SELECT v.IDVei AS '#', v.AnoModeloVei AS Ano, v.CombustivelVei AS Combustível, v.ReferenciaValoresVei AS 'Data Última Consulta', FORMAT ( v.PrecoUnitVei, 'C', 'pt-BR' ) AS 'Preço', m.NomeMod AS Modelo, ma.NomeMar AS Marca " +
                                " FROM[dbo].[TabelaVeiculo] as v " +
                                " INNER JOIN[dbo].[TabelaModelo] as m ON(v.IDMod = m.IDMod) " +
                                " INNER JOIN[dbo].[TabelaMarca] as ma ON(ma.IDMar = m.IDMar) " +
                                " INNER JOIN[dbo].[TabelaCategoria] as c ON(c.IDCat = ma.IDCat)" +
                                " ORDER BY v.AnoModeloVei";

            try {
                this.sqlMgr.closeConnection();
                this.sqlComm = new SqlCommand(sQuery, SqlManager.CONN);
                this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                if (this.sqlDataReader.HasRows) {
                    dt = new DataTable();
                    dt.Load(this.sqlDataReader);
                    dataGridView1.DataSource = dt;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message + ex.ToString());
            }
        }


        private void tbFiltroVeiculo_TextChanged(object sender, EventArgs e) {
            try {
                DataView dv = new DataView(dt);
                dv.RowFilter = String.Format("Modelo LIKE '%{0}%' OR Combustível LIKE '%{1}%'", tbFiltroVeiculo.Text, tbFiltroVeiculo.Text);
                dataGridView1.DataSource = dv;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message + ex.ToString());
            }
        }


        private void bAlterarEstoqueVei_Click(object sender, EventArgs e) {
            bAlterarEstoqueVei.Enabled = false;
            bSalvarEstoqueVei.Enabled = true;

            nudEstoqueVei.Enabled = true;
            tbPrecoVei.Enabled = true;
        }


        private void bCancelarFormVei_Click(object sender, EventArgs e) {
            this.setStartState();
        }


        private void bExcluirVei_Click(object sender, EventArgs e) {
            int iIdVei = this.iDataGridRowSelected;

            if (iIdVei > 0) {
                DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja excluir o veículo - modelo " + cbModelo.Text + "? ", "Excluir Veículo ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    try {
                        this.sqlMgr.closeConnection();
                        this.sqlComm = new SqlCommand("DELETE FROM TabelaVeiculo WHERE IDVei = '" + iIdVei + "'", SqlManager.CONN);
                        this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);

                        Utils.showSimpleMessageBox("Sucesso", "Veículo deletado com sucesso!", "success");
                        this.refreshDataGrid();
                        this.setStartState();
                    } catch (Exception ex) {
                        Utils.showSimpleMessageBox("Ops", "Problema ao deletar veículo!", "warning");
                    }
                }
            }
        }


        private void bIncluirVei_Click(object sender, EventArgs e) {
            Utils.cleanFields(this);
            bIncluirVei.Enabled = false;
            tbFiltroVeiculo.Enabled = false;
            bCancelarFormVei.Enabled = true;
            cbCategoriaVei.Enabled = true;
            cbMarca.Enabled = true;

            // preenche combobox de marcas que pertencem à categoria selecionada atualmente
            this.filterMarksCombobox();

            // preenche combobox de modelos baseado na marca selecionada atualmente
            this.filterModelsCombobox();

            try {
                // captura qual é o ID para interação com a API do modelo selecionado atualmente
                int iKeyAPIModeloAtual = int.Parse(this.getSelectedModel());

                // requisita todos os veículos do modelo selecionado atualmente
                this.fillVehiclesCombobox(this.iKeyAPIMarcaAtual, iKeyAPIModeloAtual);

            } catch(Exception ex) {
                Utils.dg(ex.StackTrace);
            }
                      
        }


        private void bGravarVei_Click(object sender, EventArgs e) {
            if(this.iIDModeloAtual_FK > 0) {
                // recupera o veículo selecionado
                this.sqlMgr.closeConnection();
                this.sqlComm = new SqlCommand("SELECT * FROM TabelaVeiculo WHERE KeyAPIVei = '" + this.sKeyAPIVei + "'", SqlManager.CONN);
                this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                if (this.sqlDataReader.HasRows) {
                    // veículo já existe e, portanto, deve-se apenas atualizar seu estoque
                    int iIdVeiculoSelecionado = 0;
                    while (this.sqlDataReader.Read()) {
                        iIdVeiculoSelecionado = int.Parse(this.sqlDataReader["IDVei"].ToString());
                    }

                    this.sqlMgr.closeConnection();
                    this.sqlComm = new SqlCommand("SELECT * FROM TabelaEstoque WHERE IDVei = '" + iIdVeiculoSelecionado + "'", SqlManager.CONN);
                    this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                    if (this.sqlDataReader.HasRows) {
                        int iAux2Show = 0;
                        int iQtdEstoque = 0;
                        while (this.sqlDataReader.Read()) {
                            iQtdEstoque = int.Parse(this.sqlDataReader["QuantEst"].ToString());
                        }
                        iAux2Show = iQtdEstoque;

                        iQtdEstoque += (int) nudEstoqueVei.Value;
                        this.sqlMgr.closeConnection();
                        this.sqlComm = new SqlCommand(" UPDATE TabelaEstoque " +
                                                        " SET QuantEst = '" + iQtdEstoque +"'" +
                                                        " WHERE IdVei = " + iIdVeiculoSelecionado, SqlManager.CONN);

                        this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                        if (this.sqlDataReader != null) {
                            Utils.showSimpleMessageBox("Veículo Existente", "Veículo já existe. Por isso, o estoque existente ["+ iAux2Show + "] foi incrementado com [" + nudEstoqueVei.Value + "], ficando com o total de: [" + iQtdEstoque + "] !", "success");
                            this.setStartState();
                            this.refreshDataGrid();
                        } else {
                            Utils.showSimpleMessageBox("Erro", "Problemas ao atualizar o estoque do veículo!", "wrong");
                        }
                    } else {
                        Utils.showSimpleMessageBox("Erro", "Problema ao encontrar o estoque já existente deste veículo !", "wrong");
                    }
                } else {
                    // veículo ainda não existe e, portanto, será inserido, juntamente com um novo registro que irá controlar seu estoque
                    this.sqlMgr.closeConnection();
                    this.sqlComm = new SqlCommand(" INSERT INTO TabelaVeiculo (AnoModeloVei, CombustivelVei, ReferenciaValoresVei, KeyAPIVei, PrecoUnitVei, IDMod) " +
                                                    " output INSERTED.IDVei " +
                                                    "VALUES (@AnoModeloVei, @CombustivelVei, @ReferenciaValoresVei, @KeyAPIVei, @PrecoUnitVei, @IDMod)", SqlManager.CONN);

                    this.sqlComm.Parameters.Add("@IDVei", SqlDbType.Int);
                    this.sqlComm.Parameters["@IDVei"].Value = 0;

                    this.sqlComm.Parameters.Add("@AnoModeloVei", SqlDbType.Int);
                    this.sqlComm.Parameters["@AnoModeloVei"].Value = this.iAnoModelo;

                    this.sqlComm.Parameters.Add("@CombustivelVei", SqlDbType.NVarChar);
                    this.sqlComm.Parameters["@CombustivelVei"].Value = this.sCombustivelModelo;

                    this.sqlComm.Parameters.Add("@ReferenciaValoresVei", SqlDbType.NVarChar);
                    this.sqlComm.Parameters["@ReferenciaValoresVei"].Value = dtpReferencia.Value;

                    this.sqlComm.Parameters.Add("@KeyAPIVei", SqlDbType.NVarChar);
                    this.sqlComm.Parameters["@KeyAPIVei"].Value = this.sKeyAPIVei;

                    decimal d;
                    decimal.TryParse(Utils.formatPrice2DB(this.sPrecoModelo), NumberStyles.Any, CultureInfo.InvariantCulture, out d);
                    this.sqlComm.Parameters.Add("@PrecoUnitVei", SqlDbType.Decimal);
                    this.sqlComm.Parameters["@PrecoUnitVei"].Value = d;

                    this.sqlComm.Parameters.Add("@IDMod", SqlDbType.Int);
                    this.sqlComm.Parameters["@IDMod"].Value = this.iIDModeloAtual_FK;

                    int iIdVeiculo_FK = this.sqlMgr.performQueryReturnId(this.sqlComm);

                    Utils.dg("############ ID do VEÍCULO inserido: " + iIdVeiculo_FK);
                    // ao inserir o veículo, já existe o valor necessário para fazer a vinculação com valor do estoque
                    if (iIdVeiculo_FK > 0) {
                        this.sqlMgr.closeConnection();
                        this.sqlComm = new SqlCommand(" INSERT INTO TabelaEstoque (QuantEst, IDVei) " +
                                                        "VALUES (@QuantEst, @IDVei)", SqlManager.CONN);

                        this.sqlComm.Parameters.Add("@IDEst", SqlDbType.Int);
                        this.sqlComm.Parameters["@IDEst"].Value = 0;

                        this.sqlComm.Parameters.Add("@QuantEst", SqlDbType.Int);
                        this.sqlComm.Parameters["@QuantEst"].Value = nudEstoqueVei.Value;

                        this.sqlComm.Parameters.Add("@IDVei", SqlDbType.Int);
                        this.sqlComm.Parameters["@IDVei"].Value = iIdVeiculo_FK;

                        this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                        if (this.sqlDataReader != null) {
                            Utils.showSimpleMessageBox("Sucesso", "Veículo e estoque cadastrados com sucesso!", "success");
                            this.refreshDataGrid();
                            this.setStartState();
                        } else {
                            Utils.showSimpleMessageBox("Erro", "Problemas ao cadastrar o estoque do novo veículo!", "wrong");
                        }
                    } else {
                        Utils.showSimpleMessageBox("Erro", "Erro ao cadastrar novo veículo!", "wrong");
                    }
                }
            } else {
                Utils.showSimpleMessageBox("Aviso", "Problema ao vincular veículo com modelo!", "warning");
            }
        }


        private void bSalvarEstoqueVei_Click(object sender, EventArgs e) {
            this.sqlMgr.closeConnection();            

            this.sqlComm = new SqlCommand("UPDATE [dbo].[TabelaVeiculo] " +
                                            "SET [PrecoUnitVei] = '" + tbPrecoVei.Text.Replace(',','.') + "'" +
                                            "WHERE IDVei = '" + this.iDataGridRowSelected + "'", SqlManager.CONN);
            try {
                this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);

                this.sqlMgr.closeConnection();
                this.sqlComm = new SqlCommand("UPDATE [dbo].[TabelaEstoque] " +
                                            "SET [QuantEst] = '" + nudEstoqueVei.Value + "'" +
                                            "WHERE IDVei = '" + this.iDataGridRowSelected + "'", SqlManager.CONN);

                this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                Utils.showSimpleMessageBox("Sucesso", "Informações de Estoque atualizadas com sucesso!", "success");
                this.setStartState();
                this.refreshDataGrid();
            } catch(Exception ex) {
                Utils.showSimpleMessageBox("Aviso", "Por favor, preencha os valores corretamente!", "warning");
            }
        }


        private void setStartState() {
            try {
                Utils.cleanFields(gbDados);
                Utils.cleanFields(gbEstoque);
                Utils.cleanFields(gbFiltros);
                Utils.disableFields(gbDados);
                Utils.disableFields(gbEstoque);
                Utils.disableFields(gbFiltros);

                this.iKeyAPIMarcaAtual = 0;
                this.iIDModeloAtual_FK = 0;
                this.sCategoriaSelecionada = "";
                this.sURLModeloVeiculoAtual = "";

                this.iAnoModelo = 0;
                this.sCombustivelModelo = "";
                this.sKeyAPIVei = "";
                this.sPrecoModelo = "";
                this.iDataGridRowSelected = 0;

                bAlterarEstoqueVei.Enabled = false;
                bCancelarFormVei.Enabled = false;
                tbFiltroVeiculo.Enabled = true;
                bExcluirVei.Enabled = false;
                bIncluirVei.Enabled = true;
                bGravarVei.Enabled = false;
                bSalvarEstoqueVei.Enabled = false;
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }
        }


        private void filterMarksCombobox() {
           
            try {
                int iIdCategoria = int.Parse(cbCategoriaVei.SelectedValue.ToString());
                this.sCategoriaSelecionada = (iIdCategoria == 1) ? "carros" : (iIdCategoria == 2) ? "motos" : "caminhoes";

                bool bAlreadySetted = false;
                if(cbMarca.Items.Count > 0) cbMarca.Items.Clear();

                this.sqlMgr.closeConnection();
                this.sqlComm = new SqlCommand("SELECT * FROM TabelaMarca WHERE IdCat = '" + iIdCategoria + "'", SqlManager.CONN);
                this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                if (this.sqlDataReader.HasRows) {
                    while (this.sqlDataReader.Read()) {
                        ComboboxItem cbItem = new ComboboxItem();
                        cbItem.Value = this.sqlDataReader["IDMar"].ToString();
                        cbItem.Text = this.sqlDataReader["NomeMar"].ToString();
                        cbMarca.Items.Add(cbItem);

                        if (!bAlreadySetted) {
                            cbMarca.SelectedItem = cbItem;
                            this.iKeyAPIMarcaAtual = int.Parse(this.sqlDataReader["KeyAPIMar"].ToString());
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
                bool bAlreadySetted = false;
                cbModelo.Enabled = true;
                if(cbModelo.Items.Count > 0) cbModelo.Items.Clear();
                String sIdMarcaSelecionada = this.getSelectedMark();

                this.sqlMgr.closeConnection();
                this.sqlComm = new SqlCommand("SELECT * FROM TabelaModelo WHERE IDMar = '" + sIdMarcaSelecionada + "'", SqlManager.CONN);
                this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                if (this.sqlDataReader.HasRows) {
                    while(this.sqlDataReader.Read()) {
                        ComboboxItem cbItem = new ComboboxItem();
                        cbItem.Value = this.sqlDataReader["KeyAPIMod"].ToString();
                        cbItem.Text = this.sqlDataReader["NomeMod"].ToString();
                        cbModelo.Items.Add(cbItem);

                        if (!bAlreadySetted) {
                            cbModelo.SelectedItem = cbItem;
                            this.iIDModeloAtual_FK = int.Parse(this.sqlDataReader["IDMod"].ToString());
                            bAlreadySetted = true;
                        }
                    }
                } else {
                    cbModelo.Enabled = false;
                }
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }

        }

        
        private void fillVehiclesCombobox(int iMarca, int iModelo) {
            Utils.dg("[CHEGADA NO MÉTODO fillVehiclesCombobox()] --> Marca: " + iMarca + "  &&  --> Modelo: " + iModelo);

            if (iMarca > 0 && iModelo > 0) {
                cbVeiculo.Enabled = true;
                if (cbVeiculo.Items.Count > 0) cbVeiculo.Items.Clear();
                bGravarVei.Enabled = true;
                bool bAlreadySetted = false;

                // atualiza URL de requisição para que os dados do veículo (modelo) de carros, motos ou caminhões possam ser pesquisados e preencher os inputs da tela
                Utils.dg("=> Os modelos do veículo serão buscados dinamicamente com esta URL: [ " + Utils.CONST_API_VEICULOS + this.sCategoriaSelecionada + "/veiculo/" + iMarca + "/" + iModelo + ".json  ]");

                WebRequest request = WebRequest.Create(Utils.CONST_API_VEICULOS + this.sCategoriaSelecionada + "/veiculo/" + iMarca + "/" + iModelo + ".json");
                String respJSON = Utils.makeRequest(request);

                if (respJSON != null) {
                    this.sURLModeloVeiculoAtual = Utils.CONST_API_VEICULOS + this.sCategoriaSelecionada + "/veiculo/" + iMarca + "/" + iModelo + "/";
                    try {
                        JArray parsedArray = JArray.Parse(respJSON);
                        foreach (JObject parsedObject in parsedArray.Children<JObject>()) {
                            ComboboxItem cbItem = new ComboboxItem();
                            bool isFilledKey = false;
                            bool isFilledValue = false;
                            foreach (JProperty parsedProperty in parsedObject.Properties()) {
                                string propertyName = parsedProperty.Name;

                                if (propertyName.Equals("id")) {
                                    isFilledKey = true;
                                    cbItem.Value = parsedProperty.Value;
                                }

                                if (propertyName.Equals("name")) {
                                    isFilledValue = true;
                                    cbItem.Text = parsedProperty.Value.ToString();
                                }

                                if (isFilledKey && isFilledValue) {
                                    cbVeiculo.Items.Add(cbItem);
                                    break;
                                }
                            }

                            if (!bAlreadySetted) {
                                cbVeiculo.SelectedItem = cbItem;
                                bAlreadySetted = true;
                            }
                        }

                        // faz a última requisição do ciclo (para preencher os campos referentes ao veículo escolhido)
                        this.fillVehicleFields();
                        
                    } catch (Exception ex) {
                        Utils.dg(ex.StackTrace);
                    }
                } else {
                    cbVeiculo.Enabled = false;
                    Utils.showSimpleMessageBox("Ops", "Verifique sua conexão com a internet!", "wrong");
                }
            }
        }


        private String getSelectedMark() {
            try {
                String sIdMarcaSelecionada;
                ComboboxItem cbItemSelecionado;
                ComboBox cmb = (ComboBox)cbMarca;
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
                String sKeyModAPI;
                ComboboxItem cbItemSelecionado;
                ComboBox cmb = (ComboBox)cbModelo;
                cbItemSelecionado = (ComboboxItem)cmb.SelectedItem;
                sKeyModAPI = cbItemSelecionado.Value.ToString();

                return sKeyModAPI;
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);

                // se não houver modelo, não tem como haver ano e combustível
                if (cbModelo.Items.Count > 0) cbModelo.Items.Clear();
                cbModelo.Enabled = false;
                cbModelo.Text = "";
                if (cbVeiculo.Items.Count > 0) cbVeiculo.Items.Clear();
                cbVeiculo.Enabled = false;
                cbVeiculo.Text = "";

                tbAnoVei.Text = "";
                tbCombustivelVei.Text = "";
                tbCodFIPEVei.Text = "";
                tbPrecoVei.Text = "";
                dtpReferencia.Value = DateTime.Now;
                nudEstoqueVei.Value = 1;
                nudEstoqueVei.Enabled = false;
                nudEstoqueVei.BackColor = Color.White;

                return null;
            }
        }


        private String getSelectedVehicle() {
            try {
                String sVehicleKey2API;
                ComboboxItem cbItemSelecionado;
                ComboBox cmb = (ComboBox)cbVeiculo;
                cbItemSelecionado = (ComboboxItem)cmb.SelectedItem;
                sVehicleKey2API = cbItemSelecionado.Value.ToString();

                return sVehicleKey2API;
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
                return null;
            }
        }


        private void fillVehicleFields() {
            String sIdAnoDoModeloSelecionado = this.getSelectedVehicle();

            // atualiza URL de requisição para que os dados do veículo (modelo) de carros, motos ou caminhões possam ser pesquisados e preencher os inputs da tela
            Utils.dg("=> O ano e dados do modelo de veículo escolhido será encontrado em : [ " + this.sURLModeloVeiculoAtual + sIdAnoDoModeloSelecionado + ".json  ]");

            WebRequest request = WebRequest.Create(this.sURLModeloVeiculoAtual + sIdAnoDoModeloSelecionado + ".json");
            String respJSON = Utils.makeRequest(request);

            if (respJSON != null) {
                try {
                    JObject parsedObject = JObject.Parse(respJSON);

                    foreach (JProperty parsedProperty in parsedObject.Properties()) {
                        string propertyName = parsedProperty.Name;
                        if (propertyName.Equals("ano_modelo")) this.iAnoModelo = int.Parse(parsedProperty.Value.ToString());
                        if (propertyName.Equals("combustivel")) this.sCombustivelModelo = parsedProperty.Value.ToString();
                        if (propertyName.Equals("key")) this.sKeyAPIVei = parsedProperty.Value.ToString();
                        if (propertyName.Equals("preco")) this.sPrecoModelo = parsedProperty.Value.ToString();
                    }

                    tbAnoVei.Text = this.iAnoModelo.ToString();
                    tbCombustivelVei.Text = this.sCombustivelModelo;
                    tbCodFIPEVei.Text = this.sKeyAPIVei;
                    tbPrecoVei.Text = this.sPrecoModelo;
                    dtpReferencia.Value = DateTime.Now;

                    bGravarVei.Enabled = true;
                    nudEstoqueVei.Value = 1;
                    nudEstoqueVei.Enabled = true;
                    nudEstoqueVei.BackColor = Color.White;
                    nudEstoqueVei.Focus();
                } catch (Exception ex) {
                    Utils.dg(ex.StackTrace);
                    Utils.showSimpleMessageBox("Aviso", "Por favor, verifique seu acesso à internet!", "warning");
                }
            }
        }


        private void cbCategoriaVei_SelectedIndexChanged(object sender, EventArgs e) {
            this.filterMarksCombobox();
            this.filterModelsCombobox();

            try {
                int iKeyAPIModeloAtual = int.Parse(this.getSelectedModel());
                this.fillVehiclesCombobox(this.iKeyAPIMarcaAtual, iKeyAPIModeloAtual);
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }
        }


        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e) {
            // executa a consulta ao bd e a atualização dos combobox de nível menor de hierarquia apenas se o usuário que fez a mudança de índice (não o sistema)
            ComboBox cb = (ComboBox)sender;
            if (!cb.Focused) {
                return;
            }

            // atualiza o atributo da classe que indica qual é a key atual para integração com API da Tabela FIPE
            this.sqlMgr.closeConnection();
            this.sqlComm = new SqlCommand("SELECT * FROM TabelaMarca WHERE IdMar = '" + this.getSelectedMark() + "'", SqlManager.CONN);
            this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
            if (this.sqlDataReader.HasRows && this.sqlDataReader.Read()) {
                    this.iKeyAPIMarcaAtual = int.Parse(this.sqlDataReader["KeyAPIMar"].ToString());
            }

            // realiza um filtro no combobox de modelos baseado na nova marca escolhida
            this.filterModelsCombobox();
            try {
                int iKeyAPIModeloAtual = int.Parse(this.getSelectedModel());
                this.fillVehiclesCombobox(this.iKeyAPIMarcaAtual, iKeyAPIModeloAtual);
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }            
        }


        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBox cb = (ComboBox)sender;
            if (!cb.Focused) {
                return;
            }

            int iKeyAPIModeloAtual = int.Parse(this.getSelectedModel());
            this.sqlMgr.closeConnection();
            this.sqlComm = new SqlCommand("SELECT * FROM TabelaModelo WHERE KeyAPIMod = '" + iKeyAPIModeloAtual + "'", SqlManager.CONN);
            this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
            if (this.sqlDataReader.HasRows && this.sqlDataReader.Read()) {
                this.iIDModeloAtual_FK = int.Parse(this.sqlDataReader["IDMod"].ToString());
            }
            this.fillVehiclesCombobox(this.iKeyAPIMarcaAtual, iKeyAPIModeloAtual);
        }


        private void cbVeiculo_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBox cb = (ComboBox)sender;
            if (!cb.Focused) {
                return;
            }

            this.fillVehicleFields();
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            // Se o click foi realizado no cabeçalho
            if (e.RowIndex == -1) return;

            this.iDataGridRowSelected = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            this.sqlMgr.closeConnection();
            this.sqlComm = new SqlCommand("SELECT * " +
                                            "FROM[dbo].[TabelaVeiculo] as v " +
                                            "INNER JOIN[dbo].[TabelaEstoque] as e on(e.IDVei = v.IDVei) " +
                                            "INNER JOIN[dbo].[TabelaModelo] as m ON(v.IDMod = m.IDMod) " +
                                            "INNER JOIN[dbo].[TabelaMarca] as ma ON(ma.IDMar = m.IDMar) " +
                                            "INNER JOIN[dbo].[TabelaCategoria] as c ON(c.IDCat = ma.IDCat)" +
                                            "WHERE v.IDVei = '" + this.iDataGridRowSelected + "'", SqlManager.CONN);

            this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
            if (this.sqlDataReader.Read()) {
                Utils.disableFields(gbDados);
                Utils.disableFields(gbEstoque);
                Utils.disableFields(gbFiltros);
                Utils.cleanFields(gbFiltros);

                cbModelo.Text = this.sqlDataReader["NomeMod"].ToString();
                tbAnoVei.Text = this.sqlDataReader.GetInt32(1).ToString();
                tbCombustivelVei.Text = this.sqlDataReader["CombustivelVei"].ToString();
                dtpReferencia.Text = this.sqlDataReader["ReferenciaValoresVei"].ToString();
                tbCodFIPEVei.Text = this.sqlDataReader["KeyAPIVei"].ToString();
                tbPrecoVei.Text = this.sqlDataReader["PrecoUnitVei"].ToString();

                int iEst = this.sqlDataReader.GetInt32(8);
                NumericUpDown numericUpDown = (NumericUpDown)nudEstoqueVei;
                numericUpDown.Text = iEst.ToString();
                nudEstoqueVei.Value = iEst;
            }

            bExcluirVei.Enabled = true;
            bCancelarFormVei.Enabled = true;
            bAlterarEstoqueVei.Enabled = true;
        }


        private void tbPrecoVei_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }


    }
}
