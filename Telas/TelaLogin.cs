 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace Inscricao_e_Matricula
{
    public partial class TelaLogin : Form
    {
        public string nome = "Admin_Master";
        public string senha = "master";
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

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            if (txtnome.Text==nome && txtsenha.Text==senha)
            {
                this.Hide();
                telaPrincipal.ShowDialog();
            }

        }


        private void btnrestore_max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
