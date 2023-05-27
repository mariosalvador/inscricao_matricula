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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
            
        }

        private void btn_Entra_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            this.Hide();
            telaPrincipal.ShowDialog();
          
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
