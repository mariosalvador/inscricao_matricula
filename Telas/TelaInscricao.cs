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
    public partial class TelaInscricao : Form
    {
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
            if (txt_AreaFormacao.Text !="" && txt_Curso.Text !="" && txt_Localidade.Text!="" && txt_Nacionalidade.Text!="" && txt_Genero.Text !="" && txt_Tel.Text !="" && txt_Bi.Text !="" && txtnome.Text !="")
            {
                Class_TelaInscricao _TelaInscricao = new Class_TelaInscricao();

                _TelaInscricao.Insc_Nome = txtnome.Text;
                _TelaInscricao.Insc_nuneroBI=txt_Bi.Text;
                _TelaInscricao.Insc_numTelefone = Convert.ToInt32(txt_Tel.Text);
                _TelaInscricao.Insc_Genero = txt_Genero.Text;
                _TelaInscricao.Insc_Nacionalidade = txt_Nacionalidade.Text;
                _TelaInscricao.Insc_Localidade = txt_Localidade.Text;
                _TelaInscricao.Insc_Curso = txt_Curso.Text;
                _TelaInscricao.Insc_AreaFormacao = txt_AreaFormacao.Text;

                //Obtencao das notas digitadas
                _TelaInscricao.Lp7 = Convert.ToDouble(txt_LP7);
                _TelaInscricao.Lp8 = Convert.ToDouble(txt_LP8);
                _TelaInscricao.Lp9 = Convert.ToDouble(txt_LP9);
                _TelaInscricao.Lp_media = (_TelaInscricao.Lp7+_TelaInscricao.Lp8+_TelaInscricao.Lp9);

                _TelaInscricao.Lp7 = Convert.ToDouble(txt_LP7);
                _TelaInscricao.Lp8 = Convert.ToDouble(txt_LP8);
                _TelaInscricao.Lp9 = Convert.ToDouble(txt_LP9);
                _TelaInscricao.Lp_media = (_TelaInscricao.Lp7 + _TelaInscricao.Lp8 + _TelaInscricao.Lp9);






            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
