namespace CalculadoraGeometrica.Forms
{
    partial class frmCalcular
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbNomeForma = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFormula = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtVar3 = new System.Windows.Forms.TextBox();
            this.txtVar2 = new System.Windows.Forms.TextBox();
            this.txtVar1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblCalculo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFormulaComNum = new System.Windows.Forms.Label();
            this.lblFormula = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbNomeForma);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbFormula);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(723, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma";
            // 
            // cmbNomeForma
            // 
            this.cmbNomeForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeForma.FormattingEnabled = true;
            this.cmbNomeForma.Location = new System.Drawing.Point(20, 54);
            this.cmbNomeForma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNomeForma.Name = "cmbNomeForma";
            this.cmbNomeForma.Size = new System.Drawing.Size(233, 26);
            this.cmbNomeForma.TabIndex = 4;
            this.cmbNomeForma.SelectedIndexChanged += new System.EventHandler(this.CarregarFormulas);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(583, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 127);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da forma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Qual Formula deseja realizar o Calculo?";
            // 
            // cmbFormula
            // 
            this.cmbFormula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormula.FormattingEnabled = true;
            this.cmbFormula.Location = new System.Drawing.Point(20, 111);
            this.cmbFormula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFormula.Name = "cmbFormula";
            this.cmbFormula.Size = new System.Drawing.Size(233, 26);
            this.cmbFormula.TabIndex = 4;
            this.cmbFormula.SelectedIndexChanged += new System.EventHandler(this.CarregaLbl);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl3);
            this.groupBox2.Controls.Add(this.lbl2);
            this.groupBox2.Controls.Add(this.txtVar3);
            this.groupBox2.Controls.Add(this.txtVar2);
            this.groupBox2.Controls.Add(this.txtVar1);
            this.groupBox2.Controls.Add(this.lbl1);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.lblCalculo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblFormulaComNum);
            this.groupBox2.Controls.Add(this.lblFormula);
            this.groupBox2.Controls.Add(this.btnVoltar);
            this.groupBox2.Controls.Add(this.btnCalcular);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 172);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(723, 305);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Formula";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(6, 149);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(140, 18);
            this.lbl3.TabIndex = 29;
            this.lbl3.Text = "Numero da variavel 3:";
            this.lbl3.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(6, 87);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(140, 18);
            this.lbl2.TabIndex = 28;
            this.lbl2.Text = "Numero da variavel 2:";
            this.lbl2.Visible = false;
            // 
            // txtVar3
            // 
            this.txtVar3.Location = new System.Drawing.Point(9, 169);
            this.txtVar3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVar3.Name = "txtVar3";
            this.txtVar3.Size = new System.Drawing.Size(233, 26);
            this.txtVar3.TabIndex = 27;
            this.txtVar3.Visible = false;
            this.txtVar3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVar3_KeyPress);
            // 
            // txtVar2
            // 
            this.txtVar2.Location = new System.Drawing.Point(9, 107);
            this.txtVar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVar2.Name = "txtVar2";
            this.txtVar2.Size = new System.Drawing.Size(233, 26);
            this.txtVar2.TabIndex = 26;
            this.txtVar2.Visible = false;
            this.txtVar2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVar2_KeyPress);
            // 
            // txtVar1
            // 
            this.txtVar1.Location = new System.Drawing.Point(9, 51);
            this.txtVar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVar1.Name = "txtVar1";
            this.txtVar1.Size = new System.Drawing.Size(233, 26);
            this.txtVar1.TabIndex = 25;
            this.txtVar1.Visible = false;
            this.txtVar1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVar1_KeyPress);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(5, 31);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(138, 18);
            this.lbl1.TabIndex = 24;
            this.lbl1.Text = "Numero da variavel 1:";
            this.lbl1.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(503, 254);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 47);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Editar Formula";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblCalculo
            // 
            this.lblCalculo.AutoSize = true;
            this.lblCalculo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculo.Location = new System.Drawing.Point(369, 217);
            this.lblCalculo.Name = "lblCalculo";
            this.lblCalculo.Size = new System.Drawing.Size(76, 27);
            this.lblCalculo.TabIndex = 22;
            this.lblCalculo.Text = "Calcule";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Resultado:";
            // 
            // lblFormulaComNum
            // 
            this.lblFormulaComNum.AutoSize = true;
            this.lblFormulaComNum.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormulaComNum.Location = new System.Drawing.Point(369, 142);
            this.lblFormulaComNum.Name = "lblFormulaComNum";
            this.lblFormulaComNum.Size = new System.Drawing.Size(98, 27);
            this.lblFormulaComNum.TabIndex = 20;
            this.lblFormulaComNum.Text = "Selecione";
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormula.Location = new System.Drawing.Point(369, 63);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(98, 27);
            this.lblFormula.TabIndex = 19;
            this.lblFormula.Text = "Selecione";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(5, 254);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 47);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "< Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(609, 254);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 47);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Formula com os valores:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Formula:";
            // 
            // frmCalcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 489);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(761, 528);
            this.MinimumSize = new System.Drawing.Size(761, 528);
            this.Name = "frmCalcular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCalcular_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbNomeForma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFormula;
        private System.Windows.Forms.Label lblCalculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFormulaComNum;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtVar3;
        private System.Windows.Forms.TextBox txtVar2;
        private System.Windows.Forms.TextBox txtVar1;
        private System.Windows.Forms.Label lbl1;
    }
}