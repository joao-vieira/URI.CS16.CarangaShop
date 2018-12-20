namespace CarangaShop {
    partial class FormRelatoriosFuncionario {
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bRelatorio1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bRelatorio2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bRelatorio3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bRelatorio4 = new System.Windows.Forms.Button();
            this.gbRelatorioPorNome = new System.Windows.Forms.GroupBox();
            this.tbNomeRelatorio2 = new System.Windows.Forms.TextBox();
            this.bGerarRelatorio2 = new System.Windows.Forms.Button();
            this.gbRelatorioPorData = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bGerarRelatorio3 = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbRelatorioPorSalario = new System.Windows.Forms.GroupBox();
            this.bGerarRelatorio4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TabelaFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CarangaShopDataSet = new CarangaShop.CarangaShopDataSet();
            this.TabelaFuncionarioTableAdapter = new CarangaShop.CarangaShopDataSetTableAdapters.TabelaFuncionarioTableAdapter();
            this.gbRelatorioPorNome.SuspendLayout();
            this.gbRelatorioPorData.SuspendLayout();
            this.gbRelatorioPorSalario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarangaShopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bRelatorio1
            // 
            this.bRelatorio1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRelatorio1.Location = new System.Drawing.Point(56, 27);
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
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Todos os funcionários cadastrados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Relatório de Funcionários por Nome";
            // 
            // bRelatorio2
            // 
            this.bRelatorio2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRelatorio2.Location = new System.Drawing.Point(315, 27);
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
            this.label3.Location = new System.Drawing.Point(263, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = " (incluindo apenas algumas letras do nome)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(529, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Relatório de Funcionários por ";
            // 
            // bRelatorio3
            // 
            this.bRelatorio3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRelatorio3.Location = new System.Drawing.Point(568, 27);
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
            this.label5.Location = new System.Drawing.Point(551, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de Nascimento";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TabelaFuncionarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CarangaShop.RFuncionarios1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(35, 209);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(938, 246);
            this.reportViewer1.TabIndex = 11;
            this.reportViewer1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(783, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Intervalo de Salário";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(761, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Relatório de Funcionários por ";
            // 
            // bRelatorio4
            // 
            this.bRelatorio4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRelatorio4.Location = new System.Drawing.Point(800, 27);
            this.bRelatorio4.Name = "bRelatorio4";
            this.bRelatorio4.Size = new System.Drawing.Size(106, 45);
            this.bRelatorio4.TabIndex = 12;
            this.bRelatorio4.Text = "Relatório 4";
            this.bRelatorio4.UseVisualStyleBackColor = true;
            this.bRelatorio4.Click += new System.EventHandler(this.bRelatorio4_Click);
            // 
            // gbRelatorioPorNome
            // 
            this.gbRelatorioPorNome.Controls.Add(this.tbNomeRelatorio2);
            this.gbRelatorioPorNome.Controls.Add(this.bGerarRelatorio2);
            this.gbRelatorioPorNome.Location = new System.Drawing.Point(273, 111);
            this.gbRelatorioPorNome.Name = "gbRelatorioPorNome";
            this.gbRelatorioPorNome.Size = new System.Drawing.Size(200, 81);
            this.gbRelatorioPorNome.TabIndex = 15;
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
            // gbRelatorioPorData
            // 
            this.gbRelatorioPorData.Controls.Add(this.dateTimePicker1);
            this.gbRelatorioPorData.Controls.Add(this.bGerarRelatorio3);
            this.gbRelatorioPorData.Location = new System.Drawing.Point(510, 114);
            this.gbRelatorioPorData.Name = "gbRelatorioPorData";
            this.gbRelatorioPorData.Size = new System.Drawing.Size(223, 81);
            this.gbRelatorioPorData.TabIndex = 16;
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
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.TabelaFuncionarioBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "CarangaShop.RFuncionarios1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(35, 224);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(938, 246);
            this.reportViewer2.TabIndex = 17;
            this.reportViewer2.Visible = false;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.TabelaFuncionarioBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "CarangaShop.RFuncionarios1.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(35, 235);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(938, 246);
            this.reportViewer3.TabIndex = 18;
            this.reportViewer3.Visible = false;
            // 
            // gbRelatorioPorSalario
            // 
            this.gbRelatorioPorSalario.Controls.Add(this.textBox1);
            this.gbRelatorioPorSalario.Controls.Add(this.comboBox1);
            this.gbRelatorioPorSalario.Controls.Add(this.bGerarRelatorio4);
            this.gbRelatorioPorSalario.Location = new System.Drawing.Point(760, 114);
            this.gbRelatorioPorSalario.Name = "gbRelatorioPorSalario";
            this.gbRelatorioPorSalario.Size = new System.Drawing.Size(223, 81);
            this.gbRelatorioPorSalario.TabIndex = 19;
            this.gbRelatorioPorSalario.TabStop = false;
            this.gbRelatorioPorSalario.Text = "Relatório por Salário";
            this.gbRelatorioPorSalario.Visible = false;
            // 
            // bGerarRelatorio4
            // 
            this.bGerarRelatorio4.Location = new System.Drawing.Point(71, 46);
            this.bGerarRelatorio4.Name = "bGerarRelatorio4";
            this.bGerarRelatorio4.Size = new System.Drawing.Size(75, 23);
            this.bGerarRelatorio4.TabIndex = 13;
            this.bGerarRelatorio4.Text = "Gerar";
            this.bGerarRelatorio4.UseVisualStyleBackColor = true;
            this.bGerarRelatorio4.Click += new System.EventHandler(this.bGerarRelatorio4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Maior que",
            "Menor que"});
            this.comboBox1.Location = new System.Drawing.Point(113, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // reportViewer4
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.TabelaFuncionarioBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "CarangaShop.RFuncionarios1.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(35, 257);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(938, 246);
            this.reportViewer4.TabIndex = 20;
            this.reportViewer4.Visible = false;
            this.reportViewer4.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.reportViewer4_ReportRefresh);
            // 
            // TabelaFuncionarioBindingSource
            // 
            this.TabelaFuncionarioBindingSource.DataMember = "TabelaFuncionario";
            this.TabelaFuncionarioBindingSource.DataSource = this.CarangaShopDataSet;
            // 
            // CarangaShopDataSet
            // 
            this.CarangaShopDataSet.DataSetName = "CarangaShopDataSet";
            this.CarangaShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TabelaFuncionarioTableAdapter
            // 
            this.TabelaFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // FormRelatoriosFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 515);
            this.Controls.Add(this.reportViewer4);
            this.Controls.Add(this.gbRelatorioPorSalario);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.gbRelatorioPorData);
            this.Controls.Add(this.gbRelatorioPorNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bRelatorio4);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bRelatorio3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bRelatorio2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bRelatorio1);
            this.Name = "FormRelatoriosFuncionario";
            this.Text = "Relatórios de Funcionário";
            this.Load += new System.EventHandler(this.FormRelatoriosFuncionario_Load);
            this.gbRelatorioPorNome.ResumeLayout(false);
            this.gbRelatorioPorNome.PerformLayout();
            this.gbRelatorioPorData.ResumeLayout(false);
            this.gbRelatorioPorSalario.ResumeLayout(false);
            this.gbRelatorioPorSalario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarangaShopDataSet)).EndInit();
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
        private CarangaShopDataSet CarangaShopDataSet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bRelatorio4;
        private System.Windows.Forms.BindingSource TabelaFuncionarioBindingSource;
        private CarangaShopDataSetTableAdapters.TabelaFuncionarioTableAdapter TabelaFuncionarioTableAdapter;
        private System.Windows.Forms.GroupBox gbRelatorioPorNome;
        private System.Windows.Forms.TextBox tbNomeRelatorio2;
        private System.Windows.Forms.Button bGerarRelatorio2;
        private System.Windows.Forms.GroupBox gbRelatorioPorData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bGerarRelatorio3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.GroupBox gbRelatorioPorSalario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bGerarRelatorio4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
    }
}