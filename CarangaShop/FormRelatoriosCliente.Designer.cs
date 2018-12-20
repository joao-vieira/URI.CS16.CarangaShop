namespace CarangaShop {
    partial class FormRelatoriosCliente {
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
            this.TabelaClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CarangaShopDataSet = new CarangaShop.CarangaShopDataSet();
            this.bRelatorio1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bRelatorio2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bRelatorio3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bGerarRelatorio2 = new System.Windows.Forms.Button();
            this.gbRelatorioPorNome = new System.Windows.Forms.GroupBox();
            this.tbNomeRelatorio2 = new System.Windows.Forms.TextBox();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbRelatorioPorData = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bGerarRelatorio3 = new System.Windows.Forms.Button();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TabelaClienteTableAdapter = new CarangaShop.CarangaShopDataSetTableAdapters.TabelaClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarangaShopDataSet)).BeginInit();
            this.gbRelatorioPorNome.SuspendLayout();
            this.gbRelatorioPorData.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabelaClienteBindingSource
            // 
            this.TabelaClienteBindingSource.DataMember = "TabelaCliente";
            this.TabelaClienteBindingSource.DataSource = this.CarangaShopDataSet;
            // 
            // CarangaShopDataSet
            // 
            this.CarangaShopDataSet.DataSetName = "CarangaShopDataSet";
            this.CarangaShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label1.Size = new System.Drawing.Size(210, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Todos os clientes cadastrados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Relatório de Clientes por Nome";
            // 
            // bRelatorio2
            // 
            this.bRelatorio2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRelatorio2.Location = new System.Drawing.Point(312, 27);
            this.bRelatorio2.Name = "bRelatorio2";
            this.bRelatorio2.Size = new System.Drawing.Size(106, 45);
            this.bRelatorio2.TabIndex = 5;
            this.bRelatorio2.Text = "Relatório 2";
            this.bRelatorio2.UseVisualStyleBackColor = true;
            this.bRelatorio2.Click += new System.EventHandler(this.bRelatorio2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = " (incluindo apenas algumas letras do nome)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(515, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Relatório de Clientes por ";
            // 
            // bRelatorio3
            // 
            this.bRelatorio3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRelatorio3.Location = new System.Drawing.Point(554, 27);
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
            this.label5.Location = new System.Drawing.Point(537, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de Nascimento";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TabelaClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CarangaShop.RClientes1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(35, 207);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(689, 246);
            this.reportViewer1.TabIndex = 11;
            this.reportViewer1.Visible = false;
            this.reportViewer1.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.reportViewer1_ReportRefresh);
            // 
            // bGerarRelatorio2
            // 
            this.bGerarRelatorio2.Location = new System.Drawing.Point(59, 46);
            this.bGerarRelatorio2.Name = "bGerarRelatorio2";
            this.bGerarRelatorio2.Size = new System.Drawing.Size(75, 23);
            this.bGerarRelatorio2.TabIndex = 12;
            this.bGerarRelatorio2.Text = "Gerar";
            this.bGerarRelatorio2.UseVisualStyleBackColor = true;
            this.bGerarRelatorio2.Click += new System.EventHandler(this.bGerarRelatorio2_Click);
            // 
            // gbRelatorioPorNome
            // 
            this.gbRelatorioPorNome.Controls.Add(this.tbNomeRelatorio2);
            this.gbRelatorioPorNome.Controls.Add(this.bGerarRelatorio2);
            this.gbRelatorioPorNome.Location = new System.Drawing.Point(263, 120);
            this.gbRelatorioPorNome.Name = "gbRelatorioPorNome";
            this.gbRelatorioPorNome.Size = new System.Drawing.Size(200, 81);
            this.gbRelatorioPorNome.TabIndex = 13;
            this.gbRelatorioPorNome.TabStop = false;
            this.gbRelatorioPorNome.Text = "Relatório por Nome";
            this.gbRelatorioPorNome.Visible = false;
            // 
            // tbNomeRelatorio2
            // 
            this.tbNomeRelatorio2.Location = new System.Drawing.Point(7, 20);
            this.tbNomeRelatorio2.Name = "tbNomeRelatorio2";
            this.tbNomeRelatorio2.Size = new System.Drawing.Size(187, 20);
            this.tbNomeRelatorio2.TabIndex = 13;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.TabelaClienteBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "CarangaShop.RClientes1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(35, 216);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(689, 246);
            this.reportViewer2.TabIndex = 14;
            this.reportViewer2.Visible = false;
            this.reportViewer2.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.reportViewer2_ReportRefresh);
            // 
            // gbRelatorioPorData
            // 
            this.gbRelatorioPorData.Controls.Add(this.dateTimePicker1);
            this.gbRelatorioPorData.Controls.Add(this.bGerarRelatorio3);
            this.gbRelatorioPorData.Location = new System.Drawing.Point(501, 120);
            this.gbRelatorioPorData.Name = "gbRelatorioPorData";
            this.gbRelatorioPorData.Size = new System.Drawing.Size(223, 81);
            this.gbRelatorioPorData.TabIndex = 15;
            this.gbRelatorioPorData.TabStop = false;
            this.gbRelatorioPorData.Text = "Relatório por Data";
            this.gbRelatorioPorData.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // bGerarRelatorio3
            // 
            this.bGerarRelatorio3.Location = new System.Drawing.Point(71, 46);
            this.bGerarRelatorio3.Name = "bGerarRelatorio3";
            this.bGerarRelatorio3.Size = new System.Drawing.Size(75, 23);
            this.bGerarRelatorio3.TabIndex = 13;
            this.bGerarRelatorio3.Text = "Gerar";
            this.bGerarRelatorio3.UseVisualStyleBackColor = true;
            this.bGerarRelatorio3.Click += new System.EventHandler(this.bGerarRelatorio3_Click);
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.TabelaClienteBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "CarangaShop.RClientes3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(35, 226);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(689, 246);
            this.reportViewer3.TabIndex = 16;
            this.reportViewer3.Visible = false;
            this.reportViewer3.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.reportViewer3_ReportRefresh);
            // 
            // TabelaClienteTableAdapter
            // 
            this.TabelaClienteTableAdapter.ClearBeforeFill = true;
            // 
            // FormRelatoriosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 482);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.gbRelatorioPorData);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.gbRelatorioPorNome);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bRelatorio3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bRelatorio2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bRelatorio1);
            this.Name = "FormRelatoriosCliente";
            this.Text = "Relatórios de Cliente";
            this.Load += new System.EventHandler(this.FormRelatoriosCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarangaShopDataSet)).EndInit();
            this.gbRelatorioPorNome.ResumeLayout(false);
            this.gbRelatorioPorNome.PerformLayout();
            this.gbRelatorioPorData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRelatorio1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bRelatorio2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bRelatorio3;
        private System.Windows.Forms.Label label5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TabelaClienteBindingSource;
        private CarangaShopDataSet CarangaShopDataSet;
        private CarangaShopDataSetTableAdapters.TabelaClienteTableAdapter TabelaClienteTableAdapter;
        private System.Windows.Forms.Button bGerarRelatorio2;
        private System.Windows.Forms.GroupBox gbRelatorioPorNome;
        private System.Windows.Forms.TextBox tbNomeRelatorio2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.GroupBox gbRelatorioPorData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bGerarRelatorio3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
    }
}