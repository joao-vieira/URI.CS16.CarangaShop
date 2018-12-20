using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarangaShop {
    public partial class FormUsuario : Form {
        private SqlCommand sqlComm;
        private SqlManager sqlMgr;
        private SqlDataReader sqlDataReader;
        private DataTable dt;
        private int iDataGridRowSelected;

        public FormUsuario() {
            InitializeComponent();

            this.sqlComm = new SqlCommand();
            this.sqlMgr = new SqlManager();

            this.setStartState();
        }


        private void FormUsuario_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'carangaShopDataSet1.TabelaFuncionario' table. You can move, or remove it, as needed.
            this.tabelaFuncionarioTableAdapter.Fill(this.carangaShopDataSet1.TabelaFuncionario);
            this.refreshDataGrid();
        }


        private void refreshDataGrid() {
            String sQuery = "SELECT u.IDUsu AS '#', u.NomeUsu AS 'Nome de Usuário',  " +
                                "CASE " +
                                    "WHEN u.NivelAcessoUsu = 1 THEN 'Administrador' " +
                                    "ELSE 'Funcionário' " +
                                "END AS Permissão, f.NomeFunc AS 'Nome do Funcionário', f.SalarioFunc AS Salário " +
                                "FROM[dbo].[TabelaUsuario] AS u " +
                                "INNER JOIN[dbo].[TabelaFuncionario] AS f ON(u.IDFunc = f.IDFunc) " +
                                "ORDER BY f.NomeFunc";
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


        private void tbFiltroNomeFuncionario_TextChanged(object sender, EventArgs e) {
            try {
                DataView dv = new DataView(dt);
                dv.RowFilter = String.Format("[Nome do Funcionário] LIKE '%{0}%'", tbFiltroNomeFuncionario.Text);
                dataGridView1.DataSource = dv;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message + ex.ToString());
            }
        }


        private void bCancelarFormUsu_Click(object sender, EventArgs e) {
            this.setStartState();
        }


        private void bExcluirUsu_Click(object sender, EventArgs e) {
            int iIdUsu = int.Parse(tbIDUsu.Text.ToString());

            if(iIdUsu > 0) {
                DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja excluir o usuário " + tbNomeUsu.Text  +"? ", "Excluir Usuário ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    try {
                        this.sqlMgr.closeConnection();
                        this.sqlComm = new SqlCommand("DELETE FROM TabelaUsuario WHERE IDUsu = '" + iIdUsu + "'", SqlManager.CONN);
                        this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);

                        Utils.showSimpleMessageBox("Sucesso", "Usuário deletado com sucesso!", "success");
                        this.refreshDataGrid();
                        this.setStartState();
                    } catch (Exception ex) {
                        Utils.showSimpleMessageBox("Ops", "Problema ao deletar usuário!", "warning");
                    }
                }
            }
        }


        private void bIncluirUsu_Click(object sender, EventArgs e) {
            Utils.cleanFields(this);
            Utils.enableFields(this);

            int iLastId = 0;
            String sLastId = "";
            this.sqlMgr.closeConnection();
            this.sqlComm = new SqlCommand("SELECT TOP(1) IDUsu FROM TabelaUsuario ORDER BY 1 DESC", SqlManager.CONN);
            this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
            if (this.sqlDataReader.Read()) {
                sLastId = sqlDataReader["IDUsu"].ToString();
            }
            iLastId = (sLastId.Equals("")) ? 1 : int.Parse(sLastId) + 1;
            this.sqlMgr.closeConnection();
            tbIDUsu.Text = iLastId.ToString();
            tbIDUsu.Enabled = false;

            tbFiltroNomeFuncionario.Enabled = false;
            bExcluirUsu.Enabled = false;
            bIncluirUsu.Enabled = false;
            bSalvarUsu.Enabled = true;
        }


        private void bSalvarUsu_Click(object sender, EventArgs e) {
            errorProvider1.Clear();

            if("".Equals(tbNomeUsu.Text)) {
                errorProvider1.SetError(tbNomeUsu, "O nome de usuário deve ser preenchido!");
                return;
            }
            if ("".Equals(tbSenhaUsu.Text)) {
                errorProvider1.SetError(tbSenhaUsu, "A senha deve ser definida!");
                return;
            }

            int iNivelAcessoUsu = 0;
            int iIdFunc_FK = 0;
            String passCrypted = "";

            this.sqlMgr.closeConnection();
            this.sqlComm = new SqlCommand("SELECT * FROM[dbo].[TabelaUsuario] AS u " +
                                            "WHERE u.IDFunc = '" + cbFuncionarioUsu.SelectedValue.ToString() + "' AND " +
                                            "u.IDUsu != '" + tbIDUsu.Text + "'", SqlManager.CONN);

            this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
            if (this.sqlDataReader.HasRows) { // Funcionário já possui usuário
                Utils.showSimpleMessageBox("Aviso", "Esse funcionário já possui credenciais de acesso ao sistema. Por favor, consulte a listagem abaixo e faça alterações, caso necessário!", "warning");
                return;
            }

            this.sqlMgr.closeConnection();
            this.sqlComm = new SqlCommand("SELECT * FROM[dbo].[TabelaUsuario] AS u " +
                                            "WHERE u.IDUsu = '" + tbIDUsu.Text + "'", SqlManager.CONN);

            this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
            if (this.sqlDataReader.HasRows) { // Atualiza usuário
                iNivelAcessoUsu = (cbNivelAcessoUsu.Text.Equals("Administrador")) ? 1 : 2;
                iIdFunc_FK = int.Parse(cbFuncionarioUsu.SelectedValue.ToString());
                passCrypted = Utils.encrypt(tbSenhaUsu.Text);

                try {
                    this.sqlMgr.closeConnection();
                    this.sqlComm = new SqlCommand(" UPDATE TabelaUsuario SET NomeUsu = @NomeUsu, SenhaUsu = @SenhaUsu, " +
                                                        "NivelAcessoUsu = @NivelAcessoUsu, IDFunc = @IDFunc " +
                                                        "WHERE IDUsu = '" + tbIDUsu.Text + "'" , SqlManager.CONN);

                    this.sqlComm.Parameters.Add("@NomeUsu", System.Data.SqlDbType.NVarChar);
                    this.sqlComm.Parameters["@NomeUsu"].Value = tbNomeUsu.Text;

                    this.sqlComm.Parameters.Add("@SenhaUsu", System.Data.SqlDbType.NVarChar);
                    this.sqlComm.Parameters["@SenhaUsu"].Value = passCrypted;

                    this.sqlComm.Parameters.Add("@NivelAcessoUsu", System.Data.SqlDbType.NVarChar);
                    this.sqlComm.Parameters["@NivelAcessoUsu"].Value = iNivelAcessoUsu;

                    this.sqlComm.Parameters.Add("@IDFunc", System.Data.SqlDbType.NVarChar);
                    this.sqlComm.Parameters["@IDFunc"].Value = iIdFunc_FK;

                    this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                    if (this.sqlDataReader != null) {
                        Utils.showSimpleMessageBox("Sucesso", "Usuário atualizado com sucesso!", "success");
                        this.refreshDataGrid();
                        this.setStartState();
                    } else {
                        Utils.showSimpleMessageBox("Erro", "Problemas ao atualizar o Usuário!", "wrong");
                    }
                } catch(Exception ex) {
                    Utils.dg(ex.StackTrace);
                    Utils.showSimpleMessageBox("Erro", "Problema ao capturar informações para atualizar usuário!", "wrong");
                }
            } else { // Insere usuário
                try {
                    Utils.dg(" #1 = " + cbNivelAcessoUsu.Text);
                    Utils.dg(" #2.2 = " + cbFuncionarioUsu.SelectedValue.ToString());
                    iNivelAcessoUsu = (cbNivelAcessoUsu.Text.Equals("Administrador")) ? 1 : 2;
                    iIdFunc_FK      = int.Parse(cbFuncionarioUsu.SelectedValue.ToString());
                    passCrypted     = Utils.encrypt(tbSenhaUsu.Text);

                    this.sqlMgr.closeConnection();
                    this.sqlComm = new SqlCommand(" INSERT INTO TabelaUsuario (NomeUsu, SenhaUsu, NivelAcessoUsu, IDFunc) " +
                                                    "VALUES (@NomeUsu, @SenhaUsu, @NivelAcessoUsu, @IDFunc)", SqlManager.CONN);

                    this.sqlComm.Parameters.Add("@IDUsu", System.Data.SqlDbType.Int);
                    this.sqlComm.Parameters["@IDUsu"].Value = 0;

                    this.sqlComm.Parameters.Add("@NomeUsu", System.Data.SqlDbType.NVarChar);
                    this.sqlComm.Parameters["@NomeUsu"].Value = tbNomeUsu.Text;

                    this.sqlComm.Parameters.Add("@SenhaUsu", System.Data.SqlDbType.NVarChar);
                    this.sqlComm.Parameters["@SenhaUsu"].Value = passCrypted;
                
                    this.sqlComm.Parameters.Add("@NivelAcessoUsu", System.Data.SqlDbType.NVarChar);
                    this.sqlComm.Parameters["@NivelAcessoUsu"].Value = iNivelAcessoUsu;

                    this.sqlComm.Parameters.Add("@IDFunc", System.Data.SqlDbType.NVarChar);
                    this.sqlComm.Parameters["@IDFunc"].Value = iIdFunc_FK;

                    this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                    if (this.sqlDataReader != null) {
                        Utils.showSimpleMessageBox("Sucesso", "Usuário cadastrado com sucesso!", "success");
                        this.refreshDataGrid();
                        this.setStartState();
                    } else {
                        Utils.showSimpleMessageBox("Erro", "Problemas ao cadastrar o Usuário!", "wrong");
                    }
                } catch (Exception ex) {
                    Utils.dg(ex.StackTrace);
                    Utils.showSimpleMessageBox("Erro", "Problema ao capturar informações do novo usuário!", "wrong");
                }
            }
        }


        private void setStartState() {
            try {
                Utils.cleanFields(gbInfoNovoUsuario);
                Utils.cleanFields(gbConsultaUsuario);
                Utils.disableFields(this);

                this.iDataGridRowSelected = 0;

                tbFiltroNomeFuncionario.Enabled = true;
                bSalvarUsu.Enabled = false;
                bExcluirUsu.Enabled = false;
                bIncluirUsu.Enabled = true;
                tbIDUsu.Text = "";
                tbIDUsu.Enabled = true;

                errorProvider1.Clear();
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            // Se o click foi realizado no cabeçalho
            if (e.RowIndex == -1) return;

            this.iDataGridRowSelected = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            Utils.enableFields(this);

            this.sqlMgr.closeConnection();
            this.sqlComm = new SqlCommand("SELECT * FROM[dbo].[TabelaUsuario] AS u " +
                                            "INNER JOIN[dbo].[TabelaFuncionario] AS f ON(f.IDFunc = u.IDFunc) " +
                                            "WHERE u.IDUsu = '" + this.iDataGridRowSelected + "'", SqlManager.CONN);

            this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
            if (this.sqlDataReader.Read()) {
                tbIDUsu.Text = sqlDataReader["IDUsu"].ToString();
                tbIDUsu.Enabled = false;

                tbNomeUsu.Text = sqlDataReader["NomeUsu"].ToString();
                tbSenhaUsu.Text = Utils.decrypt(sqlDataReader["SenhaUsu"].ToString());
                cbFuncionarioUsu.SelectedIndex = cbFuncionarioUsu.FindStringExact(sqlDataReader["NomeFunc"].ToString());

                String sSearch = (int.Parse(sqlDataReader["NivelAcessoUsu"].ToString()) == 1) ? "Administrador" : "Funcionário";
                cbNivelAcessoUsu.SelectedIndex = cbNivelAcessoUsu.FindStringExact(sSearch);
            }

            bExcluirUsu.Enabled = true;
            bSalvarUsu.Enabled = true;
        }
        


    }
}
