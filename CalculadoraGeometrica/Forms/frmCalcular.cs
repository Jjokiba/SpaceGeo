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
using Flee.PublicTypes;

namespace CalculadoraGeometrica.Forms
{
    public partial class frmCalcular : Form
    {
        int idForma;
        char[] ch2 = new char[3]; // array de variáveis na fórmula

        public frmCalcular(int idForm)
        {
            InitializeComponent();
            CarregaFormas();
            idForma = idForm;
            cmbNomeForma.SelectedIndex = cmbNomeForma.FindString(idForma.ToString() + " - ");
            CarregarFormulas(null, null);
        }

        public frmPrincipal refFormInicial { get; set; }

        public void Parametros()
        {
            lblFormula.Text = "Selecione";
            lblFormulaComNum.Text = "Selecione";
            lblCalculo.Text = "Calcule";
            txtVar1.Visible = false;
            lbl1.Visible = false;
            txtVar2.Visible = false;
            lbl2.Visible = false;
            txtVar3.Visible = false;
            lbl3.Visible = false;
        }

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
            txtVar1.Visible = false;
            lbl1.Visible = false;
            txtVar2.Visible = false;
            lbl2.Visible = false;
            txtVar3.Visible = false;
            lbl3.Visible = false;

            clsFormula objFormula = new clsFormula();
            MySqlDataReader sql_dr = objFormula.GetFormulaById(Convert.ToInt32(cmbFormula.SelectedItem.ToString().Split('-')[0].Trim()));
            if (sql_dr.Read())
            {
                lblFormula.Text = sql_dr["formula"].ToString();

                char[] ch = new char[lblFormula.Text.Length];

                for (int i = 0; i < lblFormula.Text.Length; i++) // carrega a string da fórmula em um array de char
                {
                    ch[i] = lblFormula.Text[i];
                }

                ch2 = new char[3];
                int quantasVar = 0; // número de variáveis na fórmula
                foreach (char c in ch)
                {
                    if (Char.IsLetter(c))
                    {
                        bool existe = false;
                        foreach (char c2 in ch2)
                        {
                            if (c2.Equals(c)) // se caso a letra já existir no array
                                existe = true;
                        }
                        if (!existe)
                        {
                            ch2[quantasVar] = c;
                            quantasVar++;
                        }
                    }
                }

                if (quantasVar >= 3)
                {
                    txtVar3.Visible = true;
                    lbl3.Visible = true;
                    txtVar2.Visible = true;
                    lbl2.Visible = true;
                    txtVar1.Visible = true;
                    lbl1.Visible = true;
                }
                else if (quantasVar >= 2)
                {
                    txtVar2.Visible = true;
                    lbl2.Visible = true;
                    txtVar1.Visible = true;
                    lbl1.Visible = true;
                }
                else if (quantasVar >= 1)
                {
                    txtVar1.Visible = true;
                    lbl1.Visible = true;
                }

            }
            sql_dr.Close();
        }

        private void CarregarFormulas(object sender, EventArgs e)
        {
            Parametros();
            idForma = Convert.ToInt32(cmbNomeForma.SelectedItem.ToString().Split('-')[0].Trim());
            cmbFormula.Items.Clear();
            clsFormula objFormula = new clsFormula();
            MySqlDataReader sql_dr = objFormula.GetFormulasByIdForma(idForma);
            while (sql_dr.Read())
            {
                cmbFormula.Items.Add(sql_dr["id_formula"].ToString() + " - " + sql_dr["nome_formula"].ToString());
            }
            sql_dr.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAdicionar edit = new frmAdicionar(idForma, 1);
            edit.refFormEdit = this;

            this.Hide();
            edit.Show();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (checkCampos())
            {
                substituiCalculo(lblFormula.Text.ToString().Trim());
                String calculo = lblFormulaComNum.Text.ToString().Trim();
                try
                {
                    ExpressionContext context = new ExpressionContext();
                    context.Imports.AddType(typeof(Math));
                    IGenericExpression<double> eGeneric = context.CompileGeneric<double>(calculo);
                    calculo = eGeneric.Evaluate().ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                lblCalculo.Text = calculo;
            }
        }

        private void substituiCalculo(String cal)
        {
            String calculo = cal;
            if (txtVar1.Visible && txtVar1.Text.ToString() != "")
            {
                calculo = calculo.Replace(ch2[0].ToString(), txtVar1.Text.ToString());
                if (txtVar2.Visible)
                {
                    if (txtVar2.Text.ToString() != "")
                    {
                        calculo = calculo.Replace(ch2[1].ToString(), txtVar2.Text.ToString());
                        if (txtVar3.Visible)
                        {
                            if (txtVar3.Text.ToString() != "")
                            {
                                calculo = calculo.Replace(ch2[2].ToString(), txtVar3.Text.ToString());
                            }
                        }
                    }
                }
            }
            lblFormulaComNum.Text = calculo;
        }

        private bool checkCampos()
        {
            bool ok = false;
            if (txtVar1.Visible && txtVar1.Text.ToString() != "")
            {
                if (txtVar2.Visible)
                {
                    if (txtVar2.Text.ToString() != "")
                    {
                        if (txtVar3.Visible)
                        {
                            if (txtVar3.Text.ToString() != "")
                            {
                                ok = true;
                            }
                        }
                        else
                        {
                            ok = true;
                        }
                    }
                }
                else
                {
                    ok = true;
                }
            }
            return ok;
        }

        private void txtVar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                if (!txtVar1.Text.ToString().Contains(",") && e.KeyChar == ',')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtVar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                if (!txtVar2.Text.ToString().Contains(",") && e.KeyChar == ',')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtVar3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                if (!txtVar3.Text.ToString().Contains(",") && e.KeyChar == ',')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
}
