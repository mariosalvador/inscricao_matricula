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
    public partial class TelaInformacao : Form
    {
        public TelaInformacao()
        {
            InitializeComponent();
        }

        private void pic_Home_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            this.Hide();
            telaPrincipal.Show();
        }

        private void pic_Add_Click(object sender, EventArgs e)
        {
            TelaOperacao telaOperacao = new TelaOperacao();
            this.Hide();
            telaOperacao.ShowDialog();
        }
    }
}
