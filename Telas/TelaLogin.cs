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
        public DataTable dataTable = new DataTable();
        public static string nome;
        public static string senha;
        DialogResult btr = new DialogResult();
        public TelaLogin()
        {
            InitializeComponent();
            
        }
        
            
       
        public void reposta(int resp)
        {
            if (btr == DialogResult.OK && resp ==1)
            {
                txtnome.Focus();
            }
            if (btr == DialogResult.OK && resp == 2)
            {
                txtsenha.Focus();
            }
            if (btr == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        private void btn_Entra_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            this.Hide();
            telaPrincipal.ShowDialog();

        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            txtnome.Focus();
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            TelaOperacao telaOperacao = new TelaOperacao();
            this.Hide();
            telaOperacao.Show();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
             TelaPrincipal telaPrincipal = new TelaPrincipal();
            /*  if (txtnome.Text==nome && txtsenha.Text==senha)
              {
                  this.Hide();
                  telaPrincipal.ShowDialog();
              }
              else if (txtnome.Text == "")
              {
                  btr= MessageBox.Show("Preencha o campo do nome...", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                  reposta(1);
              }
              else if (txtsenha.Text == "")
              {
                  btr = MessageBox.Show("Preencha o campo do da senha...", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                  reposta(2);
              }
              else if( txtnome.Text !=nome)
              {
                  btr = MessageBox.Show("O nome de usuário está incorreto", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                  reposta(1);
              }
              else if (txtsenha.Text != senha)
              {
                  btr = MessageBox.Show("A senha inserida está incorreta", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                  reposta(2);
              }
              else if (txtnome.Text != nome && txtsenha.Text != senha)
              {
                  btr = MessageBox.Show("O nome de Usuário e a senha estão incorretos", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                  reposta(1);
              }*/
                nome = txtnome.Text;
                senha=txtsenha.Text;
                if (txtnome.Text == "" && txtsenha.Text == "")
                {
                    txtnome.Focus();
                    return;
                }

                string mySql = "SELECT * FROM entidade WHERE nome_entidade='" + nome  + "' AND senha_entidade='" + senha  + "'";
                dataTable = Data_Base.Consulta(mySql);

                if (dataTable.Rows.Count == 1)
                {
                   telaPrincipal.Show();
                    MessageBox.Show(" usuario encontrado");
                }
                else
                {
                    MessageBox.Show("Usuario nao encontrado");
                }
            
           
        }

        private void txtsenha_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void checkpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkpass.Checked == true)
            {
                txtsenha.PasswordChar = '\u0000';
            }
            else
            {
                txtsenha.PasswordChar = '*';
            }
        }  
        
    }
}
