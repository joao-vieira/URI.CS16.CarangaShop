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
    public partial class Login : Form {
        private SqlCommand sqlComm;
        private SqlManager sqlMgr;
        private SqlDataReader sqlDataReader;

        public Login() {
            InitializeComponent();

            this.sqlComm = new SqlCommand();
            this.sqlMgr = new SqlManager();

            txUsuario.Focus();
        }


        private void btSair_Click(object sender, EventArgs e) {
            Application.Exit();
        }


        private void btEntrar_Click(object sender, EventArgs e) {
            errorProvider1.Clear();

            String stUsuario = txUsuario.Text;
            String stSenha   = txSenha.Text;

            if(stUsuario.Equals("") || stSenha.Equals("")) {
                if(stUsuario.Equals("") && stSenha.Equals("")) Utils.showSimpleMessageBox("Aviso", "Preencha os campos de login!", "warning");
                else if (stUsuario.Equals("")) errorProvider1.SetError(txUsuario, "Preencha este campo!");
                else if (stSenha.Equals("")) errorProvider1.SetError(txSenha, "Preencha este campo!");

                return;
            } else {
                this.sqlMgr.closeConnection();
                this.sqlComm = new SqlCommand("SELECT * FROM TabelaUsuario WHERE NomeUsu = '" + stUsuario + "'", SqlManager.CONN);
                this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                
                if (this.sqlDataReader.HasRows) {
                    if (this.sqlDataReader.Read()) {
                        String sEncryptPssword = sqlDataReader["SenhaUsu"].ToString();
                        int iIdFunc_FK = int.Parse(sqlDataReader["IDFunc"].ToString());
                        int iNivelAcessoAtual = int.Parse(sqlDataReader["NivelAcessoUsu"].ToString());

                        String sDecryptedPassword = Utils.decrypt(sEncryptPssword);
                        if (stSenha.Equals(sDecryptedPassword)) {
                            lblAcessoNegado.Text = "";
                            lblAcessoNegado.Visible = false;

                            Utils.ID_FUNCIONARIO_LOGADO = iIdFunc_FK;
                            Utils.NIVEL_ACESSO_ATUAL    = iNivelAcessoAtual;

                            this.Close();
                        } else {
                            lblAcessoNegado.Text = "Senha incorreta. Por favor, verifique!";
                            lblAcessoNegado.Visible = true;
                            txSenha.Text = "";

                            errorProvider1.SetError(txSenha, "Senha incorreta!");
                            return;
                        }
                    } else {
                        lblAcessoNegado.Text = "Usuário não encontrado. Por favor, verifique!";
                        lblAcessoNegado.Visible = true;

                        errorProvider1.SetError(txUsuario, "Usuário não encontrado!");
                        return;
                    }
                } else {
                    lblAcessoNegado.Text = "Usuário não encontrado. Por favor, verifique!";
                    lblAcessoNegado.Visible = true;

                    errorProvider1.SetError(txUsuario, "Usuário não encontrado!");
                    return;
                }

            }
        }

    }
}
