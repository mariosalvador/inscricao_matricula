using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscricao_e_Matricula
{
   public class Codigo
    {
    }

    // Class para os metodos da tela Principal 
    public class Class_TelaPrincipal
    {
       
        public int totalInscrito { get; set; }
        public int vagasDisponiveis { get; private set; }
        public int totalMatriculado { get; set; }
        
        

       
     

    }

    // Class para os Metodos da tela de Inscricao

    public class Class_TelaInscricao
    {
        public string Insc_Nome;
        public string Insc_nuneroBI;
        public int Insc_numTelefone;
        public string Insc_Genero;
        public string Insc_Nacionalidade;
        public string Insc_Localidade;
        public string Insc_Endereco;
        public string Insc_Curso;
        public string Insc_AreaFormacao;

        // Variaveis para as Notas do Certificado
        public double Lp7, Lp8, Lp9, Lp_media;
        public double mat7, mat8, mat9, mat_media;
        public double Qui7, Qui8, Qui9, Qui_media;
        public double Ing7, Ing8, Ing9, Ing_media;
        public double Fis7, Fis8, Fis9, Fis_media;

    }
}
