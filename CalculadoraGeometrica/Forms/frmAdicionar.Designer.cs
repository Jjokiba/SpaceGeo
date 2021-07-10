namespace CalculadoraGeometrica.Forms
{
    partial class frmAdicionar
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
            this.btnBuscarImagem = new System.Windows.Forms.Button();
            this.cmbNomeForma = new System.Windows.Forms.ComboBox();
            this.picFotoForma = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeNovaForma = new System.Windows.Forms.TextBox();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVar3 = new System.Windows.Forms.Button();
            this.btnVar2 = new System.Windows.Forms.Button();
            this.btnVar1 = new System.Windows.Forms.Button();
            this.btnFechaPar = new System.Windows.Forms.Button();
            this.cmbFormulas = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnInserirFormula = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnAbrePar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNumVar = new System.Windows.Forms.ComboBox();
            this.txtVar3 = new System.Windows.Forms.TextBox();
            this.txtVar2 = new System.Windows.Forms.TextBox();
            this.txtVar1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ofdBuscarFoto = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoForma)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarImagem);
            this.groupBox1.Controls.Add(this.cmbNomeForma);
            this.groupBox1.Controls.Add(this.picFotoForma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNomeNovaForma);
            this.groupBox1.Controls.Add(this.rdbNao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbSim);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(728, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma";
            // 
            // btnBuscarImagem
            // 
            this.btnBuscarImagem.Location = new System.Drawing.Point(365, 57);
            this.btnBuscarImagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarImagem.Name = "btnBuscarImagem";
            this.btnBuscarImagem.Size = new System.Drawing.Size(100, 47);
            this.btnBuscarImagem.TabIndex = 16;
            this.btnBuscarImagem.Text = "Procurar imagem";
            this.btnBuscarImagem.UseVisualStyleBackColor = true;
            this.btnBuscarImagem.Click += new System.EventHandler(this.btnBuscarImagem_Click);
            // 
            // cmbNomeForma
            // 
            this.cmbNomeForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeForma.FormattingEnabled = true;
            this.cmbNomeForma.Location = new System.Drawing.Point(20, 86);
            this.cmbNomeForma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNomeForma.Name = "cmbNomeForma";
            this.cmbNomeForma.Size = new System.Drawing.Size(233, 24);
            this.cmbNomeForma.TabIndex = 4;
            this.cmbNomeForma.SelectedValueChanged += new System.EventHandler(this.CarregarFotoForma);
            // 
            // picFotoForma
            // 
            this.picFotoForma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFotoForma.Location = new System.Drawing.Point(259, 34);
            this.picFotoForma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFotoForma.Name = "picFotoForma";
            this.picFotoForma.Size = new System.Drawing.Size(101, 91);
            this.picFotoForma.TabIndex = 15;
            this.picFotoForma.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da forma:";
            // 
            // txtNomeNovaForma
            // 
            this.txtNomeNovaForma.Location = new System.Drawing.Point(20, 57);
            this.txtNomeNovaForma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeNovaForma.Name = "txtNomeNovaForma";
            this.txtNomeNovaForma.Size = new System.Drawing.Size(233, 22);
            this.txtNomeNovaForma.TabIndex = 3;
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Location = new System.Drawing.Point(487, 98);
            this.rdbNao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(55, 21);
            this.rdbNao.TabIndex = 2;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "Não";
            this.rdbNao.UseVisualStyleBackColor = true;
            this.rdbNao.CheckedChanged += new System.EventHandler(this.rbSimNaoNomeFormula);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "A forma na qual deseja inserir \r\numa nova formula ja está no banco?";
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Location = new System.Drawing.Point(487, 71);
            this.rdbSim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(52, 21);
            this.rdbSim.TabIndex = 0;
            this.rdbSim.TabStop = true;
            this.rdbSim.Text = "Sim";
            this.rdbSim.UseVisualStyleBackColor = true;
            this.rdbSim.CheckedChanged += new System.EventHandler(this.rbSimNaoNomeFormula);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVar3);
            this.groupBox2.Controls.Add(this.btnVar2);
            this.groupBox2.Controls.Add(this.btnVar1);
            this.groupBox2.Controls.Add(this.btnFechaPar);
            this.groupBox2.Controls.Add(this.cmbFormulas);
            this.groupBox2.Controls.Add(this.btnVoltar);
            this.groupBox2.Controls.Add(this.btnInserirFormula);
            this.groupBox2.Controls.Add(this.btnSquare);
            this.groupBox2.Controls.Add(this.btnAbrePar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnDivide);
            this.groupBox2.Controls.Add(this.btnTimes);
            this.groupBox2.Controls.Add(this.btnMais);
            this.groupBox2.Controls.Add(this.btnMenos);
            this.groupBox2.Controls.Add(this.txtFormula);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbNumVar);
            this.groupBox2.Controls.Add(this.txtVar3);
            this.groupBox2.Controls.Add(this.txtVar2);
            this.groupBox2.Controls.Add(this.txtVar1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 172);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(728, 336);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Formula";
            // 
            // btnVar3
            // 
            this.btnVar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVar3.Location = new System.Drawing.Point(628, 217);
            this.btnVar3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVar3.Name = "btnVar3";
            this.btnVar3.Size = new System.Drawing.Size(61, 48);
            this.btnVar3.TabIndex = 23;
            this.btnVar3.UseVisualStyleBackColor = true;
            this.btnVar3.Click += new System.EventHandler(this.btnVar3_Click);
            // 
            // btnVar2
            // 
            this.btnVar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVar2.Location = new System.Drawing.Point(561, 217);
            this.btnVar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVar2.Name = "btnVar2";
            this.btnVar2.Size = new System.Drawing.Size(61, 48);
            this.btnVar2.TabIndex = 22;
            this.btnVar2.UseVisualStyleBackColor = true;
            this.btnVar2.Click += new System.EventHandler(this.btnVar2_Click);
            // 
            // btnVar1
            // 
            this.btnVar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVar1.Location = new System.Drawing.Point(495, 217);
            this.btnVar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVar1.Name = "btnVar1";
            this.btnVar1.Size = new System.Drawing.Size(61, 48);
            this.btnVar1.TabIndex = 21;
            this.btnVar1.UseVisualStyleBackColor = true;
            this.btnVar1.Click += new System.EventHandler(this.btnVar1_Click);
            // 
            // btnFechaPar
            // 
            this.btnFechaPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechaPar.Location = new System.Drawing.Point(431, 217);
            this.btnFechaPar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFechaPar.Name = "btnFechaPar";
            this.btnFechaPar.Size = new System.Drawing.Size(61, 48);
            this.btnFechaPar.TabIndex = 20;
            this.btnFechaPar.Text = ")";
            this.btnFechaPar.UseVisualStyleBackColor = true;
            this.btnFechaPar.Click += new System.EventHandler(this.btnFechaPar_Click);
            // 
            // cmbFormulas
            // 
            this.cmbFormulas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormulas.FormattingEnabled = true;
            this.cmbFormulas.Items.AddRange(new object[] {
            "Area total",
            "Volume"});
            this.cmbFormulas.Location = new System.Drawing.Point(364, 60);
            this.cmbFormulas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFormulas.Name = "cmbFormulas";
            this.cmbFormulas.Size = new System.Drawing.Size(324, 24);
            this.cmbFormulas.TabIndex = 19;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(5, 283);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 47);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "< Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnInserirFormula
            // 
            this.btnInserirFormula.Location = new System.Drawing.Point(621, 283);
            this.btnInserirFormula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInserirFormula.Name = "btnInserirFormula";
            this.btnInserirFormula.Size = new System.Drawing.Size(100, 47);
            this.btnInserirFormula.TabIndex = 17;
            this.btnInserirFormula.Text = "Inserir Formula";
            this.btnInserirFormula.UseVisualStyleBackColor = true;
            this.btnInserirFormula.Click += new System.EventHandler(this.btnInserirFormula_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare.Location = new System.Drawing.Point(628, 164);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(61, 48);
            this.btnSquare.TabIndex = 14;
            this.btnSquare.Text = "^";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnAbrePar
            // 
            this.btnAbrePar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrePar.Location = new System.Drawing.Point(364, 218);
            this.btnAbrePar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbrePar.Name = "btnAbrePar";
            this.btnAbrePar.Size = new System.Drawing.Size(61, 48);
            this.btnAbrePar.TabIndex = 13;
            this.btnAbrePar.Text = "(";
            this.btnAbrePar.UseVisualStyleBackColor = true;
            this.btnAbrePar.Click += new System.EventHandler(this.btnAbrePar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nome da formula:";
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(561, 164);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(61, 48);
            this.btnDivide.TabIndex = 12;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnTimes
            // 
            this.btnTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimes.Location = new System.Drawing.Point(495, 164);
            this.btnTimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(61, 48);
            this.btnTimes.TabIndex = 11;
            this.btnTimes.Text = "*";
            this.btnTimes.UseVisualStyleBackColor = true;
            this.btnTimes.Click += new System.EventHandler(this.btnTimes_Click);
            // 
            // btnMais
            // 
            this.btnMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Location = new System.Drawing.Point(431, 164);
            this.btnMais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(61, 48);
            this.btnMais.TabIndex = 10;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(364, 164);
            this.btnMenos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(61, 48);
            this.btnMenos.TabIndex = 2;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // txtFormula
            // 
            this.txtFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormula.Location = new System.Drawing.Point(365, 132);
            this.txtFormula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(327, 26);
            this.txtFormula.TabIndex = 9;
            this.txtFormula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validar);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Formula:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Caractere da variavel 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Caractere da variavel 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero de Variavel(is) necessaria(s)";
            // 
            // cmbNumVar
            // 
            this.cmbNumVar.FormattingEnabled = true;
            this.cmbNumVar.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbNumVar.Location = new System.Drawing.Point(20, 60);
            this.cmbNumVar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNumVar.Name = "cmbNumVar";
            this.cmbNumVar.Size = new System.Drawing.Size(233, 24);
            this.cmbNumVar.TabIndex = 4;
            this.cmbNumVar.SelectedValueChanged += new System.EventHandler(this.validarTxt);
            this.cmbNumVar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BloquearKeyPress);
            // 
            // txtVar3
            // 
            this.txtVar3.Location = new System.Drawing.Point(20, 251);
            this.txtVar3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVar3.Name = "txtVar3";
            this.txtVar3.Size = new System.Drawing.Size(233, 22);
            this.txtVar3.TabIndex = 3;
            this.txtVar3.TextChanged += new System.EventHandler(this.vartres);
            this.txtVar3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarVarPress);
            // 
            // txtVar2
            // 
            this.txtVar2.Location = new System.Drawing.Point(20, 190);
            this.txtVar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVar2.Name = "txtVar2";
            this.txtVar2.Size = new System.Drawing.Size(233, 22);
            this.txtVar2.TabIndex = 2;
            this.txtVar2.TextChanged += new System.EventHandler(this.vardois);
            this.txtVar2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarVarPress);
            // 
            // txtVar1
            // 
            this.txtVar1.Location = new System.Drawing.Point(20, 133);
            this.txtVar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVar1.Name = "txtVar1";
            this.txtVar1.Size = new System.Drawing.Size(233, 22);
            this.txtVar1.TabIndex = 1;
            this.txtVar1.TextChanged += new System.EventHandler(this.varum);
            this.txtVar1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarVarPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Caractere da variavel 1:";
            // 
            // ofdBuscarFoto
            // 
            this.ofdBuscarFoto.FileName = "openFileDialog1";
            // 
            // frmAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 510);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(767, 557);
            this.MinimumSize = new System.Drawing.Size(767, 557);
            this.Name = "frmAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdicionar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fechar);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoForma)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbNomeForma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeNovaForma;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNumVar;
        private System.Windows.Forms.TextBox txtVar3;
        private System.Windows.Forms.TextBox txtVar2;
        private System.Windows.Forms.TextBox txtVar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarImagem;
        private System.Windows.Forms.PictureBox picFotoForma;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnAbrePar;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnTimes;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnInserirFormula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cmbFormulas;
        private System.Windows.Forms.OpenFileDialog ofdBuscarFoto;
        private System.Windows.Forms.Button btnVar3;
        private System.Windows.Forms.Button btnVar2;
        private System.Windows.Forms.Button btnVar1;
        private System.Windows.Forms.Button btnFechaPar;
    }
}