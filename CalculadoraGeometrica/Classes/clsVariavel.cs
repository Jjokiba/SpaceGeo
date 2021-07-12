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

        public MySqlDataReader GetVarByIdForma(int id)
        {
            connectionClass instancia_cnx = new connectionClass();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;

            string query = "SELECT char_variavel FROM tb_variavel WHERE id_forma = " + id;
            cmd.CommandText = query;

            MySqlDataReader dr = instancia_cnx.selecionar(cmd);

            return dr;
        }
    }
}
