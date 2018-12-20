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
    public partial class FormFuncionario : Form {
        private SqlCommand sqlComm;
        private SqlManager sqlMgr;
        private SqlDataReader sqlDataReader;
        private String sLogradouroFunc;
        private String sComplementoFunc;
        private String sBairroFunc;
        private String sCidadeFunc;
        private String sUFFunc;
        private bool bCEPAlreadyExists;
        private int iIdEnd_FK;
        private DataTable dt;
        private int iDataGridRowSelected;

        public FormFuncionario() {
            InitializeComponent();

            this.sqlComm = new SqlCommand();
            this.sqlMgr = new SqlManager();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.setStartState();
        }


        private void FormFuncionario_Load(object sender, EventArgs e) {
            this.refreshDataGrid();
        }


        private void refreshDataGrid() {
            String sQuery = "SELECT f.IDFunc AS '#', f.NomeFunc AS 'Nome do Funcionário', f.CPFFunc AS CPF, FORMAT ( f.SalarioFunc, 'C', 'pt-BR' ) AS Salário, e.CEPEnd AS CEP, e.NomeCidadeEnd AS Cidade, e.UFCidadeEnd AS UF  " +
                                " FROM[dbo].[TabelaFuncionario] AS f " +
                                " INNER JOIN[dbo].[TabelaEndereco] as e ON(e.IDEnd = f.IDEnd) " +
                                " ORDER BY f.NomeFunc";
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


        private void tbFiltroFuncionario_TextChanged(object sender, EventArgs e) {
            try {
                DataView dv = new DataView(dt);
                dv.RowFilter = String.Format("[Nome do Funcionário] LIKE '%{0}%'", tbFiltroFuncionario.Text);
                dataGridView1.DataSource = dv;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message + ex.ToString());
            }
        }


        private void bCancelarFormFunc_Click(object sender, EventArgs e) {
            this.setStartState();
        }


        private void bExcluirFunc_Click(object sender, EventArgs e) {
            int iIdFunc = int.Parse(tbIDFunc.Text.ToString());

            if (iIdFunc > 0) {
                DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja excluir o funcionário " + tbNomeFunc.Text + "? ", "Excluir Funcionário ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    try {
                        this.sqlMgr.closeConnection();
                        this.sqlComm = new SqlCommand("DELETE FROM TabelaFuncionario WHERE IDFunc = '" + iIdFunc + "'", SqlManager.CONN);
                        this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);

                        try {
                            this.sqlMgr.closeConnection();
                            this.sqlComm = new SqlCommand("DELETE FROM TabelaUsuario WHERE IDFunc = '" + iIdFunc + "'", SqlManager.CONN);
                            this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);

                            Utils.showSimpleMessageBox("Sucesso", "Funcionário e credenciais de acesso deletados com sucesso!", "success");
                            this.refreshDataGrid();
                            this.setStartState();
                        } catch (Exception ex) {
                            Utils.showSimpleMessageBox("Aviso", "Funcionário deletado com sucesso. Porém, o sistema apresentou problemas ao excluir as credenciais desse funcionário!", "warning");
                            this.refreshDataGrid();
                            this.setStartState();
                        }
                    } catch (Exception ex) {
                        Utils.showSimpleMessageBox("Ops", "Problema ao deletar funcionário!", "warning");
                    }
                }
            }
        }


        private void bIncluirFunc_Click(object sender, EventArgs e) {
            this.setStartState();

            Utils.cleanFields(this);
            Utils.enableFields(this);
            bIncluirFunc.Enabled = false;
            tbFiltroFuncionario.Enabled = false;
            bCheckCEP.Enabled = true;

            int iLastId = 0;
            String sLastId = "";
            this.sqlMgr.closeConnection();
            this.sqlComm = new SqlCommand("SELECT TOP(1) IDFunc FROM TabelaFuncionario ORDER BY 1 DESC", SqlManager.CONN);
            this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
            if (this.sqlDataReader.Read()) {
                sLastId = sqlDataReader["IDFunc"].ToString();
            }
            iLastId = (sLastId.Equals("")) ? 1 : int.Parse(sLastId) + 1;
            this.sqlMgr.closeConnection();

            tbIDFunc.Text = iLastId.ToString();
            tbIDFunc.Enabled = false;
            this.disableFieldsAddress();
        }


        private void bSalvarFunc_Click(object sender, EventArgs e) {
            errorProvider1.Clear();

            // <Validações do FORM>

            if("".Equals(tbNomeFunc.Text)) {
                errorProvider1.SetError(tbNomeFunc, "O nome do funcionário deve ser informado!");
                return;
            }
            if ("".Equals(tbEmailFunc.Text)) {
                errorProvider1.SetError(tbEmailFunc, "Por favor, preencha o e-mail com o formato xxx@xxx.xxx!");
                return;
            }
            if (!Utils.validaCPF(mtbCPFFunc.Text)) {
                errorProvider1.SetError(mtbCPFFunc, "CPF Inválido!");
                return;
            }

            decimal dSalario;
            if (!decimal.TryParse(tbSalarioFunc.Text, out dSalario) || decimal.Parse(tbSalarioFunc.Text.ToString()) <= 0 || "".Equals(tbSalarioFunc.Text)) {
                errorProvider1.SetError(tbSalarioFunc, "Este campo não pode ser vazio e deve ser maior que zero!");
                return;
            }
            // </Validações do FORM>


            String sCEP = tbCEPFuncEnd.Text;
            if (sCEP.Equals("") || sCEP.Length < 8) {
                Utils.showSimpleMessageBox("Aviso", "Por favor, informe um CEP válido (8 dígitos) antes de inserir um funcionário!", "warning");
            } else {

                this.sqlMgr.closeConnection();
                this.sqlComm = new SqlCommand("SELECT * FROM[dbo].[TabelaFuncionario] AS f " +
                                                "WHERE f.IDFunc = " + tbIDFunc.Text, SqlManager.CONN);
                this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);

                if (this.sqlDataReader.HasRows) { // Atualiza Funcionário
                    // TODO: deveria pegar o cep informado e pesquisar no banco. Se já existe, atualiza a relação. Se não, cria uma nova

                    this.sqlMgr.closeConnection();
                    this.sqlComm = new SqlCommand("UPDATE TabelaFuncionario SET NomeFunc = @NomeFunc , EmailFunc = @EmailFunc,  DataNascFunc = @DataNascFunc, " +
                                                        "TelefoneFunc = @TelefoneFunc, SalarioFunc = @SalarioFunc,  CPFFunc = @CPFFunc " +
                                                        "WHERE IDFunc = '" + tbIDFunc.Text + "'", SqlManager.CONN);


                    this.sqlComm.Parameters.Add("@NomeFunc", System.Data.SqlDbType.NVarChar);
                    this.sqlComm.Parameters["@NomeFunc"].Value = tbNomeFunc.Text;

                    this.sqlComm.Parameters.Add("@DataNascFunc", System.Data.SqlDbType.Date);
                    this.sqlComm.Parameters["@DataNascFunc"].Value = dtpDataNascFunc.Text;

                    this.sqlComm.Parameters.Add("@EmailFunc", System.Data.SqlDbType.NVarChar);
                    this.sqlComm.Parameters["@EmailFunc"].Value = tbEmailFunc.Text;

                    this.sqlComm.Parameters.Add("@TelefoneFunc", System.Data.SqlDbType.NVarChar);
                    this.sqlComm.Parameters["@TelefoneFunc"].Value = mtbTelefoneFunc.Text;

                    this.sqlComm.Parameters.Add("@CPFFunc", System.Data.SqlDbType.NVarChar);
                    this.sqlComm.Parameters["@CPFFunc"].Value = mtbCPFFunc.Text;

                    this.sqlComm.Parameters.Add("@SalarioFunc", System.Data.SqlDbType.Decimal);
                    this.sqlComm.Parameters["@SalarioFunc"].Value = tbSalarioFunc.Text;

                    this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                    if (this.sqlDataReader != null) {
                        Utils.showSimpleMessageBox("Sucesso", "Funcionário atualizado com sucesso!", "success");
                        this.setStartState();
                        this.refreshDataGrid();
                    } else {
                        Utils.showSimpleMessageBox("Erro", "Problemas ao atualizar o Funcionário!", "wrong");
                    }

                } else { // Insere Funcionário

                    // só executa essa inserção se o CEP pesquisado ainda não existe na base de dados
                    if (!this.bCEPAlreadyExists) {
                        this.sqlMgr.closeConnection();

                        this.sqlComm = new SqlCommand(" INSERT INTO TabelaEndereco (LogradouroEnd, ComplementoEnd, BairroEnd, NomeCidadeEnd, UFCidadeEnd, CEPEnd) " +
                                                        "output INSERTED.IDEnd " +
                                                        "VALUES (@LogradouroEnd, @ComplementoEnd, @BairroEnd, @NomeCidadeEnd, @UFCidadeEnd, @CEPEnd)", SqlManager.CONN);

                        this.sqlComm.Parameters.Add("@IDEnd", System.Data.SqlDbType.Int);
                        this.sqlComm.Parameters["@IDEnd"].Value = 0;

                        this.sqlComm.Parameters.Add("@LogradouroEnd", System.Data.SqlDbType.NVarChar);
                        this.sqlComm.Parameters["@LogradouroEnd"].Value = this.sLogradouroFunc;

                        this.sqlComm.Parameters.Add("@ComplementoEnd", System.Data.SqlDbType.NVarChar);
                        this.sqlComm.Parameters["@ComplementoEnd"].Value = this.sComplementoFunc;

                        this.sqlComm.Parameters.Add("@BairroEnd", System.Data.SqlDbType.NVarChar);
                        this.sqlComm.Parameters["@BairroEnd"].Value = this.sBairroFunc;

                        this.sqlComm.Parameters.Add("@NomeCidadeEnd", System.Data.SqlDbType.NVarChar);
                        this.sqlComm.Parameters["@NomeCidadeEnd"].Value = this.sCidadeFunc;

                        this.sqlComm.Parameters.Add("@UFCidadeEnd", System.Data.SqlDbType.NVarChar);
                        this.sqlComm.Parameters["@UFCidadeEnd"].Value = this.sUFFunc;

                        this.sqlComm.Parameters.Add("@CEPEnd", System.Data.SqlDbType.NVarChar);
                        this.sqlComm.Parameters["@CEPEnd"].Value = sCEP;

                        this.iIdEnd_FK = this.sqlMgr.performQueryReturnId(this.sqlComm);
                    }

                    Utils.dg("############ ID do endereço inserido: " + this.iIdEnd_FK);
                    if (this.iIdEnd_FK > 0) {
                        this.sqlMgr.closeConnection();
                        this.sqlComm = new SqlCommand(" INSERT INTO TabelaFuncionario (NomeFunc, EmailFunc, DataNascFunc, TelefoneFunc, CPFFunc, SalarioFunc, IDEnd) " +
                                                        "VALUES (@NomeFunc, @EmailFunc, @DataNascFunc, @TelefoneFunc, @CPFFunc, @SalarioFunc, @IDEnd)", SqlManager.CONN);

                        this.sqlComm.Parameters.Add("@IDFunc", System.Data.SqlDbType.Int);
                        this.sqlComm.Parameters["@IDFunc"].Value = 0;

                        this.sqlComm.Parameters.Add("@NomeFunc", System.Data.SqlDbType.NVarChar);
                        this.sqlComm.Parameters["@NomeFunc"].Value = tbNomeFunc.Text;

                        this.sqlComm.Parameters.Add("@EmailFunc", System.Data.SqlDbType.NVarChar);
                        this.sqlComm.Parameters["@EmailFunc"].Value = tbEmailFunc.Text;

                        this.sqlComm.Parameters.Add("@DataNascFunc", System.Data.SqlDbType.Date);
                        this.sqlComm.Parameters["@DataNascFunc"].Value = dtpDataNascFunc.Text;

                        this.sqlComm.Parameters.Add("@TelefoneFunc", System.Data.SqlDbType.NVarChar);
                        this.sqlComm.Parameters["@TelefoneFunc"].Value = mtbTelefoneFunc.Text;

                        this.sqlComm.Parameters.Add("@CPFFunc", System.Data.SqlDbType.NVarChar);
                        this.sqlComm.Parameters["@CPFFunc"].Value = mtbCPFFunc.Text;

                        this.sqlComm.Parameters.Add("@SalarioFunc", System.Data.SqlDbType.Decimal);
                        this.sqlComm.Parameters["@SalarioFunc"].Value = tbSalarioFunc.Text;

                        this.sqlComm.Parameters.Add("@IDEnd", System.Data.SqlDbType.Int);
                        this.sqlComm.Parameters["@IDEnd"].Value = this.iIdEnd_FK;

                        this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                        if (this.sqlDataReader != null) {
                            Utils.showSimpleMessageBox("Sucesso", "Funcionário cadastrado com sucesso!", "success");
                            this.setStartState();
                            this.refreshDataGrid();
                        } else {
                            Utils.showSimpleMessageBox("Erro", "Problemas ao cadastrar o funcionário!", "wrong");
                        }
                    } else {
                        Utils.showSimpleMessageBox("Erro", "Problemas ao cadastrar o endereço do funcionário!", "wrong");
                    }
                }
            }
        }


        private void bCheckCEP_Click(object sender, EventArgs e) {
            String sCEP = tbCEPFuncEnd.Text;
            try {
                int iVerify = int.Parse(sCEP);

                if (sCEP.Equals("") || sCEP.Length < 8) {
                    Utils.showSimpleMessageBox("Aviso", "Por favor, informe um CEP válido (8 dígitos) antes de consultar", "warning");
                    bSalvarFunc.Enabled = false;
                } else {

                    // consulta e verifica se o CEP digitado já existe na base de dados. Se sim, apenas mostra as informações. Se não, consulta na API
                    this.sqlMgr.closeConnection();
                    this.sqlComm = new SqlCommand("SELECT * FROM TabelaEndereco WHERE CEPEnd = " + sCEP, SqlManager.CONN);
                    this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                    if (this.sqlDataReader.Read()) {
                        Utils.dg(" Encontrou o CEP (" + sCEP + ") na base de dados e não vai consultar na API!");

                        this.bCEPAlreadyExists = true;
                        this.iIdEnd_FK = int.Parse(sqlDataReader["IDEnd"].ToString());

                        tbLogradouroFuncEnd.Text = sqlDataReader["LogradouroEnd"].ToString();
                        tbComplementoFuncEnd.Text = sqlDataReader["ComplementoEnd"].ToString();
                        tbBairroFuncEnd.Text = sqlDataReader["BairroEnd"].ToString();
                        tbCidadeFuncEnd.Text = sqlDataReader["NomeCidadeEnd"].ToString();
                        tbUFFuncEnd.Text = sqlDataReader["UFCidadeEnd"].ToString();

                        this.sqlMgr.closeConnection();
                        bSalvarFunc.Enabled = true;
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
                                    bSalvarFunc.Enabled = false;
                                } else {
                                    foreach (JProperty parsedProperty in parsedObject.Properties()) {
                                        string propertyName = parsedProperty.Name;
                                        if (propertyName.Equals("logradouro")) this.sLogradouroFunc = parsedProperty.Value.ToString();
                                        if (propertyName.Equals("complemento")) this.sComplementoFunc = parsedProperty.Value.ToString();
                                        if (propertyName.Equals("bairro")) this.sBairroFunc = parsedProperty.Value.ToString();
                                        if (propertyName.Equals("localidade")) this.sCidadeFunc = parsedProperty.Value.ToString();
                                        if (propertyName.Equals("uf")) this.sUFFunc = parsedProperty.Value.ToString();
                                    }

                                    tbLogradouroFuncEnd.Text = this.sLogradouroFunc;
                                    tbComplementoFuncEnd.Text = this.sComplementoFunc;
                                    tbBairroFuncEnd.Text = this.sBairroFunc;
                                    tbCidadeFuncEnd.Text = this.sCidadeFunc;
                                    tbUFFuncEnd.Text = this.sUFFunc;

                                    bSalvarFunc.Enabled = true;
                                }
                            } catch (Exception ex) {
                                Utils.dg(ex.StackTrace);
                                bSalvarFunc.Enabled = false;
                            }
                        } else {
                            Utils.showSimpleMessageBox("Ops", "Tivemos um erro ao realizar uma consultar online. Verifique sua conexão com a internet!", "wrong");
                            bSalvarFunc.Enabled = false;
                        }
                    }
                }
            } catch (Exception ex) {
                Utils.showSimpleMessageBox("Aviso", "Por favor, digite apenas números!", "warning");
                bSalvarFunc.Enabled = false;
                Utils.dg(ex.StackTrace);
            }
        }


        private void setStartState() {
            try {
                this.sLogradouroFunc = "";
                this.sComplementoFunc = "";
                this.sBairroFunc = "";
                this.sCidadeFunc = "";
                this.sUFFunc = "";
                this.bCEPAlreadyExists = false;
                this.iIdEnd_FK = 0;

                Utils.cleanFields(gbInfoPessoais);
                Utils.cleanFields(gbInfoEndereco);
                Utils.disableFields(gbInfoPessoais);
                Utils.disableFields(gbInfoEndereco);
                tbFiltroFuncionario.Enabled = true;
                bSalvarFunc.Enabled = false;
                bExcluirFunc.Enabled = false;
                bIncluirFunc.Enabled = true;
                bCheckCEP.Enabled = false;
                tbIDFunc.Text = "";

                errorProvider1.Clear();
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }
        }


        private void enableFieldsAddress() {
            tbLogradouroFuncEnd.Enabled  = true;
            tbComplementoFuncEnd.Enabled = true;
            tbBairroFuncEnd.Enabled      = true;
            tbCidadeFuncEnd.Enabled      = true;
            tbUFFuncEnd.Enabled          = true;
        }


        private void disableFieldsAddress() {
            tbLogradouroFuncEnd.Enabled  = false;
            tbComplementoFuncEnd.Enabled = false;
            tbBairroFuncEnd.Enabled      = false;
            tbCidadeFuncEnd.Enabled      = false;
            tbUFFuncEnd.Enabled          = false;
        }


        private void tbCEPFuncEnd_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                 e.Handled = true;
            }
        }


        private void tbSalarioFunc_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { //&& (e.KeyChar != '.')
                e.Handled = true;
            }

            /* // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }*/
        }


        private void mtbCPFFunc_Validating(object sender, CancelEventArgs e) {
            if (!Utils.validaCPF(mtbCPFFunc.Text)) {
                errorProvider1.SetError(mtbCPFFunc, "CPF Inválido!");
            } else {
                errorProvider1.SetError(mtbCPFFunc, "");
            }
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            // Se o click foi realizado no cabeçalho
            if (e.RowIndex == -1) return;

            this.iDataGridRowSelected = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            Utils.enableFields(this);

            this.sqlMgr.closeConnection();
            this.sqlComm = new SqlCommand("SELECT f.IDFunc, f.NomeFunc, f.EmailFunc, f.DataNascFunc, f.TelefoneFunc, f.CPFFunc, f.SalarioFunc , f.IDEnd,  " +
                                            " e.IDEnd, e.LogradouroEnd, e.ComplementoEnd, e.BairroEnd, e.NomeCidadeEnd, e.UFCidadeEnd, e.CEPEnd" +
                                            " FROM[dbo].[TabelaFuncionario] AS f " +
                                            " INNER JOIN[dbo].[TabelaEndereco] as e ON(e.IDEnd = f.IDEnd) " +
                                            " WHERE f.IDFunc = '" + this.iDataGridRowSelected + "'", SqlManager.CONN);

            this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
            if (this.sqlDataReader.Read()) {
                tbIDFunc.Text = sqlDataReader["IDFunc"].ToString();
                tbIDFunc.Enabled = false;

                tbNomeFunc.Text = sqlDataReader["NomeFunc"].ToString();
                tbEmailFunc.Text = sqlDataReader["EmailFunc"].ToString();
                mtbTelefoneFunc.Text = sqlDataReader["TelefoneFunc"].ToString();
                mtbCPFFunc.Text = sqlDataReader["CPFFunc"].ToString();
                dtpDataNascFunc.Text = sqlDataReader["DataNascFunc"].ToString();
                tbSalarioFunc.Text = sqlDataReader["SalarioFunc"].ToString();
                tbCEPFuncEnd.Text = sqlDataReader["CEPEnd"].ToString();
                tbLogradouroFuncEnd.Text = sqlDataReader["LogradouroEnd"].ToString();
                tbComplementoFuncEnd.Text = sqlDataReader["ComplementoEnd"].ToString();
                tbBairroFuncEnd.Text = sqlDataReader["BairroEnd"].ToString();
                tbCidadeFuncEnd.Text = sqlDataReader["NomeCidadeEnd"].ToString();
                tbUFFuncEnd.Text = sqlDataReader["UFCidadeEnd"].ToString();
            }

            bExcluirFunc.Enabled = true;
            bSalvarFunc.Enabled = true;
            Utils.disableFields(gbInfoEndereco);
            tbCEPFuncEnd.Enabled = false;
            bCheckCEP.Enabled = false;
        }


    }
}
