using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscricao_e_Matricula.Telas
{
    public partial class confirmado : Form
    {
        public confirmado()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Telas.Telaconfirmar tela = new Telas.Telaconfirmar();
            tela.aberto = false;
            this.TopMost = false;
            this.Close();
        }

        private void confirmado_Load(object sender, EventArgs e)
        {
            Telas.Telaconfirmar tela = new Telas.Telaconfirmar();
            tela.aberto = true;
        }
    }
}
