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
       // string data_source = "datasource=localhost; username=root; password=mariopaulos06; database=insc_mat";
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
            this.Hide();
            telaOperacao.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

                string data_source = "datasource=localhost;username=root;password=mariopaulos06;database=insc_mat";
                // conexao com o MYsql
                Conexao = new MySqlConnection(data_source);


                string sql = "INSERT INTO entidade(nome_entidade,tipo_entidade,senha_entidade) VALUES('" + txtnome_cadastra.Text + "','" + cb_funcao_cadastra.Text + "','" + txtsenha_cadastra.Text + "')";

                // comando insert
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Entidade Criada");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
    
}
