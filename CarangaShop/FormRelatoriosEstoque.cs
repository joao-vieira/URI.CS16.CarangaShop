using Microsoft.Reporting.WinForms;
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
    public partial class FormRelatoriosEstoque : Form {
        private SqlCommand sqlComm;
        private SqlManager sqlMgr;
        private SqlDataReader sqlDataReader;
        private int iVeiculoAtual;

        public FormRelatoriosEstoque() {
            InitializeComponent();

            this.sqlComm = new SqlCommand();
            this.sqlMgr = new SqlManager();
        }

        private void FormRelatoriosEstoque_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'CarangaShopDataSet.TabelaEstoque' table. You can move, or remove it, as needed.
            //this.TabelaEstoqueTableAdapter.Fill(this.CarangaShopDataSet.TabelaEstoque);
            // this.TabelaEstoqueTableAdapter.Fill(this.CarangaShopDataSet.TabelaEstoque);
            this.tabelaModeloTableAdapter.Fill(this.CarangaShopDataSet.TabelaModelo);
            this.tabelaCategoriaTableAdapter.Fill(this.CarangaShopDataSet.TabelaCategoria);
            this.reportViewer2.RefreshReport();
            this.reportViewer2.RefreshReport();
        }


        // Atualiza Reports
        private void reportViewer1_ReportRefresh(object sender, CancelEventArgs e) {
            this.EstoquePorCategoriaTableAdapter.Fill(this.CarangaShopDataSet.EstoquePorCategoria, int.Parse(cbCategoriaRel1.SelectedValue.ToString()));
            this.reportViewer1.RefreshReport();
        }


        private void reportViewer2_ReportRefresh(object sender, CancelEventArgs e) {
            this.TabelaEstoqueTableAdapter.FillByIDVei(this.CarangaShopDataSet.TabelaEstoque, this.iVeiculoAtual);
            this.reportViewer2.RefreshReport();
        }


        // Controla qual relatório está sendo exibido atualmente
        private void bRelatorio1_Click(object sender, EventArgs e) {
            this.reportViewer1.Visible = false;
            this.reportViewer2.Visible = false;
            gbRelatorio2.Visible = false;

            gbRelatorio1.Visible = true;
        }


        private void bRelatorio2_Click(object sender, EventArgs e) {
            this.fillVehiclesCombobox();

            this.reportViewer1.Visible = false;
            this.reportViewer2.Visible = false;
            gbRelatorio1.Visible = false;

            gbRelatorio2.Visible = true;
        }


        // Gera os relatórios que necessitam de parâmetros
        private void bGerarRelatorio1_Click(object sender, EventArgs e) {
            this.reportViewer1.Visible = true;

            this.EstoquePorCategoriaTableAdapter.Fill(this.CarangaShopDataSet.EstoquePorCategoria, int.Parse(cbCategoriaRel1.SelectedValue.ToString()));
            this.reportViewer1.RefreshReport();

            try {
                ReportParameter rp = new ReportParameter("idCategoria", cbCategoriaRel1.SelectedValue.ToString());
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp });
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }

            this.reportViewer1.RefreshReport();
        }


        private void bGerarRelatorio2_Click(object sender, EventArgs e) {
            this.reportViewer2.Visible = true;
            
            if(this.iVeiculoAtual > 0) {
                this.TabelaEstoqueTableAdapter.FillByIDVei(this.CarangaShopDataSet.TabelaEstoque, this.iVeiculoAtual);
                this.reportViewer2.RefreshReport();

                try {
                    ReportParameter rp = new ReportParameter("idVeiculo", this.iVeiculoAtual.ToString());
                    this.reportViewer2.LocalReport.SetParameters(new ReportParameter[] { rp });
                } catch (Exception ex) {
                    Utils.dg(ex.StackTrace);
                }

                this.reportViewer2.RefreshReport();
            } else {
                Utils.showSimpleMessageBox("Ops!", "O modelo selecionado não possui nenhum veículo cadastrado. Por favor, escolha outro!", "warning");
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            this.fillVehiclesCombobox();
        }


        private void fillVehiclesCombobox() {
            try {
                bool bAlreadySetted = false;
                comboBox2.Text = "";
                if (comboBox2.Items.Count > 0) comboBox2.Items.Clear();

                this.sqlMgr.closeConnection();
                this.sqlComm = new SqlCommand("SELECT * FROM TabelaVeiculo WHERE IDMod = '" + comboBox1.SelectedValue.ToString() + "'", SqlManager.CONN);
                Utils.dg("===> " + "SELECT * FROM TabelaVeiculo WHERE IDMod = '" + comboBox1.SelectedValue.ToString() + "'");
                this.sqlDataReader = this.sqlMgr.performQuery(this.sqlComm);
                if (this.sqlDataReader.HasRows) {
                    while (this.sqlDataReader.Read()) {
                        ComboboxItem cbItem = new ComboboxItem();
                        cbItem.Value = this.sqlDataReader["IDVei"].ToString();
                        cbItem.Text = this.sqlDataReader["AnoModeloVei"].ToString() + " / " + this.sqlDataReader["CombustivelVei"].ToString();
                        comboBox2.Items.Add(cbItem);

                        if (!bAlreadySetted) {
                            comboBox2.SelectedItem = cbItem;
                            this.iVeiculoAtual = int.Parse(this.sqlDataReader["IDVei"].ToString());
                            bAlreadySetted = true;
                        }
                    }
                }
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }
        }

        
    }
}
