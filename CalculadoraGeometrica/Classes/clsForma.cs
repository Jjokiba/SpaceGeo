using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.IO;

namespace CalculadoraGeometrica.Classes
{
    class clsForma
    {

        public Byte[] convertImageToByte(Image imageForma)
        {
            MemoryStream ms = new MemoryStream();

            imageForma.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); //Salvando imagem no memoryStream

            Byte[] myData = new Byte[ms.Length];

            myData = ms.ToArray();

            return myData;
        }

        public Image convertByteToImage(Byte[] byteImageForma)
        {
            MemoryStream ms = new MemoryStream(byteImageForma);
            Image imageForma = Image.FromStream(ms);
            return imageForma;
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

        public void InsertFormas(string nomeForma,Byte[] imagemForma = null)
        {
            connectionClass instancia_insert = new connectionClass();
            MySqlCommand sql_cmd = new MySqlCommand();

            sql_cmd.CommandType = CommandType.Text;
            string sql_query = "INSERT INTO tb_forma (nome_forma, imagem_forma) VALUES "
                + "(@nomeFormula" + ((imagemForma != null) ? "@imagemFormula);" : ");");
            sql_cmd.CommandText = sql_query;
            sql_cmd.Parameters.Add("@nomeFormula", MySqlDbType.String).Value = nomeForma;
            if (imagemForma != null)
            {
                sql_cmd.Parameters.Add("@imagemFormula", MySqlDbType.Blob).Value = imagemForma;
            }
            instancia_insert.CRUD(sql_cmd);
        }
    }
}
