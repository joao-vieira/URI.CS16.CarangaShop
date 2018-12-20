namespace CarangaShop {
    partial class FormVeiculo {
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
            this.bIncluirVei = new System.Windows.Forms.Button();
            this.bExcluirVei = new System.Windows.Forms.Button();
            this.bCancelarFormVei = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAnoVei = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carangaShopDataSet = new CarangaShop.CarangaShopDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.tabelaMarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.cbVeiculo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCombustivelVei = new System.Windows.Forms.TextBox();
            this.tbCodFIPEVei = new System.Windows.Forms.TextBox();
            this.dtpReferencia = new System.Windows.Forms.DateTimePicker();
            this.cbCategoriaVei = new System.Windows.Forms.ComboBox();
            this.tabelaCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbPrecoVei = new System.Windows.Forms.TextBox();
            this.nudEstoqueVei = new System.Windows.Forms.NumericUpDown();
            this.bSalvarEstoqueVei = new System.Windows.Forms.Button();
            this.bAlterarEstoqueVei = new System.Windows.Forms.Button();
            this.tabelaMarcaTableAdapter = new CarangaShop.CarangaShopDataSetTableAdapters.TabelaMarcaTableAdapter();
            this.bGravarVei = new System.Windows.Forms.Button();
            this.tabelaCategoriaTableAdapter = new CarangaShop.CarangaShopDataSetTableAdapters.TabelaCategoriaTableAdapter();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.gbEstoque = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbFiltroVeiculo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carangaShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaMarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstoqueVei)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbDados.SuspendLayout();
            this.gbEstoque.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Veículo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veículo:";
            // 
            // bIncluirVei
            // 
            this.bIncluirVei.Location = new System.Drawing.Point(26, 20);
            this.bIncluirVei.Name = "bIncluirVei";
            this.bIncluirVei.Size = new System.Drawing.Size(149, 23);
            this.bIncluirVei.TabIndex = 2;
            this.bIncluirVei.Text = "Incluir";
            this.bIncluirVei.UseVisualStyleBackColor = true;
            this.bIncluirVei.Click += new System.EventHandler(this.bIncluirVei_Click);
            // 
            // bExcluirVei
            // 
            this.bExcluirVei.Location = new System.Drawing.Point(195, 49);
            this.bExcluirVei.Name = "bExcluirVei";
            this.bExcluirVei.Size = new System.Drawing.Size(147, 23);
            this.bExcluirVei.TabIndex = 4;
            this.bExcluirVei.Text = "Excluir";
            this.bExcluirVei.UseVisualStyleBackColor = true;
            this.bExcluirVei.Click += new System.EventHandler(this.bExcluirVei_Click);
            // 
            // bCancelarFormVei
            // 
            this.bCancelarFormVei.Location = new System.Drawing.Point(195, 20);
            this.bCancelarFormVei.Name = "bCancelarFormVei";
            this.bCancelarFormVei.Size = new System.Drawing.Size(147, 23);
            this.bCancelarFormVei.TabIndex = 5;
            this.bCancelarFormVei.Text = "Cancelar";
            this.bCancelarFormVei.UseVisualStyleBackColor = true;
            this.bCancelarFormVei.Click += new System.EventHandler(this.bCancelarFormVei_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ano:";
            // 
            // tbAnoVei
            // 
            this.tbAnoVei.Location = new System.Drawing.Point(64, 27);
            this.tbAnoVei.Name = "tbAnoVei";
            this.tbAnoVei.Size = new System.Drawing.Size(70, 20);
            this.tbAnoVei.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 439);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(754, 156);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // carangaShopDataSet
            // 
            this.carangaShopDataSet.DataSetName = "CarangaShopDataSet";
            this.carangaShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(368, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Marca:";
            // 
            // cbMarca
            // 
            this.cbMarca.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabelaMarcaBindingSource, "IDMar", true));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(434, 31);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(232, 21);
            this.cbMarca.TabIndex = 17;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // tabelaMarcaBindingSource
            // 
            this.tabelaMarcaBindingSource.DataMember = "TabelaMarca";
            this.tabelaMarcaBindingSource.DataSource = this.carangaShopDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Modelo:";
            // 
            // cbModelo
            // 
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(99, 62);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(211, 21);
            this.cbModelo.TabIndex = 21;
            this.cbModelo.SelectedIndexChanged += new System.EventHandler(this.cbModelo_SelectedIndexChanged);
            // 
            // cbVeiculo
            // 
            this.cbVeiculo.FormattingEnabled = true;
            this.cbVeiculo.Location = new System.Drawing.Point(434, 64);
            this.cbVeiculo.Name = "cbVeiculo";
            this.cbVeiculo.Size = new System.Drawing.Size(232, 21);
            this.cbVeiculo.TabIndex = 22;
            this.cbVeiculo.SelectedIndexChanged += new System.EventHandler(this.cbVeiculo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Código";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(143, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Combustível:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(165, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Consulta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Preço Unitário:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Categoria:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Qtd. Estoque:";
            // 
            // tbCombustivelVei
            // 
            this.tbCombustivelVei.Location = new System.Drawing.Point(237, 30);
            this.tbCombustivelVei.Name = "tbCombustivelVei";
            this.tbCombustivelVei.Size = new System.Drawing.Size(233, 20);
            this.tbCombustivelVei.TabIndex = 29;
            // 
            // tbCodFIPEVei
            // 
            this.tbCodFIPEVei.Location = new System.Drawing.Point(64, 72);
            this.tbCodFIPEVei.Name = "tbCodFIPEVei";
            this.tbCodFIPEVei.Size = new System.Drawing.Size(70, 20);
            this.tbCodFIPEVei.TabIndex = 30;
            // 
            // dtpReferencia
            // 
            this.dtpReferencia.Location = new System.Drawing.Point(237, 75);
            this.dtpReferencia.Name = "dtpReferencia";
            this.dtpReferencia.Size = new System.Drawing.Size(233, 20);
            this.dtpReferencia.TabIndex = 31;
            // 
            // cbCategoriaVei
            // 
            this.cbCategoriaVei.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabelaCategoriaBindingSource, "IDCat", true));
            this.cbCategoriaVei.DataSource = this.tabelaCategoriaBindingSource;
            this.cbCategoriaVei.DisplayMember = "DescCat";
            this.cbCategoriaVei.FormattingEnabled = true;
            this.cbCategoriaVei.Location = new System.Drawing.Point(99, 26);
            this.cbCategoriaVei.Name = "cbCategoriaVei";
            this.cbCategoriaVei.Size = new System.Drawing.Size(211, 21);
            this.cbCategoriaVei.TabIndex = 32;
            this.cbCategoriaVei.ValueMember = "IDCat";
            this.cbCategoriaVei.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaVei_SelectedIndexChanged);
            // 
            // tabelaCategoriaBindingSource
            // 
            this.tabelaCategoriaBindingSource.DataMember = "TabelaCategoria";
            this.tabelaCategoriaBindingSource.DataSource = this.carangaShopDataSet;
            // 
            // tbPrecoVei
            // 
            this.tbPrecoVei.Location = new System.Drawing.Point(121, 23);
            this.tbPrecoVei.Name = "tbPrecoVei";
            this.tbPrecoVei.Size = new System.Drawing.Size(93, 20);
            this.tbPrecoVei.TabIndex = 33;
            this.tbPrecoVei.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecoVei_KeyPress);
            // 
            // nudEstoqueVei
            // 
            this.nudEstoqueVei.BackColor = System.Drawing.Color.White;
            this.nudEstoqueVei.Location = new System.Drawing.Point(121, 53);
            this.nudEstoqueVei.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudEstoqueVei.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEstoqueVei.Name = "nudEstoqueVei";
            this.nudEstoqueVei.Size = new System.Drawing.Size(93, 20);
            this.nudEstoqueVei.TabIndex = 34;
            this.nudEstoqueVei.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bSalvarEstoqueVei
            // 
            this.bSalvarEstoqueVei.Location = new System.Drawing.Point(121, 87);
            this.bSalvarEstoqueVei.Name = "bSalvarEstoqueVei";
            this.bSalvarEstoqueVei.Size = new System.Drawing.Size(93, 23);
            this.bSalvarEstoqueVei.TabIndex = 36;
            this.bSalvarEstoqueVei.Text = "Salvar";
            this.bSalvarEstoqueVei.UseVisualStyleBackColor = true;
            this.bSalvarEstoqueVei.Click += new System.EventHandler(this.bSalvarEstoqueVei_Click);
            // 
            // bAlterarEstoqueVei
            // 
            this.bAlterarEstoqueVei.Location = new System.Drawing.Point(12, 87);
            this.bAlterarEstoqueVei.Name = "bAlterarEstoqueVei";
            this.bAlterarEstoqueVei.Size = new System.Drawing.Size(93, 23);
            this.bAlterarEstoqueVei.TabIndex = 35;
            this.bAlterarEstoqueVei.Text = "Alterar";
            this.bAlterarEstoqueVei.UseVisualStyleBackColor = true;
            this.bAlterarEstoqueVei.Click += new System.EventHandler(this.bAlterarEstoqueVei_Click);
            // 
            // tabelaMarcaTableAdapter
            // 
            this.tabelaMarcaTableAdapter.ClearBeforeFill = true;
            // 
            // bGravarVei
            // 
            this.bGravarVei.Location = new System.Drawing.Point(25, 49);
            this.bGravarVei.Name = "bGravarVei";
            this.bGravarVei.Size = new System.Drawing.Size(149, 23);
            this.bGravarVei.TabIndex = 38;
            this.bGravarVei.Text = "Gravar";
            this.bGravarVei.UseVisualStyleBackColor = true;
            this.bGravarVei.Click += new System.EventHandler(this.bGravarVei_Click);
            // 
            // tabelaCategoriaTableAdapter
            // 
            this.tabelaCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.label11);
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Controls.Add(this.label5);
            this.gbFiltros.Controls.Add(this.cbMarca);
            this.gbFiltros.Controls.Add(this.label6);
            this.gbFiltros.Controls.Add(this.cbModelo);
            this.gbFiltros.Controls.Add(this.cbVeiculo);
            this.gbFiltros.Controls.Add(this.cbCategoriaVei);
            this.gbFiltros.Location = new System.Drawing.Point(17, 19);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(720, 94);
            this.gbFiltros.TabIndex = 39;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros para Cadastro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bIncluirVei);
            this.groupBox2.Controls.Add(this.bGravarVei);
            this.groupBox2.Controls.Add(this.bExcluirVei);
            this.groupBox2.Controls.Add(this.bCancelarFormVei);
            this.groupBox2.Location = new System.Drawing.Point(442, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 83);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ações de controle do formulário";
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.gbEstoque);
            this.gbDados.Controls.Add(this.label3);
            this.gbDados.Controls.Add(this.tbAnoVei);
            this.gbDados.Controls.Add(this.label7);
            this.gbDados.Controls.Add(this.tbCodFIPEVei);
            this.gbDados.Controls.Add(this.label8);
            this.gbDados.Controls.Add(this.label9);
            this.gbDados.Controls.Add(this.tbCombustivelVei);
            this.gbDados.Controls.Add(this.dtpReferencia);
            this.gbDados.Location = new System.Drawing.Point(17, 119);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(720, 143);
            this.gbDados.TabIndex = 41;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados Complementares";
            // 
            // gbEstoque
            // 
            this.gbEstoque.Controls.Add(this.label10);
            this.gbEstoque.Controls.Add(this.label12);
            this.gbEstoque.Controls.Add(this.bSalvarEstoqueVei);
            this.gbEstoque.Controls.Add(this.tbPrecoVei);
            this.gbEstoque.Controls.Add(this.bAlterarEstoqueVei);
            this.gbEstoque.Controls.Add(this.nudEstoqueVei);
            this.gbEstoque.Location = new System.Drawing.Point(484, 19);
            this.gbEstoque.Name = "gbEstoque";
            this.gbEstoque.Size = new System.Drawing.Size(220, 116);
            this.gbEstoque.TabIndex = 41;
            this.gbEstoque.TabStop = false;
            this.gbEstoque.Text = "Informações de Estoque";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.gbFiltros);
            this.groupBox5.Controls.Add(this.gbDados);
            this.groupBox5.Location = new System.Drawing.Point(47, 59);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(754, 273);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Informações do Novo Veículo";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbFiltroVeiculo);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(47, 338);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(389, 83);
            this.groupBox6.TabIndex = 43;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Consulta";
            // 
            // tbFiltroVeiculo
            // 
            this.tbFiltroVeiculo.Location = new System.Drawing.Point(20, 50);
            this.tbFiltroVeiculo.Name = "tbFiltroVeiculo";
            this.tbFiltroVeiculo.Size = new System.Drawing.Size(337, 20);
            this.tbFiltroVeiculo.TabIndex = 1;
            this.tbFiltroVeiculo.TextChanged += new System.EventHandler(this.tbFiltroVeiculo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Modelo do Veículo ou Combustível";
            // 
            // FormVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 627);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormVeiculo";
            this.Text = "Cadastro de Veículo";
            this.Load += new System.EventHandler(this.FormVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carangaShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaMarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstoqueVei)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.gbEstoque.ResumeLayout(false);
            this.gbEstoque.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bIncluirVei;
        private System.Windows.Forms.Button bExcluirVei;
        private System.Windows.Forms.Button bCancelarFormVei;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAnoVei;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.ComboBox cbVeiculo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbCombustivelVei;
        private System.Windows.Forms.TextBox tbCodFIPEVei;
        private System.Windows.Forms.DateTimePicker dtpReferencia;
        private System.Windows.Forms.ComboBox cbCategoriaVei;
        private System.Windows.Forms.TextBox tbPrecoVei;
        private System.Windows.Forms.NumericUpDown nudEstoqueVei;
        private System.Windows.Forms.Button bSalvarEstoqueVei;
        private System.Windows.Forms.Button bAlterarEstoqueVei;
        private CarangaShopDataSet carangaShopDataSet;
        private System.Windows.Forms.BindingSource tabelaMarcaBindingSource;
        private CarangaShopDataSetTableAdapters.TabelaMarcaTableAdapter tabelaMarcaTableAdapter;
        private System.Windows.Forms.Button bGravarVei;
        private System.Windows.Forms.BindingSource tabelaCategoriaBindingSource;
        private CarangaShopDataSetTableAdapters.TabelaCategoriaTableAdapter tabelaCategoriaTableAdapter;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.GroupBox gbEstoque;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbFiltroVeiculo;
        private System.Windows.Forms.Label label4;
    }
}