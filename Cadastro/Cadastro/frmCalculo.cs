using Microsoft.Win32;
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
using System.Xml.Serialization;

namespace Cadastro
{
    public partial class frmCalculo : Form
    {
        public object txtID;
        public object txtNome;
        public int VlHORA = ValorHora;

        public object FrmCadUser { get; private set; }
        public static int ValorHora { get; private set; }

        public frmCalculo()
        {
            InitializeComponent();
        }
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True");
        



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtValorHora.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double vlrHora) &&
                int.TryParse(txtHorasNoMes.Text, out int horasTrabalhadas))
            {
                double total = vlrHora * horasTrabalhadas;
                txtSalarioBruto.Text = total.ToString();

                if (txtSalarioBruto.Text.Length > 0 && double.TryParse(txtSalarioBruto.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double salarioBruto))
                {
                    if (salarioBruto <= 1320.00)
                    {
                        txtINSS.Text = (salarioBruto * 0.075).ToString("F2", CultureInfo.InvariantCulture);
                    }
                    else if (salarioBruto > 1320.00 && salarioBruto <= 2571.29)
                    {
                        double inss = (((salarioBruto - 1320) * 0.09) + 99);
                        txtINSS.Text = inss.ToString("F2", CultureInfo.InvariantCulture);
                    }
                    else if (salarioBruto >= 2571.30 && salarioBruto <= 3856.94)
                    {
                        double inss = (((salarioBruto - 2571.29) * 0.12) + (99) + (112.62));
                        txtINSS.Text = inss.ToString("F2", CultureInfo.InvariantCulture);
                    }
                    else if (salarioBruto >= 3856.95 && salarioBruto <= 7507.49)
                    {
                        double inss = (((salarioBruto - 3856.94) * 0.14) + (99) + (112.62) + (154.28));
                        txtINSS.Text = inss.ToString("F2", CultureInfo.InvariantCulture);
                    }
                    else if (salarioBruto > 7507.49)
                    {
                        txtINSS.Text = "876.97";
                    }

                    double salarioBase = salarioBruto - double.Parse(txtINSS.Text, CultureInfo.InvariantCulture);

                    if (salarioBase <= 2112.0)
                    {
                        txtIRRF.Text = "ISENTO";
                    }
                    else if (salarioBase >= 2112.01 && salarioBase <= 2826.65)
                    {
                        double irrf = (salarioBase * 0.075) - 158.4;
                        txtIRRF.Text = irrf.ToString("F2", CultureInfo.InvariantCulture);
                        txtSalarioLiquido.Text = (salarioBase - irrf).ToString("F2", CultureInfo.InvariantCulture);
                    }
                    else if (salarioBase >= 2826.66 && salarioBase <= 3751.05)
                    {
                        double irrf = ((salarioBase - 2826.65) * 0.15) + 53.60;
                        txtIRRF.Text = irrf.ToString("F2", CultureInfo.InvariantCulture);
                        txtSalarioLiquido.Text = (salarioBase - irrf).ToString("F2", CultureInfo.InvariantCulture);
                    }
                    else if (salarioBase >= 3751.06 && salarioBase <= 4664.68)
                    {
                        double irrf = ((salarioBase - 3751.05) * 0.225) + 53.60 + 138.66;
                        txtIRRF.Text = irrf.ToString("F2", CultureInfo.InvariantCulture);
                        txtSalarioLiquido.Text = (salarioBase - irrf).ToString("F2", CultureInfo.InvariantCulture);
                    }
                    else if (salarioBase > 4664.68)
                    {
                        double irrf = ((salarioBase - 4664.68) * 0.275) + 53.60 + 138.66 + 205.56;
                        txtIRRF.Text = irrf.ToString("F2", CultureInfo.InvariantCulture);
                        txtSalarioLiquido.Text = (salarioBase - irrf).ToString("F2", CultureInfo.InvariantCulture);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira valores válidos para as horas e o valor da hora.");
            }
        }

        private void frmCalculo_Load(object sender, EventArgs e)
        {

        }
        private void ExibirHorasNoMes(string idFuncionario)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True"))
                {
                    cn.Open();

                    var sql = "SELECT Total_de_Horas_Mes FROM TB_TotalHoraMensal WHERE ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idFuncionario);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            txtHorasNoMes.Text = result.ToString();
                        }
                        else
                        {
                            txtHorasNoMes.Text = "Sem dados de horas no mês para este funcionário.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar dados de horas no mês: " + ex.Message);
            }
        }

        private void SetBackColorDegrade(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);

            //onde muda a cor
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(0, 250, 154), Color.FromArgb(255, 255, 255), 90f);

            graphics.FillRectangle(br, gradient_rect);
        }
        private void FrmCalculo_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            {
                // Encerrar o programa
                Close();
            }
            // Se o usuário escolher 'Não' na caixa de diálogo, o programa não será encerrado
        }

        public void BtnExibir_Click(object sender, EventArgs e)
        {
            string ID = textBox1.Text;
            string Nome = textBox2.Text;
            string ValorHora = txtValorHora.Text;
            string HorasNoMes = txtHorasNoMes.Text;
            string SalarioBruto = txtSalarioBruto.Text;
            string INSS = txtINSS.Text;
            string IRFF = txtIRRF.Text;
            string SalarioLiquido = txtSalarioLiquido.Text;

            FrmHolerite destino = new FrmHolerite(ID, Nome, ValorHora, HorasNoMes, SalarioBruto, INSS, IRFF, SalarioLiquido);

            destino.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True"))
                {
                    cn.Open();

                    var sql = "SELECT * FROM Funcionario ";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Atribui o DataTable como DataSource do DataGridView
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar dados: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                AtualizarTextBoxesComDadosSelecionados();

                if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index != -1)
                {
                    DataGridViewRow ro = dataGridView1.Rows[dataGridView1.CurrentRow.Index];

                    if (ro.Cells["ID"].Value != null)
                    {
                        AtualizarTextBoxesComDadosSelecionados();

                        if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index != -1)
                        {
                            DataGridViewRow r = dataGridView1.Rows[dataGridView1.CurrentRow.Index];

                            if (ro.Cells["ID"].Value != null)
                            {
                                string idFuncionario = ro.Cells["ID"].Value.ToString();
                                ExibirHorasNoMes(idFuncionario);
                            }
                        }
                    }
                }
            }



        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarTextBoxesComDadosSelecionados();
        }

        private void AtualizarTextBoxesComDadosSelecionados()
        {
            try
            {
                // Abre a conexão com o banco de dados
                using (SqlConnection cn = new SqlConnection(@"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True"))
                {
                    cn.Open();

                    if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index != -1)
                    {
                        DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentRow.Index];

                        // Verifica se as células contêm valores e se são do tipo correto
                        if (row.Cells["ID"].Value != null && row.Cells["Nome"].Value != null)
                        {
                            // Atualiza os TextBoxes com os dados da linha selecionada
                            textBox1.Text = row.Cells["ID"].Value.ToString();
                            textBox2.Text = row.Cells["Nome"].Value.ToString();
                            txtValorHora.Text = row.Cells["VLHORA"].Value?.ToString();

                            // Busca a coluna "Total_de_Horas_Mes" na tabela "TB_TotalHoraMensal"
                            string idFuncionario = row.Cells["ID"].Value.ToString();
                            string horasNoMes = BuscarHorasNoMes(cn, idFuncionario);

                            // Atualiza o TextBox correspondente com o valor das horas no mês
                            txtHorasNoMes.Text = horasNoMes;

                            // Se a coluna DTADM estiver presente na consulta, atualiza o TextBox correspondente
                            if (row.Cells["DTADM"].Value != null)
                            {
                                mskDTADM.Text = row.Cells["DTADM"].Value.ToString();
                            }
                            else
                            {
                                mskDTADM.Text = string.Empty;
                            }
                        }
                        else
                        {
                            LimparTextBoxes();
                        }
                    }
                    else
                    {
                        LimparTextBoxes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar dados: " + ex.Message);
            }
        }

        private string BuscarHorasNoMes(SqlConnection cn, string idFuncionario)
        {
            try
            {
                // Query para buscar as horas no mês na tabela "TB_TotalHoraMensal"
                var sql = "SELECT Total_de_Horas_Mes FROM TB_TotalHoraMensal WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@ID", idFuncionario);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return "Sem dados de horas no mês para este funcionário.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar dados de horas no mês: " + ex.Message);
                return string.Empty;
            }
        }

        private void LimparTextBoxes()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            txtValorHora.Text = string.Empty;
            mskDTADM.Text = string.Empty;
            txtHorasNoMes.Text = string.Empty; // Limpa também o TextBox das horas no mês
        }


        public void btnExibir_Click(object sender, EventArgs e)
        {
            string ID = textBox1.Text;
            string Nome = textBox2.Text;
            string ValorHora = txtValorHora.Text;
            string SalarioBruto = txtSalarioBruto.Text;
            string INSS = txtINSS.Text;
            string IRFF = txtIRRF.Text;
            string SalarioLiquido = txtSalarioLiquido.Text;

            string HorasNoMes = BuscarHorasNoMes(ID); // Aqui você precisa chamar o método para buscar TOTALHORASNOMES

            FrmHolerite destino = new FrmHolerite(ID, Nome, ValorHora, HorasNoMes, SalarioBruto, INSS, IRFF, SalarioLiquido);
            destino.Show();
        }

        // Método para buscar as horas no mês
        private string BuscarHorasNoMes(string idFuncionario)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True"))
                {
                    cn.Open();
                    var sql = "SELECT Total_de_Horas_Mes FROM TB_TotalHoraMensal WHERE ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idFuncionario);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            return result.ToString();
                        }
                        else
                        {
                            return "Sem dados de horas no mês para este funcionário.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar dados de horas no mês: " + ex.Message);
                return string.Empty;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar os controles TextBox e MaskedTextBox, exceto o DataGridView
            foreach (Control control in this.Controls)
            {
                if ((control is TextBox || control is MaskedTextBox) && control != dataGridView1)
                {
                    if (control != mskDTADM) // Excluir a MaskedTextBox específica que você deseja manter
                    {
                        ((TextBoxBase)control).Clear();
                    }
                }
            }

            // Limpar a MaskedTextBox de data (mskDTADM)
            mskDTADM.Clear();
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

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro cad = new FrmCadastro();
            cad.Show();
        }


        private void cadastroDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro cad = new FrmCadastro();
            cad.Show();
        }

        private void apontamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApontamento apont = new frmApontamento();
            apont.Show();
        }

        private void acompanhamentoDeFériasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAcompanhamento acomp = new frmAcompanhamento();
            acomp.Show();
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnminimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT SUM(CASE WHEN ISNUMERIC(SalarioLiquido) = 1 THEN CAST(SalarioLiquido AS DECIMAL(18, 2)) ELSE 0 END) AS TotalFolha FROM Holerite";
                    SqlCommand command = new SqlCommand(query, connection);
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal totalFolha = Convert.ToDecimal(result);
                        txtSomaGeralFolha.Text = totalFolha.ToString("C"); // Define o resultado na TextBox
                    }
                    else
                    {
                        txtSomaGeralFolha.Text = "Não há dados de folha de pagamento.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular total de folha de pagamento: " + ex.Message);
            }
        }


        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre sob = new FrmSobre();
            sob.Show();
        }



        private void btnB_Nome_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True"))
                {
                    cn.Open();
                    var sql = "SELECT * FROM Funcionario WHERE Nome = @Nome";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", txtBuscaNome.Text);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Atribui o DataTable como DataSource do DataGridView
                        dataGridView1.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            txtBuscaNome.Text = "Nome não encontrado.";
                        }
                        else
                        {
                            txtBuscaNome.Text = ""; // Limpa o texto anterior, se houver
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar nome: " + ex.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            {
                // Obtém o ID do funcionário a ser excluído da TextBox1
                if (int.TryParse(textBox1.Text, out int idFuncionario))
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(@"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True"))
                        {
                            cn.Open();

                            // Consulta para obter os dados do funcionário a ser excluído
                            var selectQuery = "SELECT * FROM Funcionario WHERE ID = @ID";

                            using (SqlCommand selectCmd = new SqlCommand(selectQuery, cn))
                            {
                                selectCmd.Parameters.AddWithValue("@ID", idFuncionario);
                                SqlDataReader reader = selectCmd.ExecuteReader();

                                // Verifica se existem dados para o funcionário
                                if (reader.HasRows)
                                {
                                    // Move para o primeiro registro (único, pois é pelo ID)
                                    reader.Read();

                                    // Obtém os dados do funcionário a ser excluído
                                    int id = reader.GetInt32(reader.GetOrdinal("ID"));
                                    string nome = reader.GetString(reader.GetOrdinal("Nome"));
                                    DateTime dataAdmissao = reader.GetDateTime(reader.GetOrdinal("DTADM"));
                                    int valorHora = reader.GetInt32(reader.GetOrdinal("VLHORA"));

                                    // Fecha o reader antes de realizar a próxima consulta
                                    reader.Close();

                                    // Insere os dados do funcionário na tabela Funcionarios_Desligados
                                    var insertQuery = "INSERT INTO Funcionarios_Desligados (ID, Nome, DTADM, DTDM, VLHORA) VALUES (@ID, @Nome, @DTADM, @DTDM, @VLHORA)";

                                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, cn))
                                    {
                                        insertCmd.Parameters.AddWithValue("@ID", id);
                                        insertCmd.Parameters.AddWithValue("@Nome", nome);
                                        insertCmd.Parameters.AddWithValue("@DTADM", dataAdmissao);
                                        insertCmd.Parameters.AddWithValue("@DTDM", DateTime.Now); // Data de desligamento como data atual
                                        insertCmd.Parameters.AddWithValue("@VLHORA", valorHora);
                                        insertCmd.ExecuteNonQuery();
                                    }

                                    // Agora exclui o funcionário da tabela Funcionario
                                    var deleteQuery = "DELETE FROM Funcionario WHERE ID = @ID";

                                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, cn))
                                    {
                                        deleteCmd.Parameters.AddWithValue("@ID", id);
                                        deleteCmd.ExecuteNonQuery();
                                    }

                                    // Atualiza o DataGridView após a exclusão do funcionário
                                    AtualizarDataGridView();
                                    MessageBox.Show("Funcionário excluído com sucesso e movido para a tabela Funcionarios_Desligados.");
                                }
                                else
                                {
                                    MessageBox.Show("Funcionário não encontrado.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir funcionário: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um ID válido.");
                }
            }


            void AtualizarDataGridView()
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(@"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True"))
                    {
                        cn.Open();
                        var sql = "SELECT * FROM Funcionario";

                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Atualiza o dataGridView1 com os dados obtidos da consulta
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar dataGridView1: " + ex.Message);
                }

            }

        }

        private void funcionáriosDesligadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncDeslig FD = new FrmFuncDeslig();
            FD.Show();
        }

        private void registroDeOcorrênciasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Carrega os dados das tabelas Funcionario, TB_TotalHoraMensal e Holerite
                    string query = @"
            SELECT 
                F.ID AS Funcionario_ID,
                F.Nome AS Nome_Funcionario,
                F.DTADM AS Data_Admissao,
                THM.Total_de_Horas_Mes,
                H.*  -- Seleciona todos os campos da tabela Holerite
            FROM 
                Funcionario F
            INNER JOIN 
                TB_TotalHoraMensal THM ON F.ID = THM.ID
            LEFT JOIN
                Holerite H ON F.ID = H.ID";  // Utilize LEFT JOIN se Holerite pode ter registros opcionais relacionados a Funcionario

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Carrega os dados no DataGridView
                    dataGridView1.DataSource = table;

                    // Remove a coluna HORASNOMES do DataGridView, se ela existir
                    if (dataGridView1.Columns.Contains("HORASNOMES"))
                    {
                        dataGridView1.Columns.Remove("HORASNOMES");
                    }

                    // Calcula o total da folha de pagamento
                    SqlCommand command = new SqlCommand("SELECT SUM(CASE WHEN ISNUMERIC(SalarioLiquido) = 1 THEN CAST(SalarioLiquido AS DECIMAL(18, 2)) ELSE 0 END) AS TotalFolha FROM Holerite", connection);
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal totalFolha = Convert.ToDecimal(result);
                        txtTotalFolha.Text = totalFolha.ToString("C"); // Define o resultado na TextBox
                    }
                    else
                    {
                        txtTotalFolha.Text = "Não há dados de folha de pagamento.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar relatório: " + ex.Message);
            }
        }

            private void label11_Click(object sender, EventArgs e)
        {

        }

        private void funcionáriosDesligadosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmFuncDeslig fdp = new FrmFuncDeslig();
            fdp.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja limpar a tabela Holerite?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(@"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True"))
                    {
                        cn.Open();

                        string sqlTruncate = "TRUNCATE TABLE Holerite";

                        using (SqlCommand cmd = new SqlCommand(sqlTruncate, cn))
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Tabela Holerite limpa com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao limpar a tabela Holerite: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
 }


