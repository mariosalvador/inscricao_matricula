using System;
using Guna.UI2.WinForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscricao_e_Matricula
{
    public partial class TelaSplash : Form
    {
        public TelaSplash()
        {
            InitializeComponent();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            TelaLogin tela = new TelaLogin();
            if ( PROGRESSBAR.Value < 100)
            {
                PROGRESSBAR.Value += 1;
            }
            else if (PROGRESSBAR.Value == 100)
            {
                timer1.Enabled = false;
                this.Hide();
                tela.ShowDialog();
            }
            
        }

        private void TelaSplash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
