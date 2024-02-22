using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCharpBDFolhaDePag
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
            // Adicionando o evento Shown ao carregar o formulário
            this.Shown += FrmSplash_Shown;
        }

        private void FrmSplash_Shown(object sender, EventArgs e)
        {
            lblStatus.Text = "Carregando o sistema...";
            this.Refresh();

            for (int i = 1; i <= 100; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(40);
            }

            progressBar1.Value = 99;
            Thread.Sleep(500);
            this.Close();
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmSplash_Shown(object sender, EventArgs e, Thread thread)
        {
            lblStatus.Text = "Carregando o sistema...";
            this.Refresh();

            for (int i = 1; i < 101; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(40);
            }

            progressBar1.Value = 99;  
            Thread.Sleep(500);
            Close();
        }
    }
}

