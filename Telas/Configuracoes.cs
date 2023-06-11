using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Inscricao_e_Matricula.Telas
{
    public partial class Configuracoes : Form
    {
        public string caminho_fotos = System.Environment.CurrentDirectory + @"\fotos\";
        public Configuracoes()
        {
            InitializeComponent();
        }
        
        private void Configuracões_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_add_foto_Click(object sender, EventArgs e)
        {
            string caminho_imagem="";
            string nome_imagem ="";
            string destino_imagem ="";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                caminho_imagem = openFileDialog1.FileName;
                nome_imagem = openFileDialog1.SafeFileName;
                destino_imagem = caminho_fotos + nome_imagem;

            }
            if (File.Exists(destino_imagem))
            {
                if (MessageBox.Show("O Arquivo já existe, deseja substituir?", "Substituir", MessageBoxButtons.YesNo)==DialogResult.No)
                {
                    return;
                }
                
            }
            //System.IO.File.Copy(caminho_imagem, destino_imagem, true);
            //if (File.Exists(destino_imagem))
            //{
            pic_perfil.Image = Image.FromFile(@caminho_imagem);
            //}
            //else
            //{
            //    MessageBox.Show("O Arquivo não foi copiado.", "Aviso!!", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            //}
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Telas.Telaconfirmar tela = new Telas.Telaconfirmar();
            tela.TopMost = true;
            this.Enabled = false;
            tela.ShowDialog();

            if (tela.aberto == false)
            {
                this.Enabled = true;
            }
            
        }

       
    }
}
