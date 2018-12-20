using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarangaShop {
    public partial class FormModelo : Form {
        private SqlCommand sqlComm;
        private SqlManager sqlMgr;
        private SqlDataReader sqlDataReader;
        private String sKeyAPIModeloSelecionado;
        private String sNomeModeloSelecionado;
        private String sCategoriaSelecionada;
        private DataTable dt;
        private int iDataGridRowSelected;

        public FormModelo() {
            InitializeComponent();

            this.sqlComm = new SqlCommand();
            this.sqlMgr = new SqlManager();

            this.setStartState();
        }


        private void FormModelo_Load_1(object sender, EventArgs e) {
            this.tabelaCategoriaTableAdapter.Fill(this.carangaShopDataSet1.TabelaCategoria);
            this.tabelaMarcaTableAdapter1.Fill(this.carangaShopDataSet1.TabelaMarca);

            // filtra as marcas listadas no Combobox 'Marcas'
            this.filterMarksCombobox();

            // preenche os modelos listados no Combobox 'Modelos' com base na marca selecionada
            String sKeyMarAPI = this.getSelectedMark();

            Utils.dg("TEM KEY DA MARCA? " + sKeyMarAPI);

            try {
                this.fillModelsCombobox(int.Parse(sKeyMarAPI));

                this.refreshDataGrid();
            } catch(Exception ex) {
                Utils.dg(ex.StackTrace);
            }
        }


        private void refreshDataGrid() {
            String sQuery = "SELECT m.IDMod AS '#', m.NomeMod AS 'Nome do Modelo', ma.NomeMar AS 'Nome da Marca', c.DescCat AS Categoria " +
                                "FROM[dbo].[TabelaModelo] as m " +
                                "INNER JOIN[dbo].[TabelaMarca] as ma ON(ma.IDMar = m.IDMar) " +
                                "INNER JOIN[dbo].[TabelaCategoria] as c ON(c.IDCat = ma.IDCat) " +
                                "ORDER BY m.NomeMod";

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


        private void tbFiltroModelo_TextChanged(object sender, EventArgs e) {
            try {
                DataView dv = new DataView(dt);
                dv.RowFilter = String.Format("[Nome da Marca] LIKE '%{0}%'", tbFiltroModelo.Text);
                dataGridView1.DataSource = dv;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message + ex.ToString());
            }
        }


        private void bIncluirModelo_Click(object sender, EventArgs e) {
            Utils.cleanFields(this);
            tbFiltroModelo.Enabled = false;
            bIncluirModelo.Enabled = false;
            cbCategoria.Enabled = true;
            cbMarca.Enabled  = true;
            cbModelo.Enabled = true;

            // filtra as marcas listadas no Combobox 'Marcas'
            this.filterMarksCombobox();

            // preenche os modelos listados no Combobox 'Modelos' com base na marca selecionada
            String sKeyMarAPI = this.getSelectedMark();
            this.fillModelsCombobox(int.Parse(sKeyMarAPI));

            int iLastId = 0;
            String sLastId = "";
            this.sqlMgr.closeConnection();
            this.sqlComm = new SqlCommand("SELECT TOP(1) IDMod FROM TabelaModelo ORDER BY 1 DESC", SqlManager.CONN);
            this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
            if (this.sqlDataReader.Read()) {
                sLastId = sqlDataReader["IDMod"].ToString();
            }
            iLastId = (sLastId.Equals("")) ? 1 : int.Parse(sLastId) + 1;
            tbIDMod.Text = iLastId.ToString();
            tbIDMod.Enabled = false;
        }


        private void bSalvarModelo_Click(object sender, EventArgs e) {
            String sKeyAPIMar = this.getSelectedMark();

            this.sqlMgr.closeConnection();
            this.sqlComm = new SqlCommand("SELECT * FROM TabelaMarca WHERE KeyAPIMar = '" + sKeyAPIMar + "'", SqlManager.CONN);
            this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
            if(this.sqlDataReader.HasRows && this.sqlDataReader.Read()) {
                int iIdMar_FK = int.Parse(this.sqlDataReader["IDMar"].ToString());

                this.sqlMgr.closeConnection();
                this.sqlComm = new SqlCommand(" INSERT INTO TabelaModelo (NomeMod, KeyAPIMod, IDMar) " +
                                                "VALUES (@NomeMod, @KeyAPIMod, @IDMar)", SqlManager.CONN);

                this.sqlComm.Parameters.Add("@IDMod", System.Data.SqlDbType.Int);
                this.sqlComm.Parameters["@IDMod"].Value = 0;

                this.sqlComm.Parameters.Add("@NomeMod", System.Data.SqlDbType.NVarChar);
                this.sqlComm.Parameters["@NomeMod"].Value = this.sNomeModeloSelecionado;

                this.sqlComm.Parameters.Add("@KeyAPIMod", System.Data.SqlDbType.NVarChar);
                this.sqlComm.Parameters["@KeyAPIMod"].Value = this.sKeyAPIModeloSelecionado;

                this.sqlComm.Parameters.Add("@IDMar", System.Data.SqlDbType.Int);
                this.sqlComm.Parameters["@IDMar"].Value = iIdMar_FK;

                this.sqlMgr.performQueryWithoutReturn(this.sqlComm);
                Utils.showSimpleMessageBox("Sucesso", "Modelo cadastrado com sucesso!", "success");
                this.setStartState();
                this.refreshDataGrid();
            } else {
                Utils.showSimpleMessageBox("Erro", "Problemas ao encontrar a marca selecionada no banco de dados!", "wrong");
            }
        }


        private void bCancelarFormModelo_Click(object sender, EventArgs e) {
            this.setStartState();
        }


        private void bExcluirModelo_Click(object sender, EventArgs e) {
            int iIdModelo = int.Parse(tbIDMod.Text.ToString());

            if (iIdModelo > 0) {
                DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja excluir o modelo " + cbModelo.Text + "? ", "Excluir Modelo ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    try {
                        this.sqlMgr.closeConnection();
                        this.sqlComm = new SqlCommand("DELETE FROM TabelaModelo WHERE IDMod = '" + iIdModelo + "'", SqlManager.CONN);
                        this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);

                        Utils.showSimpleMessageBox("Sucesso", "Modelo deletado com sucesso!", "success");
                        this.refreshDataGrid();
                        this.setStartState();
                    } catch (Exception ex) {
                        Utils.showSimpleMessageBox("Ops", "Problema ao deletar modelo!", "warning");
                    }
                }
            }
        }


        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e) {
            try {

                // filtra as marcas listadas no Combobox 'Marcas'
                this.filterMarksCombobox();

                // preenche os modelos listados no Combobox 'Modelos' com base na marca selecionada
                String sKeyMarAPI = this.getSelectedMark();
                this.fillModelsCombobox(int.Parse(sKeyMarAPI));

            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }
        }


        private void cbMarca_SelectedIndexChanged_1(object sender, EventArgs e) {
            try {
                String sKeyMarAPI = this.getSelectedMark();
                this.fillModelsCombobox(int.Parse(sKeyMarAPI));
            } catch(Exception ex) {
                Utils.dg(ex.StackTrace);
            }
        }


        private void cbModelo_SelectedIndexChanged_1(object sender, EventArgs e) {
            bSalvarModelo.Enabled = true;

            ComboboxItem cbItemSelecionado;
            ComboBox cmb = (ComboBox)sender;
            try {
                cbItemSelecionado = (ComboboxItem)cmb.SelectedItem;
                this.sKeyAPIModeloSelecionado = cbItemSelecionado.Value.ToString();
                this.sNomeModeloSelecionado = cbItemSelecionado.Text;
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }
        }


        private void setStartState() {
            try {
                this.sKeyAPIModeloSelecionado = "";
                this.sNomeModeloSelecionado = "";
                this.sCategoriaSelecionada = "";

                Utils.cleanFields(gbFiltros);
                Utils.cleanFields(gbDados);
                Utils.disableFields(gbFiltros);
                Utils.disableFields(gbDados);
                tbFiltroModelo.Enabled = true;
                bExcluirModelo.Enabled = false;
                bIncluirModelo.Enabled = true;
                bSalvarModelo.Enabled = false;
                tbIDMod.Text = "";
                tbIDMod.Enabled = true;

                cbModelo.Items.Clear();
                cbModelo.Text = "";
                cbMarca.Items.Clear();
                cbMarca.Text = "";
                cbCategoria.Items.Clear();
                cbCategoria.Text = "";
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }
       }


        private void filterMarksCombobox() {
            try {
                int iIdCategoria = int.Parse(cbCategoria.SelectedValue.ToString());
                this.sCategoriaSelecionada = (iIdCategoria == 1) ? "carros" : (iIdCategoria == 2) ? "motos" : "caminhoes";

                bool bAlreadySetted = false;
                cbMarca.Items.Clear();

                this.sqlMgr.closeConnection();
                this.sqlComm = new SqlCommand("SELECT * FROM TabelaMarca WHERE IdCat = '" + iIdCategoria + "'", SqlManager.CONN);
                this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                if (this.sqlDataReader.HasRows) {
                    while (this.sqlDataReader.Read()) {
                        ComboboxItem cbItem = new ComboboxItem();
                        cbItem.Value = this.sqlDataReader["KeyAPIMar"].ToString();
                        cbItem.Text = this.sqlDataReader["NomeMar"].ToString();
                        cbMarca.Items.Add(cbItem);

                        if (!bAlreadySetted) {
                            cbMarca.SelectedItem = cbItem;
                            bAlreadySetted = true;
                        }
                    }
                }
            } catch(Exception ex) {
                Utils.dg(ex.StackTrace);
            }
        }


        private void fillModelsCombobox(int selectedIndex) {
            if (selectedIndex > 0) {
                // atualiza URL de requisição para que modelos de carros, motos ou caminhões possam ser pesquisados
                Utils.dg("=> Os modelos serão buscados dinamicamente com esta URL: [ " + Utils.CONST_API_VEICULOS + this.sCategoriaSelecionada + "/veiculos/" + selectedIndex + ".json ]");

                WebRequest request = WebRequest.Create(Utils.CONST_API_VEICULOS + this.sCategoriaSelecionada  + "/veiculos/" + selectedIndex + ".json");
                String respJSON = Utils.makeRequest(request);
                bool bAlreadySetted = false;

                if (respJSON != null) {
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

                                if (propertyName.Equals("fipe_name")) {
                                    isFilledValue = true;
                                    cbItem.Text = parsedProperty.Value.ToString();
                                }

                                if (isFilledKey && isFilledValue) {
                                    cbModelo.Items.Add(cbItem);
                                    break;
                                }
                            }

                            if (!bAlreadySetted) {
                                cbModelo.SelectedItem = cbItem;
                                bAlreadySetted = true;
                            }
                        }
                    } catch (Exception ex) {
                        Utils.dg(ex.StackTrace);
                    }
                } else {
                    Utils.showSimpleMessageBox("Ops", "Verifique sua conexão com a internet!", "wrong");
                }
            }
        }


        private String getSelectedMark() {
            try {
                String sKeyMarAPI;
                ComboboxItem cbItemSelecionado;
                ComboBox cmb = (ComboBox)cbMarca;
                cbItemSelecionado = (ComboboxItem)cmb.SelectedItem;
                sKeyMarAPI = cbItemSelecionado.Value.ToString();

                return sKeyMarAPI;
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
                return null;
            }
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            // Se o click foi realizado no cabeçalho
            if (e.RowIndex == -1) return;

            this.iDataGridRowSelected = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            Utils.enableFields(this);

            try {
                this.sqlMgr.closeConnection();
                this.sqlComm = new SqlCommand("SELECT * " +
                                                "FROM[dbo].[TabelaModelo] as m " +
                                                "INNER JOIN[dbo].[TabelaMarca] as ma ON(ma.IDMar = m.IDMar) " +
                                                "INNER JOIN[dbo].[TabelaCategoria] as c ON(c.IDCat = ma.IDCat) " +
                                                " WHERE m.IDMod = '" + this.iDataGridRowSelected + "'", SqlManager.CONN);

                this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                if (this.sqlDataReader.Read()) {
                    tbIDMod.Text = sqlDataReader["IDMod"].ToString();
                    tbIDMod.Enabled = false;

                    cbCategoria.SelectedIndex = cbCategoria.FindStringExact(sqlDataReader["DescCat"].ToString());
                    cbMarca.SelectedIndex = cbMarca.FindStringExact(sqlDataReader["NomeMar"].ToString());
                    cbModelo.SelectedIndex = cbModelo.FindStringExact(sqlDataReader["NomeMod"].ToString());
                }

                bExcluirModelo.Enabled = true;
                bSalvarModelo.Enabled = true;
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }
        }

        
    }
}
