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
    public partial class Tela_CadastraEntidade : Form
    {
        public Tela_CadastraEntidade()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            TelaOperacao telaOperacao = new TelaOperacao();
            this.Hide();
            telaOperacao.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
