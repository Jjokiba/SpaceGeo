﻿using System;
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
                cmbForma.Items.Add(sql_dr["id_forma"].ToString() + " - " + sql_dr["nome_forma"].ToString());
            }
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
    }
}
