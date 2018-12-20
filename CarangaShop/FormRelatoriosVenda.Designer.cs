namespace CarangaShop {
    partial class FormRelatoriosVenda {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ItensVendaPorClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CarangaShopDataSet = new CarangaShop.CarangaShopDataSet();
            this.ItensVendaPorClienteEntreDatasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItensVendaEntreDatasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bRelatorio1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bRelatorio2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bRelatorio3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bGerarRelatorio2 = new System.Windows.Forms.Button();
            this.gbRelatorio2 = new System.Windows.Forms.GroupBox();
            this.dtpFinalRel2 = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioRel2 = new System.Windows.Forms.DateTimePicker();
            this.cbClienteRel2 = new System.Windows.Forms.ComboBox();
            this.tabelaClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbRelatorio3 = new System.Windows.Forms.GroupBox();
            this.dtpFinalRel3 = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioRel3 = new System.Windows.Forms.DateTimePicker();
            this.bGerarRelatorio3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbRelatorio1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbClienteRel1 = new System.Windows.Forms.ComboBox();
            this.bGerarRelatorio1 = new System.Windows.Forms.Button();
            this.tabelaClienteTabelaVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelaClienteTableAdapter = new CarangaShop.CarangaShopDataSetTableAdapters.TabelaClienteTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ItensVendaPorClienteTableAdapter = new CarangaShop.CarangaShopDataSetTableAdapters.ItensVendaPorClienteTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ItensVendaPorClienteEntreDatasTableAdapter = new CarangaShop.CarangaShopDataSetTableAdapters.ItensVendaPorClienteEntreDatasTableAdapter();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ItensVendaEntreDatasTableAdapter = new CarangaShop.CarangaShopDataSetTableAdapters.ItensVendaEntreDatasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ItensVendaPorClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarangaShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItensVendaPorClienteEntreDatasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItensVendaEntreDatasBindingSource)).BeginInit();
            this.gbRelatorio2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaClienteBindingSource)).BeginInit();
            this.gbRelatorio3.SuspendLayout();
            this.gbRelatorio1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaClienteTabelaVendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ItensVendaPorClienteBindingSource
            // 
            this.ItensVendaPorClienteBindingSource.DataMember = "ItensVendaPorCliente";
            this.ItensVendaPorClienteBindingSource.DataSource = this.CarangaShopDataSet;
            // 
            // CarangaShopDataSet
            // 
            this.CarangaShopDataSet.DataSetName = "CarangaShopDataSet";
            this.CarangaShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ItensVendaPorClienteEntreDatasBindingSource
            // 
            this.ItensVendaPorClienteEntreDatasBindingSource.DataMember = "ItensVendaPorClienteEntreDatas";
            this.ItensVendaPorClienteEntreDatasBindingSource.DataSource = this.CarangaShopDataSet;
            // 
            // ItensVendaEntreDatasBindingSource
            // 
            this.ItensVendaEntreDatasBindingSource.DataMember = "ItensVendaEntreDatas";
            this.ItensVendaEntreDatasBindingSource.DataSource = this.CarangaShopDataSet;
            // 
            // bRelatorio1
            // 
            this.bRelatorio1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRelatorio1.Location = new System.Drawing.Point(76, 27);
            this.bRelatorio1.Name = "bRelatorio1";
            this.bRelatorio1.Size = new System.Drawing.Size(106, 45);
            this.bRelatorio1.TabIndex = 3;
            this.bRelatorio1.Text = "Relatório 1";
            this.bRelatorio1.UseVisualStyleBackColor = true;
            this.bRelatorio1.Click += new System.EventHandler(this.bRelatorio1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Todos os veículos comprados";
            // 
            // bRelatorio2
            // 
            this.bRelatorio2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRelatorio2.Location = new System.Drawing.Point(373, 27);
            this.bRelatorio2.Name = "bRelatorio2";
            this.bRelatorio2.Size = new System.Drawing.Size(106, 45);
            this.bRelatorio2.TabIndex = 5;
            this.bRelatorio2.Text = "Relatório 2";
            this.bRelatorio2.UseVisualStyleBackColor = true;
            this.bRelatorio2.Click += new System.EventHandler(this.bRelatorio2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(689, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Todas as Vendas em um";
            // 
            // bRelatorio3
            // 
            this.bRelatorio3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRelatorio3.Location = new System.Drawing.Point(715, 27);
            this.bRelatorio3.Name = "bRelatorio3";
            this.bRelatorio3.Size = new System.Drawing.Size(106, 45);
            this.bRelatorio3.TabIndex = 8;
            this.bRelatorio3.Text = "Relatório 3";
            this.bRelatorio3.UseVisualStyleBackColor = true;
            this.bRelatorio3.Click += new System.EventHandler(this.bRelatorio3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(712, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "intervalo de datas:";
            // 
            // bGerarRelatorio2
            // 
            this.bGerarRelatorio2.Location = new System.Drawing.Point(88, 79);
            this.bGerarRelatorio2.Name = "bGerarRelatorio2";
            this.bGerarRelatorio2.Size = new System.Drawing.Size(137, 23);
            this.bGerarRelatorio2.TabIndex = 12;
            this.bGerarRelatorio2.Text = "Gerar";
            this.bGerarRelatorio2.UseVisualStyleBackColor = true;
            this.bGerarRelatorio2.Click += new System.EventHandler(this.bGerarRelatorio2_Click);
            // 
            // gbRelatorio2
            // 
            this.gbRelatorio2.Controls.Add(this.dtpFinalRel2);
            this.gbRelatorio2.Controls.Add(this.dtpInicioRel2);
            this.gbRelatorio2.Controls.Add(this.cbClienteRel2);
            this.gbRelatorio2.Controls.Add(this.bGerarRelatorio2);
            this.gbRelatorio2.Location = new System.Drawing.Point(273, 120);
            this.gbRelatorio2.Name = "gbRelatorio2";
            this.gbRelatorio2.Size = new System.Drawing.Size(305, 108);
            this.gbRelatorio2.TabIndex = 13;
            this.gbRelatorio2.TabStop = false;
            this.gbRelatorio2.Text = "Relatório por Nome";
            this.gbRelatorio2.Visible = false;
            // 
            // dtpFinalRel2
            // 
            this.dtpFinalRel2.Location = new System.Drawing.Point(156, 48);
            this.dtpFinalRel2.Name = "dtpFinalRel2";
            this.dtpFinalRel2.Size = new System.Drawing.Size(140, 20);
            this.dtpFinalRel2.TabIndex = 17;
            // 
            // dtpInicioRel2
            // 
            this.dtpInicioRel2.Location = new System.Drawing.Point(12, 48);
            this.dtpInicioRel2.Name = "dtpInicioRel2";
            this.dtpInicioRel2.Size = new System.Drawing.Size(140, 20);
            this.dtpInicioRel2.TabIndex = 16;
            // 
            // cbClienteRel2
            // 
            this.cbClienteRel2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabelaClienteBindingSource, "IDCli", true));
            this.cbClienteRel2.DataSource = this.tabelaClienteBindingSource;
            this.cbClienteRel2.DisplayMember = "NomeCli";
            this.cbClienteRel2.FormattingEnabled = true;
            this.cbClienteRel2.Location = new System.Drawing.Point(12, 21);
            this.cbClienteRel2.Name = "cbClienteRel2";
            this.cbClienteRel2.Size = new System.Drawing.Size(284, 21);
            this.cbClienteRel2.TabIndex = 15;
            this.cbClienteRel2.ValueMember = "IDCli";
            // 
            // tabelaClienteBindingSource
            // 
            this.tabelaClienteBindingSource.DataMember = "TabelaCliente";
            this.tabelaClienteBindingSource.DataSource = this.CarangaShopDataSet;
            // 
            // gbRelatorio3
            // 
            this.gbRelatorio3.Controls.Add(this.dtpFinalRel3);
            this.gbRelatorio3.Controls.Add(this.dtpInicioRel3);
            this.gbRelatorio3.Controls.Add(this.bGerarRelatorio3);
            this.gbRelatorio3.Location = new System.Drawing.Point(620, 120);
            this.gbRelatorio3.Name = "gbRelatorio3";
            this.gbRelatorio3.Size = new System.Drawing.Size(305, 108);
            this.gbRelatorio3.TabIndex = 15;
            this.gbRelatorio3.TabStop = false;
            this.gbRelatorio3.Text = "Relatório por Data";
            this.gbRelatorio3.Visible = false;
            // 
            // dtpFinalRel3
            // 
            this.dtpFinalRel3.Location = new System.Drawing.Point(17, 45);
            this.dtpFinalRel3.Name = "dtpFinalRel3";
            this.dtpFinalRel3.Size = new System.Drawing.Size(252, 20);
            this.dtpFinalRel3.TabIndex = 15;
            // 
            // dtpInicioRel3
            // 
            this.dtpInicioRel3.Location = new System.Drawing.Point(17, 20);
            this.dtpInicioRel3.Name = "dtpInicioRel3";
            this.dtpInicioRel3.Size = new System.Drawing.Size(252, 20);
            this.dtpInicioRel3.TabIndex = 14;
            // 
            // bGerarRelatorio3
            // 
            this.bGerarRelatorio3.Location = new System.Drawing.Point(83, 79);
            this.bGerarRelatorio3.Name = "bGerarRelatorio3";
            this.bGerarRelatorio3.Size = new System.Drawing.Size(137, 23);
            this.bGerarRelatorio3.TabIndex = 13;
            this.bGerarRelatorio3.Text = "Gerar";
            this.bGerarRelatorio3.UseVisualStyleBackColor = true;
            this.bGerarRelatorio3.Click += new System.EventHandler(this.bGerarRelatorio3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(314, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Todos os veículos comprados pelo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(312, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "cliente, em um intervalo de datas:";
            // 
            // gbRelatorio1
            // 
            this.gbRelatorio1.Controls.Add(this.label2);
            this.gbRelatorio1.Controls.Add(this.cbClienteRel1);
            this.gbRelatorio1.Controls.Add(this.bGerarRelatorio1);
            this.gbRelatorio1.Location = new System.Drawing.Point(35, 120);
            this.gbRelatorio1.Name = "gbRelatorio1";
            this.gbRelatorio1.Size = new System.Drawing.Size(199, 108);
            this.gbRelatorio1.TabIndex = 20;
            this.gbRelatorio1.TabStop = false;
            this.gbRelatorio1.Text = "Relatório por Cliente";
            this.gbRelatorio1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome do Cliente:";
            // 
            // cbClienteRel1
            // 
            this.cbClienteRel1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabelaClienteBindingSource, "IDCli", true));
            this.cbClienteRel1.DataSource = this.tabelaClienteBindingSource;
            this.cbClienteRel1.DisplayMember = "NomeCli";
            this.cbClienteRel1.FormattingEnabled = true;
            this.cbClienteRel1.Location = new System.Drawing.Point(6, 48);
            this.cbClienteRel1.Name = "cbClienteRel1";
            this.cbClienteRel1.Size = new System.Drawing.Size(186, 21);
            this.cbClienteRel1.TabIndex = 14;
            this.cbClienteRel1.ValueMember = "IDCli";
            // 
            // bGerarRelatorio1
            // 
            this.bGerarRelatorio1.Location = new System.Drawing.Point(51, 79);
            this.bGerarRelatorio1.Name = "bGerarRelatorio1";
            this.bGerarRelatorio1.Size = new System.Drawing.Size(75, 23);
            this.bGerarRelatorio1.TabIndex = 13;
            this.bGerarRelatorio1.Text = "Gerar";
            this.bGerarRelatorio1.UseVisualStyleBackColor = true;
            this.bGerarRelatorio1.Click += new System.EventHandler(this.bGerarRelatorio1_Click);
            // 
            // tabelaClienteTableAdapter
            // 
            this.tabelaClienteTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "por determinado cliente:";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ItensVendaPorClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CarangaShop.RVenda1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(35, 247);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(890, 246);
            this.reportViewer1.TabIndex = 22;
            this.reportViewer1.Visible = false;
            // 
            // ItensVendaPorClienteTableAdapter
            // 
            this.ItensVendaPorClienteTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ItensVendaPorClienteEntreDatasBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "CarangaShop.RVenda2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(35, 269);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(890, 246);
            this.reportViewer2.TabIndex = 23;
            this.reportViewer2.Visible = false;
            // 
            // ItensVendaPorClienteEntreDatasTableAdapter
            // 
            this.ItensVendaPorClienteEntreDatasTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.ItensVendaEntreDatasBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "CarangaShop.RVenda3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(35, 290);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(890, 246);
            this.reportViewer3.TabIndex = 24;
            this.reportViewer3.Visible = false;
            // 
            // ItensVendaEntreDatasTableAdapter
            // 
            this.ItensVendaEntreDatasTableAdapter.ClearBeforeFill = true;
            // 
            // FormRelatoriosVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 563);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbRelatorio1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbRelatorio3);
            this.Controls.Add(this.gbRelatorio2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bRelatorio3);
            this.Controls.Add(this.bRelatorio2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bRelatorio1);
            this.Name = "FormRelatoriosVenda";
            this.Text = "Relatórios de Cliente";
            this.Load += new System.EventHandler(this.FormRelatoriosCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItensVendaPorClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarangaShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItensVendaPorClienteEntreDatasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItensVendaEntreDatasBindingSource)).EndInit();
            this.gbRelatorio2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaClienteBindingSource)).EndInit();
            this.gbRelatorio3.ResumeLayout(false);
            this.gbRelatorio1.ResumeLayout(false);
            this.gbRelatorio1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaClienteTabelaVendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRelatorio1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bRelatorio2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bRelatorio3;
        private System.Windows.Forms.Label label5;
        private CarangaShopDataSet CarangaShopDataSet;
        private System.Windows.Forms.Button bGerarRelatorio2;
        private System.Windows.Forms.GroupBox gbRelatorio2;
        private System.Windows.Forms.GroupBox gbRelatorio3;
        private System.Windows.Forms.DateTimePicker dtpInicioRel3;
        private System.Windows.Forms.Button bGerarRelatorio3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbRelatorio1;
        private System.Windows.Forms.ComboBox cbClienteRel1;
        private System.Windows.Forms.Button bGerarRelatorio1;
        private System.Windows.Forms.BindingSource tabelaClienteTabelaVendaBindingSource;
        private System.Windows.Forms.BindingSource tabelaClienteBindingSource;
        private CarangaShopDataSetTableAdapters.TabelaClienteTableAdapter tabelaClienteTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpFinalRel2;
        private System.Windows.Forms.DateTimePicker dtpInicioRel2;
        private System.Windows.Forms.ComboBox cbClienteRel2;
        private System.Windows.Forms.DateTimePicker dtpFinalRel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ItensVendaPorClienteBindingSource;
        private CarangaShopDataSetTableAdapters.ItensVendaPorClienteTableAdapter ItensVendaPorClienteTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource ItensVendaPorClienteEntreDatasBindingSource;
        private CarangaShopDataSetTableAdapters.ItensVendaPorClienteEntreDatasTableAdapter ItensVendaPorClienteEntreDatasTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource ItensVendaEntreDatasBindingSource;
        private CarangaShopDataSetTableAdapters.ItensVendaEntreDatasTableAdapter ItensVendaEntreDatasTableAdapter;
    }
}