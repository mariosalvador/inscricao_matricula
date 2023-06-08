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
    public partial class Tela_informacao : Form
    {
        public AnchorStyles baixo = AnchorStyles.Bottom;
        public AnchorStyles cima = AnchorStyles.Top;
        public Tela_informacao()
        {
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            InitializeComponent();
        }

        private void Tela_informacao_Load(object sender, EventArgs e)
        {

        }
    }
}
