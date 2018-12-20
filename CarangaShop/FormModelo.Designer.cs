namespace CarangaShop {
    partial class FormModelo {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bIncluirModelo = new System.Windows.Forms.Button();
            this.bSalvarModelo = new System.Windows.Forms.Button();
            this.bExcluirModelo = new System.Windows.Forms.Button();
            this.bCancelarFormModelo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIDMod = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carangaShopDataSet1 = new CarangaShop.CarangaShopDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.tabelaMarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.tabelaMarcaTableAdapter1 = new CarangaShop.CarangaShopDataSetTableAdapters.TabelaMarcaTableAdapter();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.tabelaCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelaCategoriaTableAdapter = new CarangaShop.CarangaShopDataSetTableAdapters.TabelaCategoriaTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbFiltroModelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carangaShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaMarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCategoriaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbDados.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Modelos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // bIncluirModelo
            // 
            this.bIncluirModelo.Location = new System.Drawing.Point(6, 19);
            this.bIncluirModelo.Name = "bIncluirModelo";
            this.bIncluirModelo.Size = new System.Drawing.Size(88, 23);
            this.bIncluirModelo.TabIndex = 2;
            this.bIncluirModelo.Text = "Incluir";
            this.bIncluirModelo.UseVisualStyleBackColor = true;
            this.bIncluirModelo.Click += new System.EventHandler(this.bIncluirModelo_Click);
            // 
            // bSalvarModelo
            // 
            this.bSalvarModelo.Location = new System.Drawing.Point(6, 48);
            this.bSalvarModelo.Name = "bSalvarModelo";
            this.bSalvarModelo.Size = new System.Drawing.Size(88, 23);
            this.bSalvarModelo.TabIndex = 3;
            this.bSalvarModelo.Text = "Salvar";
            this.bSalvarModelo.UseVisualStyleBackColor = true;
            this.bSalvarModelo.Click += new System.EventHandler(this.bSalvarModelo_Click);
            // 
            // bExcluirModelo
            // 
            this.bExcluirModelo.Location = new System.Drawing.Point(109, 48);
            this.bExcluirModelo.Name = "bExcluirModelo";
            this.bExcluirModelo.Size = new System.Drawing.Size(88, 23);
            this.bExcluirModelo.TabIndex = 4;
            this.bExcluirModelo.Text = "Excluir";
            this.bExcluirModelo.UseVisualStyleBackColor = true;
            this.bExcluirModelo.Click += new System.EventHandler(this.bExcluirModelo_Click);
            // 
            // bCancelarFormModelo
            // 
            this.bCancelarFormModelo.Location = new System.Drawing.Point(109, 19);
            this.bCancelarFormModelo.Name = "bCancelarFormModelo";
            this.bCancelarFormModelo.Size = new System.Drawing.Size(88, 23);
            this.bCancelarFormModelo.TabIndex = 5;
            this.bCancelarFormModelo.Text = "Cancelar";
            this.bCancelarFormModelo.UseVisualStyleBackColor = true;
            this.bCancelarFormModelo.Click += new System.EventHandler(this.bCancelarFormModelo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modelo:";
            // 
            // tbIDMod
            // 
            this.tbIDMod.Location = new System.Drawing.Point(84, 31);
            this.tbIDMod.Name = "tbIDMod";
            this.tbIDMod.Size = new System.Drawing.Size(107, 20);
            this.tbIDMod.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(474, 188);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // carangaShopDataSet1
            // 
            this.carangaShopDataSet1.DataSetName = "CarangaShopDataSet";
            this.carangaShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Marca:";
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(264, 28);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(203, 21);
            this.cbMarca.TabIndex = 17;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged_1);
            // 
            // tabelaMarcaBindingSource
            // 
            this.tabelaMarcaBindingSource.DataMember = "TabelaMarca";
            this.tabelaMarcaBindingSource.DataSource = this.carangaShopDataSet1;
            // 
            // cbModelo
            // 
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(264, 31);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(203, 21);
            this.cbModelo.TabIndex = 19;
            this.cbModelo.SelectedIndexChanged += new System.EventHandler(this.cbModelo_SelectedIndexChanged_1);
            // 
            // tabelaMarcaTableAdapter1
            // 
            this.tabelaMarcaTableAdapter1.ClearBeforeFill = true;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabelaCategoriaBindingSource, "IDCat", true));
            this.cbCategoria.DataSource = this.tabelaCategoriaBindingSource;
            this.cbCategoria.DisplayMember = "DescCat";
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(89, 28);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(102, 21);
            this.cbCategoria.TabIndex = 20;
            this.cbCategoria.ValueMember = "IDCat";
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // tabelaCategoriaBindingSource
            // 
            this.tabelaCategoriaBindingSource.DataMember = "TabelaCategoria";
            this.tabelaCategoriaBindingSource.DataSource = this.carangaShopDataSet1;
            // 
            // tabelaCategoriaTableAdapter
            // 
            this.tabelaCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Categoria:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bIncluirModelo);
            this.groupBox1.Controls.Add(this.bSalvarModelo);
            this.groupBox1.Controls.Add(this.bExcluirModelo);
            this.groupBox1.Controls.Add(this.bCancelarFormModelo);
            this.groupBox1.Location = new System.Drawing.Point(329, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 85);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações de controle do formulário";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbFiltroModelo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(52, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 85);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta";
            // 
            // tbFiltroModelo
            // 
            this.tbFiltroModelo.Location = new System.Drawing.Point(10, 48);
            this.tbFiltroModelo.Name = "tbFiltroModelo";
            this.tbFiltroModelo.Size = new System.Drawing.Size(244, 20);
            this.tbFiltroModelo.TabIndex = 1;
            this.tbFiltroModelo.TextChanged += new System.EventHandler(this.tbFiltroModelo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Marca do Modelo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gbDados);
            this.groupBox3.Controls.Add(this.gbFiltros);
            this.groupBox3.Location = new System.Drawing.Point(52, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(486, 178);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações do Novo Modelo";
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.label2);
            this.gbDados.Controls.Add(this.label3);
            this.gbDados.Controls.Add(this.tbIDMod);
            this.gbDados.Controls.Add(this.cbModelo);
            this.gbDados.Location = new System.Drawing.Point(7, 97);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(473, 69);
            this.gbDados.TabIndex = 1;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados Complementares";
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.label7);
            this.gbFiltros.Controls.Add(this.label5);
            this.gbFiltros.Controls.Add(this.cbMarca);
            this.gbFiltros.Controls.Add(this.cbCategoria);
            this.gbFiltros.Location = new System.Drawing.Point(7, 20);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(473, 71);
            this.gbFiltros.TabIndex = 0;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros para Cadastro";
            // 
            // FormModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 525);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormModelo";
            this.Text = "Cadastro de Modelos";
            this.Load += new System.EventHandler(this.FormModelo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carangaShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaMarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCategoriaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bIncluirModelo;
        private System.Windows.Forms.Button bSalvarModelo;
        private System.Windows.Forms.Button bExcluirModelo;
        private System.Windows.Forms.Button bCancelarFormModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIDMod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbModelo;
        private CarangaShopDataSet carangaShopDataSet;
        private CarangaShopDataSetTableAdapters.TabelaMarcaTableAdapter tabelaMarcaTableAdapter;
        private CarangaShopDataSet carangaShopDataSet1;
        private System.Windows.Forms.BindingSource tabelaMarcaBindingSource;
        private CarangaShopDataSetTableAdapters.TabelaMarcaTableAdapter tabelaMarcaTableAdapter1;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.BindingSource tabelaCategoriaBindingSource;
        private CarangaShopDataSetTableAdapters.TabelaCategoriaTableAdapter tabelaCategoriaTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.TextBox tbFiltroModelo;
        private System.Windows.Forms.Label label4;
    }
}