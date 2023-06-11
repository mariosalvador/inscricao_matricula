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
            aberto = true;
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
    }
}
