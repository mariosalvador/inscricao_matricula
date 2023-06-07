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
            label4.Visible = true;
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            btnhome.FillColor = Color.Orange;
            TelaLogin telaLogin = new TelaLogin();
            lb_Entidade.Text = telaLogin.nome;
            Class_TelaInscricao _TelaInscricao = new Class_TelaInscricao();
            lb_TotaInscrito.Text =Convert.ToString( _TelaInscricao.totalInscrito);
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
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
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
            TelaOperacao tl = new TelaOperacao();
            this.Hide();
            tl.ShowDialog();
        }
        int p=0;
        int w = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (opcao == 1)
            {
                if (btnspanel.Width <= 170)
                {
                    btnspanel.Width = btnspanel.Width + 3;
                    paneljanela.Width = paneljanela.Width - 3;
                    paneljanela.Location = new Point(paneljanela.Location.X + 3, paneljanela.Location.Y);
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
                    btnspanel.Width = btnspanel.Width - 3;
                    paneljanela.Width = paneljanela.Width + 3;
                    paneljanela.Location = new Point(paneljanela.Location.X - 3, paneljanela.Location.Y);
                }
                else
                {
                    timer1.Enabled = false;
                }
            }
        }

        private void btnssidebar_leave(object sender, EventArgs e)
        {
            ocultar();
        }

        private void Side_bar_hover(object sender, EventArgs e)
        {
            
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

       

       

       
    }
}
