using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraGeometrica.Classes
{
    class clsVariavel
    {
        public void InsertVariavel(string charVariavel, string idForma)
        {
            connectionClass instancia_insert = new connectionClass();
            MySqlCommand sql_cmd = new MySqlCommand();

            sql_cmd.CommandType = CommandType.Text;
            string sql_query = "INSERT INTO tb_Variavel (char_variavel, id_forma) VALUES "
                + " ( @charVariavel, @idForma)";
            sql_cmd.CommandText = sql_query;
            sql_cmd.Parameters.Add("@charVariavel", MySqlDbType.String).Value = charVariavel;
            sql_cmd.Parameters.Add("@idForma", MySqlDbType.Int32).Value = int.Parse(idForma);

            instancia_insert.CRUD(sql_cmd);
        }
    }
}
