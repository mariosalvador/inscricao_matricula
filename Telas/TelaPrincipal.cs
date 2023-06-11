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
        public Form form = new Form();
        public TelaPrincipal()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        //public void add_tela(Form form)
        //{
        //    var v = new Form();
        //    v = form;
        //    v.Visible = true;
        //    v.Dock = DockStyle.Fill;
        //    paneljanela.Controls.Add(v);
        //}

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
            Telas.Configuracoes tela = new Telas.Configuracoes();
            form = new Telas.Tela_informacao();
            TelaLogin login = new TelaLogin();
            lb_Entidade.Text = login.nome;
            btnhome.FillColor = Color.Orange;
            btnhome.BackColor = Color.Transparent;
            btnadd.FillColor = Color.Transparent;
            btnhelp.FillColor = Color.Transparent;
            btnconfig.FillColor = Color.Transparent;
            btn_ver.FillColor = Color.Transparent;
            form.Visible = true;
            form.Dock= DockStyle.Fill;
            paneljanela.Controls.Add(form);
            Pic_perfil.Image = Image.FromFile(@tela.imagem_perfil);
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
                guna2Button1.Image = Image.FromFile(@"C:\Users\Jesimiel\Documents\IM\inscricao_matricula\Resources\window_restore_icon_137011.png");

                guna2Elipse7.BorderRadius = 0;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                guna2Button1.Image = Image.FromFile(@"C:\Users\Jesimiel\Documents\IM\inscricao_matricula\Resources\window_maximize_icon_137012.png");
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
            form = new TelaOperacao();
            paneljanela.Controls.Clear();
            form.TopLevel = false;
            form.Visible = true;
            form.Dock = DockStyle.Fill;
            paneljanela.Controls.Add(form);
            btnhome.FillColor = Color.Transparent;
            btnadd.FillColor = Color.Orange;
            btnhelp.FillColor = Color.Transparent;
            btnconfig.FillColor = Color.Transparent;
            btn_ver.FillColor = Color.Transparent;
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
            form = new Telas.Configuracoes();
            paneljanela.Controls.Clear();
            form.TopLevel = false;
            form.Visible = true;
            form.Dock = DockStyle.Fill;
            paneljanela.Controls.Add(form);
            btnconfig.FillColor = Color.Orange;
            btnhome.FillColor = Color.Transparent;
            btnadd.FillColor = Color.Transparent;
            btnhelp.FillColor = Color.Transparent;
            btn_ver.FillColor = Color.Transparent;
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
            form = new Telas.Tela_informacao();
            paneljanela.Controls.Clear();
            form.TopLevel = false;
            form.Visible = true;
            form.Dock = DockStyle.Fill;
            paneljanela.Controls.Add(form);
            btnhome.FillColor = Color.Orange;
            btnadd.FillColor = Color.Transparent;
            btnhelp.FillColor = Color.Transparent;
            btnconfig.FillColor = Color.Transparent;
            btn_ver.FillColor = Color.Transparent;
        }

        private void lb_Entidade_Click(object sender, EventArgs e)
        {

        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            form =new Telas.Ajuda();
            paneljanela.Controls.Clear();
            form.TopLevel = false;
            form.Visible = true;
            form.Dock = DockStyle.Fill;
            paneljanela.Controls.Add(form);
            btnhome.FillColor = Color.Transparent;
            btnadd.FillColor = Color.Transparent;
            btnhelp.FillColor = Color.Orange;
            btnconfig.FillColor = Color.Transparent;
            btn_ver.FillColor = Color.Transparent;

        }
    }
}
