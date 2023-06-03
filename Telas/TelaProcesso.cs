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
    public partial class TelaProcesso : Form
    {
        int aux=1;
        public TelaProcesso()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (aux < 100)
            {
                aux++;
            }
            else
            {
                Application.Exit();
            }
        }

        private void TelaProcesso_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
