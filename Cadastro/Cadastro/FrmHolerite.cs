using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cadastro
{
    public partial class FrmHolerite : Form
    {
        private string iD;
        private string nome;
        private string valorHora;
        private string salarioBruto;
        private string iNSS;
        private string iRFF;
        private string salarioLiquido;
        private string HorasNoMes;

        public FrmHolerite()
        {
            InitializeComponent();
        }

        public FrmHolerite(string ID, string Nome, string ValorHora, string HorasNoMes, string SalarioBruto, string INSS, string IRRF, string SalarioLiquido)
        {
            InitializeComponent();

            textBox1.Text = ID;
            textBox2.Text = Nome;
            txtHorasNoMes.Text = HorasNoMes;
            txtValorHora.Text = ValorHora;
            textBox5.Text = SalarioBruto;
            textBox6.Text = INSS;
            textBox7.Text = IRRF;
            textBox8.Text = SalarioLiquido;

            // Atualizando os valores das variáveis internas
            iD = ID;
            nome = Nome;
            valorHora = ValorHora;
            salarioBruto = SalarioBruto;
            iNSS = INSS;
            iRFF = IRRF;
            salarioLiquido = SalarioLiquido;
            this.HorasNoMes = HorasNoMes; // Atualizando o valor da variável HorasNoMes
        }


        public void FrmHolerite_Load(object sender, EventArgs e)
        {
            // Obtém a data e hora atuais
            DateTime dataAtual = DateTime.Now;

            // Exibe a data no formato desejado na TextBox chamada txtData
            txtData.Text = dataAtual.ToString("dd/MM/yyyy");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label30_Click(object sender, EventArgs e)
        {

        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por favor, conecte uma impressora.", "Conectar Impressora", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string ID = textBox1.Text;
            string Nome = textBox2.Text;
            string ValorHora = txtValorHora.Text;
            string SalarioBruto = textBox5.Text;
            string INSS = textBox6.Text;
            string IRRF = textBox7.Text;
            string SalarioLiquido = textBox8.Text;
            string HorasNoMes = txtHorasNoMes.Text;

            if (int.TryParse(HorasNoMes, out int horasNoMes))
            {
                InserirDadosNoHolerite(ID, Nome, ValorHora, SalarioBruto, INSS, IRRF, SalarioLiquido, horasNoMes);
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor numérico para Horas no Mês.");
            }
        }

        private void InserirDadosNoHolerite(string ID, string Nome, string ValorHora, string SalarioBruto, string INSS, string IRRF, string SalarioLiquido, int HorasNoMes)
        {
            try
            {
                string connectionString = @"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Holerite (ID, Nome, ValorHora, SalarioBruto, INSS, IRRF, SalarioLiquido, HorasNoMes) " +
                                   "VALUES (@ID, @Nome, @ValorHora, @SalarioBruto, @INSS, @IRRF, @SalarioLiquido, @HorasNoMes)";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@Nome", Nome);
                    command.Parameters.AddWithValue("@ValorHora", ValorHora);
                    command.Parameters.AddWithValue("@SalarioBruto", SalarioBruto);
                    command.Parameters.AddWithValue("@INSS", INSS);
                    command.Parameters.AddWithValue("@IRRF", IRRF);
                    command.Parameters.AddWithValue("@SalarioLiquido", SalarioLiquido);
                    command.Parameters.AddWithValue("@HorasNoMes", HorasNoMes);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dados salvos na tabela Holerite com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao salvar os dados na tabela Holerite.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir dados na tabela Holerite: " + ex.Message);
            }
        }
    }
}