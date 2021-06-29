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

namespace CalculadoraGeometrica.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            CarregaFormas();
        }
        
        public void CarregaFormas()
        {
            clsForma objForma = new clsForma();
            MySqlDataReader sql_dr = objForma.GetAllFormas();
            while (sql_dr.Read())
            {
                cmbForma.Items.Add(sql_dr["nome_forma"].ToString());
            }
        }
    }
}
