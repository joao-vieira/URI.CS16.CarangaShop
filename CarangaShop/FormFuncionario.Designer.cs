namespace CarangaShop {
    partial class FormFuncionario {
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
            this.bIncluirFunc = new System.Windows.Forms.Button();
            this.bSalvarFunc = new System.Windows.Forms.Button();
            this.bExcluirFunc = new System.Windows.Forms.Button();
            this.bCancelarFormFunc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIDFunc = new System.Windows.Forms.TextBox();
            this.tbNomeFunc = new System.Windows.Forms.TextBox();
            this.tbEmailFunc = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carangaShopDataSet = new CarangaShop.CarangaShopDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbCPFFunc = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbTelefoneFunc = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataNascFunc = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCEPFuncEnd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbLogradouroFuncEnd = new System.Windows.Forms.TextBox();
            this.tbComplementoFuncEnd = new System.Windows.Forms.TextBox();
            this.tbBairroFuncEnd = new System.Windows.Forms.TextBox();
            this.tbCidadeFuncEnd = new System.Windows.Forms.TextBox();
            this.tbUFFuncEnd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbSalarioFunc = new System.Windows.Forms.TextBox();
            this.bCheckCEP = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabelaClienteTableAdapter1 = new CarangaShop.CarangaShopDataSetTableAdapters.TabelaClienteTableAdapter();
            this.gbInfoEndereco = new System.Windows.Forms.GroupBox();
            this.gbInfoPessoais = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbFiltroFuncionario = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carangaShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbInfoEndereco.SuspendLayout();
            this.gbInfoPessoais.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Funcionário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // bIncluirFunc
            // 
            this.bIncluirFunc.Location = new System.Drawing.Point(6, 19);
            this.bIncluirFunc.Name = "bIncluirFunc";
            this.bIncluirFunc.Size = new System.Drawing.Size(125, 23);
            this.bIncluirFunc.TabIndex = 2;
            this.bIncluirFunc.Text = "Incluir";
            this.bIncluirFunc.UseVisualStyleBackColor = true;
            this.bIncluirFunc.Click += new System.EventHandler(this.bIncluirFunc_Click);
            // 
            // bSalvarFunc
            // 
            this.bSalvarFunc.Location = new System.Drawing.Point(6, 48);
            this.bSalvarFunc.Name = "bSalvarFunc";
            this.bSalvarFunc.Size = new System.Drawing.Size(125, 23);
            this.bSalvarFunc.TabIndex = 3;
            this.bSalvarFunc.Text = "Salvar";
            this.bSalvarFunc.UseVisualStyleBackColor = true;
            this.bSalvarFunc.Click += new System.EventHandler(this.bSalvarFunc_Click);
            // 
            // bExcluirFunc
            // 
            this.bExcluirFunc.Location = new System.Drawing.Point(146, 49);
            this.bExcluirFunc.Name = "bExcluirFunc";
            this.bExcluirFunc.Size = new System.Drawing.Size(125, 23);
            this.bExcluirFunc.TabIndex = 4;
            this.bExcluirFunc.Text = "Excluir";
            this.bExcluirFunc.UseVisualStyleBackColor = true;
            this.bExcluirFunc.Click += new System.EventHandler(this.bExcluirFunc_Click);
            // 
            // bCancelarFormFunc
            // 
            this.bCancelarFormFunc.Location = new System.Drawing.Point(146, 20);
            this.bCancelarFormFunc.Name = "bCancelarFormFunc";
            this.bCancelarFormFunc.Size = new System.Drawing.Size(125, 23);
            this.bCancelarFormFunc.TabIndex = 5;
            this.bCancelarFormFunc.Text = "Cancelar";
            this.bCancelarFormFunc.UseVisualStyleBackColor = true;
            this.bCancelarFormFunc.Click += new System.EventHandler(this.bCancelarFormFunc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-mail:";
            // 
            // tbIDFunc
            // 
            this.tbIDFunc.Location = new System.Drawing.Point(99, 19);
            this.tbIDFunc.Name = "tbIDFunc";
            this.tbIDFunc.Size = new System.Drawing.Size(71, 20);
            this.tbIDFunc.TabIndex = 9;
            // 
            // tbNomeFunc
            // 
            this.tbNomeFunc.Location = new System.Drawing.Point(99, 55);
            this.tbNomeFunc.Name = "tbNomeFunc";
            this.tbNomeFunc.Size = new System.Drawing.Size(219, 20);
            this.tbNomeFunc.TabIndex = 10;
            // 
            // tbEmailFunc
            // 
            this.tbEmailFunc.Location = new System.Drawing.Point(407, 22);
            this.tbEmailFunc.Name = "tbEmailFunc";
            this.tbEmailFunc.Size = new System.Drawing.Size(164, 20);
            this.tbEmailFunc.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 441);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(658, 154);
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
            this.label5.Location = new System.Drawing.Point(362, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "CPF:";
            // 
            // mtbCPFFunc
            // 
            this.mtbCPFFunc.Location = new System.Drawing.Point(407, 56);
            this.mtbCPFFunc.Mask = "000,000,000-00";
            this.mtbCPFFunc.Name = "mtbCPFFunc";
            this.mtbCPFFunc.Size = new System.Drawing.Size(164, 20);
            this.mtbCPFFunc.TabIndex = 16;
            this.mtbCPFFunc.Validating += new System.ComponentModel.CancelEventHandler(this.mtbCPFFunc_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Telefone:";
            // 
            // mtbTelefoneFunc
            // 
            this.mtbTelefoneFunc.Location = new System.Drawing.Point(99, 90);
            this.mtbTelefoneFunc.Mask = "(00) 00000-0000";
            this.mtbTelefoneFunc.Name = "mtbTelefoneFunc";
            this.mtbTelefoneFunc.Size = new System.Drawing.Size(219, 20);
            this.mtbTelefoneFunc.TabIndex = 18;
            // 
            // dtpDataNascFunc
            // 
            this.dtpDataNascFunc.Location = new System.Drawing.Point(99, 122);
            this.dtpDataNascFunc.Name = "dtpDataNascFunc";
            this.dtpDataNascFunc.Size = new System.Drawing.Size(219, 20);
            this.dtpDataNascFunc.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Dt Nasc.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(362, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "CEP:";
            // 
            // tbCEPFuncEnd
            // 
            this.tbCEPFuncEnd.Location = new System.Drawing.Point(407, 121);
            this.tbCEPFuncEnd.MaxLength = 8;
            this.tbCEPFuncEnd.Name = "tbCEPFuncEnd";
            this.tbCEPFuncEnd.Size = new System.Drawing.Size(164, 20);
            this.tbCEPFuncEnd.TabIndex = 22;
            this.tbCEPFuncEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCEPFuncEnd_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Logradouro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(348, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Compl:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Bairro:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(343, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Cidade:";
            // 
            // tbLogradouroFuncEnd
            // 
            this.tbLogradouroFuncEnd.Location = new System.Drawing.Point(99, 23);
            this.tbLogradouroFuncEnd.Name = "tbLogradouroFuncEnd";
            this.tbLogradouroFuncEnd.Size = new System.Drawing.Size(219, 20);
            this.tbLogradouroFuncEnd.TabIndex = 29;
            // 
            // tbComplementoFuncEnd
            // 
            this.tbComplementoFuncEnd.Location = new System.Drawing.Point(407, 19);
            this.tbComplementoFuncEnd.Name = "tbComplementoFuncEnd";
            this.tbComplementoFuncEnd.Size = new System.Drawing.Size(164, 20);
            this.tbComplementoFuncEnd.TabIndex = 30;
            // 
            // tbBairroFuncEnd
            // 
            this.tbBairroFuncEnd.Location = new System.Drawing.Point(99, 52);
            this.tbBairroFuncEnd.Name = "tbBairroFuncEnd";
            this.tbBairroFuncEnd.Size = new System.Drawing.Size(219, 20);
            this.tbBairroFuncEnd.TabIndex = 31;
            // 
            // tbCidadeFuncEnd
            // 
            this.tbCidadeFuncEnd.Location = new System.Drawing.Point(407, 51);
            this.tbCidadeFuncEnd.Name = "tbCidadeFuncEnd";
            this.tbCidadeFuncEnd.Size = new System.Drawing.Size(164, 20);
            this.tbCidadeFuncEnd.TabIndex = 32;
            // 
            // tbUFFuncEnd
            // 
            this.tbUFFuncEnd.Location = new System.Drawing.Point(577, 51);
            this.tbUFFuncEnd.Name = "tbUFFuncEnd";
            this.tbUFFuncEnd.Size = new System.Drawing.Size(47, 20);
            this.tbUFFuncEnd.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(343, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 16);
            this.label13.TabIndex = 34;
            this.label13.Text = "Salário:";
            // 
            // tbSalarioFunc
            // 
            this.tbSalarioFunc.Location = new System.Drawing.Point(407, 88);
            this.tbSalarioFunc.MaxLength = 9;
            this.tbSalarioFunc.Name = "tbSalarioFunc";
            this.tbSalarioFunc.Size = new System.Drawing.Size(164, 20);
            this.tbSalarioFunc.TabIndex = 35;
            this.tbSalarioFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalarioFunc_KeyPress);
            // 
            // bCheckCEP
            // 
            this.bCheckCEP.Image = global::CarangaShop.Properties.Resources.search1;
            this.bCheckCEP.Location = new System.Drawing.Point(577, 116);
            this.bCheckCEP.Name = "bCheckCEP";
            this.bCheckCEP.Size = new System.Drawing.Size(37, 29);
            this.bCheckCEP.TabIndex = 23;
            this.bCheckCEP.UseVisualStyleBackColor = true;
            this.bCheckCEP.Click += new System.EventHandler(this.bCheckCEP_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Olive;
            this.label14.Location = new System.Drawing.Point(347, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(277, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Um CEP válido contém 8 dígitos. Digite apenas números!";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabelaClienteTableAdapter1
            // 
            this.tabelaClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // gbInfoEndereco
            // 
            this.gbInfoEndereco.Controls.Add(this.label9);
            this.gbInfoEndereco.Controls.Add(this.label10);
            this.gbInfoEndereco.Controls.Add(this.label11);
            this.gbInfoEndereco.Controls.Add(this.label12);
            this.gbInfoEndereco.Controls.Add(this.tbUFFuncEnd);
            this.gbInfoEndereco.Controls.Add(this.tbLogradouroFuncEnd);
            this.gbInfoEndereco.Controls.Add(this.tbCidadeFuncEnd);
            this.gbInfoEndereco.Controls.Add(this.tbComplementoFuncEnd);
            this.gbInfoEndereco.Controls.Add(this.tbBairroFuncEnd);
            this.gbInfoEndereco.Location = new System.Drawing.Point(14, 195);
            this.gbInfoEndereco.Name = "gbInfoEndereco";
            this.gbInfoEndereco.Size = new System.Drawing.Size(632, 87);
            this.gbInfoEndereco.TabIndex = 37;
            this.gbInfoEndereco.TabStop = false;
            this.gbInfoEndereco.Text = "Informações do Endereço";
            // 
            // gbInfoPessoais
            // 
            this.gbInfoPessoais.Controls.Add(this.label2);
            this.gbInfoPessoais.Controls.Add(this.label3);
            this.gbInfoPessoais.Controls.Add(this.label14);
            this.gbInfoPessoais.Controls.Add(this.label4);
            this.gbInfoPessoais.Controls.Add(this.bCheckCEP);
            this.gbInfoPessoais.Controls.Add(this.tbSalarioFunc);
            this.gbInfoPessoais.Controls.Add(this.tbCEPFuncEnd);
            this.gbInfoPessoais.Controls.Add(this.tbIDFunc);
            this.gbInfoPessoais.Controls.Add(this.label8);
            this.gbInfoPessoais.Controls.Add(this.label13);
            this.gbInfoPessoais.Controls.Add(this.tbNomeFunc);
            this.gbInfoPessoais.Controls.Add(this.tbEmailFunc);
            this.gbInfoPessoais.Controls.Add(this.label5);
            this.gbInfoPessoais.Controls.Add(this.mtbCPFFunc);
            this.gbInfoPessoais.Controls.Add(this.label7);
            this.gbInfoPessoais.Controls.Add(this.label6);
            this.gbInfoPessoais.Controls.Add(this.dtpDataNascFunc);
            this.gbInfoPessoais.Controls.Add(this.mtbTelefoneFunc);
            this.gbInfoPessoais.Location = new System.Drawing.Point(14, 19);
            this.gbInfoPessoais.Name = "gbInfoPessoais";
            this.gbInfoPessoais.Size = new System.Drawing.Size(632, 170);
            this.gbInfoPessoais.TabIndex = 38;
            this.gbInfoPessoais.TabStop = false;
            this.gbInfoPessoais.Text = "Informações Pessoais";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gbInfoPessoais);
            this.groupBox3.Controls.Add(this.gbInfoEndereco);
            this.groupBox3.Location = new System.Drawing.Point(37, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(658, 295);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações do Novo Funcionário";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bIncluirFunc);
            this.groupBox4.Controls.Add(this.bSalvarFunc);
            this.groupBox4.Controls.Add(this.bCancelarFormFunc);
            this.groupBox4.Controls.Add(this.bExcluirFunc);
            this.groupBox4.Location = new System.Drawing.Point(412, 354);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 81);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ações de controle do formulário";
            // 
            // tbFiltroFuncionario
            // 
            this.tbFiltroFuncionario.Location = new System.Drawing.Point(17, 48);
            this.tbFiltroFuncionario.Name = "tbFiltroFuncionario";
            this.tbFiltroFuncionario.Size = new System.Drawing.Size(304, 20);
            this.tbFiltroFuncionario.TabIndex = 41;
            this.tbFiltroFuncionario.TextChanged += new System.EventHandler(this.tbFiltroFuncionario_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.tbFiltroFuncionario);
            this.groupBox5.Location = new System.Drawing.Point(37, 354);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(369, 81);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Consulta";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 16);
            this.label15.TabIndex = 42;
            this.label15.Text = "Nome do Funcionário:";
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 619);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormFuncionario";
            this.Text = "Cadastro de Funcionário";
            this.Load += new System.EventHandler(this.FormFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carangaShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbInfoEndereco.ResumeLayout(false);
            this.gbInfoEndereco.PerformLayout();
            this.gbInfoPessoais.ResumeLayout(false);
            this.gbInfoPessoais.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bIncluirFunc;
        private System.Windows.Forms.Button bSalvarFunc;
        private System.Windows.Forms.Button bExcluirFunc;
        private System.Windows.Forms.Button bCancelarFormFunc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIDFunc;
        private System.Windows.Forms.TextBox tbNomeFunc;
        private System.Windows.Forms.TextBox tbEmailFunc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbCPFFunc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbTelefoneFunc;
        private System.Windows.Forms.DateTimePicker dtpDataNascFunc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bCheckCEP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbLogradouroFuncEnd;
        private System.Windows.Forms.TextBox tbComplementoFuncEnd;
        private System.Windows.Forms.TextBox tbBairroFuncEnd;
        private System.Windows.Forms.TextBox tbCidadeFuncEnd;
        private System.Windows.Forms.TextBox tbUFFuncEnd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbSalarioFunc;
        private CarangaShopDataSetTableAdapters.TabelaClienteTableAdapter tabelaClienteTableAdapter1;
        public System.Windows.Forms.TextBox tbCEPFuncEnd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private CarangaShopDataSet carangaShopDataSet;
        private System.Windows.Forms.GroupBox gbInfoEndereco;
        private System.Windows.Forms.GroupBox gbInfoPessoais;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbFiltroFuncionario;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label15;
    }
}