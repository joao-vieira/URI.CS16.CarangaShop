using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarangaShop {
    public partial class FormRelatoriosVeiculo : Form {
        public FormRelatoriosVeiculo() {
            InitializeComponent();
        }

        private void FormRelatoriosVeiculo_Load(object sender, EventArgs e) {
            this.tabelaCategoriaTableAdapter.Fill(this.CarangaShopDataSet.TabelaCategoria);
            this.TabelaVeiculoTableAdapter.Fill(this.CarangaShopDataSet.TabelaVeiculo);
        }

        
        // Atualiza Reports
        private void reportViewer1_ReportRefresh(object sender, CancelEventArgs e) {
            this.TabelaVeiculoTableAdapter.Fill(this.CarangaShopDataSet.TabelaVeiculo);
            this.reportViewer1.RefreshReport();
        }


        private void reportViewer2_ReportRefresh(object sender, CancelEventArgs e) {
            this.TabelaVeiculoTableAdapter.FillByCategoria(this.CarangaShopDataSet.TabelaVeiculo, int.Parse(cbCategoriaRelatorio2.SelectedValue.ToString()));
            this.reportViewer2.RefreshReport();
        }


        private void reportViewer3_ReportRefresh(object sender, CancelEventArgs e) {
            if (comboBox1.Text.Equals("Crescente")) {
                this.TabelaVeiculoTableAdapter.FillByCategoriaOrderByPrecoASC(this.CarangaShopDataSet.TabelaVeiculo, int.Parse(cbCategoriaRelatorio2.SelectedValue.ToString()));
                this.reportViewer3.RefreshReport();
            } else {
                this.TabelaVeiculoTableAdapter.FillByCategoriaOrderByPrecoDESC(this.CarangaShopDataSet.TabelaVeiculo, int.Parse(cbCategoriaRelatorio2.SelectedValue.ToString()));
                this.reportViewer3.RefreshReport();
            }
        }

        // Controla qual relatório está sendo exibido atualmente
        private void bRelatorio1_Click(object sender, EventArgs e) {
            this.TabelaVeiculoTableAdapter.Fill(this.CarangaShopDataSet.TabelaVeiculo);
            this.reportViewer1.RefreshReport();

            this.reportViewer2.Visible = false;
            this.reportViewer3.Visible = false;
            gbRelatorio2.Visible = false;
            gbRelatorio3.Visible = false;

            this.reportViewer1.Visible = true;
        }


        private void bRelatorio2_Click(object sender, EventArgs e) {
            this.reportViewer1.Visible = false;
            this.reportViewer2.Visible = false;
            this.reportViewer3.Visible = false;
            gbRelatorio3.Visible = false;

            gbRelatorio2.Visible = true;
        }


        private void bRelatorio3_Click(object sender, EventArgs e) {
            this.reportViewer1.Visible = false;
            this.reportViewer2.Visible = false;
            this.reportViewer3.Visible = false;
            gbRelatorio2.Visible = false;

            gbRelatorio3.Visible = true;
            comboBox1.SelectedItem = comboBox1.Items[0];
        }


        // Gera os relatórios que necessitam de parâmetros
        private void bGerarRelatorio2_Click(object sender, EventArgs e) {
            this.reportViewer2.Visible = true;

            this.TabelaVeiculoTableAdapter.FillByCategoria(this.CarangaShopDataSet.TabelaVeiculo, int.Parse(cbCategoriaRelatorio2.SelectedValue.ToString()));
            this.reportViewer2.RefreshReport();
            try {
                ReportParameter rp = new ReportParameter("idCategoria", cbCategoriaRelatorio2.SelectedValue.ToString());
                this.reportViewer2.LocalReport.SetParameters(new ReportParameter[] { rp });
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }

            this.reportViewer2.RefreshReport();
        }


        private void bGerarRelatorio3_Click(object sender, EventArgs e) {
            this.reportViewer3.Visible = true;

            if(comboBox1.Text.Equals("Crescente")) {
                this.TabelaVeiculoTableAdapter.FillByCategoriaOrderByPrecoASC(this.CarangaShopDataSet.TabelaVeiculo, int.Parse(cbCategoriaRelatorio2.SelectedValue.ToString()));
                this.reportViewer3.RefreshReport();
            } else {
                this.TabelaVeiculoTableAdapter.FillByCategoriaOrderByPrecoDESC(this.CarangaShopDataSet.TabelaVeiculo, int.Parse(cbCategoriaRelatorio2.SelectedValue.ToString()));
                this.reportViewer3.RefreshReport();
            }
            
            try {
                ReportParameter rp = new ReportParameter("idCategoria", cbCategoriaRelatorio2.SelectedValue.ToString());
                this.reportViewer3.LocalReport.SetParameters(new ReportParameter[] { rp });
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }

            this.reportViewer3.RefreshReport();
        }
    }
}
