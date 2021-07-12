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

        public MySqlDataReader GetFormulaByOperacao(int id, string operacao)
        {
            connectionClass instancia_cnx = new connectionClass();
            MySqlCommand sql_cmd = new MySqlCommand();
            sql_cmd.CommandType = CommandType.Text;
            string sql_query = "SELECT formula FROM tb_formula WHERE id_forma = " + id + " AND nome_formula LIKE '" + operacao + "'";
            sql_cmd.CommandText = sql_query;
            MySqlDataReader sql_dr = instancia_cnx.selecionar(sql_cmd);
            return sql_dr;
        }

        public MySqlDataReader GetFormulaById(int id)
        {
            connectionClass instancia_cnx = new connectionClass();
            MySqlCommand sql_cmd = new MySqlCommand();
            sql_cmd.CommandType = CommandType.Text;
            string sql_query = "SELECT * FROM tb_formula where id_formula = " + id;
            sql_cmd.CommandText = sql_query;
            MySqlDataReader sql_dr = instancia_cnx.selecionar(sql_cmd);
            return sql_dr;
        }

        public void InsertFormula(string nomeFormula, string formula, string idForma)
        {
            connectionClass instancia_insert = new connectionClass();
            MySqlCommand sql_cmd = new MySqlCommand();

            sql_cmd.CommandType = CommandType.Text;
            string sql_query = "INSERT INTO tb_formula (nome_formula, formula, id_forma) VALUES "
                + " ( @nomeFormula, @formula, @idForma)";
            sql_cmd.CommandText = sql_query;
            sql_cmd.Parameters.Add("@nomeFormula", MySqlDbType.String).Value = nomeFormula;
            sql_cmd.Parameters.Add("@formula", MySqlDbType.String).Value = nomeFormula;
            sql_cmd.Parameters.Add("@idForma", MySqlDbType.Int32).Value = idForma;
            
            instancia_insert.CRUD(sql_cmd);
        }

        public void UpdateFormula(string nomeFormula, string formula, int idForma)
        {
            connectionClass instancia_update = new connectionClass();
            
            MySqlCommand sql_cmd = new MySqlCommand();
            sql_cmd.CommandType = CommandType.Text;

            string sql_query = "UPDATE tb_formula SET formula = '@formula' WHERE id_forma = @id AND nome_formula like '@nomeFormula'";
            sql_cmd.CommandText = sql_query;
            sql_cmd.Parameters.AddWithValue("@formula", formula);
            sql_cmd.Parameters.AddWithValue("@id", idForma);
            sql_cmd.Parameters.AddWithValue("@nomeFormula", nomeFormula);

            instancia_update.CRUD(sql_cmd);
        }

    }
}
