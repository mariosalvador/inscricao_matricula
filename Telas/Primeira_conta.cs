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
    public partial class Primeira_conta : Form
    {
        public Primeira_conta()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            if (txtsenha_1.Text != txtsenha_2.Text)
            {
                MessageBox.Show("As senhas inseridas não correnspondem", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

            }
        }

        private void checkpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkpass.Checked == true)
            {
                txtsenha_1.PasswordChar  = '*';
                txtsenha_2.PasswordChar = '*';
            }
        }
    }
}
