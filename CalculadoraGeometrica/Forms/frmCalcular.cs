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
    public partial class frmCalcular : Form
    {
        public frmCalcular(int idForma)
        {
            InitializeComponent();
            CarregaFormas();
            cmbNomeForma.SelectedIndex = cmbNomeForma.FindString(idForma.ToString() + " - ");
            CarregarFormulas(idForma);
        }

        public frmPrincipal refFormInicial { get; set; }

        public void CarregaFormas()
        {
            clsForma objForma = new clsForma();
            MySqlDataReader sql_dr = objForma.GetAllFormas();
            while (sql_dr.Read())
            {
                cmbNomeForma.Items.Add(sql_dr["id_forma"].ToString() + " - " + sql_dr["nome_forma"].ToString());
            }
        }

        public void CarregarFormulas(int id)
        {
            clsFormula objFormula = new clsFormula();
            MySqlDataReader sql_dr = objFormula.GetFormulasByIdForma(id);
            while (sql_dr.Read())
            {
                cmbFormula.Items.Add(sql_dr["id_formula"].ToString() + " - " + sql_dr["nome_formula"].ToString());
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            refFormInicial.Show();
        }

        private void frmCalcular_FormClosing(object sender, FormClosingEventArgs e)
        {
            refFormInicial.Close();
        }
    }
}
