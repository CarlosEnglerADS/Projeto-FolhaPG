using System;

namespace Cadastro
{
    partial class frmApontamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApontamento));
            this.label1 = new System.Windows.Forms.Label();
            this.txtID_Func = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataApontamento = new System.Windows.Forms.TextBox();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.txtHorasDia = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acompanhamentoDeFériasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acompanhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscar_ID = new System.Windows.Forms.Button();
            this.bntTD_Apontamentos = new System.Windows.Forms.Button();
            this.lblTotal_Hora_Mes = new System.Windows.Forms.Label();
            this.txtTotalHoraNoMesCorrente = new System.Windows.Forms.TextBox();
            this.btnZerarApontamenntosMensalDesteID = new System.Windows.Forms.Button();
            this.btnAdTotalHoras = new System.Windows.Forms.Button();
            this.btnExcluirApont = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÓDIGO  FUNCIONARIO";
            // 
            // txtID_Func
            // 
            this.txtID_Func.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_Func.Location = new System.Drawing.Point(197, 52);
            this.txtID_Func.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID_Func.Name = "txtID_Func";
            this.txtID_Func.Size = new System.Drawing.Size(33, 21);
            this.txtID_Func.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data De Apontamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hora Saida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Horas Dia";
            // 
            // txtDataApontamento
            // 
            this.txtDataApontamento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataApontamento.Location = new System.Drawing.Point(197, 76);
            this.txtDataApontamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDataApontamento.Name = "txtDataApontamento";
            this.txtDataApontamento.Size = new System.Drawing.Size(69, 21);
            this.txtDataApontamento.TabIndex = 6;
            // 
            // txtEntrada
            // 
            this.txtEntrada.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(197, 103);
            this.txtEntrada.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(56, 21);
            this.txtEntrada.TabIndex = 7;
            // 
            // txtSaida
            // 
            this.txtSaida.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaida.Location = new System.Drawing.Point(197, 128);
            this.txtSaida.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(56, 21);
            this.txtSaida.TabIndex = 8;
            // 
            // txtHorasDia
            // 
            this.txtHorasDia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasDia.Location = new System.Drawing.Point(197, 154);
            this.txtHorasDia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHorasDia.Name = "txtHorasDia";
            this.txtHorasDia.Size = new System.Drawing.Size(56, 21);
            this.txtHorasDia.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(12, 223);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(69, 57);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Apontar Horas Diarias";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(26, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Apontamento de Horas ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(392, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Cadastro.Properties.Resources.fundo21;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.acompanhamentoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(477, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acompanhamentoDeFériasToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.calculoToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // acompanhamentoDeFériasToolStripMenuItem
            // 
            this.acompanhamentoDeFériasToolStripMenuItem.BackgroundImage = global::Cadastro.Properties.Resources.fundo21;
            this.acompanhamentoDeFériasToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.acompanhamentoDeFériasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.acompanhamentoDeFériasToolStripMenuItem.Name = "acompanhamentoDeFériasToolStripMenuItem";
            this.acompanhamentoDeFériasToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.acompanhamentoDeFériasToolStripMenuItem.Text = "Acompanhamento de Férias";
            this.acompanhamentoDeFériasToolStripMenuItem.Click += new System.EventHandler(this.acompanhamentoDeFériasToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.BackgroundImage = global::Cadastro.Properties.Resources.fundo_fw;
            this.cadastroToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // calculoToolStripMenuItem
            // 
            this.calculoToolStripMenuItem.BackgroundImage = global::Cadastro.Properties.Resources.fundo21;
            this.calculoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calculoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.calculoToolStripMenuItem.Name = "calculoToolStripMenuItem";
            this.calculoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.calculoToolStripMenuItem.Text = "Cálculo";
            this.calculoToolStripMenuItem.Click += new System.EventHandler(this.calculoToolStripMenuItem_Click);
            // 
            // acompanhamentoToolStripMenuItem
            // 
            this.acompanhamentoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.acompanhamentoToolStripMenuItem.Name = "acompanhamentoToolStripMenuItem";
            this.acompanhamentoToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.acompanhamentoToolStripMenuItem.Text = "Acompanhamento ";
            this.acompanhamentoToolStripMenuItem.Click += new System.EventHandler(this.acompanhamentoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(392, 50);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Minimiza";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(274, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(453, 150);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnBuscar_ID
            // 
            this.btnBuscar_ID.Location = new System.Drawing.Point(102, 223);
            this.btnBuscar_ID.Name = "btnBuscar_ID";
            this.btnBuscar_ID.Size = new System.Drawing.Size(75, 57);
            this.btnBuscar_ID.TabIndex = 18;
            this.btnBuscar_ID.Text = "Busca por ID";
            this.btnBuscar_ID.UseVisualStyleBackColor = true;
            this.btnBuscar_ID.Click += new System.EventHandler(this.btnBuscar_ID_Click);
            // 
            // bntTD_Apontamentos
            // 
            this.bntTD_Apontamentos.Location = new System.Drawing.Point(344, 226);
            this.bntTD_Apontamentos.Name = "bntTD_Apontamentos";
            this.bntTD_Apontamentos.Size = new System.Drawing.Size(121, 53);
            this.bntTD_Apontamentos.TabIndex = 19;
            this.bntTD_Apontamentos.Text = "Visualizar Todos os Apontamentos";
            this.bntTD_Apontamentos.UseVisualStyleBackColor = true;
            this.bntTD_Apontamentos.Click += new System.EventHandler(this.bntTD_Apontamentos_Click);
            // 
            // lblTotal_Hora_Mes
            // 
            this.lblTotal_Hora_Mes.AutoSize = true;
            this.lblTotal_Hora_Mes.Location = new System.Drawing.Point(6, 182);
            this.lblTotal_Hora_Mes.Name = "lblTotal_Hora_Mes";
            this.lblTotal_Hora_Mes.Size = new System.Drawing.Size(166, 13);
            this.lblTotal_Hora_Mes.TabIndex = 20;
            this.lblTotal_Hora_Mes.Text = "Total Hora No Mes Corrente";
            // 
            // txtTotalHoraNoMesCorrente
            // 
            this.txtTotalHoraNoMesCorrente.Location = new System.Drawing.Point(197, 182);
            this.txtTotalHoraNoMesCorrente.Name = "txtTotalHoraNoMesCorrente";
            this.txtTotalHoraNoMesCorrente.Size = new System.Drawing.Size(56, 20);
            this.txtTotalHoraNoMesCorrente.TabIndex = 21;
            // 
            // btnZerarApontamenntosMensalDesteID
            // 
            this.btnZerarApontamenntosMensalDesteID.Location = new System.Drawing.Point(197, 225);
            this.btnZerarApontamenntosMensalDesteID.Name = "btnZerarApontamenntosMensalDesteID";
            this.btnZerarApontamenntosMensalDesteID.Size = new System.Drawing.Size(133, 55);
            this.btnZerarApontamenntosMensalDesteID.TabIndex = 22;
            this.btnZerarApontamenntosMensalDesteID.Text = "Zerar Apontamentos Mensal  Deste Funcionário";
            this.btnZerarApontamenntosMensalDesteID.UseVisualStyleBackColor = true;
            this.btnZerarApontamenntosMensalDesteID.Click += new System.EventHandler(this.btnZerarApontamenntosMensalDesteID_Click);
            // 
            // btnAdTotalHoras
            // 
            this.btnAdTotalHoras.Location = new System.Drawing.Point(392, 157);
            this.btnAdTotalHoras.Name = "btnAdTotalHoras";
            this.btnAdTotalHoras.Size = new System.Drawing.Size(75, 63);
            this.btnAdTotalHoras.TabIndex = 23;
            this.btnAdTotalHoras.Text = "Adiciona Total de Horas";
            this.btnAdTotalHoras.UseVisualStyleBackColor = true;
            this.btnAdTotalHoras.Click += new System.EventHandler(this.btnAdTotalHoras_Click);
            // 
            // btnExcluirApont
            // 
            this.btnExcluirApont.Location = new System.Drawing.Point(392, 128);
            this.btnExcluirApont.Name = "btnExcluirApont";
            this.btnExcluirApont.Size = new System.Drawing.Size(75, 21);
            this.btnExcluirApont.TabIndex = 24;
            this.btnExcluirApont.Text = "Exclusão de Apontamentos";
            this.btnExcluirApont.UseVisualStyleBackColor = true;
            this.btnExcluirApont.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmApontamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Cadastro.Properties.Resources.fundo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(477, 477);
            this.Controls.Add(this.btnExcluirApont);
            this.Controls.Add(this.btnAdTotalHoras);
            this.Controls.Add(this.btnZerarApontamenntosMensalDesteID);
            this.Controls.Add(this.txtTotalHoraNoMesCorrente);
            this.Controls.Add(this.lblTotal_Hora_Mes);
            this.Controls.Add(this.bntTD_Apontamentos);
            this.Controls.Add(this.btnBuscar_ID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtHorasDia);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.txtDataApontamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID_Func);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmApontamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmApontamento";
            this.Load += new System.EventHandler(this.frmApontamento_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmApontamento_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnSlavar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID_Func;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDataApontamento;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.TextBox txtHorasDia;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acompanhamentoDeFériasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acompanhamentoToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscar_ID;
        private System.Windows.Forms.Button bntTD_Apontamentos;
        private System.Windows.Forms.Label lblTotal_Hora_Mes;
        private System.Windows.Forms.TextBox txtTotalHoraNoMesCorrente;
        private System.Windows.Forms.Button btnZerarApontamenntosMensalDesteID;
        private System.Windows.Forms.Button btnAdTotalHoras;
        private System.Windows.Forms.Button btnExcluirApont;
    }
}