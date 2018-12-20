namespace CarangaShop {
    partial class FormRelatoriosEstoque {
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
            this.EstoquePorCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CarangaShopDataSet = new CarangaShop.CarangaShopDataSet();
            this.TabelaVeiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bRelatorio1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bRelatorio2 = new System.Windows.Forms.Button();
            this.TabelaVeiculoTableAdapter = new CarangaShop.CarangaShopDataSetTableAdapters.TabelaVeiculoTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategoriaRel1 = new System.Windows.Forms.ComboBox();
            this.tabelaCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbRelatorio1 = new System.Windows.Forms.GroupBox();
            this.bGerarRelatorio1 = new System.Windows.Forms.Button();
            this.gbRelatorio2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabelaModeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bGerarRelatorio2 = new System.Windows.Forms.Button();
            this.tabelaCategoriaTableAdapter = new CarangaShop.CarangaShopDataSetTableAdapters.TabelaCategoriaTableAdapter();
            this.tabelaModeloTableAdapter = new CarangaShop.CarangaShopDataSetTableAdapters.TabelaModeloTableAdapter();
            this.TabelaClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabelaClienteTableAdapter = new CarangaShop.CarangaShopDataSetTableAdapters.TabelaClienteTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.estoquePorCategoriaTableAdapter1 = new CarangaShop.CarangaShopDataSetTableAdapters.EstoquePorCategoriaTableAdapter();
            this.EstoquePorCategoriaTableAdapter = new CarangaShop.CarangaShopDataSetTableAdapters.EstoquePorCategoriaTableAdapter();
            this.tabelaEstoqueTableAdapter1 = new CarangaShop.CarangaShopDataSetTableAdapters.TabelaEstoqueTableAdapter();
            this.TabelaEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabelaEstoqueTableAdapter = new CarangaShop.CarangaShopDataSetTableAdapters.TabelaEstoqueTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.EstoquePorCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarangaShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaVeiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCategoriaBindingSource)).BeginInit();
            this.gbRelatorio1.SuspendLayout();
            this.gbRelatorio2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaModeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaEstoqueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EstoquePorCategoriaBindingSource
            // 
            this.EstoquePorCategoriaBindingSource.DataMember = "EstoquePorCategoria";
            this.EstoquePorCategoriaBindingSource.DataSource = this.CarangaShopDataSet;
            // 
            // CarangaShopDataSet
            // 
            this.CarangaShopDataSet.DataSetName = "CarangaShopDataSet";
            this.CarangaShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TabelaVeiculoBindingSource
            // 
            this.TabelaVeiculoBindingSource.DataMember = "TabelaVeiculo";
            this.TabelaVeiculoBindingSource.DataSource = this.CarangaShopDataSet;
            // 
            // bRelatorio1
            // 
            this.bRelatorio1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRelatorio1.Location = new System.Drawing.Point(126, 28);
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
            this.label1.Location = new System.Drawing.Point(87, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantidade de veículos de";
            // 
            // bRelatorio2
            // 
            this.bRelatorio2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRelatorio2.Location = new System.Drawing.Point(433, 28);
            this.bRelatorio2.Name = "bRelatorio2";
            this.bRelatorio2.Size = new System.Drawing.Size(106, 45);
            this.bRelatorio2.TabIndex = 5;
            this.bRelatorio2.Text = "Relatório 2";
            this.bRelatorio2.UseVisualStyleBackColor = true;
            this.bRelatorio2.Click += new System.EventHandler(this.bRelatorio2_Click);
            // 
            // TabelaVeiculoTableAdapter
            // 
            this.TabelaVeiculoTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "uma categoria no estoque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Quantidade de um produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = " específico";
            // 
            // cbCategoriaRel1
            // 
            this.cbCategoriaRel1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabelaCategoriaBindingSource, "IDCat", true));
            this.cbCategoriaRel1.DataSource = this.tabelaCategoriaBindingSource;
            this.cbCategoriaRel1.DisplayMember = "DescCat";
            this.cbCategoriaRel1.FormattingEnabled = true;
            this.cbCategoriaRel1.Location = new System.Drawing.Point(6, 29);
            this.cbCategoriaRel1.Name = "cbCategoriaRel1";
            this.cbCategoriaRel1.Size = new System.Drawing.Size(188, 21);
            this.cbCategoriaRel1.TabIndex = 15;
            this.cbCategoriaRel1.ValueMember = "IDCat";
            // 
            // tabelaCategoriaBindingSource
            // 
            this.tabelaCategoriaBindingSource.DataMember = "TabelaCategoria";
            this.tabelaCategoriaBindingSource.DataSource = this.CarangaShopDataSet;
            // 
            // gbRelatorio1
            // 
            this.gbRelatorio1.Controls.Add(this.bGerarRelatorio1);
            this.gbRelatorio1.Controls.Add(this.cbCategoriaRel1);
            this.gbRelatorio1.Location = new System.Drawing.Point(70, 131);
            this.gbRelatorio1.Name = "gbRelatorio1";
            this.gbRelatorio1.Size = new System.Drawing.Size(200, 94);
            this.gbRelatorio1.TabIndex = 16;
            this.gbRelatorio1.TabStop = false;
            this.gbRelatorio1.Text = "Relatório por Categoria";
            this.gbRelatorio1.Visible = false;
            // 
            // bGerarRelatorio1
            // 
            this.bGerarRelatorio1.Location = new System.Drawing.Point(56, 59);
            this.bGerarRelatorio1.Name = "bGerarRelatorio1";
            this.bGerarRelatorio1.Size = new System.Drawing.Size(75, 23);
            this.bGerarRelatorio1.TabIndex = 16;
            this.bGerarRelatorio1.Text = "Gerar";
            this.bGerarRelatorio1.UseVisualStyleBackColor = true;
            this.bGerarRelatorio1.Click += new System.EventHandler(this.bGerarRelatorio1_Click);
            // 
            // gbRelatorio2
            // 
            this.gbRelatorio2.Controls.Add(this.comboBox2);
            this.gbRelatorio2.Controls.Add(this.comboBox1);
            this.gbRelatorio2.Controls.Add(this.bGerarRelatorio2);
            this.gbRelatorio2.Location = new System.Drawing.Point(365, 131);
            this.gbRelatorio2.Name = "gbRelatorio2";
            this.gbRelatorio2.Size = new System.Drawing.Size(258, 94);
            this.gbRelatorio2.TabIndex = 17;
            this.gbRelatorio2.TabStop = false;
            this.gbRelatorio2.Text = "Relatório por Veículo";
            this.gbRelatorio2.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(133, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabelaModeloBindingSource, "IDMod", true));
            this.comboBox1.DataSource = this.tabelaModeloBindingSource;
            this.comboBox1.DisplayMember = "NomeMod";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "IDMod";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabelaModeloBindingSource
            // 
            this.tabelaModeloBindingSource.DataMember = "TabelaModelo";
            this.tabelaModeloBindingSource.DataSource = this.CarangaShopDataSet;
            // 
            // bGerarRelatorio2
            // 
            this.bGerarRelatorio2.Location = new System.Drawing.Point(68, 59);
            this.bGerarRelatorio2.Name = "bGerarRelatorio2";
            this.bGerarRelatorio2.Size = new System.Drawing.Size(132, 23);
            this.bGerarRelatorio2.TabIndex = 17;
            this.bGerarRelatorio2.Text = "Gerar";
            this.bGerarRelatorio2.UseVisualStyleBackColor = true;
            this.bGerarRelatorio2.Click += new System.EventHandler(this.bGerarRelatorio2_Click);
            // 
            // tabelaCategoriaTableAdapter
            // 
            this.tabelaCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // tabelaModeloTableAdapter
            // 
            this.tabelaModeloTableAdapter.ClearBeforeFill = true;
            // 
            // TabelaClienteBindingSource
            // 
            this.TabelaClienteBindingSource.DataMember = "TabelaCliente";
            this.TabelaClienteBindingSource.DataSource = this.CarangaShopDataSet;
            // 
            // TabelaClienteTableAdapter
            // 
            this.TabelaClienteTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EstoquePorCategoriaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CarangaShop.REstoque1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(33, 241);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(279, 121);
            this.reportViewer1.TabIndex = 18;
            this.reportViewer1.Visible = false;
            // 
            // estoquePorCategoriaTableAdapter1
            // 
            this.estoquePorCategoriaTableAdapter1.ClearBeforeFill = true;
            // 
            // EstoquePorCategoriaTableAdapter
            // 
            this.EstoquePorCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // tabelaEstoqueTableAdapter1
            // 
            this.tabelaEstoqueTableAdapter1.ClearBeforeFill = true;
            // 
            // TabelaEstoqueBindingSource
            // 
            this.TabelaEstoqueBindingSource.DataMember = "TabelaEstoque";
            this.TabelaEstoqueBindingSource.DataSource = this.CarangaShopDataSet;
            // 
            // TabelaEstoqueTableAdapter
            // 
            this.TabelaEstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.TabelaEstoqueBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "CarangaShop.REstoque2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(348, 241);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(288, 121);
            this.reportViewer2.TabIndex = 19;
            this.reportViewer2.Visible = false;
            // 
            // FormRelatoriosEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 386);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.gbRelatorio2);
            this.Controls.Add(this.gbRelatorio1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bRelatorio2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bRelatorio1);
            this.Name = "FormRelatoriosEstoque";
            this.Text = "Relatórios de Estoque";
            this.Load += new System.EventHandler(this.FormRelatoriosEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EstoquePorCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarangaShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaVeiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCategoriaBindingSource)).EndInit();
            this.gbRelatorio1.ResumeLayout(false);
            this.gbRelatorio2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaModeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaEstoqueBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRelatorio1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bRelatorio2;
        private CarangaShopDataSet CarangaShopDataSet;
        private System.Windows.Forms.BindingSource TabelaVeiculoBindingSource;
        private CarangaShopDataSetTableAdapters.TabelaVeiculoTableAdapter TabelaVeiculoTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCategoriaRel1;
        private System.Windows.Forms.GroupBox gbRelatorio1;
        private System.Windows.Forms.GroupBox gbRelatorio2;
        private System.Windows.Forms.BindingSource tabelaCategoriaBindingSource;
        private CarangaShopDataSetTableAdapters.TabelaCategoriaTableAdapter tabelaCategoriaTableAdapter;
        private System.Windows.Forms.Button bGerarRelatorio1;
        private System.Windows.Forms.Button bGerarRelatorio2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tabelaModeloBindingSource;
        private CarangaShopDataSetTableAdapters.TabelaModeloTableAdapter tabelaModeloTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource TabelaClienteBindingSource;
        private CarangaShopDataSetTableAdapters.TabelaClienteTableAdapter TabelaClienteTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CarangaShopDataSetTableAdapters.EstoquePorCategoriaTableAdapter estoquePorCategoriaTableAdapter1;
        private System.Windows.Forms.BindingSource EstoquePorCategoriaBindingSource;
        private CarangaShopDataSetTableAdapters.EstoquePorCategoriaTableAdapter EstoquePorCategoriaTableAdapter;
        private CarangaShopDataSetTableAdapters.TabelaEstoqueTableAdapter tabelaEstoqueTableAdapter1;
        private System.Windows.Forms.BindingSource TabelaEstoqueBindingSource;
        private CarangaShopDataSetTableAdapters.TabelaEstoqueTableAdapter TabelaEstoqueTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}