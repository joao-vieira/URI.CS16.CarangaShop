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
    public partial class FormRelatoriosFuncionario : Form {
        public FormRelatoriosFuncionario() {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }


        // Atualiza Reports
        private void reportViewer1_ReportRefresh(object sender, CancelEventArgs e) {
            this.TabelaFuncionarioTableAdapter.Fill(this.CarangaShopDataSet.TabelaFuncionario);
            this.reportViewer1.RefreshReport();
        }


        private void reportViewer2_ReportRefresh(object sender, CancelEventArgs e) {
            this.TabelaFuncionarioTableAdapter.FillByName(this.CarangaShopDataSet.TabelaFuncionario, "%" + tbNomeRelatorio2.Text + "%");
            this.reportViewer2.RefreshReport();
        }


        private void reportViewer3_ReportRefresh(object sender, CancelEventArgs e) {
            this.TabelaFuncionarioTableAdapter.FillByDataNasc(this.CarangaShopDataSet.TabelaFuncionario, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            this.reportViewer3.RefreshReport();
        }


        private void reportViewer4_ReportRefresh(object sender, CancelEventArgs e) {
            if (comboBox1.Text.Equals("Maior que")) {
                this.TabelaFuncionarioTableAdapter.FillBySalarioMaior(this.CarangaShopDataSet.TabelaFuncionario, Convert.ToDecimal(textBox1.Text));
                this.reportViewer4.RefreshReport();
            } else {
                this.TabelaFuncionarioTableAdapter.FillBySalarioMenor(this.CarangaShopDataSet.TabelaFuncionario, Convert.ToDecimal(textBox1.Text));
                this.reportViewer4.RefreshReport();
            }
        }

        // Controla qual relatório está sendo exibido atualmente
        private void bRelatorio1_Click(object sender, EventArgs e) {
            this.TabelaFuncionarioTableAdapter.Fill(this.CarangaShopDataSet.TabelaFuncionario);
            this.reportViewer1.RefreshReport();

            this.reportViewer2.Visible = false;
            this.reportViewer3.Visible = false;
            this.reportViewer4.Visible = false;
            gbRelatorioPorNome.Visible = false;
            gbRelatorioPorData.Visible = false;
            gbRelatorioPorSalario.Visible = false;

            this.reportViewer1.Visible = true;
        }


        private void bRelatorio2_Click(object sender, EventArgs e) {
            this.reportViewer1.Visible = false;
            this.reportViewer2.Visible = false;
            this.reportViewer3.Visible = false;
            this.reportViewer4.Visible = false;
            gbRelatorioPorData.Visible = false;
            gbRelatorioPorSalario.Visible = false;

            gbRelatorioPorNome.Visible = true;
        }


        private void bRelatorio3_Click(object sender, EventArgs e) {
            this.reportViewer1.Visible = false;
            this.reportViewer2.Visible = false;
            this.reportViewer3.Visible = false;
            this.reportViewer4.Visible = false;
            gbRelatorioPorNome.Visible = false;
            gbRelatorioPorSalario.Visible = false;

            gbRelatorioPorData.Visible = true;
        }


        private void bRelatorio4_Click(object sender, EventArgs e) {
            this.reportViewer1.Visible = false;
            this.reportViewer2.Visible = false;
            this.reportViewer3.Visible = false;
            this.reportViewer4.Visible = false;
            gbRelatorioPorNome.Visible = false;
            gbRelatorioPorData.Visible = false;

            gbRelatorioPorSalario.Visible = true;
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        // Gera os relatórios que necessitam de parâmetros
        private void bGerarRelatorio2_Click(object sender, EventArgs e) {
            this.reportViewer2.Visible = true;

            this.TabelaFuncionarioTableAdapter.FillByName(this.CarangaShopDataSet.TabelaFuncionario, "%" + tbNomeRelatorio2.Text + "%");
            this.reportViewer2.RefreshReport();
            try {
                if (tbNomeRelatorio2.Text.Equals("")) {
                    ReportParameter rp = new ReportParameter("funcName", "");
                    this.reportViewer2.LocalReport.SetParameters(new ReportParameter[] { rp });
                } else {
                    ReportParameter rp = new ReportParameter("funcName", tbNomeRelatorio2.Text);
                    this.reportViewer2.LocalReport.SetParameters(new ReportParameter[] { rp });
                }
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }

            this.reportViewer2.RefreshReport();
        }


        private void bGerarRelatorio3_Click(object sender, EventArgs e) {
            string sDateSelected = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            this.reportViewer3.Visible = true;

            this.TabelaFuncionarioTableAdapter.FillByDataNasc(this.CarangaShopDataSet.TabelaFuncionario, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
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


        private void bGerarRelatorio4_Click(object sender, EventArgs e) {
            this.reportViewer4.Visible = true;

            if (comboBox1.Text.Equals("Maior que")) {
                this.TabelaFuncionarioTableAdapter.FillBySalarioMaior(this.CarangaShopDataSet.TabelaFuncionario, Convert.ToDecimal(textBox1.Text));
                this.reportViewer4.RefreshReport();
            } else {
                this.TabelaFuncionarioTableAdapter.FillBySalarioMenor(this.CarangaShopDataSet.TabelaFuncionario, Convert.ToDecimal(textBox1.Text));
                this.reportViewer4.RefreshReport();
            }

            try {
                ReportParameter rp = new ReportParameter("salario", textBox1.Text);
                this.reportViewer4.LocalReport.SetParameters(new ReportParameter[] { rp });
            } catch (Exception ex) {
                Utils.dg(ex.StackTrace);
            }

            this.reportViewer4.RefreshReport();
        }


        private void FormRelatoriosFuncionario_Load(object sender, EventArgs e) {
            this.TabelaFuncionarioTableAdapter.Fill(this.CarangaShopDataSet.TabelaFuncionario);
            this.reportViewer3.RefreshReport();
        }

        
    }
}
