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
    public partial class FormRelatoriosCliente : Form {
        public FormRelatoriosCliente() {
            InitializeComponent();
        }

        // Atualiza Reports
        private void reportViewer1_ReportRefresh(object sender, CancelEventArgs e) {
            this.TabelaClienteTableAdapter.Fill(this.CarangaShopDataSet.TabelaCliente);
            this.reportViewer1.RefreshReport();
        }


        private void reportViewer2_ReportRefresh(object sender, CancelEventArgs e) {
            this.TabelaClienteTableAdapter.FillByName(this.CarangaShopDataSet.TabelaCliente, "%" + tbNomeRelatorio2.Text + "%");
            this.reportViewer2.RefreshReport();
        }


        private void reportViewer3_ReportRefresh(object sender, CancelEventArgs e) {
            this.TabelaClienteTableAdapter.FillByDataNasc(this.CarangaShopDataSet.TabelaCliente, dateTimePicker1.Value.ToString("yyyy-MM-dd") );
            this.reportViewer3.RefreshReport();
        }


        // Controla qual relatório está sendo exibido atualmente
        private void bRelatorio1_Click(object sender, EventArgs e) {
            this.TabelaClienteTableAdapter.Fill(this.CarangaShopDataSet.TabelaCliente);
            this.reportViewer1.RefreshReport();

            this.reportViewer2.Visible = false;
            this.reportViewer3.Visible = false;
            gbRelatorioPorNome.Visible = false;
            gbRelatorioPorData.Visible = false;

            this.reportViewer1.Visible = true;
        }


        private void bRelatorio2_Click(object sender, EventArgs e) {
            this.reportViewer1.Visible = false;
            this.reportViewer2.Visible = false;
            this.reportViewer3.Visible = false;
            gbRelatorioPorData.Visible = false;

            gbRelatorioPorNome.Visible = true;
        }


        private void bRelatorio3_Click(object sender, EventArgs e) {
            this.reportViewer1.Visible = false;
            this.reportViewer2.Visible = false;
            this.reportViewer3.Visible = false;
            gbRelatorioPorNome.Visible = false;

            gbRelatorioPorData.Visible = true;
        }


        // Gera os relatórios que necessitam de parâmetros
        private void bGerarRelatorio2_Click(object sender, EventArgs e) {
            this.reportViewer2.Visible = true;

            this.TabelaClienteTableAdapter.FillByName(this.CarangaShopDataSet.TabelaCliente, "%" + tbNomeRelatorio2.Text + "%");
            this.reportViewer2.RefreshReport();
            try {
                if(tbNomeRelatorio2.Text.Equals("")) {
                    ReportParameter rp = new ReportParameter("clientName", "");
                    this.reportViewer2.LocalReport.SetParameters(new ReportParameter[] { rp });
                } else {
                    ReportParameter rp = new ReportParameter("clientName",  tbNomeRelatorio2.Text);
                    this.reportViewer2.LocalReport.SetParameters(new ReportParameter[] { rp });
                }
            } catch(Exception ex) {
                Utils.dg(ex.StackTrace);
            }

            this.reportViewer2.RefreshReport();
        }


        private void bGerarRelatorio3_Click(object sender, EventArgs e) {
            string sDateSelected = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            this.reportViewer3.Visible = true;

            this.TabelaClienteTableAdapter.FillByDataNasc(this.CarangaShopDataSet.TabelaCliente, sDateSelected);
            this.reportViewer3.RefreshReport();
            try {
                if (dateTimePicker1.Text.Equals("")) {
                    ReportParameter rp = new ReportParameter("dataNasc", DateTime.Today.ToString("yyyy-MM-dd"));
                    this.reportViewer3.LocalReport.SetParameters(new ReportParameter[] { rp });
                } else {
                    ReportParameter rp = new ReportParameter("dataNasc", sDateSelected);
                    this.reportViewer3.LocalReport.SetParameters(new ReportParameter[] { rp });
                }
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }

            this.reportViewer3.RefreshReport();
        }


        private void FormRelatoriosCliente_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'CarangaShopDataSet.TabelaCliente' table. You can move, or remove it, as needed.
            this.TabelaClienteTableAdapter.Fill(this.CarangaShopDataSet.TabelaCliente);

        }
    }
}
