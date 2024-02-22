using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Drawing2D;

namespace Cadastro
{
    public partial class FrmCadastro : Form
    {
        //referencia de conexao
        SqlConnection conn = new SqlConnection(@"Data Source =CARLOS\SQLEXPRESS; Initial Catalog = Cadastro; Integrated Security = True");

        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conn.ConnectionString))
                {
                    cn.Open();

                    var sql = "INSERT INTO Funcionario (ID, NOME, DTADM, VLHORA) VALUES (@ID, @NOME, @DTADM, @VLHORA)";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        // Verifique se os campos estão preenchidos antes de prosseguir
                        if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtNome.Text) ||
                            string.IsNullOrWhiteSpace(txtData.Text) || string.IsNullOrWhiteSpace(txtValorHora.Text))
                        {
                            MessageBox.Show("Por favor, preencha todos os campos.");
                            return;
                        }

                        // Verifica se o ID é numérico antes de atribuir ao parâmetro
                        if (!int.TryParse(txtID.Text, out _))
                        {
                            MessageBox.Show("O ID deve ser um número inteiro.");
                            return;
                        }

                        // Verifica se o valor da hora é numérico antes de atribuir ao parâmetro
                        if (!decimal.TryParse(txtValorHora.Text, out _))
                        {
                            MessageBox.Show("O valor da hora deve ser numérico.");
                            return;
                        }

                        if (!DateTime.TryParse(txtData.Text, out DateTime conDateTime))
                        {
                            MessageBox.Show("Formato de data inválido. Use o formato correto.");
                            return;
                        }

                        cmd.Parameters.AddWithValue("@ID", txtID.Text);
                        cmd.Parameters.AddWithValue("@NOME", txtNome.Text);
                        cmd.Parameters.AddWithValue("@DTADM", conDateTime);
                        cmd.Parameters.AddWithValue("@VLHORA", txtValorHora.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cadastro efetuado com Sucesso");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir os dados!\n\n" + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void SetBackColorDegrade(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);

            //onde muda a cor
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(0, 250, 154), Color.FromArgb(255, 255, 255), 90f);

            graphics.FillRectangle(br, gradient_rect);
        }
        private void FrmCadastro_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
            {
                // Encerrar o programa
                Close();
            }
            // Se o usuário escolher 'Não' na caixa de diálogo, o programa não será encerrado
        }

        private void acompanhamentoDeFériasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcompanhamento acomp = new frmAcompanhamento();
            acomp.Show();
        }

        private void apontamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApontamento apont = new frmApontamento();
            apont.Show();
        }

        private void cálculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculo cal = new frmCalculo();
            cal.Show();
        }

        public void acompanhamentoDeFériasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAcompanhamento acomp = new frmAcompanhamento();
            acomp.Show();
        }

        private void apontamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmApontamento apont = new frmApontamento();
            apont.Show();
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre sob = new FrmSobre();
            sob.Show();
        }
    }
} 
