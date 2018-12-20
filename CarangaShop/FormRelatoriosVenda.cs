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
    public partial class FormRelatoriosVenda : Form {
        public FormRelatoriosVenda() {
            InitializeComponent();
        }


        private void FormRelatoriosCliente_Load(object sender, EventArgs e) {
            this.tabelaClienteTableAdapter.Fill(this.CarangaShopDataSet.TabelaCliente);
        }


        // Atualiza Reports
        private void reportViewer1_ReportRefresh(object sender, CancelEventArgs e) {
            this.ItensVendaPorClienteTableAdapter.Fill(this.CarangaShopDataSet.ItensVendaPorCliente, int.Parse(cbClienteRel1.SelectedValue.ToString()));
            this.reportViewer1.RefreshReport();
        }


        private void reportViewer2_ReportRefresh(object sender, CancelEventArgs e) {
            this.ItensVendaPorClienteEntreDatasTableAdapter.Fill(this.CarangaShopDataSet.ItensVendaPorClienteEntreDatas,
                int.Parse(cbClienteRel2.SelectedValue.ToString()), dtpInicioRel2.Value.ToString("yyyy-MM-dd"), dtpFinalRel2.Value.ToString("yyyy-MM-dd"));
            this.reportViewer2.RefreshReport();
        }


        private void reportViewer3_ReportRefresh(object sender, CancelEventArgs e) {
            this.ItensVendaEntreDatasTableAdapter.Fill(this.CarangaShopDataSet.ItensVendaEntreDatas,
                    dtpInicioRel3.Value.ToString("yyyy-MM-dd"), dtpFinalRel3.Value.ToString("yyyy-MM-dd"));
            this.reportViewer3.RefreshReport();
        }


        // Controla qual relatório está sendo exibido atualmente
        private void bRelatorio1_Click(object sender, EventArgs e) {
            this.reportViewer1.Visible = false;
            this.reportViewer2.Visible = false;
            this.reportViewer3.Visible = false;
            gbRelatorio2.Visible = false;
            gbRelatorio3.Visible = false;

            gbRelatorio1.Visible = true;
        }


        private void bRelatorio2_Click(object sender, EventArgs e) {
            this.reportViewer1.Visible = false;
            this.reportViewer2.Visible = false;
            this.reportViewer3.Visible = false;
            gbRelatorio1.Visible = false;
            gbRelatorio3.Visible = false;

            gbRelatorio2.Visible = true;
        }


        private void bRelatorio3_Click(object sender, EventArgs e) {
            this.reportViewer1.Visible = false;
            this.reportViewer2.Visible = false;
            this.reportViewer3.Visible = false;
            gbRelatorio1.Visible = false;
            gbRelatorio2.Visible = false;

            gbRelatorio3.Visible = true;
        }


        // Gera os relatórios que necessitam de parâmetros
        private void bGerarRelatorio1_Click(object sender, EventArgs e) {
            this.reportViewer1.Visible = true;

            this.ItensVendaPorClienteTableAdapter.Fill(this.CarangaShopDataSet.ItensVendaPorCliente, int.Parse(cbClienteRel1.SelectedValue.ToString()));
            this.reportViewer1.RefreshReport();
            try {
                ReportParameter rp = new ReportParameter("idCliente", cbClienteRel1.SelectedValue.ToString());
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp });
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }

            this.reportViewer1.RefreshReport();
        }


        private void bGerarRelatorio2_Click(object sender, EventArgs e) {
            this.reportViewer2.Visible = true;

            this.ItensVendaPorClienteEntreDatasTableAdapter.Fill(this.CarangaShopDataSet.ItensVendaPorClienteEntreDatas,
                int.Parse(cbClienteRel2.SelectedValue.ToString()), dtpInicioRel2.Value.ToString("yyyy-MM-dd"), dtpFinalRel2.Value.ToString("yyyy-MM-dd"));
            this.reportViewer2.RefreshReport();
            try {
                ReportParameter rp  = new ReportParameter("idCliente", cbClienteRel2.SelectedValue.ToString());
                ReportParameter rp2 = new ReportParameter("dtInicio", dtpInicioRel2.Value.ToString("yyyy-MM-dd"));
                ReportParameter rp3 = new ReportParameter("dtFinal", dtpFinalRel2.Value.ToString("yyyy-MM-dd"));
                this.reportViewer2.LocalReport.SetParameters(new ReportParameter[] { rp, rp2, rp3 });
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }

            this.reportViewer2.RefreshReport();
        }


        private void bGerarRelatorio3_Click(object sender, EventArgs e) {
            this.reportViewer3.Visible = true;

            this.ItensVendaEntreDatasTableAdapter.Fill(this.CarangaShopDataSet.ItensVendaEntreDatas,
                    dtpInicioRel3.Value.ToString("yyyy-MM-dd"), dtpFinalRel3.Value.ToString("yyyy-MM-dd"));
            this.reportViewer3.RefreshReport();
            try {
                ReportParameter rp = new ReportParameter("dtInicio", dtpInicioRel2.Value.ToString("yyyy-MM-dd"));
                ReportParameter rp2 = new ReportParameter("dtFinal", dtpFinalRel2.Value.ToString("yyyy-MM-dd"));
                this.reportViewer2.LocalReport.SetParameters(new ReportParameter[] { rp, rp2 });
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }

            this.reportViewer3.RefreshReport();
        }

        
    }
}
