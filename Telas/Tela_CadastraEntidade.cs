using System;
using Guna.UI2.WinForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inscricao_e_Matricula
{
    
    public partial class Tela_CadastraEntidade : Form
    {
        MySqlConnection Conexao;
      
        public Tela_CadastraEntidade()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            TelaOperacao telaOperacao = new TelaOperacao();
            txtnome_cadastra.Clear();
             txtsenha_cadastra.Clear();
            cb_funcao_cadastra.Text = "";

            this.Hide();
            telaOperacao.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Entidade entidade = new Entidade();
            entidade.nome_entidade = txtnome_cadastra.Text;
            entidade.senha_entidade = txtsenha_cadastra.Text;
            entidade.tipo_entidade = cb_funcao_cadastra.Text;

            Data_Base.Nova_Entidade(entidade);
        }

        private void Tela_CadastraEntidade_Load(object sender, EventArgs e)
        {

        }

        private void cb_funcao_cadastra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtnome_cadastra_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
