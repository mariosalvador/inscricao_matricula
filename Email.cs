using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Inscricao_e_Matricula
{
    public class Email
    {
        public static int codigo;
        public static bool validar(string email)
        {
            Regex expressao = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (expressao.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
