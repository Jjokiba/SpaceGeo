using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace CalculadoraGeometrica.Classes
{
    class clsForma
    {
        


        public Byte[] convertImageToByte(Image imageForma)
        {
            if (imageForma != null)
            {
                byte[] foto_array;
                using (MemoryStream stream = new MemoryStream())
                {
                    Bitmap bmp = new Bitmap(imageForma);
                    bmp.Save(stream, ImageFormat.Jpeg);
                    foto_array = stream.ToArray();
                }

                return (foto_array);
            }
            else
            {
                return (null);
            }
        }

        public Image convertByteToImage(Byte[] byteImageForma)
        {
            MemoryStream ms = new MemoryStream(byteImageForma);
            try
            {
                return Image.FromStream(ms);
            }
            catch
            {
                return null;
            }
        }


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

        public MySqlDataReader GetFormaFromID(int id)
        {
            connectionClass instancia_cnx = new connectionClass();
            MySqlCommand sql_cmd = new MySqlCommand();
            sql_cmd.CommandType = CommandType.Text;
            string sql_query = "SELECT * FROM tb_forma WHERE id_forma = @idforma";
            sql_cmd.CommandText = sql_query;
            sql_cmd.Parameters.Add("@idforma", MySqlDbType.Int32).Value = id;
            MySqlDataReader sql_dr = instancia_cnx.selecionar(sql_cmd);
            return sql_dr;
        }

        public MySqlDataAdapter GetFormaByIDAdapter(int id)
        {
            connectionClass instancia_cnx = new connectionClass();
            MySqlCommand sql_cmd = new MySqlCommand();
            sql_cmd.CommandType = CommandType.Text;
            string sql_query = "SELECT * FROM tb_forma WHERE id_forma = @idforma";
            sql_cmd.CommandText = sql_query;
            sql_cmd.Parameters.Add("@idforma", MySqlDbType.Int32).Value = id;
            MySqlDataAdapter sql_dr = instancia_cnx.selecionarAdapter(sql_cmd);
            return sql_dr;
        }

        public int InsertFormas(string nomeForma,Byte[] imagemForma = null)
        {
            connectionClass instancia_insert = new connectionClass();
            MySqlCommand sql_cmd = new MySqlCommand();

            sql_cmd.CommandType = CommandType.Text;
            string sql_query = "INSERT INTO tb_forma (nome_forma, imagem_forma) VALUES "
                + "(@nomeFormula" + ((imagemForma != null) ? ", @imagemFormula);" : ", NULL);");
            sql_cmd.CommandText = sql_query;
            sql_cmd.Parameters.Add("@nomeFormula", MySqlDbType.String).Value = nomeForma;
            if (imagemForma != null)
            {
                sql_cmd.Parameters.Add("@imagemFormula", MySqlDbType.Blob).Value = imagemForma;
            }
            instancia_insert.CRUD(sql_cmd);

            sql_query = "select MAX(id_forma) as ULTIMO FROM tb_forma;";
            sql_cmd.CommandText = sql_query;
            MySqlDataReader sql_dr = instancia_insert.selecionar(sql_cmd);
            int lastIdGenerated = -1;
            while (sql_dr.Read())
            {
                lastIdGenerated = int.Parse(sql_dr["ULTIMO"].ToString());
            }

            return lastIdGenerated;
        }

        
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
