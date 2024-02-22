using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCharpBDFolhaDePag
{
    public partial class FrmCadUser : Form
    {
        string connectionString = @"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=LoginCharp;Integrated Security=True";

        public string Username { get; private set; }

        public FrmCadUser()
        {
            InitializeComponent();
        }
        private bool UsuarioExiste(string username)
        {
            string query = "SELECT COUNT(*) FROM Usuario WHERE Username = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                try
                {
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao verificar se o usuário já existe: " + ex.Message);
                    return false;
                }
            }
        }

        private bool ValidarSenha(string password)
        {
            if (password.Length < 8 || !Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,}$"))
            {
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (!ValidarSenha(password))
            {
                MessageBox.Show("A senha deve ter pelo menos 8 caracteres, incluindo uma letra maiúscula, uma letra minúscula, um número e um caractere especial.");
                return;
            }

            if (UsuarioExiste(username))
            {
                MessageBox.Show("Já existe um usuário com esse nome. Escolha um nome de usuário diferente.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Usuario (Username, Password) VALUES (@Username, @Password)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dados salvos com sucesso na tabela!");
                        CarregarDados();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível salvar os dados na tabela.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar na tabela: " + ex.Message);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nomeUsuarioSelecionado = dataGridView1.SelectedRows[0].Cells["Username"].Value.ToString();

                // Sua string de conexão com o banco de dados
                string connectionString = @"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=LoginCharp;Integrated Security=True";

                // Consulta SQL para excluir o usuário da tabela
                string query = "DELETE FROM Usuario WHERE Username = @Username";

                // Cria a conexão com o banco de dados usando a string de conexão
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Cria o comando SQL e atribui a conexão e a consulta
                    SqlCommand command = new SqlCommand(query, connection);

                    // Adiciona o parâmetro (nome do usuário) ao comando SQL
                    command.Parameters.AddWithValue("@Username", nomeUsuarioSelecionado);

                    try
                    {
                        // Abre a conexão com o banco de dados
                        connection.Open();

                        // Executa o comando SQL (exclui o usuário da tabela)
                        int rowsAffected = command.ExecuteNonQuery();

                        // Verifica se a exclusão foi realizada com sucesso
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuário excluído com sucesso!");
                            // Atualize o DataGridView após a exclusão se necessário
                            CarregarDados(); // Método para recarregar os dados no DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado ou não foi possível excluir.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir o usuário: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um usuário para excluir.");
            }
        }

        // Método para carregar os dados no DataGridView
        private void CarregarDados()
        {
            // Sua string de conexão com o banco de dados
            string connectionString = @"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=LoginCharp;Integrated Security=True";

            // Consulta SQL para buscar todos os usuários
            string query = "SELECT Username FROM Usuario";

            // Cria a conexão com o banco de dados usando a string de conexão
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Cria o adaptador de dados
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();

                try
                {
                    // Abre a conexão com o banco de dados e preenche o DataTable
                    connection.Open();
                    da.Fill(dt);

                    // Define a fonte de dados do DataGridView como o DataTable
                    dataGridView1.DataSource = dt;

                    // Oculta a coluna do ID (se houver) para o usuário
                    if (dataGridView1.Columns.Contains("ID"))
                        dataGridView1.Columns["ID"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Obter o nome do usuário para buscar
            string nomeUsuario = txtBuscaUser.Text.Trim(); // Supondo que txtBuscaUser é o TextBox onde o usuário insere o nome para buscar

            // Sua string de conexão com o banco de dados
            string connectionString = @"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=LoginCharp;Integrated Security=True";

            // Consulta SQL para buscar usuários com base no nome
            string query = "SELECT Username FROM Usuario WHERE Username LIKE @Username";

            // Cria a conexão com o banco de dados usando a string de conexão
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Cria o comando SQL e atribui a conexão e a consulta
                SqlCommand command = new SqlCommand(query, connection);

                // Adiciona o parâmetro (nome do usuário) ao comando SQL
                command.Parameters.AddWithValue("@Username", "%" + nomeUsuario + "%");

                try
                {
                    // Cria um adaptador de dados para preencher o DataGridView
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();

                    // Abre a conexão com o banco de dados
                    connection.Open();

                    // Preenche o DataTable com os resultados da busca
                    da.Fill(dt);

                    // Exibe os resultados no DataGridView
                    dataGridView1.DataSource = dt;

                    // Define a coluna a ser exibida no DataGridView
                    dataGridView1.Columns["Username"].HeaderText = "Nome de Usuário"; // Ajuste o cabeçalho da coluna conforme necessário
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar usuários: " + ex.Message);
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula selecionada é válida e se a linha está selecionada
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                // Obtém o nome do usuário da célula selecionada
                @Username = dataGridView1.Rows[e.RowIndex].Cells["Username"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula selecionada é válida e se a linha está selecionada
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                // Obtém o nome do usuário da célula selecionada
               Username = dataGridView1.Rows[e.RowIndex].Cells["Username"].Value.ToString();
            }
        }

        private void btnTrocarSenha_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se alguma linha está selecionada no dataGridView1
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Obtém o novo valor da senha do TextBox txtnovaSenha
                    string novaSenha = txtNovaSenha.Text;

                    // Obtém o nome de usuário (Username) da linha selecionada
                    string usernameSelecionado = dataGridView1.SelectedRows[0].Cells["Username"].Value.ToString();

                    // Sua string de conexão com o banco de dados
                    string connectionString = @"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=LoginCharp;Integrated Security=True";

                    // Comando SQL para atualizar a senha do usuário na tabela
                    string query = "UPDATE Usuario SET Password = @NovaSenha WHERE Username = @Username";

                    // Cria a conexão com o banco de dados usando a string de conexão
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Cria o comando SQL e atribui a conexão e a consulta
                        SqlCommand command = new SqlCommand(query, connection);

                        // Adiciona os parâmetros (nova senha e nome de usuário) ao comando SQL
                        command.Parameters.AddWithValue("@NovaSenha", novaSenha);
                        command.Parameters.AddWithValue("@Username", usernameSelecionado);

                        // Abre a conexão com o banco de dados
                        connection.Open();

                        // Executa o comando SQL (atualiza a senha na tabela)
                        int rowsAffected = command.ExecuteNonQuery();

                        // Verifica se a atualização foi realizada com sucesso
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Senha atualizada com sucesso para o usuário: " + usernameSelecionado);
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado ou senha não atualizada.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um usuário na lista.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar a senha: " + ex.Message);
            }
        }
    }
}

