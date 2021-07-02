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
    public partial class frmAdicionar : Form
    {
        public bool liberado = true, validação = false;

        public frmAdicionar()
        {
            InitializeComponent();
            CarregaFormas();
            inicializar();
        }

        public frmPrincipal refFormInicial { get; set; }

        public void inicializar()
        {
            txtNomeForma.Text = "";
            cmbNomeForma.Enabled = false;
            rdbNao.Checked = true;
            cmbNumVar.SelectedItem = "";
            txtVar1.Text = "";
            txtVar2.Text = "";
            txtVar2.Enabled = false;
            txtVar3.Text = "";
            txtVar3.Enabled = false;
            txtFormula.Text = "";
            btnVar1.Text = "";
            btnVar1.Enabled = false;
            btnVar2.Text = "";
            btnVar2.Enabled = false;
            btnVar3.Text = "";
            btnVar3.Enabled = false;
        }

        public void CarregaFormas()
        {
            clsForma objForma = new clsForma();
            MySqlDataReader sql_dr = objForma.GetAllFormas();
            while (sql_dr.Read())
            {
                cmbNomeForma.Items.Add(sql_dr["nome_forma"].ToString());
            }
        }

        public void validarCampos()
        {
            if (txtNomeForma.Text == "" || txtVar1.Text == "" ||
                txtFormula.Text == "")
            {
                validação = false;
            }
            else
            {
                validação = true;
            }
        }

        private void fechar(object sender, FormClosingEventArgs e)
        {
            refFormInicial.Close();
        }

        private void btnBuscarImagem_Click(object sender, EventArgs e)
        {
            ofdBuscarFoto.Filter = "png|*.png|jpeg|*.jpg|bmp|*.bmp|all files|*.*";

            DialogResult dialog = ofdBuscarFoto.ShowDialog();

            if (dialog == DialogResult.OK) {
                picFotoForma.Image = Image.FromFile(ofdBuscarFoto.FileName);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            refFormInicial.Show();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            txtFormula.Text += "-";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            txtFormula.Text += "+";
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            txtFormula.Text += "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtFormula.Text += "/";
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            txtFormula.Text += "^";
        }

        private void btnAbrePar_Click(object sender, EventArgs e)
        {
            txtFormula.Text += "(";
            liberado = false;
        }

        private void btnFechaPar_Click(object sender, EventArgs e)
        {
            txtFormula.Text += ")";
            liberado = true;
        }

        private void btnVar1_Click(object sender, EventArgs e)
        {
            txtFormula.Text += btnVar1.Text;
        }

        private void btnVar2_Click(object sender, EventArgs e)
        {
            txtFormula.Text += btnVar2.Text;
        }

        private void btnVar3_Click(object sender, EventArgs e)
        {
            txtFormula.Text += btnVar3.Text;
        }

        private void varum(object sender, EventArgs e)
        {
            btnVar1.Text = txtVar1.Text;

            if (txtVar1.Text != "") {
                btnVar1.Enabled = true;
            }
            else {
                btnVar1.Enabled = false;
            }
        }

        private void vardois(object sender, EventArgs e)
        {
            btnVar2.Text = txtVar2.Text;

            if (txtVar2.Text != "")
            {
                btnVar2.Enabled = true;
            }
            else
            {
                btnVar2.Enabled = false;
            }
        }

        private void vartres(object sender, EventArgs e)
        {
            btnVar3.Text = txtVar3.Text;

            if (txtVar3.Text != "")
            {
                btnVar3.Enabled = true;
            }
            else
            {
                btnVar3.Enabled = false;
            }
        }

        private void btnInserirFormula_Click(object sender, EventArgs e)
        {
            try
            {
                validarCampos();

                if (validação)
                {
                    if (liberado)
                    {
                        MessageBox.Show("Cadastrado com sucesso");
                        inicializar();
                    }
                    else
                    {
                        validação = false;
                        MessageBox.Show("Corrija a fórmula! Parenteses faltando ou colocados em excesso");
                        txtFormula.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Erro, preencha os campos corretamente");
                }
            }
            catch
            {
                MessageBox.Show("Erro fatal");
            }
        }

        private void validar(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)(Keys.Back))
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
