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
using Cadastro;

namespace LoginCharpBDFolhaDePag
{
    public partial class FrmPrincipal1 : Form
    {
        public FrmPrincipal1()

        {
            InitializeComponent();


        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja encerrar o programa Contabilly?", "Confirmação de Encerramento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Encerrar o programa
                Application.Exit();
            }
            // Se o usuário escolher 'Não' na caixa de diálogo, o programa não será encerrado
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadUser fod = new FrmCadUser();
            fod.Show();
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void acompanhamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcompanhamento fdp = new frmAcompanhamento();
             fdp.Show();
        }

        private void apontamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApontamento Aco = new frmApontamento();
            Aco.Show();

        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCadastro fod = new FrmCadastro();
            fod.Show();
        }

        private void cálculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculo fdd = new frmCalculo();
            fdd.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadUser fod = new FrmCadUser();
            fod.Show();
        }

        private void apontamentosDeHorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApontamento apont = new frmApontamento();
            apont.Show();
        }
    }
}