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


namespace LoginCharpBDFolhaDePag
{
    public partial class FrmLogin : Form
    {
        SqlConnection Conexao = new SqlConnection(@"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=LoginCharp;Integrated Security=True");

        public FrmLogin()
        {
            InitializeComponent();
            txtUsuario.Select();
            label1.Click += label1_Click; // Associação do evento de clique do rótulo
            this.Load += FrmLogin_Load; // Associação do evento Load do formulário
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Lógica a ser executada quando o formulário é carregado
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Open();

                string query = "SELECT * FROM Usuario WHERE Username = @username AND Password = @password";
                SqlCommand cmd = new SqlCommand(query, Conexao);
                cmd.Parameters.AddWithValue("@username", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dp.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    FrmPrincipal1 Principal = new FrmPrincipal1();
                    this.Hide();
                    Principal.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtUsuario.Text = "";
                txtPassword.Text = "";
                txtUsuario.Select();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de conexão com o banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja encerrar o programa Contabilly?", "Confirmação de Encerramento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Lógica para lidar com o clique do rótulo (se necessário)
        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            FrmSplash frm = new FrmSplash();
            frm.ShowDialog();
        }
    }
}