using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CalculadoraGeometrica.Classes
{
    class clsFormula
    {
        public MySqlDataReader GetAllFormulas()
        {
            connectionClass instancia_cnx = new connectionClass();
            MySqlCommand sql_cmd = new MySqlCommand();
            sql_cmd.CommandType = CommandType.Text;
            string sql_query = "SELECT * FROM tb_formula";
            sql_cmd.CommandText = sql_query;
            MySqlDataReader sql_dr = instancia_cnx.selecionar(sql_cmd);
            return sql_dr;
        }

        public MySqlDataReader GetFormulasByIdForma(int id)
        {
            connectionClass instancia_cnx = new connectionClass();
            MySqlCommand sql_cmd = new MySqlCommand();
            sql_cmd.CommandType = CommandType.Text;
            string sql_query = "SELECT * FROM tb_formula where id_forma = " + id;
            sql_cmd.CommandText = sql_query;
            MySqlDataReader sql_dr = instancia_cnx.selecionar(sql_cmd);
            return sql_dr;
        }
    }
}
