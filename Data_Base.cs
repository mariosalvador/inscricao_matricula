using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        
        
        public static void Nova_Entidade(Entidade e)
        {
            try
            {
                var cmd = Conexao_Banco().CreateCommand();
                cmd.CommandText = "INSERT INTO usuario (nome_usuario,senha_usuario,entidade_usuario,id_usuario) VALUES(@nome, @senha, @entidade,(SELECT MAX(id_usuario)+1 FROM usuario))";
                cmd.Parameters.AddWithValue("@nome", e.nome_entidade);
                cmd.Parameters.AddWithValue("@senha", e.senha_entidade);
                cmd.Parameters.AddWithValue("@entidade", e.tipo_entidade);

                MessageBox.Show("Entidade Criada!");
                Conexao_Banco().Close();
            }
            catch (Exception ex)
            {
                Conexao_Banco().Close();
                MessageBox.Show(" " + ex.Message);
            }
        }
    
    }
}
