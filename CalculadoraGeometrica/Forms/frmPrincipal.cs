using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CalculadoraGeometrica.Classes;
using System.IO;

namespace CalculadoraGeometrica.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            //CarregaFormas();
        }
        
        public void CarregaFormas()
        {
            cmbForma.Items.Clear();
            clsForma objForma = new clsForma();
            MySqlDataReader sql_dr = objForma.GetAllFormas();

            while (sql_dr.Read())
            {
                cmbForma.Items.Add(sql_dr["id_forma"].ToString() + " - " + sql_dr["nome_forma"].ToString());
            }
            sql_dr.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (cmbForma.SelectedIndex != -1)
            {
                int idF = Convert.ToInt32(cmbForma.SelectedItem.ToString().Split('-')[0].Trim());
                frmCalcular calcular = new frmCalcular(idF);
                calcular.refFormInicial = this;

                this.Hide();
                calcular.Show();
            }
            else
            {
                MessageBox.Show("Selecione uma forma para prosseguir!", "Atenção");
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAdicionar adicionar = new frmAdicionar();
            adicionar.refFormInicial = this;

            this.Hide();
            adicionar.Show();
        }

        private void CarregarImagemForma(object sender, EventArgs e)
        {
            if (cmbForma.Text != null)
            {
                clsForma objForma = new clsForma();
                int idF = Convert.ToInt32(cmbForma.SelectedItem.ToString().Split('-')[0].Trim());
                MySqlDataReader sql_dr = objForma.GetFormaFromID(idF);

                if (sql_dr.Read())
                {
                    picImage.Image = null;
                    MySqlDataAdapter sql_da = objForma.GetFormaByIDAdapter(idF);
                    sql_da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    DataSet ds = new DataSet();
                    sql_da.Fill(ds, "tb_forma");
                    DataTable table = new DataTable();
                    sql_da.Fill(table);

                    if (ds.Tables[0].Rows[0][2] != System.DBNull.Value)
                    {
                        picImage.Image = objForma.convertByteToImage((byte[])ds.Tables[0].Rows[0][2]);
                    }
                    sql_da.Dispose();

                }
            }
        }

        private void CarregarFormulas(object sender, EventArgs e)
        {
            CarregaFormas();
        }
    }
}
