using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarangaShop {
    public partial class FormCliente : Form {
        private SqlCommand sqlComm;
        private SqlManager sqlMgr;
        private SqlDataReader sqlDataReader;
        private String sLogradouroCli;
        private String sComplementoCli;
        private String sBairroCli;
        private String sCidadeCli;
        private String sUFCli;
        private bool bCEPAlreadyExists;
        private int iIdEnd_FK;
        private DataTable dt;
        private int iDataGridRowSelected;
        private String sCEPPesquisado;

        public FormCliente() {
            InitializeComponent();

            this.sqlComm = new SqlCommand();
            this.sqlMgr = new SqlManager();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.setStartState();
        }


        private void FormCliente_Load(object sender, EventArgs e) {
            this.refreshDataGrid();
        }


        private void refreshDataGrid() {
            String sQuery = "SELECT c.IDCli AS '#', c.NomeCli AS 'Nome do Cliente', c.CPFCli AS CPF, c.TelefoneCli AS Telefone, e.CEPEnd AS CEP, e.NomeCidadeEnd AS Cidade, e.UFCidadeEnd AS UF " +
                                " FROM[dbo].[TabelaCliente] AS c " +
                                " INNER JOIN[dbo].[TabelaEndereco] as e ON(e.IDEnd = c.IDEnd) " +
                                " ORDER BY c.NomeCli";
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


        private void tbFiltroCliente_TextChanged(object sender, EventArgs e) {
            try {
                DataView dv = new DataView(dt);
                dv.RowFilter = String.Format("[Nome do Cliente] LIKE '%{0}%'", tbFiltroCliente.Text);
                dataGridView1.DataSource = dv;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message + ex.ToString());
            }
        }


        private void bCancelarFormCli_Click(object sender, EventArgs e) {
            this.setStartState();
        }


        private void bExcluirCli_Click(object sender, EventArgs e) {
            if("".Equals(tbIDCli.Text.ToString())) return;

            int iIdCli = int.Parse(tbIDCli.Text.ToString());
            if(iIdCli > 0) {
                DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja excluir o cliente " + tbNomeCli.Text + "? ", "Excluir Cliente ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    try {
                        this.sqlMgr.closeConnection();
                        this.sqlComm = new SqlCommand("DELETE FROM TabelaCliente WHERE IDCli = '" + iIdCli + "'", SqlManager.CONN);
                        this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);

                        Utils.showSimpleMessageBox("Sucesso", "Cliente deletado com sucesso!", "success");
                        this.refreshDataGrid();
                        this.setStartState();
                    } catch(Exception ex) {
                        Utils.showSimpleMessageBox("Ops", "Problema ao deletar cliente!", "warning");
                    }
                }
            }
        }


        private void bIncluirCli_Click(object sender, EventArgs e) {
            Utils.cleanFields(this);
            Utils.enableFields(this);
            bIncluirCli.Enabled = false;
            tbFiltroCliente.Enabled = false;
            bCheckCEP.Enabled = true;

            int iLastId = 0;
            String sLastId = "";
            this.sqlMgr.closeConnection();
            this.sqlComm = new SqlCommand("SELECT TOP(1) IDCli FROM TabelaCliente ORDER BY 1 DESC", SqlManager.CONN);
            this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
            if (this.sqlDataReader.Read()) {
                sLastId = sqlDataReader["IDCli"].ToString();
            }
            iLastId = (sLastId.Equals("")) ? 1 : int.Parse(sLastId) + 1;
            this.sqlMgr.closeConnection();

            tbIDCli.Text = iLastId.ToString();
            tbIDCli.Enabled = false;
            this.disableFieldsAddress();
        }


        private void bSalvarCli_Click(object sender, EventArgs e) {
            errorProvider1.Clear();

            // <Validações do FORM>
            if ("".Equals(tbNomeCli.Text)) {
                errorProvider1.SetError(tbNomeCli, "O nome do cliente deve ser informado!");
                return;
            }
            if ("".Equals(tbEmailCli.Text)) {
                errorProvider1.SetError(tbEmailCli, "Por favor, preencha o e-mail com o formato xxx@xxx.xxx!");
                return;
            }
            if (!Utils.validaCPF(mtbCPFCli.Text)) {
                errorProvider1.SetError(mtbCPFCli, "CPF Inválido!");
                return;
            }
            // </Validações do FORM>

            String sCEP = tbCEPCliEnd.Text;
            //if(!this.sCEPPesquisado.Equals(sCEP)) {
            //    Utils.showSimpleMessageBox("Aviso", "Por favor, caso deseje alterar o CEP que será salvo, clique no botão com a Lupa novamente para que o sistema não salve um endereço com o CEP incorreto!", "warning");
            //} else {
                if (sCEP.Equals("") || sCEP.Length < 8) {
                    Utils.showSimpleMessageBox("Aviso", "Por favor, informe um CEP válido (8 dígitos) antes de inserir um Cliente!", "warning");
                    return;
                } else {
                    this.sqlMgr.closeConnection();
                    this.sqlComm = new SqlCommand("SELECT * FROM[dbo].[TabelaCliente] AS c " +
                                                    "WHERE c.IDCli = " + tbIDCli.Text, SqlManager.CONN);
                    this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);

                    if (this.sqlDataReader.HasRows) { // Atualiza cliente
                        // TODO: deveria pegar o cep informado e pesquisar no banco. Se já existe, atualiza a relação. Se não, cria uma nova

                        this.sqlMgr.closeConnection();
                        this.sqlComm = new SqlCommand(" UPDATE TabelaCliente SET NomeCli = @NomeCli, EmailCli = @EmailCli, DataNascCli = @DataNascCli, " +
                                                            "TelefoneCli = @TelefoneCli, CPFCli = @CPFCli " +
                                                            "WHERE IDCli = '" + tbIDCli.Text + "'", SqlManager.CONN);


                        this.sqlComm.Parameters.Add("@NomeCli", System.Data.SqlDbType.NVarChar);
                        this.sqlComm.Parameters["@NomeCli"].Value = tbNomeCli.Text;

                        this.sqlComm.Parameters.Add("@EmailCli", System.Data.SqlDbType.NVarChar);
                        this.sqlComm.Parameters["@EmailCli"].Value = tbEmailCli.Text;

                        this.sqlComm.Parameters.Add("@DataNascCli", System.Data.SqlDbType.Date);
                        this.sqlComm.Parameters["@DataNascCli"].Value = dtpDataNascCli.Text;

                        this.sqlComm.Parameters.Add("@TelefoneCli", System.Data.SqlDbType.NVarChar);
                        this.sqlComm.Parameters["@TelefoneCli"].Value = mtbTelefoneCli.Text;

                        this.sqlComm.Parameters.Add("@CPFCli", System.Data.SqlDbType.NVarChar);
                        this.sqlComm.Parameters["@CPFCli"].Value = mtbCPFCli.Text;

                        this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                        if (this.sqlDataReader != null) {
                            Utils.showSimpleMessageBox("Sucesso", "Cliente atualizado com sucesso!", "success");
                            this.setStartState();
                            this.refreshDataGrid();
                        } else {
                            Utils.showSimpleMessageBox("Erro", "Problemas ao atualizar o Cliente!", "wrong");
                        }

                    } else { // Insere cliente

                        // só executa essa inserção se o CEP pesquisado ainda não existe na base de dados
                        if (!this.bCEPAlreadyExists) {
                            this.sqlMgr.closeConnection();

                            this.sqlComm = new SqlCommand(" INSERT INTO TabelaEndereco (LogradouroEnd, ComplementoEnd, BairroEnd, NomeCidadeEnd, UFCidadeEnd, CEPEnd) " +
                                                            "output INSERTED.IDEnd " +
                                                            "VALUES (@LogradouroEnd, @ComplementoEnd, @BairroEnd, @NomeCidadeEnd, @UFCidadeEnd, @CEPEnd)", SqlManager.CONN);

                            this.sqlComm.Parameters.Add("@IDEnd", System.Data.SqlDbType.Int);
                            this.sqlComm.Parameters["@IDEnd"].Value = 0;

                            this.sqlComm.Parameters.Add("@LogradouroEnd", System.Data.SqlDbType.NVarChar);
                            this.sqlComm.Parameters["@LogradouroEnd"].Value = this.sLogradouroCli;

                            this.sqlComm.Parameters.Add("@ComplementoEnd", System.Data.SqlDbType.NVarChar);
                            this.sqlComm.Parameters["@ComplementoEnd"].Value = this.sComplementoCli;

                            this.sqlComm.Parameters.Add("@BairroEnd", System.Data.SqlDbType.NVarChar);
                            this.sqlComm.Parameters["@BairroEnd"].Value = this.sBairroCli;

                            this.sqlComm.Parameters.Add("@NomeCidadeEnd", System.Data.SqlDbType.NVarChar);
                            this.sqlComm.Parameters["@NomeCidadeEnd"].Value = this.sCidadeCli;

                            this.sqlComm.Parameters.Add("@UFCidadeEnd", System.Data.SqlDbType.NVarChar);
                            this.sqlComm.Parameters["@UFCidadeEnd"].Value = this.sUFCli;

                            this.sqlComm.Parameters.Add("@CEPEnd", System.Data.SqlDbType.NVarChar);
                            this.sqlComm.Parameters["@CEPEnd"].Value = sCEP;

                            this.iIdEnd_FK = this.sqlMgr.performQueryReturnId(this.sqlComm);
                        }

                        Utils.dg("############ ID do endereço inserido: " + this.iIdEnd_FK);
                        if (this.iIdEnd_FK > 0) {
                            this.sqlMgr.closeConnection();
                            this.sqlComm = new SqlCommand(" INSERT INTO TabelaCliente (NomeCli, EmailCli, DataNascCli, TelefoneCli, CPFCli, IDEnd) " +
                                                            "VALUES (@NomeCli, @EmailCli, @DataNascCli, @TelefoneCli, @CPFCli, @IDEnd)", SqlManager.CONN);

                            this.sqlComm.Parameters.Add("@IDCli", System.Data.SqlDbType.Int);
                            this.sqlComm.Parameters["@IDCli"].Value = 0;

                            this.sqlComm.Parameters.Add("@NomeCli", System.Data.SqlDbType.NVarChar);
                            this.sqlComm.Parameters["@NomeCli"].Value = tbNomeCli.Text;

                            this.sqlComm.Parameters.Add("@EmailCli", System.Data.SqlDbType.NVarChar);
                            this.sqlComm.Parameters["@EmailCli"].Value = tbEmailCli.Text;

                            this.sqlComm.Parameters.Add("@DataNascCli", System.Data.SqlDbType.Date);
                            this.sqlComm.Parameters["@DataNascCli"].Value = dtpDataNascCli.Text;

                            this.sqlComm.Parameters.Add("@TelefoneCli", System.Data.SqlDbType.NVarChar);
                            this.sqlComm.Parameters["@TelefoneCli"].Value = mtbTelefoneCli.Text;

                            this.sqlComm.Parameters.Add("@CPFCli", System.Data.SqlDbType.NVarChar);
                            this.sqlComm.Parameters["@CPFCli"].Value = mtbCPFCli.Text;

                            this.sqlComm.Parameters.Add("@IDEnd", System.Data.SqlDbType.Int);
                            this.sqlComm.Parameters["@IDEnd"].Value = this.iIdEnd_FK;

                            this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                            if (this.sqlDataReader != null) {
                                Utils.showSimpleMessageBox("Sucesso", "Cliente cadastrado com sucesso!", "success");
                                this.setStartState();
                                this.refreshDataGrid();
                            } else {
                                Utils.showSimpleMessageBox("Erro", "Problemas ao cadastrar o Cliente!", "wrong");
                            }
                        } else {
                            Utils.showSimpleMessageBox("Erro", "Problemas ao cadastrar o endereço do Cliente!", "wrong");
                        }
                    }
                }
            //}
        }


        private void bCheckCEP_Click(object sender, EventArgs e) {
            String sCEP = tbCEPCliEnd.Text;
            this.sCEPPesquisado = sCEP;
            try {
                int iVerify = int.Parse(sCEP);
            
                if (sCEP.Equals("") || sCEP.Length < 8) {
                    Utils.showSimpleMessageBox("Aviso", "Por favor, informe um CEP válido (8 dígitos) antes de consultar", "warning");
                    bSalvarCli.Enabled = false;
                } else {

                    // consulta e verifica se o CEP digitado já existe na base de dados. Se sim, apenas mostra as informações. Se não, consulta na API
                    this.sqlMgr.closeConnection();
                    this.sqlComm = new SqlCommand("SELECT * FROM TabelaEndereco WHERE CEPEnd = " + sCEP, SqlManager.CONN);
                    this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                    if (this.sqlDataReader.Read()) {
                        Utils.dg(" Encontrou o CEP (" + sCEP + ") na base de dados e não vai consultar na API!");

                        this.bCEPAlreadyExists = true;
                        this.iIdEnd_FK = int.Parse(sqlDataReader["IDEnd"].ToString());

                        tbLogradouroCliEnd.Text = sqlDataReader["LogradouroEnd"].ToString();
                        tbComplementoCliEnd.Text = sqlDataReader["ComplementoEnd"].ToString();
                        tbBairroCliEnd.Text = sqlDataReader["BairroEnd"].ToString();
                        tbCidadeCliEnd.Text = sqlDataReader["NomeCidadeEnd"].ToString();
                        tbUFCliEnd.Text = sqlDataReader["UFCidadeEnd"].ToString();

                        this.sqlMgr.closeConnection();
                        bSalvarCli.Enabled = true;
                    } else {
                        Utils.dg(" Não encontrou o CEP (" + sCEP + ") na base de dados e, então, VAI consultar na API!");

                        WebRequest request = WebRequest.Create(Utils.CONST_API_ENDERECOS + sCEP + "/json/");
                        String respJSON = Utils.makeRequest(request);

                        if (respJSON != null) {
                            try {
                                JObject parsedObject = JObject.Parse(respJSON);
                                bool bIsCorromped = parsedObject.ContainsKey("erro");
                                if (bIsCorromped) {
                                    Utils.showSimpleMessageBox("Ops", "CEP não encontrado!", "warning");
                                    bSalvarCli.Enabled = false;
                                } else {
                                    foreach (JProperty parsedProperty in parsedObject.Properties()) {
                                        string propertyName = parsedProperty.Name;
                                        if (propertyName.Equals("logradouro")) this.sLogradouroCli = parsedProperty.Value.ToString();
                                        if (propertyName.Equals("complemento")) this.sComplementoCli = parsedProperty.Value.ToString();
                                        if (propertyName.Equals("bairro")) this.sBairroCli = parsedProperty.Value.ToString();
                                        if (propertyName.Equals("localidade")) this.sCidadeCli = parsedProperty.Value.ToString();
                                        if (propertyName.Equals("uf")) this.sUFCli = parsedProperty.Value.ToString();
                                    }

                                    tbLogradouroCliEnd.Text = this.sLogradouroCli;
                                    tbComplementoCliEnd.Text = this.sComplementoCli;
                                    tbBairroCliEnd.Text = this.sBairroCli;
                                    tbCidadeCliEnd.Text = this.sCidadeCli;
                                    tbUFCliEnd.Text = this.sUFCli;

                                    bSalvarCli.Enabled = true;
                                }
                            } catch (Exception ex) {
                                Utils.dg(ex.StackTrace);
                                bSalvarCli.Enabled = false;
                            }
                        } else {
                            Utils.showSimpleMessageBox("Ops", "Tivemos um erro ao realizar uma consultar online. Verifique sua conexão com a internet!", "wrong");
                            bSalvarCli.Enabled = false;
                        }
                    }
                }
            } catch (Exception ex) {
                Utils.showSimpleMessageBox("Aviso", "Por favor, digite apenas números!", "warning");
                bSalvarCli.Enabled = false;
                Utils.dg(ex.StackTrace);
            }
        }


        private void setStartState() {
            try {
                this.sLogradouroCli = "";
                this.sComplementoCli = "";
                this.sBairroCli = "";
                this.sCidadeCli = "";
                this.sUFCli = "";
                this.bCEPAlreadyExists = false;
                this.iIdEnd_FK = 0;
                this.iDataGridRowSelected = 0;
                this.sCEPPesquisado = "";

                Utils.cleanFields(gbInfoNovoCliente);
                Utils.cleanFields(gbInfoPessoais);
                Utils.disableFields(gbInfoPessoais);
                Utils.disableFields(gbInfoEndereco);
                tbFiltroCliente.Enabled = true;
                bSalvarCli.Enabled = false;
                bExcluirCli.Enabled = false;
                bIncluirCli.Enabled = true;
                bCheckCEP.Enabled = false;
                tbIDCli.Text = "";
                tbIDCli.Enabled = true;

                errorProvider1.Clear();
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }
        }


        private void enableFieldsAddress() {
            tbLogradouroCliEnd.Enabled = true;
            tbComplementoCliEnd.Enabled = true;
            tbBairroCliEnd.Enabled = true;
            tbCidadeCliEnd.Enabled = true;
            tbUFCliEnd.Enabled = true;
        }


        private void disableFieldsAddress() {
            tbLogradouroCliEnd.Enabled = false;
            tbComplementoCliEnd.Enabled = false;
            tbBairroCliEnd.Enabled = false;
            tbCidadeCliEnd.Enabled = false;
            tbUFCliEnd.Enabled = false;
        }


        private void tbCEPCliEnd_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }


        private void mtbCPFCli_Validating(object sender, CancelEventArgs e) {
            if (!Utils.validaCPF(mtbCPFCli.Text)) {
                errorProvider1.SetError(mtbCPFCli, "CPF Inválido!");
                mtbCPFCli.Focus();
            } else {
                errorProvider1.SetError(mtbCPFCli, "");
            }
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            Utils.cleanFields(gbInfoNovoCliente);
            Utils.cleanFields(gbInfoEndereco);
            Utils.cleanFields(gbInfoPessoais);

            // Se o click foi realizado no cabeçalho
            if (e.RowIndex == -1) return;

            this.iDataGridRowSelected = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            Utils.enableFields(this);

            this.sqlMgr.closeConnection();
            this.sqlComm = new SqlCommand("SELECT * " +
                                            " FROM[dbo].[TabelaCliente] AS c " +
                                            " INNER JOIN[dbo].[TabelaEndereco] as e ON(e.IDEnd = c.IDEnd) " +
                                            " WHERE c.IDCli = '" + this.iDataGridRowSelected + "'", SqlManager.CONN);

            this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
            if (this.sqlDataReader.Read()) {
                tbIDCli.Text = sqlDataReader["IDCli"].ToString();
                tbIDCli.Enabled = false;

                tbNomeCli.Text = sqlDataReader["NomeCli"].ToString();
                tbEmailCli.Text = sqlDataReader["EmailCli"].ToString();
                mtbTelefoneCli.Text = sqlDataReader["TelefoneCli"].ToString();
                mtbCPFCli.Text = sqlDataReader["CPFCli"].ToString();
                dtpDataNascCli.Text = sqlDataReader["DataNascCli"].ToString();
                tbCEPCliEnd.Text = sqlDataReader["CEPEnd"].ToString();
                tbLogradouroCliEnd.Text = sqlDataReader["LogradouroEnd"].ToString();
                tbComplementoCliEnd.Text = sqlDataReader["ComplementoEnd"].ToString();
                tbBairroCliEnd.Text = sqlDataReader["BairroEnd"].ToString();
                tbCidadeCliEnd.Text = sqlDataReader["NomeCidadeEnd"].ToString();
                tbUFCliEnd.Text = sqlDataReader["UFCidadeEnd"].ToString();
            }

            bExcluirCli.Enabled = true;
            bSalvarCli.Enabled = true;
            Utils.disableFields(gbInfoEndereco);
            tbCEPCliEnd.Enabled = false;
            bCheckCEP.Enabled = false;
        }


    }
}
