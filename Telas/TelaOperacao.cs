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
    public partial class TelaOperacao : Form
    {
        public TelaOperacao()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            TelaInscricao telaInscricao = new TelaInscricao();
            this.Hide();
            telaInscricao.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            TelaInscricao telaInscricao = new TelaInscricao();
            this.Hide();
            telaInscricao.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Tela_CadastraEntidade tela_CadastraEntidade = new Tela_CadastraEntidade();
            this.Hide();
            tela_CadastraEntidade.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Tela_CadastraEntidade tela_CadastraEntidade = new Tela_CadastraEntidade();
            this.Hide();
            tela_CadastraEntidade.Show();
        }

        private void lb_Entidade_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            lb_Entidade.Text = telaLogin.nome;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            this.Hide();
            telaPrincipal.Show();
        }
    }
}
