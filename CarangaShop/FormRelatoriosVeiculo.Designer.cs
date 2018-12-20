namespace CarangaShop {
    partial class FormRelatoriosVeiculo {
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TabelaVeiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CarangaShopDataSet = new CarangaShop.CarangaShopDataSet();
            this.bRelatorio1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bRelatorio2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bRelatorio3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TabelaVeiculoTableAdapter = new CarangaShop.CarangaShopDataSetTableAdapters.TabelaVeiculoTableAdapter();
            this.gbRelatorio2 = new System.Windows.Forms.GroupBox();
            this.bGerarRelatorio2 = new System.Windows.Forms.Button();
            this.cbCategoriaRelatorio2 = new System.Windows.Forms.ComboBox();
            this.tabelaCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelaCategoriaTableAdapter = new CarangaShop.CarangaShopDataSetTableAdapters.TabelaCategoriaTableAdapter();
            this.gbRelatorio3 = new System.Windows.Forms.GroupBox();
            this.bGerarRelatorio3 = new System.Windows.Forms.Button();
            this.cbCategoriaRelatorio3 = new System.Windows.Forms.ComboBox();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaVeiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarangaShopDataSet)).BeginInit();
            this.gbRelatorio2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCategoriaBindingSource)).BeginInit();
            this.gbRelatorio3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabelaVeiculoBindingSource
            // 
            this.TabelaVeiculoBindingSource.DataMember = "TabelaVeiculo";
            this.TabelaVeiculoBindingSource.DataSource = this.CarangaShopDataSet;
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
            this.label1.Size = new System.Drawing.Size(212, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Todos os veículos cadastrados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Relatório de Veículos por Categoria";
            // 
            // bRelatorio2
            // 
            this.bRelatorio2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRelatorio2.Location = new System.Drawing.Point(337, 27);
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
            this.label4.Location = new System.Drawing.Point(550, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Relatório de Veículos por ";
            // 
            // bRelatorio3
            // 
            this.bRelatorio3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRelatorio3.Location = new System.Drawing.Point(589, 27);
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
            this.label5.Location = new System.Drawing.Point(539, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Categoria, ordenado por valor";
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.TabelaVeiculoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CarangaShop.RVeiculos1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(35, 242);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(689, 246);
            this.reportViewer1.TabIndex = 11;
            this.reportViewer1.Visible = false;
            this.reportViewer1.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.reportViewer1_ReportRefresh);
            // 
            // TabelaVeiculoTableAdapter
            // 
            this.TabelaVeiculoTableAdapter.ClearBeforeFill = true;
            // 
            // gbRelatorio2
            // 
            this.gbRelatorio2.Controls.Add(this.bGerarRelatorio2);
            this.gbRelatorio2.Controls.Add(this.cbCategoriaRelatorio2);
            this.gbRelatorio2.Location = new System.Drawing.Point(288, 113);
            this.gbRelatorio2.Name = "gbRelatorio2";
            this.gbRelatorio2.Size = new System.Drawing.Size(220, 81);
            this.gbRelatorio2.TabIndex = 12;
            this.gbRelatorio2.TabStop = false;
            this.gbRelatorio2.Text = "Relatório por Categoria";
            this.gbRelatorio2.Visible = false;
            // 
            // bGerarRelatorio2
            // 
            this.bGerarRelatorio2.Location = new System.Drawing.Point(62, 53);
            this.bGerarRelatorio2.Name = "bGerarRelatorio2";
            this.bGerarRelatorio2.Size = new System.Drawing.Size(75, 23);
            this.bGerarRelatorio2.TabIndex = 1;
            this.bGerarRelatorio2.Text = "Gerar";
            this.bGerarRelatorio2.UseVisualStyleBackColor = true;
            this.bGerarRelatorio2.Click += new System.EventHandler(this.bGerarRelatorio2_Click);
            // 
            // cbCategoriaRelatorio2
            // 
            this.cbCategoriaRelatorio2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabelaCategoriaBindingSource, "IDCat", true));
            this.cbCategoriaRelatorio2.DataSource = this.tabelaCategoriaBindingSource;
            this.cbCategoriaRelatorio2.DisplayMember = "DescCat";
            this.cbCategoriaRelatorio2.FormattingEnabled = true;
            this.cbCategoriaRelatorio2.Location = new System.Drawing.Point(6, 20);
            this.cbCategoriaRelatorio2.Name = "cbCategoriaRelatorio2";
            this.cbCategoriaRelatorio2.Size = new System.Drawing.Size(208, 21);
            this.cbCategoriaRelatorio2.TabIndex = 0;
            this.cbCategoriaRelatorio2.ValueMember = "IDCat";
            // 
            // tabelaCategoriaBindingSource
            // 
            this.tabelaCategoriaBindingSource.DataMember = "TabelaCategoria";
            this.tabelaCategoriaBindingSource.DataSource = this.CarangaShopDataSet;
            // 
            // tabelaCategoriaTableAdapter
            // 
            this.tabelaCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // gbRelatorio3
            // 
            this.gbRelatorio3.Controls.Add(this.comboBox1);
            this.gbRelatorio3.Controls.Add(this.bGerarRelatorio3);
            this.gbRelatorio3.Controls.Add(this.cbCategoriaRelatorio3);
            this.gbRelatorio3.Location = new System.Drawing.Point(529, 113);
            this.gbRelatorio3.Name = "gbRelatorio3";
            this.gbRelatorio3.Size = new System.Drawing.Size(233, 81);
            this.gbRelatorio3.TabIndex = 13;
            this.gbRelatorio3.TabStop = false;
            this.gbRelatorio3.Text = "Relatório por Categoria";
            this.gbRelatorio3.Visible = false;
            // 
            // bGerarRelatorio3
            // 
            this.bGerarRelatorio3.Location = new System.Drawing.Point(62, 53);
            this.bGerarRelatorio3.Name = "bGerarRelatorio3";
            this.bGerarRelatorio3.Size = new System.Drawing.Size(75, 23);
            this.bGerarRelatorio3.TabIndex = 1;
            this.bGerarRelatorio3.Text = "Gerar";
            this.bGerarRelatorio3.UseVisualStyleBackColor = true;
            this.bGerarRelatorio3.Click += new System.EventHandler(this.bGerarRelatorio3_Click);
            // 
            // cbCategoriaRelatorio3
            // 
            this.cbCategoriaRelatorio3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabelaCategoriaBindingSource, "IDCat", true));
            this.cbCategoriaRelatorio3.DataSource = this.tabelaCategoriaBindingSource;
            this.cbCategoriaRelatorio3.DisplayMember = "DescCat";
            this.cbCategoriaRelatorio3.FormattingEnabled = true;
            this.cbCategoriaRelatorio3.Location = new System.Drawing.Point(6, 20);
            this.cbCategoriaRelatorio3.Name = "cbCategoriaRelatorio3";
            this.cbCategoriaRelatorio3.Size = new System.Drawing.Size(122, 21);
            this.cbCategoriaRelatorio3.TabIndex = 0;
            this.cbCategoriaRelatorio3.ValueMember = "IDCat";
            // 
            // reportViewer2
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.TabelaVeiculoBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "CarangaShop.RVeiculos2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(37, 255);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(689, 246);
            this.reportViewer2.TabIndex = 14;
            this.reportViewer2.Visible = false;
            this.reportViewer2.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.reportViewer2_ReportRefresh);
            // 
            // reportViewer3
            // 
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.TabelaVeiculoBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "CarangaShop.RVeiculos3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(35, 275);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(689, 246);
            this.reportViewer3.TabIndex = 15;
            this.reportViewer3.Visible = false;
            this.reportViewer3.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.reportViewer3_ReportRefresh);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Crescente",
            "Decrescente"});
            this.comboBox1.Location = new System.Drawing.Point(142, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // FormRelatoriosVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 533);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.gbRelatorio3);
            this.Controls.Add(this.gbRelatorio2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bRelatorio3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bRelatorio2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bRelatorio1);
            this.Name = "FormRelatoriosVeiculo";
            this.Text = "Relatórios de Veículo";
            this.Load += new System.EventHandler(this.FormRelatoriosVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaVeiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarangaShopDataSet)).EndInit();
            this.gbRelatorio2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCategoriaBindingSource)).EndInit();
            this.gbRelatorio3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRelatorio1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bRelatorio2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bRelatorio3;
        private System.Windows.Forms.Label label5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CarangaShopDataSet CarangaShopDataSet;
        private System.Windows.Forms.BindingSource TabelaVeiculoBindingSource;
        private CarangaShopDataSetTableAdapters.TabelaVeiculoTableAdapter TabelaVeiculoTableAdapter;
        private System.Windows.Forms.GroupBox gbRelatorio2;
        private System.Windows.Forms.Button bGerarRelatorio2;
        private System.Windows.Forms.ComboBox cbCategoriaRelatorio2;
        private System.Windows.Forms.BindingSource tabelaCategoriaBindingSource;
        private CarangaShopDataSetTableAdapters.TabelaCategoriaTableAdapter tabelaCategoriaTableAdapter;
        private System.Windows.Forms.GroupBox gbRelatorio3;
        private System.Windows.Forms.Button bGerarRelatorio3;
        private System.Windows.Forms.ComboBox cbCategoriaRelatorio3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}