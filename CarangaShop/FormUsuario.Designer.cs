namespace CarangaShop {
    partial class FormUsuario {
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
            this.bIncluirUsu = new System.Windows.Forms.Button();
            this.bSalvarUsu = new System.Windows.Forms.Button();
            this.bExcluirUsu = new System.Windows.Forms.Button();
            this.bCancelarFormUsu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIDUsu = new System.Windows.Forms.TextBox();
            this.tbNomeUsu = new System.Windows.Forms.TextBox();
            this.tbSenhaUsu = new System.Windows.Forms.TextBox();
            this.cbNivelAcessoUsu = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carangaShopDataSet1 = new CarangaShop.CarangaShopDataSet();
            this.cbFuncionarioUsu = new System.Windows.Forms.ComboBox();
            this.tabelaFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carangaShopDataSet = new CarangaShop.CarangaShopDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFiltroNomeFuncionario = new System.Windows.Forms.TextBox();
            this.gbInfoNovoUsuario = new System.Windows.Forms.GroupBox();
            this.gbConsultaUsuario = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabelaFuncionarioTableAdapter = new CarangaShop.CarangaShopDataSetTableAdapters.TabelaFuncionarioTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carangaShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carangaShopDataSet)).BeginInit();
            this.gbInfoNovoUsuario.SuspendLayout();
            this.gbConsultaUsuario.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Usuário do Sistema";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // bIncluirUsu
            // 
            this.bIncluirUsu.Location = new System.Drawing.Point(15, 19);
            this.bIncluirUsu.Name = "bIncluirUsu";
            this.bIncluirUsu.Size = new System.Drawing.Size(75, 23);
            this.bIncluirUsu.TabIndex = 2;
            this.bIncluirUsu.Text = "Incluir";
            this.bIncluirUsu.UseVisualStyleBackColor = true;
            this.bIncluirUsu.Click += new System.EventHandler(this.bIncluirUsu_Click);
            // 
            // bSalvarUsu
            // 
            this.bSalvarUsu.Location = new System.Drawing.Point(15, 65);
            this.bSalvarUsu.Name = "bSalvarUsu";
            this.bSalvarUsu.Size = new System.Drawing.Size(75, 23);
            this.bSalvarUsu.TabIndex = 3;
            this.bSalvarUsu.Text = "Salvar";
            this.bSalvarUsu.UseVisualStyleBackColor = true;
            this.bSalvarUsu.Click += new System.EventHandler(this.bSalvarUsu_Click);
            // 
            // bExcluirUsu
            // 
            this.bExcluirUsu.Location = new System.Drawing.Point(119, 65);
            this.bExcluirUsu.Name = "bExcluirUsu";
            this.bExcluirUsu.Size = new System.Drawing.Size(75, 23);
            this.bExcluirUsu.TabIndex = 4;
            this.bExcluirUsu.Text = "Excluir";
            this.bExcluirUsu.UseVisualStyleBackColor = true;
            this.bExcluirUsu.Click += new System.EventHandler(this.bExcluirUsu_Click);
            // 
            // bCancelarFormUsu
            // 
            this.bCancelarFormUsu.Location = new System.Drawing.Point(119, 19);
            this.bCancelarFormUsu.Name = "bCancelarFormUsu";
            this.bCancelarFormUsu.Size = new System.Drawing.Size(75, 23);
            this.bCancelarFormUsu.TabIndex = 5;
            this.bCancelarFormUsu.Text = "Cancelar";
            this.bCancelarFormUsu.UseVisualStyleBackColor = true;
            this.bCancelarFormUsu.Click += new System.EventHandler(this.bCancelarFormUsu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Permissão:";
            // 
            // tbIDUsu
            // 
            this.tbIDUsu.Location = new System.Drawing.Point(91, 36);
            this.tbIDUsu.Name = "tbIDUsu";
            this.tbIDUsu.Size = new System.Drawing.Size(140, 20);
            this.tbIDUsu.TabIndex = 9;
            // 
            // tbNomeUsu
            // 
            this.tbNomeUsu.Location = new System.Drawing.Point(91, 78);
            this.tbNomeUsu.Name = "tbNomeUsu";
            this.tbNomeUsu.Size = new System.Drawing.Size(140, 20);
            this.tbNomeUsu.TabIndex = 10;
            // 
            // tbSenhaUsu
            // 
            this.tbSenhaUsu.Location = new System.Drawing.Point(341, 79);
            this.tbSenhaUsu.Name = "tbSenhaUsu";
            this.tbSenhaUsu.PasswordChar = '*';
            this.tbSenhaUsu.Size = new System.Drawing.Size(150, 20);
            this.tbSenhaUsu.TabIndex = 11;
            // 
            // cbNivelAcessoUsu
            // 
            this.cbNivelAcessoUsu.FormattingEnabled = true;
            this.cbNivelAcessoUsu.Items.AddRange(new object[] {
            "Administrador",
            "Funcionário"});
            this.cbNivelAcessoUsu.Location = new System.Drawing.Point(91, 120);
            this.cbNivelAcessoUsu.Name = "cbNivelAcessoUsu";
            this.cbNivelAcessoUsu.Size = new System.Drawing.Size(140, 21);
            this.cbNivelAcessoUsu.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(90, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(509, 150);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // carangaShopDataSet1
            // 
            this.carangaShopDataSet1.DataSetName = "CarangaShopDataSet";
            this.carangaShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbFuncionarioUsu
            // 
            this.cbFuncionarioUsu.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabelaFuncionarioBindingSource, "IDFunc", true));
            this.cbFuncionarioUsu.DataSource = this.tabelaFuncionarioBindingSource;
            this.cbFuncionarioUsu.DisplayMember = "NomeFunc";
            this.cbFuncionarioUsu.FormattingEnabled = true;
            this.cbFuncionarioUsu.Location = new System.Drawing.Point(341, 121);
            this.cbFuncionarioUsu.Name = "cbFuncionarioUsu";
            this.cbFuncionarioUsu.Size = new System.Drawing.Size(150, 21);
            this.cbFuncionarioUsu.TabIndex = 16;
            this.cbFuncionarioUsu.ValueMember = "IDFunc";
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
            this.label6.Location = new System.Drawing.Point(246, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Funcionário:";
            // 
            // tbFiltroNomeFuncionario
            // 
            this.tbFiltroNomeFuncionario.Location = new System.Drawing.Point(9, 56);
            this.tbFiltroNomeFuncionario.Name = "tbFiltroNomeFuncionario";
            this.tbFiltroNomeFuncionario.Size = new System.Drawing.Size(238, 20);
            this.tbFiltroNomeFuncionario.TabIndex = 17;
            this.tbFiltroNomeFuncionario.TextChanged += new System.EventHandler(this.tbFiltroNomeFuncionario_TextChanged);
            // 
            // gbInfoNovoUsuario
            // 
            this.gbInfoNovoUsuario.Controls.Add(this.label2);
            this.gbInfoNovoUsuario.Controls.Add(this.label3);
            this.gbInfoNovoUsuario.Controls.Add(this.label4);
            this.gbInfoNovoUsuario.Controls.Add(this.cbFuncionarioUsu);
            this.gbInfoNovoUsuario.Controls.Add(this.label5);
            this.gbInfoNovoUsuario.Controls.Add(this.label6);
            this.gbInfoNovoUsuario.Controls.Add(this.tbIDUsu);
            this.gbInfoNovoUsuario.Controls.Add(this.tbNomeUsu);
            this.gbInfoNovoUsuario.Controls.Add(this.tbSenhaUsu);
            this.gbInfoNovoUsuario.Controls.Add(this.cbNivelAcessoUsu);
            this.gbInfoNovoUsuario.Location = new System.Drawing.Point(90, 51);
            this.gbInfoNovoUsuario.Name = "gbInfoNovoUsuario";
            this.gbInfoNovoUsuario.Size = new System.Drawing.Size(509, 189);
            this.gbInfoNovoUsuario.TabIndex = 19;
            this.gbInfoNovoUsuario.TabStop = false;
            this.gbInfoNovoUsuario.Text = "Informações do Novo Usuário";
            // 
            // gbConsultaUsuario
            // 
            this.gbConsultaUsuario.Controls.Add(this.label7);
            this.gbConsultaUsuario.Controls.Add(this.tbFiltroNomeFuncionario);
            this.gbConsultaUsuario.Location = new System.Drawing.Point(90, 257);
            this.gbConsultaUsuario.Name = "gbConsultaUsuario";
            this.gbConsultaUsuario.Size = new System.Drawing.Size(271, 100);
            this.gbConsultaUsuario.TabIndex = 20;
            this.gbConsultaUsuario.TabStop = false;
            this.gbConsultaUsuario.Text = "Consulta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nome do Funcionário:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bExcluirUsu);
            this.groupBox3.Controls.Add(this.bCancelarFormUsu);
            this.groupBox3.Controls.Add(this.bSalvarUsu);
            this.groupBox3.Controls.Add(this.bIncluirUsu);
            this.groupBox3.Location = new System.Drawing.Point(399, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ações de controle do formulário";
            // 
            // tabelaFuncionarioTableAdapter
            // 
            this.tabelaFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 536);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbConsultaUsuario);
            this.Controls.Add(this.gbInfoNovoUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormUsuario";
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carangaShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carangaShopDataSet)).EndInit();
            this.gbInfoNovoUsuario.ResumeLayout(false);
            this.gbInfoNovoUsuario.PerformLayout();
            this.gbConsultaUsuario.ResumeLayout(false);
            this.gbConsultaUsuario.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bIncluirUsu;
        private System.Windows.Forms.Button bSalvarUsu;
        private System.Windows.Forms.Button bExcluirUsu;
        private System.Windows.Forms.Button bCancelarFormUsu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIDUsu;
        private System.Windows.Forms.TextBox tbNomeUsu;
        private System.Windows.Forms.TextBox tbSenhaUsu;
        private System.Windows.Forms.ComboBox cbNivelAcessoUsu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbFuncionarioUsu;
        private System.Windows.Forms.Label label6;
        private CarangaShopDataSet carangaShopDataSet;
        private CarangaShopDataSet carangaShopDataSet1;
        private System.Windows.Forms.TextBox tbFiltroNomeFuncionario;
        private System.Windows.Forms.GroupBox gbInfoNovoUsuario;
        private System.Windows.Forms.GroupBox gbConsultaUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource tabelaFuncionarioBindingSource;
        private CarangaShopDataSetTableAdapters.TabelaFuncionarioTableAdapter tabelaFuncionarioTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}