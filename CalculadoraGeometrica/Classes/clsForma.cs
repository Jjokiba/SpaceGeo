using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CalculadoraGeometrica.Classes
{
    class clsForma
    {
        public MySqlDataReader GetAllFormas()
        {
            connectionClass instancia_cnx = new connectionClass();
            MySqlCommand sql_cmd = new MySqlCommand();
            sql_cmd.CommandType = CommandType.Text;
            string sql_query = "SELECT * FROM tb_forma";
            sql_cmd.CommandText = sql_query;
            MySqlDataReader sql_dr = instancia_cnx.selecionar(sql_cmd);
            return sql_dr;
        }
    }
}
