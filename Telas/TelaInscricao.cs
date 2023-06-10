using System;
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
    public partial class TelaInscricao : Form
    {
        Class_TelaInscricao _TelaInscricao = new Class_TelaInscricao();
        MySqlConnection Conexao;
        public TelaInscricao()
        {
            InitializeComponent();
        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            TelaOperacao telaOperacao = new TelaOperacao();
            this.Hide();
            telaOperacao.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Validar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "")
            {
                MessageBox.Show(" Campo de Nome Vazio!!!");
                MessageBox.Show("Preencha o Campo de nome");
                txtnome.Focus();
            }
            else
            {
                if (txt_Bi.Text == "")
                {
                    MessageBox.Show(" Campo Vazio Detetado!!!");
                    MessageBox.Show("Preencha o campo de BI");
                    txt_Bi.Focus();
                }
                if (txt_Tel.Text == "")
                {
                    MessageBox.Show(" Campo Vazio Detetado!!!");
                    MessageBox.Show("Preencha o campo de Telefone");
                    txt_Tel.Focus();
                }
                if (txt_Genero.Text == "")
                {
                    MessageBox.Show(" Campo Vazio Detetado!!!");
                    MessageBox.Show(" Preencha o campo de Genero");
                    txt_Genero.Focus();
                }
                if (txt_Nacionalidade.Text == "")
                {
                    MessageBox.Show(" Campo Vazio Detetado!!!");
                    MessageBox.Show(" Preencha o campo de Nacionalidade");
                    txt_Nacionalidade.Focus();
                }
                if (txt_Localidade.Text == "")
                {
                    MessageBox.Show(" Campo Vazio Detetado!!!");
                    MessageBox.Show(" Preencha o campo de Localidade");
                    txt_Localidade.Focus();
                }
                if (txt_Curso.Text == "")
                {
                    MessageBox.Show(" Campo Vazio Detetado!!!");
                    MessageBox.Show(" Preencha o campo de Curso");
                    txt_Curso.Focus();
                }
                if (txt_AreaFormacao.Text == "")
                {
                    MessageBox.Show(" Campo Vazio Detetado!!!");
                    MessageBox.Show(" Preencha o campo de Area de Formação");
                    txt_AreaFormacao.Focus();
                }
            }
           // id_aluno,nome_aluno,data_aluno,tel_aluno,bi_aluno,genero,media_id,curso_id 

            try
            {
                if (txt_AreaFormacao.Text != "" && txt_Curso.Text != "" && txt_Localidade.Text != "" && txt_Nacionalidade.Text != "" && txt_Genero.Text != "" && txt_Tel.Text != "" && txt_Bi.Text != "" && txtnome.Text != "")
                {
                    string data_source = "datasource=localhost;username=root;password=mariopaulos06;database=insc_mat";
                    // conexao com o MYsql
                    Conexao = new MySqlConnection(data_source);


                    string sql = "INSERT INTO aluno(nome_aluno,tel_aluno,bi_aluno,genero) VALUES('" + txtnome.Text + "','" + txt_Tel.Text + "','" + txt_Bi.Text + "','" + txt_Genero.Text+ "')";

                    // comando insert
                    MySqlCommand comando = new MySqlCommand(sql, Conexao);


                    Conexao.Open();

                    comando.ExecuteReader();

                    MessageBox.Show("Aluno inscrito");

                }
            /*catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
            finally
            {
                Conexao.Close();
            }




            _TelaInscricao.Insc_Nome = txtnome.Text;
                    _TelaInscricao.Insc_nuneroBI = txt_Bi.Text;
                    _TelaInscricao.Insc_numTelefone = Convert.ToInt32(txt_Tel.Text);
                    _TelaInscricao.Insc_Genero = txt_Genero.Text;
                    _TelaInscricao.Insc_Nacionalidade = txt_Nacionalidade.Text;
                    _TelaInscricao.Insc_Localidade = txt_Localidade.Text;
                    _TelaInscricao.Insc_Curso = txt_Curso.Text;
                    _TelaInscricao.Insc_AreaFormacao = txt_AreaFormacao.Text;
                    
                    //Obtencao das notas digitadas
                    _TelaInscricao.Lp7 = Convert.ToDouble(txt_LP7.Text);
                    _TelaInscricao.Lp8 = Convert.ToDouble(txt_LP8.Text);
                    _TelaInscricao.Lp9 = Convert.ToDouble(txt_LP9.Text);
                    _TelaInscricao.Lp_media = Convert.ToDouble( txt_LPmedia.Text);

                    _TelaInscricao.Qui7 = Convert.ToDouble(txt_Qui7.Text);
                    _TelaInscricao.Qui8 = Convert.ToDouble(txt_Qui8.Text);
                    _TelaInscricao.Qui9 = Convert.ToDouble(txt_Qui9.Text);
                    _TelaInscricao.Qui_media = Convert.ToDouble(txt_Quimedia.Text);

                    _TelaInscricao.mat7 = Convert.ToDouble(txt_Mat7.Text);
                    _TelaInscricao.mat8 = Convert.ToDouble(txt_Mat8.Text);
                    _TelaInscricao.mat9 = Convert.ToDouble(txt_Mat9.Text);
                    _TelaInscricao.mat_media = Convert.ToDouble(txt_Matmedia.Text);


                    _TelaInscricao.Fis7 = Convert.ToDouble(txt_Fis7.Text);
                    _TelaInscricao.Fis8 = Convert.ToDouble(txt_Fis8.Text);
                    _TelaInscricao.Fis9 = Convert.ToDouble(txt_Fis9.Text);
                    _TelaInscricao.Fis_media = Convert.ToDouble(txt_Fismedia.Text);

                    _TelaInscricao.totalInscrito += 1;*/
                
            } catch (Exception erro)
            {
                MessageBox.Show("ERRO: {0}",erro.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Localidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Genero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Nacionalidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Bi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
