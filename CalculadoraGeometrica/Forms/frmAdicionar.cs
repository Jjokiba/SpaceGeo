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
        int idForma;
        int op;

        public frmAdicionar(int idForm = -1, int ope = 0)
        {
            op = ope;
            idForma = idForm;
            InitializeComponent();
            CarregaFormas();
            inicializar();
        }

        #region Tratamentos de inicialização do form

        public void inicializar()
        {
            if (op == 0)
            {
                txtNomeNovaForma.Text = "";
                cmbNomeForma.Enabled = false;
                rdbNao.Checked = true;
                cmbNumVar.Text = "";
                txtVar1.Text = "";
                txtVar1.Enabled = false;
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
                cmbFormulas.Text = "";
                cmbNomeForma.Text = "";
            }
            else
            {
                rdbSim.Checked = true;
                cmbNomeForma.SelectedIndex = idForma - 1;
                preencherVariaveis();
            }
        }

        public void preencherVariaveis()
        {
            txtVar1.Text = "";
            txtVar1.Enabled = false;
            txtVar2.Text = "";
            txtVar2.Enabled = false;
            txtVar3.Text = "";
            txtVar3.Enabled = false;

            char[] var = new char[3];
            int i = 0;

            clsVariavel objVar = new clsVariavel();
            MySqlDataReader dr = objVar.GetVarByIdForma(idForma);

            while (dr.Read())
            {
                var[i] = char.Parse(dr["char_variavel"].ToString());

                i++;
            }
            dr.Close();

            if (i == 1) 
            {
                cmbNumVar.SelectedIndex = 0;
                txtVar1.Text = var[0].ToString();
                txtVar1.Enabled = true;
            }
            else if (i == 2) 
            {
                cmbNumVar.SelectedIndex = 1;
                txtVar1.Text = var[0].ToString();
                txtVar1.Enabled = true;
                txtVar2.Text = var[1].ToString();
                txtVar2.Enabled = true;
            }
            else if (i == 3)
            {
                cmbNumVar.SelectedIndex = 2;
                txtVar1.Text = var[0].ToString();
                txtVar1.Enabled = true;
                txtVar2.Text = var[1].ToString();
                txtVar2.Enabled = true;
                txtVar3.Text = var[2].ToString();
                txtVar3.Enabled = true;
            }
        }

        public void CarregaFormas()
        {
            clsForma objForma = new clsForma();
            MySqlDataReader sql_dr = objForma.GetAllFormas();
            while (sql_dr.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = sql_dr["nome_forma"].ToString();
                item.Value = sql_dr["id_forma"].ToString();
                cmbNomeForma.Items.Add(item);
            }
            sql_dr.Close();
        }

        public void validarCampos()
        {
            if ((txtNomeNovaForma.Text == "" && cmbFormulas.Text == "") || txtVar1.Text == "" ||
                txtFormula.Text == "" || cmbFormulas.SelectedItem == null ||
                cmbNumVar.SelectedItem == null)
            {
                validação = false;
            }
            else
            {
                validação = true;
            }
        }

        #endregion
        public frmPrincipal refFormInicial { get; set; }

        public frmCalcular refFormEdit { get; set; }

        private void fechar(object sender, FormClosingEventArgs e)
        {
            if (op == 0)
            {
                refFormInicial.Close();
            }
            else
            {
                refFormEdit.Close();
            }
        }

        #region Tratamentos de click

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
            if (op == 0)
            {
                this.Hide();
                refFormInicial.Show();
            }
            else
            {
                this.Hide();
                refFormEdit.Show();
            }
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
        #endregion

        private void btnInserirFormula_Click(object sender, EventArgs e)
        {
            validarCampos();

            if (validação)
            {
                if (op == 0)
                {
                    if (liberado)
                    {

                        if (inserirFormula())
                        {
                            MessageBox.Show("Cadastrado com sucesso");
                        }

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
                    if (liberado)
                    {
                        if (editarFormula(cmbFormulas.Text, txtFormula.Text))
                        {
                            MessageBox.Show("Editado", "Sucesso");
                        }

                        inicializar();
                    }
                    else
                    {
                        validação = false;
                        MessageBox.Show("Corrija a fórmula! Parenteses faltando ou colocados em excesso");
                        txtFormula.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Erro, preencha os campos corretamente");
            }
            
            
        }
        
        private Boolean inserirFormula()
        {
            Boolean Result = false;
            try
            {
                clsForma classForma = new clsForma();
                clsFormula classFormula = new clsFormula();
                clsVariavel classVariavel = new clsVariavel();
                int idForma = 0;
                if (rdbNao.Checked)
                {
                    byte[] imagemBytes;

                    if (picFotoForma.Image != null)
                    {
                        imagemBytes = classForma.convertImageToByte(picFotoForma.Image);
                    }
                    else
                    {
                        imagemBytes = null;
                    }
                    idForma = classForma.InsertFormas(txtNomeNovaForma.Text, imagemBytes);
                }
                else
                {
                    idForma = int.Parse((cmbNomeForma.SelectedItem as ComboboxItem).Value.ToString());
                }
                classFormula.InsertFormula(cmbFormulas.Text, txtFormula.Text, idForma.ToString());

                if (cmbNumVar.Text == "3")
                {
                    classVariavel.InsertVariavel(txtVar1.Text, idForma.ToString());
                    classVariavel.InsertVariavel(txtVar2.Text, idForma.ToString());
                    classVariavel.InsertVariavel(txtVar3.Text, idForma.ToString());
                }
                else if (cmbNumVar.Text == "2")
                {
                    classVariavel.InsertVariavel(txtVar1.Text, idForma.ToString());
                    classVariavel.InsertVariavel(txtVar2.Text, idForma.ToString());
                }
                else if (cmbNumVar.Text == "1")
                {
                    classVariavel.InsertVariavel(txtVar1.Text, idForma.ToString());
                }
                Result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Result = false;
            }
            
            return Result;
            
        }

        private Boolean editarFormula(string operacao, string formula)
        {
            clsFormula objFormula = new clsFormula();

            try
            {
                objFormula.UpdateFormula(formula, idForma, operacao);
                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;

            }
        }

        private void validarTxt(object sender, EventArgs e)
        {
            if(cmbNumVar.SelectedItem.ToString() == "1") {
                txtVar1.Enabled = true;
                txtVar2.Enabled = false;
                txtVar2.Text = "";
                btnVar2.Text = "";
                btnVar2.Enabled = false;
                txtVar3.Enabled = false;
                btnVar3.Text = "";
                btnVar3.Enabled = false;
            }
            else if (cmbNumVar.SelectedItem.ToString() == "2") {
                txtVar1.Enabled = true;
                txtVar2.Enabled = true;
                txtVar3.Text = "";
                txtVar3.Enabled = false;
                btnVar3.Text = "";
                btnVar3.Enabled = false;
            }
            else if (cmbNumVar.SelectedItem.ToString() == "3")
            {
                txtVar1.Enabled = true;
                txtVar2.Enabled = true;
                txtVar3.Enabled = true;
            }
        }

        private void rbSimNaoNomeFormula(object sender, EventArgs e)
        {
            if (rdbNao.Checked)
            {
                picFotoForma.Image = null;
                txtNomeNovaForma.Enabled = true;
                cmbNomeForma.Enabled = false;
            }
            else
            {
                picFotoForma.Image = null;
                txtNomeNovaForma.Enabled = false;
                cmbNomeForma.Enabled = true;
            }
        }

        private void ValidarVarPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BloquearKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void CarregarFotoForma(object sender, EventArgs e)
        {
            if (cmbNomeForma.Text != null)
            {
                clsForma objForma = new clsForma();
                int idF = int.Parse((cmbNomeForma.SelectedItem as ComboboxItem).Value.ToString());
                MySqlDataReader sql_dr = objForma.GetFormaFromID(idF);

                if (sql_dr.Read())
                {
                    picFotoForma.Image = null;
                    MySqlDataAdapter sql_da = objForma.GetFormaByIDAdapter(idF);
                    sql_da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    DataSet ds = new DataSet();
                    sql_da.Fill(ds, "tb_forma");
                    DataTable table = new DataTable();
                    sql_da.Fill(table);

                    if (ds.Tables[0].Rows[0][2] != System.DBNull.Value)
                    {
                        picFotoForma.Image = objForma.convertByteToImage((byte[])ds.Tables[0].Rows[0][2]);
                    }
                    sql_da.Dispose();
                }
            }
        }

        private void carregaFormula(object sender, EventArgs e)
        {
            if (rdbSim.Checked == true)
            {
                string operacao = cmbFormulas.SelectedItem.ToString();

                clsFormula objFormula = new clsFormula();
                MySqlDataReader dr = objFormula.GetFormulaByOperacao(idForma, operacao);

                if (dr.Read())
                {
                    txtFormula.Text = dr["formula"].ToString();
                }
                else
                {
                    MessageBox.Show("erro");
                }
            }
        }

    }
}
