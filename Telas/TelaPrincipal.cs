using System;
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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_Add_Click(object sender, EventArgs e)
        {
            TelaOperacao telaOperacao = new TelaOperacao();
            this.Hide();
            telaOperacao.ShowDialog();

        }

        private void label23_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lb_Entidade_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            lb_Entidade.Text = " ";
            lb_Entidade.Text = telaLogin.nome;
        }

        private void pic_Info_Click(object sender, EventArgs e)
        {
            TelaInformacao telaInformacao = new TelaInformacao();
            this.Hide();
            telaInformacao.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
