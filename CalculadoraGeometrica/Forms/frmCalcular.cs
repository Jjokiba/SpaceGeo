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
            sql_dr.Close();
        }

        public void CarregarFormulas(int id)
        {
            clsFormula objFormula = new clsFormula();
            MySqlDataReader sql_dr = objFormula.GetFormulasByIdForma(id);
            while (sql_dr.Read())
            {
                cmbFormula.Items.Add(sql_dr["id_formula"].ToString() + " - " + sql_dr["nome_formula"].ToString());
            }
            sql_dr.Close();
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

        private void CarregaLbl(object sender, EventArgs e)
        {
            clsFormula objFormula = new clsFormula();
            MySqlDataReader sql_dr = objFormula.GetFormulaById(Convert.ToInt32(cmbFormula.SelectedItem.ToString().Split('-')[0].Trim()));
            if (sql_dr.Read())
            {
                lblFormula.Text = sql_dr["formula"].ToString();

                if (lblFormula.Text.Contains("A"))
                {
                    txtVarA.Visible = true;
                    lblA.Visible = true;
                }
                else
                {
                    txtVarA.Visible = false;
                    lblA.Visible = false;
                }
                if (lblFormula.Text.Contains("B"))
                {
                    txtVarB.Visible = true;
                    lblB.Visible = true;
                }
                else
                {
                    txtVarB.Visible = false;
                    lblB.Visible = false;
                }
                if (lblFormula.Text.Contains("C"))
                {
                    txtVarC.Visible = true;
                    lblC.Visible = true;
                }
                else
                {
                    txtVarC.Visible = false;
                    lblC.Visible = false;
                }
                if (lblFormula.Text.Contains("D"))
                {
                    txtVarD.Visible = true;
                    lblD.Visible = true;
                }
                else
                {
                    txtVarD.Visible = false;
                    lblD.Visible = false;
                }
                if (lblFormula.Text.Contains("E"))
                {
                    txtVarE.Visible = true;
                    lblE.Visible = true;
                }
                else
                {
                    txtVarE.Visible = false;
                    lblE.Visible = false;
                }
            }
            sql_dr.Close();
        }
    }
}
