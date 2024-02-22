using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class frmAcompanhamento : Form
    {


        public frmAcompanhamento()
        {
            InitializeComponent();
        }
        private void CarregarDados()
        {
            try
            {
                string connectionString = @"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT ID, Nome, Data_Admissao, Data_Inicio_Aquisicao, Data_Termino_Aquisicao, Data_Inicio_Gozo, Data_Termino_Gozo FROM TB_Acompanhamento_de_Ferias";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Associar o DataTable à DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }

        private void LimparTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
                else if (c.HasChildren)
                {
                    LimparTextBoxes(c);
                }
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtDataADM.Text.Length > 0)
            {
                string dataAdm = txtDataADM.Text;
                DateTime conDataAdm;

                if (!DateTime.TryParseExact(dataAdm, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out conDataAdm))
                {
                    MessageBox.Show("Insira a data em formato correto (dd/MM/yyyy)", "Formato de data inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Sai do método se a data estiver em formato inválido
                }

                DateTime dtInicioAquisicao = conDataAdm.AddYears(1);
                DateTime dtTerminoAquisicao = dtInicioAquisicao.AddDays(365);

                txtDataInicio.Text = dtInicioAquisicao.ToString("dd/MM/yyyy");
                txtTerminoAquisicao.Text = dtTerminoAquisicao.ToString("dd/MM/yyyy");

                if (txtDataInicioGozo.Text.Length > 0)
                {
                    string dataInicioGozo = txtDataInicioGozo.Text;
                    DateTime conDataInicioGozo;

                    if (!DateTime.TryParseExact(dataInicioGozo, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out conDataInicioGozo))
                    {
                        MessageBox.Show("Insira a data de início de gozo em formato correto (dd/MM/yyyy)", "Formato de data inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Sai do método se a data estiver em formato inválido
                    }

                    DateTime dtTerminoGozo = conDataInicioGozo.AddDays(29);

                    txtDataTerminoGozo.Text = dtTerminoGozo.ToString("dd/MM/yyyy");
                }
            }
        }

        private void frmAcompanhamento_Load(object sender, EventArgs e)
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
        private void FrmAcompanhamento_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                // Encerrar o programa
                Close();
            }
            // Se o usuário escolher 'Não' na caixa de diálogo, o programa não será encerrado
        }

        private void apontamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApontamento apont = new frmApontamento();
            apont.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro Cad = new FrmCadastro();
            Cad.Show();

        }

        private void cálculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculo cal = new frmCalculo();
            cal.Show();
        }




        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True"; // Substitua pela sua string de conexão

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO TB_Acompanhamento_de_Ferias (ID, Nome, Data_Admissao, Data_Inicio_Aquisicao, Data_Termino_Aquisicao, Data_Inicio_Gozo, Data_Termino_Gozo) " +
                                   "VALUES (@ID, @Nome, @DataAdmissao, @DataInicioAquisicao, @DataTerminoAquisicao, @DataInicioGozo, @DataTerminoGozo)";

                    SqlCommand command = new SqlCommand(query, connection);

                    // Preencher parâmetros com os dados dos TextBoxes

                    command.Parameters.AddWithValue("@ID", txtID.Text);
                    command.Parameters.AddWithValue("@Nome", txtNome1.Text);
                    command.Parameters.AddWithValue("@DataAdmissao", txtDataADM.Text);
                    command.Parameters.AddWithValue("@DataInicioAquisicao", txtDataInicio.Text);
                    command.Parameters.AddWithValue("@DataTerminoAquisicao", txtTerminoAquisicao.Text);
                    command.Parameters.AddWithValue("@DataInicioGozo", txtDataInicioGozo.Text);
                    command.Parameters.AddWithValue("@DataTerminoGozo", txtDataTerminoGozo.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dados salvos na tabela com sucesso!");

                        // Recarregar os dados na DataGridView após Salvar
                        CarregarDados(); // Chamada para o método que carrega os dados na DataGridView

                    }
                    else
                    {
                        MessageBox.Show("Falha ao salvar os dados na tabela.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True"; // Substitua pela sua string de conexão

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query;

                    if (!string.IsNullOrEmpty(txtID.Text))
                    {
                        int idValue;
                        if (!int.TryParse(txtID.Text, out idValue))
                        {
                            MessageBox.Show("Insira um valor numérico válido para o ID.");
                            return;
                        }

                        query = "SELECT ID, Nome, Data_Admissao, Data_Inicio_Aquisicao, Data_Termino_Aquisicao, Data_Inicio_Gozo, Data_Termino_Gozo FROM TB_Acompanhamento_de_Ferias WHERE ID = @ID";
                    }
                    else
                    {
                        query = "SELECT ID, Nome, Data_Admissao, Data_Inicio_Aquisicao, Data_Termino_Aquisicao, Data_Inicio_Gozo, Data_Termino_Gozo FROM TB_Acompanhamento_de_Ferias";
                    }

                    SqlCommand command = new SqlCommand(query, connection);

                    if (!string.IsNullOrEmpty(txtID.Text))
                    {
                        int idValue;
                        if (!int.TryParse(txtID.Text, out idValue))
                        {
                            MessageBox.Show("Insira um valor numérico válido para o ID.");
                            return;
                        }
                        command.Parameters.AddWithValue("@ID", idValue);
                    }

                    // Preenche o DataGridView com os dados filtrados ou a tabela inteira
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    if (string.IsNullOrEmpty(txtID.Text) && dataTable.Rows.Count > 0)
                    {
                        // Se nenhum ID foi fornecido e há dados, exibe o primeiro nome na caixa de texto (apenas para visualização)
                        txtNome1.Text = dataTable.Rows[0]["Nome"].ToString();
                    }
                    else if (dataTable.Rows.Count == 0)
                    {
                        txtNome1.Text = string.Empty;
                        MessageBox.Show("Nenhum registro encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar os dados: " + ex.Message);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True"; // Substitua pela sua string de conexão

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM TB_Acompanhamento_de_Ferias WHERE ID = @ID";

                    SqlCommand command = new SqlCommand(query, connection);

                    // Preencher o parâmetro ID com o valor do textbox
                    command.Parameters.AddWithValue("@ID", txtID.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registro deletado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao deletar o registro.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar o registro: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Preenche os TextBoxes com os valores das colunas correspondentes à linha selecionada
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtNome1.Text = row.Cells["Nome"].Value.ToString();
                txtDataADM.Text = Convert.ToDateTime(row.Cells["Data_Admissao"].Value).ToString("dd/MM/yyyy");
                txtDataInicio.Text = Convert.ToDateTime(row.Cells["Data_Inicio_Aquisicao"].Value).ToString("dd/MM/yyyy");
                txtTerminoAquisicao.Text = Convert.ToDateTime(row.Cells["Data_Termino_Aquisicao"].Value).ToString("dd/MM/yyyy");
                txtDataInicioGozo.Text = Convert.ToDateTime(row.Cells["Data_Inicio_Gozo"].Value).ToString("dd/MM/yyyy");
                txtDataTerminoGozo.Text = Convert.ToDateTime(row.Cells["Data_Termino_Gozo"].Value).ToString("dd/MM/yyyy");
            }
        }
        private void apontamenttoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApontamento apont = new frmApontamento();
            apont.Show();
        }

        private void cadastroDeFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro CDD = new FrmCadastro();
            CDD.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            this.WindowState = FormWindowState.Minimized;

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre sob = new FrmSobre();
            sob.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE TB_Acompanhamento_de_Ferias SET Nome = @Nome, Data_Admissao = @DataAdmissao, " +
                                   "Data_Inicio_Aquisicao = @DataInicioAquisicao, Data_Termino_Aquisicao = @DataTerminoAquisicao, " +
                                   "Data_Inicio_Gozo = @DataInicioGozo, Data_Termino_Gozo = @DataTerminoGozo WHERE ID = @ID";

                    SqlCommand command = new SqlCommand(query, connection);

                    // Preencher parâmetros com os dados dos TextBoxes
                    command.Parameters.AddWithValue("@ID", txtID.Text);
                    command.Parameters.AddWithValue("@Nome", txtNome1.Text);
                    command.Parameters.AddWithValue("@DataAdmissao", txtDataADM.Text);
                    command.Parameters.AddWithValue("@DataInicioAquisicao", txtDataInicio.Text);
                    command.Parameters.AddWithValue("@DataTerminoAquisicao", txtTerminoAquisicao.Text);
                    command.Parameters.AddWithValue("@DataInicioGozo", txtDataInicioGozo.Text);
                    command.Parameters.AddWithValue("@DataTerminoGozo", txtDataTerminoGozo.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dados atualizados na tabela com sucesso!");

                        // Recarregar os dados na DataGridView após a atualização
                        CarregarDados(); // Chamada para o método que carrega os dados na DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar os dados na tabela.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar os dados: " + ex.Message);
            }
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTextBoxes(this);
        }

        private void txtNome1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataADM_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

    


    
