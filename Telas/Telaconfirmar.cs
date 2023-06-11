using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscricao_e_Matricula.Telas
{
    public partial class Telaconfirmar : Form
    {
        public bool aberto;
        public Telaconfirmar()
        {
            InitializeComponent();
            this.txtcodigo.MaxLength = 8;
        }

        private void Telaconfirmar_Load(object sender, EventArgs e)
        {
            txtcodigo.Focus();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            aberto = false;
            this.TopMost = false;
            this.Close();       
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Telas.Configuracoes telaconfig = new Telas.Configuracoes();
            
            if (txtcodigo.Text == Email.codigo.ToString())
            {
                Telas.confirmado tela = new Telas.confirmado();
                this.TopMost = false;
                tela.TopMost = true;
                tela.ShowDialog();
                this.Close();
            }
            else if (txtcodigo.Text == "")
            {
                MessageBox.Show("Preecha o campo em branco com o código enviado ao seu e-mail", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtcodigo.Text != Email.codigo.ToString())
            {
                MessageBox.Show("O número inserido não corresponde ao código enviado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
