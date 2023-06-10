using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Inscricao_e_Matricula
{
    public class Data_Base
    {
        static string data_source = "datasource=localhost; username=root; password=mariopaulos06; database=insc_mat";
      public static  MySqlConnection  conexao;

        public static MySqlConnection Conexao_Banco()
        {
            conexao = new MySqlConnection(data_source);
            conexao.Open();
            return conexao;
        }


        public DataTable Obter_Usuarios()
        {
            MySqlDataAdapter data = null;
            DataTable dataTable = new DataTable();

            try
            {
                using (var cmd = Conexao_Banco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM usuarios";
                    data = new MySqlDataAdapter(cmd.CommandText, Conexao_Banco());

                    data.Fill(dataTable);
                    Conexao_Banco().Close();
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable Consulta(string mySql)
        {

            MySqlDataAdapter data = null;
            DataTable dataTable = new DataTable();

            try
            {
                using (var cmd = Conexao_Banco().CreateCommand())
                {
                    cmd.CommandText = mySql;
                    data = new MySqlDataAdapter(cmd.CommandText, Conexao_Banco());

                    data.Fill(dataTable);
                    Conexao_Banco().Close();
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                Conexao_Banco().Close();
                throw ex;
            }

        }
    }
}
