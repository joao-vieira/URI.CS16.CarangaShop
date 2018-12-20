using System;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace CarangaShop {
    public partial class MainForm : Form {
        private SqlManager sqlMgr;
        private SqlCommand sqlComm;

        public static int NIVEL_ACESSO_ATUAL;
        public static int ID_FUNCIONARIO_ATUAL;

        public MainForm() {
            InitializeComponent();
            this.sqlMgr          = new SqlManager();
            this.sqlComm         = new SqlCommand();

            this.TopMost         = true;
            
            /*
            this.Width = 1050;
            this.Height = 700;
            */
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState     = FormWindowState.Maximized;


            
            /*
            menuStrip1.Enabled = true;
            Utils.ID_FUNCIONARIO_LOGADO = 9;
            Utils.NIVEL_ACESSO_ATUAL    = 1;
            */


            menuStrip1.Enabled = false;

            // Abre formulário de login
            Login frmLogin          = new Login();
            frmLogin.MdiParent     = this;
            frmLogin.StartPosition = FormStartPosition.CenterScreen;
            frmLogin.ControlBox = false;
            frmLogin.Show();

            // Quando o formulário de login for fechado, executa esse código
            frmLogin.FormClosed += new FormClosedEventHandler(Form_Closed);
            void Form_Closed(object sender, FormClosedEventArgs e) {
                menuStrip1.Enabled = true;

                Utils.dg("Form de login acabou de ser fechado: ");
                Utils.dg("#1 Nivel Acesso = " + Utils.NIVEL_ACESSO_ATUAL);
                Utils.dg("#2 Funcionario Atual = " +  Utils.ID_FUNCIONARIO_LOGADO);
                if(Utils.NIVEL_ACESSO_ATUAL == 2 ) {
                    usuárioToolStripMenuItem1.Visible = false;          // Cadastro de Usuários
                    inserirMarcasToolStripMenuItem.Visible = false;     // Cadastro de Marcas (automático)
                    inserirCategoriasToolStripMenuItem.Visible = false; // Cadastro de Categorias (automático)
                    funcionáriosToolStripMenuItem.Visible = false;      // Relatório de Funcionários
                    vendasToolStripMenuItem2.Visible = false;           // Relatório de Vendas
                } else {
                    usuárioToolStripMenuItem1.Visible = true;
                    inserirMarcasToolStripMenuItem.Visible = true;
                    inserirCategoriasToolStripMenuItem.Visible = true;
                    funcionáriosToolStripMenuItem.Visible = true;
                    vendasToolStripMenuItem2.Visible = true;
                }
            }
        }


        /*
         * CADASTROS
         */
        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e) {
            Form f = Application.OpenForms["FormCliente"];
            if (f != null) { 
                f.BringToFront();
            } else {
                f = new FormCliente();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
        }


        private void funcionárioToolStripMenuItem1_Click(object sender, EventArgs e) {
            Form f = Application.OpenForms["FormFuncionario"];
            if (f != null) { 
                f.BringToFront();
            } else {
                f = new FormFuncionario();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
        }


        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e) {
            Form f = Application.OpenForms["FormUsuario"];
            if (f != null) {
                f.BringToFront();
            } else {
                f = new FormUsuario();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
        }


        private void modeloToolStripMenuItem_Click(object sender, EventArgs e) {
            Form f = Application.OpenForms["FormModelo"];
            if (f != null) {
                f.BringToFront();
            } else {
                f = new FormModelo();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
        }


        private void veículoToolStripMenuItem_Click(object sender, EventArgs e) {
            Form f = Application.OpenForms["FormVeiculo"];
            if (f != null) {
                f.BringToFront();
            } else {
                f = new FormVeiculo();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
        }


        /*
         * VENDAS
         */ 
        private void vENDASToolStripMenuItem1_Click(object sender, EventArgs e) {
            Form f = Application.OpenForms["FormVenda"];
            if (f != null) {
                f.BringToFront();
            } else {
                f = new FormVenda();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
        }


        /*
         * RELATÓRIOS
         */
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e) {
            Form f = Application.OpenForms["FormRelatoriosCliente"];
            if (f != null) {
                f.BringToFront();
            } else {
                f = new FormRelatoriosCliente();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
        }


        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e) {
            Form f = Application.OpenForms["FormRelatoriosFuncionario"];
            if (f != null) {
                f.BringToFront();
            } else {
                f = new FormRelatoriosFuncionario();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
        }


        private void veículosToolStripMenuItem1_Click(object sender, EventArgs e) {
            Form f = Application.OpenForms["FormRelatoriosVeiculo"];
            if (f != null) {
                f.BringToFront();
            } else {
                f = new FormRelatoriosVeiculo();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
        }


        private void vendasToolStripMenuItem2_Click(object sender, EventArgs e) {
            Form f = Application.OpenForms["FormRelatoriosVenda"];
            if (f != null) {
                f.BringToFront();
            } else {
                f = new FormRelatoriosVenda();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
        }


        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e) {
            Form f = Application.OpenForms["FormRelatoriosEstoque"];
            if (f != null) {
                f.BringToFront();
            } else {
                f = new FormRelatoriosEstoque();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
        }


        /*
        * CONFIGURAÇÕES (Inserções e Logoff)
        */
        private void inserirCategoriasToolStripMenuItem_Click(object sender, EventArgs e) {
            int iTotalCategorias = 0;
            SqlDataReader sqlDataReader;

            try {
                this.sqlMgr.closeConnection();
                this.sqlComm = new SqlCommand("SELECT COUNT(*) AS TOTAL_CATEGORIAS FROM TabelaCategoria", SqlManager.CONN);
                sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                if (sqlDataReader.Read()) {
                    iTotalCategorias = Int32.Parse(sqlDataReader["TOTAL_CATEGORIAS"].ToString());
                }
                this.sqlMgr.closeConnection();

                // Se já possuir registro, não faz nada [antigo: exclui todos e insere novamente]
                if (iTotalCategorias > 0) {
                    Utils.showSimpleMessageBox("Sucesso", "Categorias cadastradas com sucesso!", "success");
                    /*
                    this.sqlComm = new SqlCommand("DELETE FROM TabelaCategoria", SqlManager.CONN);
                    this.sqlMgr.performQueryWithoutReturn(this.sqlComm);
                    this.sqlMgr.closeConnection();

                    this.insereCategorias();
                    */
                } else { // Se não, insere todos os registros
                    this.insereCategorias();
                }
            } catch (Exception ex) {
                Utils.showSimpleMessageBox("Ops", "Ocorreu algum erro!", "wrong");
                Console.WriteLine(ex.StackTrace);
            }
        }


        private void carrosToolStripMenuItem_Click(object sender, EventArgs e) {
            int iTotalMarcasCarro = 0;

            try {
                this.sqlComm = new SqlCommand("SELECT COUNT(*) AS TOTAL_MARCAS_CARRO FROM TabelaMarca WHERE IDCat = 1", SqlManager.CONN);
                SqlDataReader sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                if (sqlDataReader.Read()) {
                    iTotalMarcasCarro = Int32.Parse(sqlDataReader["TOTAL_MARCAS_CARRO"].ToString());
                }
                this.sqlMgr.closeConnection();

                // Se já possuir registro, não faz nada [antigo: exclui todos e insere novamente]
                if (iTotalMarcasCarro > 0) {
                    Utils.showSimpleMessageBox("Sucesso", "Marcas de carros cadastradas com sucesso!", "success");
                    /*
                    this.sqlComm = new SqlCommand("DELETE FROM TabelaMarca WHERE IDCat = 1", SqlManager.CONN);
                    this.sqlMgr.performQueryWithoutReturn(this.sqlComm);
                    this.sqlMgr.closeConnection();

                    this.insereMarcas("carros");
                    */
                } else { // Se não, insere todos os registros pela 1ª vez
                    this.insereMarcas("carros");
                }
            } catch (Exception ex) {
                Utils.showSimpleMessageBox("Ops", "Ocorreu algum erro ao inserir marcas de carros!", "wrong");
                Console.WriteLine(ex.StackTrace);
            }
        }


        private void motosToolStripMenuItem_Click(object sender, EventArgs e) {
            int iTotalMarcasMoto = 0;
            SqlDataReader sqlDataReader;

            try {
                this.sqlComm = new SqlCommand("SELECT COUNT(*) AS TOTAL_MARCAS_MOTO FROM TabelaMarca WHERE IDCat = 2", SqlManager.CONN);
                sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                if (sqlDataReader.Read()) {
                    iTotalMarcasMoto = Int32.Parse(sqlDataReader["TOTAL_MARCAS_MOTO"].ToString());
                }
                this.sqlMgr.closeConnection();

                // Se já possuir registro, não faz nada [antigo: exclui todos e insere novamente]
                if (iTotalMarcasMoto > 0) {
                    Utils.showSimpleMessageBox("Sucesso", "Marcas de motos cadastradas com sucesso!", "success");
                    /*
                    this.sqlComm = new SqlCommand("DELETE FROM TabelaMarca WHERE IDCat = 2", SqlManager.CONN);
                    this.sqlMgr.performQueryWithoutReturn(this.sqlComm);
                    this.sqlMgr.closeConnection();

                    this.insereMarcas("motos");
                    */
                } else { // Se não, insere todos os registros pela 1ª vez
                    this.insereMarcas("motos");
                }
            } catch (Exception ex) {
                Utils.showSimpleMessageBox("Ops", "Ocorreu algum erro ao inserir marcas de motos!", "wrong");
                Console.WriteLine(ex.StackTrace);
            }
        }


        private void caminhõesToolStripMenuItem_Click(object sender, EventArgs e) {
            int iTotalMarcasCaminhão = 0;
            SqlDataReader sqlDataReader;

            try {
                this.sqlComm = new SqlCommand("SELECT COUNT(*) AS TOTAL_MARCAS_CAMINHAO FROM TabelaMarca WHERE IDCat = 3", SqlManager.CONN);
                sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                if (sqlDataReader.Read()) {
                    iTotalMarcasCaminhão = Int32.Parse(sqlDataReader["TOTAL_MARCAS_CAMINHAO"].ToString());
                }
                this.sqlMgr.closeConnection();

                // Se já possuir registro, não faz nada [antigo: exclui todos e insere novamente]
                if (iTotalMarcasCaminhão > 0) {
                    Utils.showSimpleMessageBox("Sucesso", "Marcas de caminhões cadastradas com sucesso!", "success");
                    /*
                    this.sqlComm = new SqlCommand("DELETE FROM TabelaMarca WHERE IDCat = 3", SqlManager.CONN);
                    this.sqlMgr.performQueryWithoutReturn(this.sqlComm);
                    this.sqlMgr.closeConnection();

                    this.insereMarcas("caminhoes");
                    */
                } else { // Se não, insere todos os registros pela 1ª vez
                    this.insereMarcas("caminhoes");
                }
            } catch (Exception ex) {
                Utils.showSimpleMessageBox("Ops", "Ocorreu algum erro ao inserir marcas de caminhões!", "wrong");
                Console.WriteLine(ex.StackTrace);
            }
        }



        // COMPLEMENTOS (não é menu)
        private void insereMarcas(String sCategoria) {
            int iIdCat_FK = (sCategoria.Equals("carros")) ? 1 : (sCategoria.Equals("motos")) ? 2 : 3;
            String descCat = (sCategoria.Equals("carros")) ? "Carros" : (sCategoria.Equals("motos")) ? "Motos" : "Caminhões";
            WebRequest request  = WebRequest.Create(Utils.CONST_API_VEICULOS + sCategoria + "/marcas.json");

            Utils.dg("[insereMarcas()] DE " + sCategoria + " => (" + iIdCat_FK + ")");
            Utils.dg("URL = " + Utils.CONST_API_VEICULOS + sCategoria + "/marcas.json");

            String respJSON = Utils.makeRequest(request);

            if (respJSON != null) {
                try {
                    JArray parsedArray = JArray.Parse(respJSON);
                    foreach (JObject parsedObject in parsedArray.Children<JObject>()) {
                        String sKeyAPIMar = "";
                        String sNomeMar = "";
                        foreach (JProperty parsedProperty in parsedObject.Properties()) {
                            string propertyName = parsedProperty.Name;
                            if (propertyName.Equals("id")) {
                                sKeyAPIMar = (string)parsedProperty.Value;
                            } else if (propertyName.Equals("name")) {
                                sNomeMar = (string)parsedProperty.Value;
                            }

                            if (!sKeyAPIMar.Equals("") && !sNomeMar.Equals("")) {
                                Console.WriteLine("sKeyAPIMar: {0}, sNomeMar: {1}", sKeyAPIMar, sNomeMar);

                                this.sqlComm = new SqlCommand(
                                                " INSERT INTO TabelaMarca (NomeMar, KeyAPIMar, IDCat) " +
                                                "VALUES (@NomeMar, @KeyAPIMar, @IDCat)", SqlManager.CONN);

                                this.sqlComm.Parameters.Add("@IDMar", System.Data.SqlDbType.Int);
                                this.sqlComm.Parameters["@IDMar"].Value = 0;

                                this.sqlComm.Parameters.Add("@NomeMar", System.Data.SqlDbType.NVarChar);
                                this.sqlComm.Parameters["@NomeMar"].Value = sNomeMar;

                                this.sqlComm.Parameters.Add("@KeyAPIMar", System.Data.SqlDbType.NVarChar);
                                this.sqlComm.Parameters["@KeyAPIMar"].Value = sKeyAPIMar;

                                this.sqlComm.Parameters.Add("@IDCat", System.Data.SqlDbType.Int);
                                this.sqlComm.Parameters["@IDCat"].Value = iIdCat_FK;

                                this.sqlMgr.performQueryWithoutReturn(this.sqlComm);
                                break;
                            }
                        }
                        Console.WriteLine("----------------------------------------------------------------");
                    }
                    Utils.showSimpleMessageBox("Sucesso", "Marcas de " + descCat + " inseridas com sucesso!", "success");
                } catch (Exception ex) {
                    Utils.dg(ex.StackTrace);
                }
            } else {
                Utils.showSimpleMessageBox("Ops", "Verifique sua conexão com a internet!", "warning");
            }
        }

        
        private void insereCategorias() {
            try {

                this.sqlComm = new SqlCommand(" INSERT INTO TabelaCategoria (IDCat, DescCat, ValorURLCat) " +
                                                    "VALUES (@IDCat, @DescCat, @ValorURLCat)", SqlManager.CONN);

                this.sqlComm.Parameters.Add("@IDCat", System.Data.SqlDbType.Int);
                this.sqlComm.Parameters["@IDCat"].Value = 1;

                this.sqlComm.Parameters.Add("@DescCat", System.Data.SqlDbType.NVarChar);
                this.sqlComm.Parameters["@DescCat"].Value = "Carros";

                this.sqlComm.Parameters.Add("@ValorURLCat", System.Data.SqlDbType.NVarChar);
                this.sqlComm.Parameters["@ValorURLCat"].Value = "carros";

                this.sqlMgr.performQueryWithoutReturn(this.sqlComm);
                this.sqlMgr.closeConnection();



                this.sqlComm = new SqlCommand(" INSERT INTO TabelaCategoria (IDCat, DescCat, ValorURLCat) " +
                                                    "VALUES (@IDCat, @DescCat, @ValorURLCat)", SqlManager.CONN);

                this.sqlComm.Parameters.Add("@IDCat", System.Data.SqlDbType.Int);
                this.sqlComm.Parameters["@IDCat"].Value = 2;

                this.sqlComm.Parameters.Add("@DescCat", System.Data.SqlDbType.NVarChar);
                this.sqlComm.Parameters["@DescCat"].Value = "Motos";

                this.sqlComm.Parameters.Add("@ValorURLCat", System.Data.SqlDbType.NVarChar);
                this.sqlComm.Parameters["@ValorURLCat"].Value = "motos";

                this.sqlMgr.performQueryWithoutReturn(this.sqlComm);
                this.sqlMgr.closeConnection();



                this.sqlComm = new SqlCommand(" INSERT INTO TabelaCategoria (IDCat, DescCat, ValorURLCat) " +
                                                    "VALUES (@IDCat, @DescCat, @ValorURLCat)", SqlManager.CONN);

                this.sqlComm.Parameters.Add("@IDCat", System.Data.SqlDbType.Int);
                this.sqlComm.Parameters["@IDCat"].Value = 3;

                this.sqlComm.Parameters.Add("@DescCat", System.Data.SqlDbType.NVarChar);
                this.sqlComm.Parameters["@DescCat"].Value = "Caminhões";

                this.sqlComm.Parameters.Add("@ValorURLCat", System.Data.SqlDbType.NVarChar);
                this.sqlComm.Parameters["@ValorURLCat"].Value = "caminhoes";

                this.sqlMgr.performQueryWithoutReturn(this.sqlComm);
                this.sqlMgr.closeConnection();

                Utils.showSimpleMessageBox("Sucesso", "Categorias inseridas com sucesso!", "success");
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
                Utils.showSimpleMessageBox("Erro", "Erro ao inserir categorias!", "wrong");
            }
        }

        
    }
}
