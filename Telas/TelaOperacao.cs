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
    }
}
