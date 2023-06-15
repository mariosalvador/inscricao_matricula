using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Inscricao_e_Matricula.Telas
{
    public partial class Configuracoes : Form
    {
        public string caminho_fotos = System.Environment.CurrentDirectory + @"\fotos\";
        public string Nome;
        public string imagem_perfil = "";
        string caminho_imagem = "";

        public Configuracoes()
        {
            InitializeComponent();
        }
        
        private void Configuracões_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_add_foto_Click(object sender, EventArgs e)
        {
            
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
            pic_perfil.ImageLocation = caminho_imagem;
            pic_perfil.Load();
            //}
            //else
            //{
            //    MessageBox.Show("O Arquivo não foi copiado.", "Aviso!!", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            //}
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Telas.Telaconfirmar tela = new Telas.Telaconfirmar();
            if (altswitch.Checked == true)
            {
                string destino = "";
                string corpo = "Utilize este código para confirmar as alterações nas configuracões do Sistema de Inscrição e Matrícula do IPIL: ";
                string assunto = "Código de verificação";
                Random aleatorio = new Random();
                Email.codigo = aleatorio.Next(10000000, 100000001);
                if (Email.validar(txtemail.Text) == true)
                {
                    destino = txtemail.Text;
                    corpo += Email.codigo.ToString();
                    MailMessage mensasgem = new MailMessage();
                    mensasgem.From = new MailAddress("ipil20222023@gmail.com");//de
                    mensasgem.To.Add(destino);//para
                    mensasgem.Subject = assunto;//assunto
                    mensasgem.Body = corpo;//mensagem
                    SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
                    cliente.EnableSsl = true;
                    cliente.UseDefaultCredentials = false;
                    cliente.Timeout = 50000;
                    NetworkCredential credenciais = new NetworkCredential("ipil20222023", "knripzxeorwbgpud");
                    cliente.Credentials = credenciais;
                    try
                    {
                        cliente.Send(mensasgem);
                        cliente.Dispose();
                        MessageBox.Show("Mensagem envida, verifique seu e-mail", "Aviso");
                        txtemail.Text = string.Empty;
                        tela.TopMost = true;
                        tela.ShowDialog();
                        if (tela.aberto == false)
                        {
                            this.Enabled = true;
                        }
                        else
                        {
                            this.Enabled = false;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Falha ao enviar o código");
                    }
                }
                else
                {
                    MessageBox.Show("E-mail inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            else
            {
                imagem_perfil = caminho_imagem;
                Telas.confirmado telaconf = new Telas.confirmado();
                telaconf.TopMost = true;
                telaconf.ShowDialog();
                if (tela.aberto == false)
                {
                    this.Enabled = true;
                }
                else
                {
                    this.Enabled = false;
                }
            }
            
            
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            
        }

       
    }
}
