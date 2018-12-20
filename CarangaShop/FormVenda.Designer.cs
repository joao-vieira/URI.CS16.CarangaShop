namespace CarangaShop {
    partial class FormVenda {
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
            this.bIncluirItemVenda = new System.Windows.Forms.Button();
            this.bFinalizarVenda = new System.Windows.Forms.Button();
            this.bCancelarVenda = new System.Windows.Forms.Button();
            this.carangaShopDataSet1 = new CarangaShop.CarangaShopDataSet();
            this.cbFuncionarioVenda = new System.Windows.Forms.ComboBox();
            this.tabelaFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carangaShopDataSet = new CarangaShop.CarangaShopDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.gbInfoNovaVenda = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbClienteVenda = new System.Windows.Forms.ComboBox();
            this.tabelaClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.cbMarcaVenda = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbVeiculoVenda = new System.Windows.Forms.ComboBox();
            this.cbModeloVenda = new System.Windows.Forms.ComboBox();
            this.cbCategoriaVenda = new System.Windows.Forms.ComboBox();
            this.tabelaCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbPrecoUn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bRemoverTodosItensVenda = new System.Windows.Forms.Button();
            this.bRemoverItemVenda = new System.Windows.Forms.Button();
            this.bAdicionarItemVenda = new System.Windows.Forms.Button();
            this.tabelaFuncionarioTableAdapter = new CarangaShop.CarangaShopDataSetTableAdapters.TabelaFuncionarioTableAdapter();
            this.gbEditarQuantidade = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bAlterarItem = new System.Windows.Forms.Button();
            this.bCancelarEditarItem = new System.Windows.Forms.Button();
            this.tbEditQntItem = new System.Windows.Forms.TextBox();
            this.tabelaCategoriaTableAdapter = new CarangaShop.CarangaShopDataSetTableAdapters.TabelaCategoriaTableAdapter();
            this.tabelaClienteTableAdapter = new CarangaShop.CarangaShopDataSetTableAdapters.TabelaClienteTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lbEmEstoque = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carangaShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carangaShopDataSet)).BeginInit();
            this.gbInfoNovaVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCategoriaBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gbEditarQuantidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Execução de Venda do Sistema";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bIncluirItemVenda
            // 
            this.bIncluirItemVenda.Location = new System.Drawing.Point(15, 19);
            this.bIncluirItemVenda.Name = "bIncluirItemVenda";
            this.bIncluirItemVenda.Size = new System.Drawing.Size(75, 23);
            this.bIncluirItemVenda.TabIndex = 2;
            this.bIncluirItemVenda.Text = "Incluir";
            this.bIncluirItemVenda.UseVisualStyleBackColor = true;
            this.bIncluirItemVenda.Click += new System.EventHandler(this.bIncluirItemVenda_Click);
            // 
            // bFinalizarVenda
            // 
            this.bFinalizarVenda.Location = new System.Drawing.Point(15, 123);
            this.bFinalizarVenda.Name = "bFinalizarVenda";
            this.bFinalizarVenda.Size = new System.Drawing.Size(151, 23);
            this.bFinalizarVenda.TabIndex = 3;
            this.bFinalizarVenda.Text = "Finalizar";
            this.bFinalizarVenda.UseVisualStyleBackColor = true;
            this.bFinalizarVenda.Click += new System.EventHandler(this.bFinalizarVenda_Click);
            // 
            // bCancelarVenda
            // 
            this.bCancelarVenda.Location = new System.Drawing.Point(97, 19);
            this.bCancelarVenda.Name = "bCancelarVenda";
            this.bCancelarVenda.Size = new System.Drawing.Size(75, 23);
            this.bCancelarVenda.TabIndex = 5;
            this.bCancelarVenda.Text = "Cancelar";
            this.bCancelarVenda.UseVisualStyleBackColor = true;
            this.bCancelarVenda.Click += new System.EventHandler(this.bCancelarVenda_Click);
            // 
            // carangaShopDataSet1
            // 
            this.carangaShopDataSet1.DataSetName = "CarangaShopDataSet";
            this.carangaShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbFuncionarioVenda
            // 
            this.cbFuncionarioVenda.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabelaFuncionarioBindingSource, "IDFunc", true));
            this.cbFuncionarioVenda.DataSource = this.tabelaFuncionarioBindingSource;
            this.cbFuncionarioVenda.DisplayMember = "NomeFunc";
            this.cbFuncionarioVenda.FormattingEnabled = true;
            this.cbFuncionarioVenda.Location = new System.Drawing.Point(225, 30);
            this.cbFuncionarioVenda.Name = "cbFuncionarioVenda";
            this.cbFuncionarioVenda.Size = new System.Drawing.Size(120, 21);
            this.cbFuncionarioVenda.TabIndex = 16;
            this.cbFuncionarioVenda.ValueMember = "IDFunc";
            // 
            // tabelaFuncionarioBindingSource
            // 
            this.tabelaFuncionarioBindingSource.DataMember = "TabelaFuncionario";
            this.tabelaFuncionarioBindingSource.DataSource = this.carangaShopDataSet1;
            // 
            // carangaShopDataSet
            // 
            this.carangaShopDataSet.DataSetName = "CarangaShopDataSet";
            this.carangaShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Funcionário:";
            // 
            // gbInfoNovaVenda
            // 
            this.gbInfoNovaVenda.Controls.Add(this.lbEmEstoque);
            this.gbInfoNovaVenda.Controls.Add(this.tbQuantidade);
            this.gbInfoNovaVenda.Controls.Add(this.pictureBox1);
            this.gbInfoNovaVenda.Controls.Add(this.cbClienteVenda);
            this.gbInfoNovaVenda.Controls.Add(this.label10);
            this.gbInfoNovaVenda.Controls.Add(this.cbMarcaVenda);
            this.gbInfoNovaVenda.Controls.Add(this.label9);
            this.gbInfoNovaVenda.Controls.Add(this.cbVeiculoVenda);
            this.gbInfoNovaVenda.Controls.Add(this.cbModeloVenda);
            this.gbInfoNovaVenda.Controls.Add(this.cbCategoriaVenda);
            this.gbInfoNovaVenda.Controls.Add(this.tbPrecoUn);
            this.gbInfoNovaVenda.Controls.Add(this.label7);
            this.gbInfoNovaVenda.Controls.Add(this.label5);
            this.gbInfoNovaVenda.Controls.Add(this.label4);
            this.gbInfoNovaVenda.Controls.Add(this.label3);
            this.gbInfoNovaVenda.Controls.Add(this.label2);
            this.gbInfoNovaVenda.Controls.Add(this.cbFuncionarioVenda);
            this.gbInfoNovaVenda.Controls.Add(this.label6);
            this.gbInfoNovaVenda.Location = new System.Drawing.Point(44, 51);
            this.gbInfoNovaVenda.Name = "gbInfoNovaVenda";
            this.gbInfoNovaVenda.Size = new System.Drawing.Size(551, 186);
            this.gbInfoNovaVenda.TabIndex = 19;
            this.gbInfoNovaVenda.TabStop = false;
            this.gbInfoNovaVenda.Text = "Informações da Nova Venda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarangaShop.Properties.Resources.shopping_cart;
            this.pictureBox1.Location = new System.Drawing.Point(35, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 27);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // cbClienteVenda
            // 
            this.cbClienteVenda.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabelaClienteBindingSource, "IDCli", true));
            this.cbClienteVenda.DataSource = this.tabelaClienteBindingSource;
            this.cbClienteVenda.DisplayMember = "NomeCli";
            this.cbClienteVenda.FormattingEnabled = true;
            this.cbClienteVenda.Location = new System.Drawing.Point(421, 29);
            this.cbClienteVenda.Name = "cbClienteVenda";
            this.cbClienteVenda.Size = new System.Drawing.Size(121, 21);
            this.cbClienteVenda.TabIndex = 31;
            this.cbClienteVenda.ValueMember = "IDCli";
            // 
            // tabelaClienteBindingSource
            // 
            this.tabelaClienteBindingSource.DataMember = "TabelaCliente";
            this.tabelaClienteBindingSource.DataSource = this.carangaShopDataSet1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(355, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Cliente:";
            // 
            // cbMarcaVenda
            // 
            this.cbMarcaVenda.FormattingEnabled = true;
            this.cbMarcaVenda.Location = new System.Drawing.Point(345, 63);
            this.cbMarcaVenda.Name = "cbMarcaVenda";
            this.cbMarcaVenda.Size = new System.Drawing.Size(121, 21);
            this.cbMarcaVenda.TabIndex = 29;
            this.cbMarcaVenda.SelectedIndexChanged += new System.EventHandler(this.cbMarcaVenda_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(285, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Marca:";
            // 
            // cbVeiculoVenda
            // 
            this.cbVeiculoVenda.FormattingEnabled = true;
            this.cbVeiculoVenda.Location = new System.Drawing.Point(345, 98);
            this.cbVeiculoVenda.Name = "cbVeiculoVenda";
            this.cbVeiculoVenda.Size = new System.Drawing.Size(121, 21);
            this.cbVeiculoVenda.TabIndex = 27;
            this.cbVeiculoVenda.SelectedIndexChanged += new System.EventHandler(this.cbVeiculoVenda_SelectedIndexChanged);
            // 
            // cbModeloVenda
            // 
            this.cbModeloVenda.FormattingEnabled = true;
            this.cbModeloVenda.Location = new System.Drawing.Point(98, 99);
            this.cbModeloVenda.Name = "cbModeloVenda";
            this.cbModeloVenda.Size = new System.Drawing.Size(149, 21);
            this.cbModeloVenda.TabIndex = 26;
            this.cbModeloVenda.SelectedIndexChanged += new System.EventHandler(this.cbModeloVenda_SelectedIndexChanged);
            // 
            // cbCategoriaVenda
            // 
            this.cbCategoriaVenda.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabelaCategoriaBindingSource, "IDCat", true));
            this.cbCategoriaVenda.DataSource = this.tabelaCategoriaBindingSource;
            this.cbCategoriaVenda.DisplayMember = "DescCat";
            this.cbCategoriaVenda.FormattingEnabled = true;
            this.cbCategoriaVenda.Location = new System.Drawing.Point(98, 64);
            this.cbCategoriaVenda.Name = "cbCategoriaVenda";
            this.cbCategoriaVenda.Size = new System.Drawing.Size(149, 21);
            this.cbCategoriaVenda.TabIndex = 25;
            this.cbCategoriaVenda.ValueMember = "IDCat";
            this.cbCategoriaVenda.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaVenda_SelectedIndexChanged);
            // 
            // tabelaCategoriaBindingSource
            // 
            this.tabelaCategoriaBindingSource.DataMember = "TabelaCategoria";
            this.tabelaCategoriaBindingSource.DataSource = this.carangaShopDataSet1;
            // 
            // tbPrecoUn
            // 
            this.tbPrecoUn.Enabled = false;
            this.tbPrecoUn.Location = new System.Drawing.Point(345, 133);
            this.tbPrecoUn.Name = "tbPrecoUn";
            this.tbPrecoUn.Size = new System.Drawing.Size(121, 20);
            this.tbPrecoUn.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Preço Un:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Veículo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Categoria:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bRemoverTodosItensVenda);
            this.groupBox3.Controls.Add(this.bRemoverItemVenda);
            this.groupBox3.Controls.Add(this.bAdicionarItemVenda);
            this.groupBox3.Controls.Add(this.bCancelarVenda);
            this.groupBox3.Controls.Add(this.bFinalizarVenda);
            this.groupBox3.Controls.Add(this.bIncluirItemVenda);
            this.groupBox3.Location = new System.Drawing.Point(420, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 152);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ações de controle do formulário";
            // 
            // bRemoverTodosItensVenda
            // 
            this.bRemoverTodosItensVenda.Location = new System.Drawing.Point(15, 89);
            this.bRemoverTodosItensVenda.Name = "bRemoverTodosItensVenda";
            this.bRemoverTodosItensVenda.Size = new System.Drawing.Size(151, 23);
            this.bRemoverTodosItensVenda.TabIndex = 8;
            this.bRemoverTodosItensVenda.Text = "Remover Todos Itens";
            this.bRemoverTodosItensVenda.UseVisualStyleBackColor = true;
            this.bRemoverTodosItensVenda.Click += new System.EventHandler(this.bRemoverTodosItensVenda_Click);
            // 
            // bRemoverItemVenda
            // 
            this.bRemoverItemVenda.Location = new System.Drawing.Point(97, 57);
            this.bRemoverItemVenda.Name = "bRemoverItemVenda";
            this.bRemoverItemVenda.Size = new System.Drawing.Size(75, 23);
            this.bRemoverItemVenda.TabIndex = 7;
            this.bRemoverItemVenda.Text = "Remover";
            this.bRemoverItemVenda.UseVisualStyleBackColor = true;
            this.bRemoverItemVenda.Click += new System.EventHandler(this.bRemoverItemVenda_Click);
            // 
            // bAdicionarItemVenda
            // 
            this.bAdicionarItemVenda.Location = new System.Drawing.Point(15, 57);
            this.bAdicionarItemVenda.Name = "bAdicionarItemVenda";
            this.bAdicionarItemVenda.Size = new System.Drawing.Size(75, 23);
            this.bAdicionarItemVenda.TabIndex = 6;
            this.bAdicionarItemVenda.Text = "Adicionar";
            this.bAdicionarItemVenda.UseVisualStyleBackColor = true;
            this.bAdicionarItemVenda.Click += new System.EventHandler(this.bAdicionarItemVenda_Click);
            // 
            // tabelaFuncionarioTableAdapter
            // 
            this.tabelaFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // gbEditarQuantidade
            // 
            this.gbEditarQuantidade.Controls.Add(this.label8);
            this.gbEditarQuantidade.Controls.Add(this.bAlterarItem);
            this.gbEditarQuantidade.Controls.Add(this.bCancelarEditarItem);
            this.gbEditarQuantidade.Controls.Add(this.tbEditQntItem);
            this.gbEditarQuantidade.Location = new System.Drawing.Point(421, 254);
            this.gbEditarQuantidade.Name = "gbEditarQuantidade";
            this.gbEditarQuantidade.Size = new System.Drawing.Size(174, 100);
            this.gbEditarQuantidade.TabIndex = 23;
            this.gbEditarQuantidade.TabStop = false;
            this.gbEditarQuantidade.Text = "Editar Quantidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Quantidade do Item:";
            // 
            // bAlterarItem
            // 
            this.bAlterarItem.Location = new System.Drawing.Point(96, 71);
            this.bAlterarItem.Name = "bAlterarItem";
            this.bAlterarItem.Size = new System.Drawing.Size(75, 23);
            this.bAlterarItem.TabIndex = 2;
            this.bAlterarItem.Text = "Alterar";
            this.bAlterarItem.UseVisualStyleBackColor = true;
            this.bAlterarItem.Click += new System.EventHandler(this.bAlterarItem_Click);
            // 
            // bCancelarEditarItem
            // 
            this.bCancelarEditarItem.Location = new System.Drawing.Point(14, 71);
            this.bCancelarEditarItem.Name = "bCancelarEditarItem";
            this.bCancelarEditarItem.Size = new System.Drawing.Size(75, 23);
            this.bCancelarEditarItem.TabIndex = 1;
            this.bCancelarEditarItem.Text = "Cancelar";
            this.bCancelarEditarItem.UseVisualStyleBackColor = true;
            this.bCancelarEditarItem.Click += new System.EventHandler(this.bCancelarEditarItem_Click);
            // 
            // tbEditQntItem
            // 
            this.tbEditQntItem.Location = new System.Drawing.Point(14, 37);
            this.tbEditQntItem.MaxLength = 2;
            this.tbEditQntItem.Name = "tbEditQntItem";
            this.tbEditQntItem.Size = new System.Drawing.Size(151, 20);
            this.tbEditQntItem.TabIndex = 0;
            // 
            // tabelaCategoriaTableAdapter
            // 
            this.tabelaCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // tabelaClienteTableAdapter
            // 
            this.tabelaClienteTableAdapter.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(44, 254);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(370, 265);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 28;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Modelo";
            this.columnHeader2.Width = 104;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Veículo";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantidade";
            this.columnHeader4.Width = 68;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Preço";
            this.columnHeader5.Width = 87;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 25;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(98, 133);
            this.tbQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.ReadOnly = true;
            this.tbQuantidade.Size = new System.Drawing.Size(149, 20);
            this.tbQuantidade.TabIndex = 33;
            this.tbQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbEmEstoque
            // 
            this.lbEmEstoque.AutoSize = true;
            this.lbEmEstoque.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmEstoque.Location = new System.Drawing.Point(7, 158);
            this.lbEmEstoque.Name = "lbEmEstoque";
            this.lbEmEstoque.Size = new System.Drawing.Size(54, 16);
            this.lbEmEstoque.TabIndex = 34;
            this.lbEmEstoque.Text = "label11";
            this.lbEmEstoque.Visible = false;
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 528);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gbEditarQuantidade);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbInfoNovaVenda);
            this.Controls.Add(this.label1);
            this.Name = "FormVenda";
            this.Text = "Execução de Venda";
            this.Load += new System.EventHandler(this.FormVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carangaShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carangaShopDataSet)).EndInit();
            this.gbInfoNovaVenda.ResumeLayout(false);
            this.gbInfoNovaVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCategoriaBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.gbEditarQuantidade.ResumeLayout(false);
            this.gbEditarQuantidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bIncluirItemVenda;
        private System.Windows.Forms.Button bFinalizarVenda;
        private System.Windows.Forms.Button bCancelarVenda;
        private System.Windows.Forms.ComboBox cbFuncionarioVenda;
        private System.Windows.Forms.Label label6;
        private CarangaShopDataSet carangaShopDataSet;
        private CarangaShopDataSet carangaShopDataSet1;
        private System.Windows.Forms.GroupBox gbInfoNovaVenda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource tabelaFuncionarioBindingSource;
        private CarangaShopDataSetTableAdapters.TabelaFuncionarioTableAdapter tabelaFuncionarioTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bAdicionarItemVenda;
        private System.Windows.Forms.Button bRemoverItemVenda;
        private System.Windows.Forms.Button bRemoverTodosItensVenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbEditarQuantidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bAlterarItem;
        private System.Windows.Forms.Button bCancelarEditarItem;
        private System.Windows.Forms.TextBox tbEditQntItem;
        private System.Windows.Forms.ComboBox cbVeiculoVenda;
        private System.Windows.Forms.ComboBox cbModeloVenda;
        private System.Windows.Forms.ComboBox cbCategoriaVenda;
        private System.Windows.Forms.TextBox tbPrecoUn;
        private System.Windows.Forms.BindingSource tabelaCategoriaBindingSource;
        private CarangaShopDataSetTableAdapters.TabelaCategoriaTableAdapter tabelaCategoriaTableAdapter;
        private System.Windows.Forms.ComboBox cbMarcaVenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbClienteVenda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource tabelaClienteBindingSource;
        private CarangaShopDataSetTableAdapters.TabelaClienteTableAdapter tabelaClienteTableAdapter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown tbQuantidade;
        private System.Windows.Forms.Label lbEmEstoque;
    }
}