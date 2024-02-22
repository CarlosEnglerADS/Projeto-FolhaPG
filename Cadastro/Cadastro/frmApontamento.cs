using System;
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
    public partial class frmApontamento : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=CARLOS\SQLEXPRESS; Initial Catalog = Cadastro; Integrated Security = True");
        public frmApontamento()
        {
            InitializeComponent();
        }
        private void CarregarDados()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conn.ConnectionString))
                {
                    cn.Open();

                    // Comando SQL para selecionar os dados da tabela TB_Apontamentos
                    string sqlQuery = "SELECT * FROM TB_Apontamentos";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Associar os dados ao DataGridView
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string entrada = txtEntrada.Text;
            string saida = txtSaida.Text;

            // Verificação se os campos estão vazios
            if (string.IsNullOrEmpty(txtEntrada.Text) || string.IsNullOrEmpty(txtSaida.Text))
            {
                MessageBox.Show("Insira os horários de entrada e saída.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime dEntrada, dSaida;

            if (DateTime.TryParseExact(txtEntrada.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out dEntrada) &&
                DateTime.TryParseExact(txtSaida.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out dSaida))
            {
                TimeSpan tempo = dSaida - dEntrada;
                txtHorasDia.Text = tempo.ToString();

                try
                {
                    using (SqlConnection cn = new SqlConnection(conn.ConnectionString))
                    {
                        cn.Open();

                        // Inserção na tabela TB_Apontamentos
                        var sqlInsertApontamento = "INSERT INTO TB_Apontamentos (ID, DTDIA, HORAS) VALUES (@ID_FUNCIONARIO, @DTDIA, @HORAS)";
                        DateTime conDateTime = DateTime.Parse(txtDataApontamento.Text);

                        using (SqlCommand cmdInsertApontamento = new SqlCommand(sqlInsertApontamento, cn))
                        {
                            cmdInsertApontamento.Parameters.AddWithValue("@ID_FUNCIONARIO", txtID_Func.Text);
                            cmdInsertApontamento.Parameters.AddWithValue("@DTDIA", conDateTime);
                            cmdInsertApontamento.Parameters.AddWithValue("@HORAS", tempo.ToString(@"hh\:mm"));

                            cmdInsertApontamento.ExecuteNonQuery();

                            // Adicionando MessageBox para indicar o sucesso da inserção
                            MessageBox.Show("Apontamento inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarDados();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível inserir os dados!\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Formato de hora inválido. Insira um formato válido (HH:mm).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void frmApontamento_Load(object sender, EventArgs e)
        {
            CarregarDados();

        }
        private void SetBackColorDegrade(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);

            //onde muda a cor
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(0, 250, 154), Color.FromArgb(255, 255, 255), 90f);

            graphics.FillRectangle(br, gradient_rect);
        }
        private void FrmApontamento_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
          
            {
                // Encerrar o programa
                Close();
            }
            // Se o usuário escolher 'Não' na caixa de diálogo, o programa não será encerrado
        }

        private void acompanhamentoDeFériasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcompanhamento Acomp = new frmAcompanhamento();
            Acomp.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro ca = new FrmCadastro();
            ca.Show();
        }

        private void acompanhamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcompanhamento Acomp = new frmAcompanhamento();
            Acomp.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            {
                this.WindowState = FormWindowState.Minimized;

            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre sob = new FrmSobre();
            sob.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_ID_Click(object sender, EventArgs e)
        {
            string idParaBuscar = txtID_Func.Text; // Supondo que txtID_Func seja o nome da sua textBox para inserir o ID a ser buscado

            // Verifica se o campo de busca não está vazio
            if (!string.IsNullOrEmpty(idParaBuscar))
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(conn.ConnectionString))
                    {
                        cn.Open();

                        // Consulta SQL para selecionar os apontamentos com base no ID
                        string sqlQuery = "SELECT * FROM TB_Apontamentos WHERE ID = @ID";

                        using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                        {
                            cmd.Parameters.AddWithValue("@ID", idParaBuscar);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Associar os dados ao DataGridView
                            dataGridView1.DataSource = dt;

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Nenhum registro encontrado para o ID informado.", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                // Calcula o total de horas para o ID especificado
                                TimeSpan totalHoras = TimeSpan.Zero;
                                foreach (DataRow row in dt.Rows)
                                {
                                    // Verifica se o valor na coluna HORAS é um valor válido
                                    if (TimeSpan.TryParse(row["HORAS"].ToString(), out TimeSpan horas))
                                    {
                                        totalHoras = totalHoras.Add(horas);
                                    }
                                }

                                // Exibe o total de horas na MessageBox
                                MessageBox.Show($"Total de horas para o ID {idParaBuscar}: {totalHoras.TotalHours} horas", "Total de Horas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Atualiza a TextBox com o total de horas
                                txtTotalHoraNoMesCorrente.Text = totalHoras.TotalHours.ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID para buscar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void bntTD_Apontamentos_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnZerarApontamenntosMensalDesteID_Click(object sender, EventArgs e)
        {
            string idParaZerar = txtID_Func.Text;

            if (!string.IsNullOrEmpty(idParaZerar))
            {
                DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja zerar os apontamentos deste funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacao == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(@"Data Source=CARLOS\SQLEXPRESS; Initial Catalog = Cadastro; Integrated Security = True"))
                        {
                            cn.Open();

                            string sqlDelete = "DELETE FROM TB_Apontamentos WHERE ID = @ID";

                            using (SqlCommand cmd = new SqlCommand(sqlDelete, cn))
                            {
                                cmd.Parameters.AddWithValue("@ID", idParaZerar);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show($"Apontamentos do funcionário com ID {idParaZerar} excluídos com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Recarregar os dados no DataGridView após a exclusão (se necessário)
                                    CarregarDados();
                                }
                                else
                                {
                                    MessageBox.Show("Nenhum registro encontrado para o ID informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao zerar os apontamentos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Operação cancelada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID para zerar os apontamentos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculo cfc = new frmCalculo();
            cfc.Show();
        }

        private void btnAdTotalHoras_Click(object sender, EventArgs e)
        {
            try
            {
                string totalHoras = txtTotalHoraNoMesCorrente.Text;
                int idFuncionario;

                if (!string.IsNullOrEmpty(totalHoras) && int.TryParse(txtID_Func.Text, out idFuncionario))
                {
                    using (SqlConnection cn = new SqlConnection(@"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True"))
                    {
                        cn.Open();

                        string sqlCheckExisting = "SELECT COUNT(*) FROM TB_TotalHoraMensal WHERE ID = @ID";
                        using (SqlCommand cmdCheckExisting = new SqlCommand(sqlCheckExisting, cn))
                        {
                            cmdCheckExisting.Parameters.AddWithValue("@ID", idFuncionario);

                            int existingRecords = (int)cmdCheckExisting.ExecuteScalar();

                            if (existingRecords > 0)
                            {
                                string sqlUpdateTotalHoras = "UPDATE TB_TotalHoraMensal SET Total_de_Horas_Mes = @TotalHoras WHERE ID = @ID";
                                using (SqlCommand cmdUpdateTotalHoras = new SqlCommand(sqlUpdateTotalHoras, cn))
                                {
                                    cmdUpdateTotalHoras.Parameters.AddWithValue("@TotalHoras", totalHoras);
                                    cmdUpdateTotalHoras.Parameters.AddWithValue("@ID", idFuncionario);

                                    int rowsAffected = cmdUpdateTotalHoras.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Total de horas atualizado com sucesso na tabela TB_TotalHoraMensal.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        CarregarDados(); // Se necessário, atualize os dados após a alteração
                                    }
                                    else
                                    {
                                        MessageBox.Show("Falha ao atualizar o total de horas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                string sqlInsertTotalHoras = "INSERT INTO TB_TotalHoraMensal (ID, Total_de_Horas_Mes) VALUES (@ID, @TotalHoras)";
                                using (SqlCommand cmdInsertTotalHoras = new SqlCommand(sqlInsertTotalHoras, cn))
                                {
                                    cmdInsertTotalHoras.Parameters.AddWithValue("@ID", idFuncionario);
                                    cmdInsertTotalHoras.Parameters.AddWithValue("@TotalHoras", totalHoras);

                                    int rowsInserted = cmdInsertTotalHoras.ExecuteNonQuery();

                                    if (rowsInserted > 0)
                                    {
                                        MessageBox.Show("Novo registro criado na tabela TB_TotalHoraMensal.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        CarregarDados(); // Se necessário, atualize os dados após a alteração
                                    }
                                    else
                                    {
                                        MessageBox.Show("Falha ao criar um novo registro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Digite um código válido e clique em 'Adicionar Total de Horas'.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o total de horas na tabela TB_TotalHoraMensal: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CarregarDados(); // Atualize seus dados após um erro, se necessário
            }
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int idApontamento = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                DateTime dataApontamento = Convert.ToDateTime(selectedRow.Cells["DTDIA"].Value);

                DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacao == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(@"Data Source=CARLOS\SQLEXPRESS; Initial Catalog = Cadastro; Integrated Security = True"))
                        {
                            cn.Open();

                            // Obtém as horas do registro que será excluído
                            string sqlSelectHoras = "SELECT DATEDIFF(MINUTE, '0:00', HORAS) FROM TB_Apontamentos WHERE ID = @ID AND DTDIA = @DTDIA";

                            using (SqlCommand cmdSelectHoras = new SqlCommand(sqlSelectHoras, cn))
                            {
                                cmdSelectHoras.Parameters.AddWithValue("@ID", idApontamento);
                                cmdSelectHoras.Parameters.AddWithValue("@DTDIA", dataApontamento);

                                int horasDeletadas = Convert.ToInt32(cmdSelectHoras.ExecuteScalar());

                                string sqlDelete = "DELETE FROM TB_Apontamentos WHERE ID = @ID AND DTDIA = @DTDIA";

                                using (SqlCommand cmdDelete = new SqlCommand(sqlDelete, cn))
                                {
                                    cmdDelete.Parameters.AddWithValue("@ID", idApontamento);
                                    cmdDelete.Parameters.AddWithValue("@DTDIA", dataApontamento);

                                    int rowsAffected = cmdDelete.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        // Atualiza o total de horas no TextBox
                                        int totalHoras = ObterTotalHoras(cn, idApontamento) - horasDeletadas;
                                        txtTotalHoraNoMesCorrente.Text = totalHoras.ToString();

                                        MessageBox.Show("Registro excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        CarregarDados(); // Atualiza o DataGridView após a exclusão
                                    }
                                    else
                                    {
                                        MessageBox.Show("Nenhum registro encontrado para o ID e Data selecionados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir o registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Operação cancelada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para excluir.", "Seleção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Método para obter o total de horas
        private int ObterTotalHoras(SqlConnection cn, int idApontamento)
        {
            string sqlSelectTotalHoras = "SELECT SUM(DATEDIFF(MINUTE, '0:00', HORAS)) FROM TB_Apontamentos WHERE ID = @ID";

            using (SqlCommand cmdSelectTotalHoras = new SqlCommand(sqlSelectTotalHoras, cn))
            {
                cmdSelectTotalHoras.Parameters.AddWithValue("@ID", idApontamento);

                object result = cmdSelectTotalHoras.ExecuteScalar();

                return result != DBNull.Value ? Convert.ToInt32(result) : 0;
            }
        }
    }
}