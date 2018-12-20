namespace CarangaShop {
    partial class FormCliente {
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
            this.bIncluirCli = new System.Windows.Forms.Button();
            this.bSalvarCli = new System.Windows.Forms.Button();
            this.bExcluirCli = new System.Windows.Forms.Button();
            this.bCancelarFormCli = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIDCli = new System.Windows.Forms.TextBox();
            this.tbNomeCli = new System.Windows.Forms.TextBox();
            this.tbEmailCli = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carangaShopDataSet = new CarangaShop.CarangaShopDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbCPFCli = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbTelefoneCli = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataNascCli = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCEPCliEnd = new System.Windows.Forms.TextBox();
            this.bCheckCEP = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbLogradouroCliEnd = new System.Windows.Forms.TextBox();
            this.tbComplementoCliEnd = new System.Windows.Forms.TextBox();
            this.tbBairroCliEnd = new System.Windows.Forms.TextBox();
            this.tbCidadeCliEnd = new System.Windows.Forms.TextBox();
            this.tbUFCliEnd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbInfoNovoCliente = new System.Windows.Forms.GroupBox();
            this.gbInfoPessoais = new System.Windows.Forms.GroupBox();
            this.gbInfoEndereco = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbFiltroCliente = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carangaShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbInfoNovoCliente.SuspendLayout();
            this.gbInfoPessoais.SuspendLayout();
            this.gbInfoEndereco.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // bIncluirCli
            // 
            this.bIncluirCli.Location = new System.Drawing.Point(9, 19);
            this.bIncluirCli.Name = "bIncluirCli";
            this.bIncluirCli.Size = new System.Drawing.Size(127, 23);
            this.bIncluirCli.TabIndex = 2;
            this.bIncluirCli.Text = "Incluir";
            this.bIncluirCli.UseVisualStyleBackColor = true;
            this.bIncluirCli.Click += new System.EventHandler(this.bIncluirCli_Click);
            // 
            // bSalvarCli
            // 
            this.bSalvarCli.Location = new System.Drawing.Point(9, 48);
            this.bSalvarCli.Name = "bSalvarCli";
            this.bSalvarCli.Size = new System.Drawing.Size(127, 23);
            this.bSalvarCli.TabIndex = 3;
            this.bSalvarCli.Text = "Salvar";
            this.bSalvarCli.UseVisualStyleBackColor = true;
            this.bSalvarCli.Click += new System.EventHandler(this.bSalvarCli_Click);
            // 
            // bExcluirCli
            // 
            this.bExcluirCli.Location = new System.Drawing.Point(155, 48);
            this.bExcluirCli.Name = "bExcluirCli";
            this.bExcluirCli.Size = new System.Drawing.Size(127, 23);
            this.bExcluirCli.TabIndex = 4;
            this.bExcluirCli.Text = "Excluir";
            this.bExcluirCli.UseVisualStyleBackColor = true;
            this.bExcluirCli.Click += new System.EventHandler(this.bExcluirCli_Click);
            // 
            // bCancelarFormCli
            // 
            this.bCancelarFormCli.Location = new System.Drawing.Point(155, 19);
            this.bCancelarFormCli.Name = "bCancelarFormCli";
            this.bCancelarFormCli.Size = new System.Drawing.Size(127, 23);
            this.bCancelarFormCli.TabIndex = 5;
            this.bCancelarFormCli.Text = "Cancelar";
            this.bCancelarFormCli.UseVisualStyleBackColor = true;
            this.bCancelarFormCli.Click += new System.EventHandler(this.bCancelarFormCli_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-mail:";
            // 
            // tbIDCli
            // 
            this.tbIDCli.Location = new System.Drawing.Point(104, 22);
            this.tbIDCli.Name = "tbIDCli";
            this.tbIDCli.Size = new System.Drawing.Size(71, 20);
            this.tbIDCli.TabIndex = 9;
            // 
            // tbNomeCli
            // 
            this.tbNomeCli.Location = new System.Drawing.Point(104, 51);
            this.tbNomeCli.Name = "tbNomeCli";
            this.tbNomeCli.Size = new System.Drawing.Size(219, 20);
            this.tbNomeCli.TabIndex = 10;
            // 
            // tbEmailCli
            // 
            this.tbEmailCli.Location = new System.Drawing.Point(402, 52);
            this.tbEmailCli.Name = "tbEmailCli";
            this.tbEmailCli.Size = new System.Drawing.Size(164, 20);
            this.tbEmailCli.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 446);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(662, 135);
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
            this.label5.Location = new System.Drawing.Point(342, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "CPF:";
            // 
            // mtbCPFCli
            // 
            this.mtbCPFCli.Location = new System.Drawing.Point(402, 78);
            this.mtbCPFCli.Mask = "000,000,000-00";
            this.mtbCPFCli.Name = "mtbCPFCli";
            this.mtbCPFCli.Size = new System.Drawing.Size(164, 20);
            this.mtbCPFCli.TabIndex = 16;
            this.mtbCPFCli.Validating += new System.ComponentModel.CancelEventHandler(this.mtbCPFCli_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Telefone:";
            // 
            // mtbTelefoneCli
            // 
            this.mtbTelefoneCli.Location = new System.Drawing.Point(104, 78);
            this.mtbTelefoneCli.Mask = "(00) 00000-0000";
            this.mtbTelefoneCli.Name = "mtbTelefoneCli";
            this.mtbTelefoneCli.Size = new System.Drawing.Size(219, 20);
            this.mtbTelefoneCli.TabIndex = 18;
            // 
            // dtpDataNascCli
            // 
            this.dtpDataNascCli.Location = new System.Drawing.Point(104, 110);
            this.dtpDataNascCli.Name = "dtpDataNascCli";
            this.dtpDataNascCli.Size = new System.Drawing.Size(219, 20);
            this.dtpDataNascCli.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Dt Nasc.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(342, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "CEP:";
            // 
            // tbCEPCliEnd
            // 
            this.tbCEPCliEnd.Location = new System.Drawing.Point(402, 110);
            this.tbCEPCliEnd.MaxLength = 8;
            this.tbCEPCliEnd.Name = "tbCEPCliEnd";
            this.tbCEPCliEnd.Size = new System.Drawing.Size(115, 20);
            this.tbCEPCliEnd.TabIndex = 22;
            this.tbCEPCliEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCEPCliEnd_KeyPress);
            // 
            // bCheckCEP
            // 
            this.bCheckCEP.Image = global::CarangaShop.Properties.Resources.search1;
            this.bCheckCEP.Location = new System.Drawing.Point(524, 106);
            this.bCheckCEP.Name = "bCheckCEP";
            this.bCheckCEP.Size = new System.Drawing.Size(42, 26);
            this.bCheckCEP.TabIndex = 23;
            this.bCheckCEP.UseVisualStyleBackColor = true;
            this.bCheckCEP.Click += new System.EventHandler(this.bCheckCEP_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Logradouro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(337, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Compl:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Bairro:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(337, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Cidade:";
            // 
            // tbLogradouroCliEnd
            // 
            this.tbLogradouroCliEnd.Location = new System.Drawing.Point(99, 25);
            this.tbLogradouroCliEnd.Name = "tbLogradouroCliEnd";
            this.tbLogradouroCliEnd.Size = new System.Drawing.Size(219, 20);
            this.tbLogradouroCliEnd.TabIndex = 29;
            // 
            // tbComplementoCliEnd
            // 
            this.tbComplementoCliEnd.Location = new System.Drawing.Point(397, 25);
            this.tbComplementoCliEnd.Name = "tbComplementoCliEnd";
            this.tbComplementoCliEnd.Size = new System.Drawing.Size(164, 20);
            this.tbComplementoCliEnd.TabIndex = 30;
            // 
            // tbBairroCliEnd
            // 
            this.tbBairroCliEnd.Location = new System.Drawing.Point(99, 58);
            this.tbBairroCliEnd.Name = "tbBairroCliEnd";
            this.tbBairroCliEnd.Size = new System.Drawing.Size(219, 20);
            this.tbBairroCliEnd.TabIndex = 31;
            // 
            // tbCidadeCliEnd
            // 
            this.tbCidadeCliEnd.Location = new System.Drawing.Point(397, 58);
            this.tbCidadeCliEnd.Name = "tbCidadeCliEnd";
            this.tbCidadeCliEnd.Size = new System.Drawing.Size(164, 20);
            this.tbCidadeCliEnd.TabIndex = 32;
            // 
            // tbUFCliEnd
            // 
            this.tbUFCliEnd.Location = new System.Drawing.Point(567, 58);
            this.tbUFCliEnd.Name = "tbUFCliEnd";
            this.tbUFCliEnd.Size = new System.Drawing.Size(59, 20);
            this.tbUFCliEnd.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Olive;
            this.label13.Location = new System.Drawing.Point(342, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(277, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Um CEP válido contém 8 dígitos. Digite apenas números!";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gbInfoNovoCliente
            // 
            this.gbInfoNovoCliente.Controls.Add(this.gbInfoPessoais);
            this.gbInfoNovoCliente.Controls.Add(this.gbInfoEndereco);
            this.gbInfoNovoCliente.Location = new System.Drawing.Point(22, 41);
            this.gbInfoNovoCliente.Name = "gbInfoNovoCliente";
            this.gbInfoNovoCliente.Size = new System.Drawing.Size(662, 303);
            this.gbInfoNovoCliente.TabIndex = 35;
            this.gbInfoNovoCliente.TabStop = false;
            this.gbInfoNovoCliente.Text = "Informações do Novo Cliente";
            // 
            // gbInfoPessoais
            // 
            this.gbInfoPessoais.Controls.Add(this.label3);
            this.gbInfoPessoais.Controls.Add(this.label13);
            this.gbInfoPessoais.Controls.Add(this.label4);
            this.gbInfoPessoais.Controls.Add(this.bCheckCEP);
            this.gbInfoPessoais.Controls.Add(this.tbNomeCli);
            this.gbInfoPessoais.Controls.Add(this.tbIDCli);
            this.gbInfoPessoais.Controls.Add(this.tbCEPCliEnd);
            this.gbInfoPessoais.Controls.Add(this.tbEmailCli);
            this.gbInfoPessoais.Controls.Add(this.label8);
            this.gbInfoPessoais.Controls.Add(this.label5);
            this.gbInfoPessoais.Controls.Add(this.label7);
            this.gbInfoPessoais.Controls.Add(this.label2);
            this.gbInfoPessoais.Controls.Add(this.mtbCPFCli);
            this.gbInfoPessoais.Controls.Add(this.dtpDataNascCli);
            this.gbInfoPessoais.Controls.Add(this.label6);
            this.gbInfoPessoais.Controls.Add(this.mtbTelefoneCli);
            this.gbInfoPessoais.Location = new System.Drawing.Point(15, 20);
            this.gbInfoPessoais.Name = "gbInfoPessoais";
            this.gbInfoPessoais.Size = new System.Drawing.Size(632, 163);
            this.gbInfoPessoais.TabIndex = 37;
            this.gbInfoPessoais.TabStop = false;
            this.gbInfoPessoais.Text = "Informações Pessoais";
            // 
            // gbInfoEndereco
            // 
            this.gbInfoEndereco.Controls.Add(this.label9);
            this.gbInfoEndereco.Controls.Add(this.label10);
            this.gbInfoEndereco.Controls.Add(this.label11);
            this.gbInfoEndereco.Controls.Add(this.tbUFCliEnd);
            this.gbInfoEndereco.Controls.Add(this.label12);
            this.gbInfoEndereco.Controls.Add(this.tbCidadeCliEnd);
            this.gbInfoEndereco.Controls.Add(this.tbLogradouroCliEnd);
            this.gbInfoEndereco.Controls.Add(this.tbBairroCliEnd);
            this.gbInfoEndereco.Controls.Add(this.tbComplementoCliEnd);
            this.gbInfoEndereco.Location = new System.Drawing.Point(15, 189);
            this.gbInfoEndereco.Name = "gbInfoEndereco";
            this.gbInfoEndereco.Size = new System.Drawing.Size(632, 100);
            this.gbInfoEndereco.TabIndex = 36;
            this.gbInfoEndereco.TabStop = false;
            this.gbInfoEndereco.Text = "Informações do Endereço";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bIncluirCli);
            this.groupBox4.Controls.Add(this.bSalvarCli);
            this.groupBox4.Controls.Add(this.bCancelarFormCli);
            this.groupBox4.Controls.Add(this.bExcluirCli);
            this.groupBox4.Location = new System.Drawing.Point(387, 350);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(297, 80);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ações de controle do formulário";
            // 
            // tbFiltroCliente
            // 
            this.tbFiltroCliente.Location = new System.Drawing.Point(15, 47);
            this.tbFiltroCliente.Name = "tbFiltroCliente";
            this.tbFiltroCliente.Size = new System.Drawing.Size(325, 20);
            this.tbFiltroCliente.TabIndex = 37;
            this.tbFiltroCliente.TextChanged += new System.EventHandler(this.tbFiltroCliente_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.tbFiltroCliente);
            this.groupBox5.Location = new System.Drawing.Point(22, 351);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(359, 79);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Consulta";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 16);
            this.label14.TabIndex = 38;
            this.label14.Text = "Nome do Cliente:";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 599);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbInfoNovoCliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormCliente";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carangaShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbInfoNovoCliente.ResumeLayout(false);
            this.gbInfoPessoais.ResumeLayout(false);
            this.gbInfoPessoais.PerformLayout();
            this.gbInfoEndereco.ResumeLayout(false);
            this.gbInfoEndereco.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bIncluirCli;
        private System.Windows.Forms.Button bSalvarCli;
        private System.Windows.Forms.Button bExcluirCli;
        private System.Windows.Forms.Button bCancelarFormCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIDCli;
        private System.Windows.Forms.TextBox tbNomeCli;
        private System.Windows.Forms.TextBox tbEmailCli;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbCPFCli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbTelefoneCli;
        private System.Windows.Forms.DateTimePicker dtpDataNascCli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCEPCliEnd;
        private System.Windows.Forms.Button bCheckCEP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbLogradouroCliEnd;
        private System.Windows.Forms.TextBox tbComplementoCliEnd;
        private System.Windows.Forms.TextBox tbBairroCliEnd;
        private System.Windows.Forms.TextBox tbCidadeCliEnd;
        private System.Windows.Forms.TextBox tbUFCliEnd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private CarangaShopDataSet carangaShopDataSet;
        private System.Windows.Forms.GroupBox gbInfoNovoCliente;
        private System.Windows.Forms.GroupBox gbInfoEndereco;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox gbInfoPessoais;
        private System.Windows.Forms.TextBox tbFiltroCliente;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
    }
}