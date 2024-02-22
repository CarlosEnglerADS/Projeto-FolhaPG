namespace Cadastro
{
    partial class frmCalculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.txtINSS = new System.Windows.Forms.TextBox();
            this.txtIRRF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.txtHorasNoMes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mskDTADM = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acompanhamentoDeFériasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apontamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeOcorrênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosDesligadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroDeFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apontamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acompanhamentoDeFériasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnminimiza = new System.Windows.Forms.Button();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.btnB_Nome = new System.Windows.Forms.Button();
            this.btnDesligamento = new System.Windows.Forms.Button();
            this.txtSomaGeralFolha = new System.Windows.Forms.TextBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalFolha = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salário Bruto";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Desconto INSS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Desconto IRRF";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(130, 150);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(38, 21);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(130, 182);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 21);
            this.textBox2.TabIndex = 6;
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBruto.Location = new System.Drawing.Point(398, 156);
            this.txtSalarioBruto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(57, 21);
            this.txtSalarioBruto.TabIndex = 7;
            // 
            // txtINSS
            // 
            this.txtINSS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtINSS.Location = new System.Drawing.Point(398, 187);
            this.txtINSS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtINSS.Name = "txtINSS";
            this.txtINSS.Size = new System.Drawing.Size(98, 21);
            this.txtINSS.TabIndex = 8;
            // 
            // txtIRRF
            // 
            this.txtIRRF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIRRF.Location = new System.Drawing.Point(398, 218);
            this.txtIRRF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIRRF.Name = "txtIRRF";
            this.txtIRRF.Size = new System.Drawing.Size(98, 21);
            this.txtIRRF.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Salário Líquido";
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioLiquido.Location = new System.Drawing.Point(398, 250);
            this.txtSalarioLiquido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(98, 21);
            this.txtSalarioLiquido.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 250);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Valor Hora";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 282);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Horas No Mês";
            // 
            // txtValorHora
            // 
            this.txtValorHora.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorHora.Location = new System.Drawing.Point(130, 244);
            this.txtValorHora.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(57, 21);
            this.txtValorHora.TabIndex = 16;
            // 
            // txtHorasNoMes
            // 
            this.txtHorasNoMes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasNoMes.Location = new System.Drawing.Point(130, 273);
            this.txtHorasNoMes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHorasNoMes.Name = "txtHorasNoMes";
            this.txtHorasNoMes.Size = new System.Drawing.Size(57, 21);
            this.txtHorasNoMes.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(105, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(296, 36);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cálculo do Sálario";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(162, 329);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(101, 22);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 57);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cálculo Todos Funcionários";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(454, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExibir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExibir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExibir.ForeColor = System.Drawing.Color.Black;
            this.btnExibir.Location = new System.Drawing.Point(280, 327);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(107, 22);
            this.btnExibir.TabIndex = 21;
            this.btnExibir.Text = "Exibir Holerite";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(48, 361);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 23);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar Todos";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 390);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 152);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mskDTADM
            // 
            this.mskDTADM.Location = new System.Drawing.Point(130, 212);
            this.mskDTADM.Name = "mskDTADM";
            this.mskDTADM.Size = new System.Drawing.Size(61, 21);
            this.mskDTADM.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(11, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "DataAdmissão";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 91);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(48, 329);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(95, 25);
            this.btnLimpar.TabIndex = 27;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acompanhamentoDeFériasToolStripMenuItem,
            this.apontamentoToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.registroDeOcorrênciasToolStripMenuItem,
            this.funcionáriosDesligadosToolStripMenuItem});
            this.mENUToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mENUToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.mENUToolStripMenuItem.Text = "MENU ";
            this.mENUToolStripMenuItem.Click += new System.EventHandler(this.mENUToolStripMenuItem_Click);
            // 
            // acompanhamentoDeFériasToolStripMenuItem
            // 
            this.acompanhamentoDeFériasToolStripMenuItem.BackgroundImage = global::Cadastro.Properties.Resources.fundo21;
            this.acompanhamentoDeFériasToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.acompanhamentoDeFériasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acompanhamentoDeFériasToolStripMenuItem.Name = "acompanhamentoDeFériasToolStripMenuItem";
            this.acompanhamentoDeFériasToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.acompanhamentoDeFériasToolStripMenuItem.Text = "Acompanhamento de Férias";
            this.acompanhamentoDeFériasToolStripMenuItem.Click += new System.EventHandler(this.acompanhamentoDeFériasToolStripMenuItem_Click);
            // 
            // apontamentoToolStripMenuItem
            // 
            this.apontamentoToolStripMenuItem.BackgroundImage = global::Cadastro.Properties.Resources.fundo_fw;
            this.apontamentoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.apontamentoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.apontamentoToolStripMenuItem.Name = "apontamentoToolStripMenuItem";
            this.apontamentoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.apontamentoToolStripMenuItem.Text = "Apontamento";
            this.apontamentoToolStripMenuItem.Click += new System.EventHandler(this.apontamentoToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.BackgroundImage = global::Cadastro.Properties.Resources.fundo21;
            this.cadastroToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // registroDeOcorrênciasToolStripMenuItem
            // 
            this.registroDeOcorrênciasToolStripMenuItem.Name = "registroDeOcorrênciasToolStripMenuItem";
            this.registroDeOcorrênciasToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.registroDeOcorrênciasToolStripMenuItem.Text = "Registro de Ocorrências";
            this.registroDeOcorrênciasToolStripMenuItem.Click += new System.EventHandler(this.registroDeOcorrênciasToolStripMenuItem_Click_1);
            // 
            // funcionáriosDesligadosToolStripMenuItem
            // 
            this.funcionáriosDesligadosToolStripMenuItem.Name = "funcionáriosDesligadosToolStripMenuItem";
            this.funcionáriosDesligadosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.funcionáriosDesligadosToolStripMenuItem.Text = "Funcionários Desligados";
            this.funcionáriosDesligadosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosDesligadosToolStripMenuItem_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Cadastro.Properties.Resources.fundo21;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem,
            this.cadastroDeFuncionáriosToolStripMenuItem,
            this.apontamentosToolStripMenuItem,
            this.acompanhamentoDeFériasToolStripMenuItem1,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroDeFuncionáriosToolStripMenuItem
            // 
            this.cadastroDeFuncionáriosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cadastroDeFuncionáriosToolStripMenuItem.Name = "cadastroDeFuncionáriosToolStripMenuItem";
            this.cadastroDeFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.cadastroDeFuncionáriosToolStripMenuItem.Text = "Cadastro de Funcionários";
            this.cadastroDeFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFuncionáriosToolStripMenuItem_Click);
            // 
            // apontamentosToolStripMenuItem
            // 
            this.apontamentosToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.apontamentosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.apontamentosToolStripMenuItem.Name = "apontamentosToolStripMenuItem";
            this.apontamentosToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.apontamentosToolStripMenuItem.Text = "Apontamento";
            this.apontamentosToolStripMenuItem.Click += new System.EventHandler(this.apontamentosToolStripMenuItem_Click);
            // 
            // acompanhamentoDeFériasToolStripMenuItem1
            // 
            this.acompanhamentoDeFériasToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.acompanhamentoDeFériasToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.acompanhamentoDeFériasToolStripMenuItem1.Name = "acompanhamentoDeFériasToolStripMenuItem1";
            this.acompanhamentoDeFériasToolStripMenuItem1.Size = new System.Drawing.Size(168, 20);
            this.acompanhamentoDeFériasToolStripMenuItem1.Text = "Acompanhamento de Férias";
            this.acompanhamentoDeFériasToolStripMenuItem1.Click += new System.EventHandler(this.acompanhamentoDeFériasToolStripMenuItem1_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // btnminimiza
            // 
            this.btnminimiza.BackColor = System.Drawing.Color.Gainsboro;
            this.btnminimiza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnminimiza.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnminimiza.ForeColor = System.Drawing.Color.Black;
            this.btnminimiza.Location = new System.Drawing.Point(454, 56);
            this.btnminimiza.Name = "btnminimiza";
            this.btnminimiza.Size = new System.Drawing.Size(75, 23);
            this.btnminimiza.TabIndex = 29;
            this.btnminimiza.Text = "Minimiza";
            this.btnminimiza.UseVisualStyleBackColor = false;
            this.btnminimiza.Click += new System.EventHandler(this.btnminimiza_Click);
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Location = new System.Drawing.Point(280, 361);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(144, 21);
            this.txtBuscaNome.TabIndex = 31;
            // 
            // btnB_Nome
            // 
            this.btnB_Nome.Location = new System.Drawing.Point(162, 359);
            this.btnB_Nome.Name = "btnB_Nome";
            this.btnB_Nome.Size = new System.Drawing.Size(101, 25);
            this.btnB_Nome.TabIndex = 32;
            this.btnB_Nome.Text = "Buscar Nome ";
            this.btnB_Nome.UseVisualStyleBackColor = true;
            this.btnB_Nome.Click += new System.EventHandler(this.btnB_Nome_Click);
            // 
            // btnDesligamento
            // 
            this.btnDesligamento.Location = new System.Drawing.Point(401, 302);
            this.btnDesligamento.Name = "btnDesligamento";
            this.btnDesligamento.Size = new System.Drawing.Size(95, 47);
            this.btnDesligamento.TabIndex = 33;
            this.btnDesligamento.Text = "Desligar Funcionario";
            this.btnDesligamento.UseVisualStyleBackColor = true;
            this.btnDesligamento.Click += new System.EventHandler(this.Button3_Click);
            // 
            // txtSomaGeralFolha
            // 
            this.txtSomaGeralFolha.Location = new System.Drawing.Point(101, 95);
            this.txtSomaGeralFolha.Name = "txtSomaGeralFolha";
            this.txtSomaGeralFolha.Size = new System.Drawing.Size(109, 21);
            this.txtSomaGeralFolha.TabIndex = 35;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(216, 66);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(75, 57);
            this.btnRelatorio.TabIndex = 36;
            this.btnRelatorio.Text = "Mostrar Relatorio";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(192, 551);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 15);
            this.label11.TabIndex = 37;
            this.label11.Text = "Valor Tota de Folha de Pagamento";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtTotalFolha
            // 
            this.txtTotalFolha.Location = new System.Drawing.Point(396, 547);
            this.txtTotalFolha.Name = "txtTotalFolha";
            this.txtTotalFolha.Size = new System.Drawing.Size(133, 21);
            this.txtTotalFolha.TabIndex = 38;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(101, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 39;
            this.button3.Text = "Zera Folha/Nova";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // frmCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::Cadastro.Properties.Resources.fundo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(541, 587);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtTotalFolha);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.txtSomaGeralFolha);
            this.Controls.Add(this.btnDesligamento);
            this.Controls.Add(this.btnB_Nome);
            this.Controls.Add(this.txtBuscaNome);
            this.Controls.Add(this.btnminimiza);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mskDTADM);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHorasNoMes);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIRRF);
            this.Controls.Add(this.txtINSS);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmCalculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCalculo";
            this.Load += new System.EventHandler(this.frmCalculo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmCalculo_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.TextBox txtINSS;
        private System.Windows.Forms.TextBox txtIRRF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.TextBox txtHorasNoMes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mskDTADM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acompanhamentoDeFériasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apontamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apontamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acompanhamentoDeFériasToolStripMenuItem1;
        private System.Windows.Forms.Button btnminimiza;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.Button btnB_Nome;
        private System.Windows.Forms.Button btnDesligamento;
        private System.Windows.Forms.ToolStripMenuItem registroDeOcorrênciasToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSomaGeralFolha;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalFolha;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosDesligadosToolStripMenuItem;
        private System.Windows.Forms.Button button3;
    }
}