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

namespace Cadastro
{
    public partial class FrmFuncDeslig : Form
    {
        public object idParaExcluir { get; private set; }
        public string ID { get; private set; }

        public FrmFuncDeslig()
        {
            InitializeComponent();
        }
        private void CarregarDadosTabelaTotalHoraMensal()
        {
            try
            {
                string connectionString = @"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True";

                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    string sqlQuery = "SELECT * FROM Funcionarios_Desligados";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados da tabela Funcionarios_Desligados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmFuncDeslig_Load(object sender, EventArgs e)
        {
            CarregarDadosTabelaTotalHoraMensal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)

        {
            try
            {
                string connectionString = @"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True"; // Substitua pela sua string de conexão

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        // Obtém o valor do ID da célula selecionada no DataGridView
                        string idParaDeletar = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                        string query = "DELETE FROM Funcionarios_Desligados WHERE ID = @ID";

                        SqlCommand command = new SqlCommand(query, connection);

                        // Preencher o parâmetro ID com o valor obtido do DataGridView
                        command.Parameters.AddWithValue("@ID", idParaDeletar);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro deletado com sucesso!");
                            CarregarDadosTabelaTotalHoraMensal();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro foi deletado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione um registro para deletar.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar o registro: " + ex.Message);
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        string idParaCopiar = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                        string nomeParaCopiar = dataGridView1.SelectedRows[0].Cells["Nome"].Value.ToString();
                        string dtAdmParaCopiar = dataGridView1.SelectedRows[0].Cells["DTADM"].Value.ToString();
                        string vlHoraParaCopiar = dataGridView1.SelectedRows[0].Cells["VLHORA"].Value.ToString();

                        string insertQuery = "INSERT INTO Funcionario (ID, Nome, DTADM, VLHORA) " +
                                             "SELECT ID, Nome, DTADM, VLHORA " +
                                             "FROM Funcionarios_Desligados " +
                                             "WHERE ID = @ID AND Nome = @Nome AND DTADM = @DTADM AND VLHORA = @VLHORA";

                        SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@ID", idParaCopiar);
                        insertCommand.Parameters.AddWithValue("@Nome", nomeParaCopiar);
                        insertCommand.Parameters.AddWithValue("@DTADM", dtAdmParaCopiar);
                        insertCommand.Parameters.AddWithValue("@VLHORA", vlHoraParaCopiar);

                        int rowsInserted = insertCommand.ExecuteNonQuery();

                        if (rowsInserted > 0)
                        {
                            string deleteQuery = "DELETE FROM Funcionarios_Desligados WHERE ID = @ID AND Nome = @Nome AND DTADM = @DTADM AND VLHORA = @VLHORA";
                            SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                            deleteCommand.Parameters.AddWithValue("@ID", idParaCopiar);
                            deleteCommand.Parameters.AddWithValue("@Nome", nomeParaCopiar);
                            deleteCommand.Parameters.AddWithValue("@DTADM", dtAdmParaCopiar);
                            deleteCommand.Parameters.AddWithValue("@VLHORA", vlHoraParaCopiar);

                            int rowsDeleted = deleteCommand.ExecuteNonQuery();

                            if (rowsDeleted > 0)
                            {
                                MessageBox.Show("Registro copiado e removido com sucesso!");
                                CarregarDadosTabelaTotalHoraMensal(); // Atualizar o DataGridView após a operação
                            }
                            else
                            {
                                MessageBox.Show("Erro ao remover registro da tabela Funcionarios_Desligados.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erro ao copiar registro para a tabela Funcionario.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione um registro para copiar.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a operação: " + ex.Message);
            }
        }

    }
}