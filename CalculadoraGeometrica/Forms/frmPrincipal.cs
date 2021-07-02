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

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            frmCalcular calcular = new frmCalcular();
            calcular.refFormInicial = this;

            this.Hide();
            calcular.Show();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAdicionar adicionar = new frmAdicionar();
            adicionar.refFormInicial = this;

            this.Hide();
            adicionar.Show();
        }
    }
}
