using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Threading;


namespace Inscricao_e_Matricula
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        public int opcao;
        public void expandir()
        {   
            timer1.Enabled = true;
            opcao = 1;
            label4.Visible = false;
        }
        public void ocultar()
        {
            timer1.Enabled = true;
            opcao = 2;
            
        }
        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            TelaLogin login = new TelaLogin();
            lb_Entidade.Text = login.nome;
            btnhome.FillColor = Color.Orange;
            Telas.Tela_informacao tela = new Telas.Tela_informacao();
            tela.Visible = true;
            tela.Dock = DockStyle.Fill;
            paneljanela.Controls.Add(tela);

        }

       

        private void pic_Add_Click(object sender, EventArgs e)
        {
            TelaOperacao telaOperacao = new TelaOperacao();
            this.Hide();
            telaOperacao.ShowDialog();

        }

       

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                
                guna2Elipse7.BorderRadius = 0;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                guna2Elipse7.BorderRadius = 35;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            paneljanela.Controls.Clear();
            TelaOperacao tela = new TelaOperacao();
            tela.TopLevel = false;
            tela.Visible = true;
            tela.Dock = DockStyle.Fill;
            paneljanela.Controls.Add(tela);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (opcao == 1)
            {
                if (btnspanel.Width <= 170)
                {
                    btnspanel.Width += 5;
                    
                }
                else
                {
                    timer1.Enabled = false;
                }
            }
            else
            {
                if (btnspanel.Width >= 74)
                {
                    btnspanel.Width = btnspanel.Width - 4;
                    
                }
                else
                {
                    timer1.Enabled = false;
                    label4.Visible = true;
                }
            }
        }

        private void btnssidebar_leave(object sender, EventArgs e)
        {
            ocultar();
        }

        private void Side_bar_hover(object sender, EventArgs e)
        {
            btnspanel.BringToFront();
            expandir();
            
        }

        private void Side_bar_leave(object sender, EventArgs e)
        {
            ocultar();
          
        }

        private void btnconfig_Click(object sender, EventArgs e)
        {
            Telas.Configuracoes tl = new Telas.Configuracoes();
            tl.TopLevel=false;
            tl.Visible = true;
            paneljanela.Controls.Add(tl);
        }

        private void pnins_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnmat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnreje_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paneljanela_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            paneljanela.Controls.Clear();
            Telas.Tela_informacao tela = new Telas.Tela_informacao();
            tela.TopLevel = false;
            tela.Visible = true;
            paneljanela.Controls.Add(tela);
            tela.Dock = DockStyle.Fill;
        }

        private void lb_Entidade_Click(object sender, EventArgs e)
        {

        }
    }
}
