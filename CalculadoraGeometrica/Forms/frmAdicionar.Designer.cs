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
            this.txtNomeForma = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.txtNomeForma);
            this.groupBox1.Controls.Add(this.rdbNao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbSim);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(546, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma";
            // 
            // btnBuscarImagem
            // 
            this.btnBuscarImagem.Location = new System.Drawing.Point(274, 46);
            this.btnBuscarImagem.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarImagem.Name = "btnBuscarImagem";
            this.btnBuscarImagem.Size = new System.Drawing.Size(75, 38);
            this.btnBuscarImagem.TabIndex = 16;
            this.btnBuscarImagem.Text = "Procurar imagem";
            this.btnBuscarImagem.UseVisualStyleBackColor = true;
            this.btnBuscarImagem.Click += new System.EventHandler(this.btnBuscarImagem_Click);
            // 
            // cmbNomeForma
            // 
            this.cmbNomeForma.FormattingEnabled = true;
            this.cmbNomeForma.Location = new System.Drawing.Point(15, 70);
            this.cmbNomeForma.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNomeForma.Name = "cmbNomeForma";
            this.cmbNomeForma.Size = new System.Drawing.Size(176, 21);
            this.cmbNomeForma.TabIndex = 4;
            // 
            // picFotoForma
            // 
            this.picFotoForma.Location = new System.Drawing.Point(194, 28);
            this.picFotoForma.Margin = new System.Windows.Forms.Padding(2);
            this.picFotoForma.Name = "picFotoForma";
            this.picFotoForma.Size = new System.Drawing.Size(76, 74);
            this.picFotoForma.TabIndex = 15;
            this.picFotoForma.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da forma:";
            // 
            // txtNomeForma
            // 
            this.txtNomeForma.Location = new System.Drawing.Point(15, 46);
            this.txtNomeForma.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeForma.Name = "txtNomeForma";
            this.txtNomeForma.Size = new System.Drawing.Size(176, 20);
            this.txtNomeForma.TabIndex = 3;
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Location = new System.Drawing.Point(365, 80);
            this.rdbNao.Margin = new System.Windows.Forms.Padding(2);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(45, 17);
            this.rdbNao.TabIndex = 2;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "Não";
            this.rdbNao.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "A forma na qual deseja inserir \r\numa nova formula ja está no banco?";
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Location = new System.Drawing.Point(365, 58);
            this.rdbSim.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(42, 17);
            this.rdbSim.TabIndex = 0;
            this.rdbSim.TabStop = true;
            this.rdbSim.Text = "Sim";
            this.rdbSim.UseVisualStyleBackColor = true;
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
            this.groupBox2.Location = new System.Drawing.Point(9, 140);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(546, 273);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Formula";
            // 
            // btnVar3
            // 
            this.btnVar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVar3.Location = new System.Drawing.Point(471, 176);
            this.btnVar3.Margin = new System.Windows.Forms.Padding(2);
            this.btnVar3.Name = "btnVar3";
            this.btnVar3.Size = new System.Drawing.Size(46, 39);
            this.btnVar3.TabIndex = 23;
            this.btnVar3.UseVisualStyleBackColor = true;
            this.btnVar3.Click += new System.EventHandler(this.btnVar3_Click);
            // 
            // btnVar2
            // 
            this.btnVar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVar2.Location = new System.Drawing.Point(421, 176);
            this.btnVar2.Margin = new System.Windows.Forms.Padding(2);
            this.btnVar2.Name = "btnVar2";
            this.btnVar2.Size = new System.Drawing.Size(46, 39);
            this.btnVar2.TabIndex = 22;
            this.btnVar2.UseVisualStyleBackColor = true;
            this.btnVar2.Click += new System.EventHandler(this.btnVar2_Click);
            // 
            // btnVar1
            // 
            this.btnVar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVar1.Location = new System.Drawing.Point(371, 176);
            this.btnVar1.Margin = new System.Windows.Forms.Padding(2);
            this.btnVar1.Name = "btnVar1";
            this.btnVar1.Size = new System.Drawing.Size(46, 39);
            this.btnVar1.TabIndex = 21;
            this.btnVar1.UseVisualStyleBackColor = true;
            this.btnVar1.Click += new System.EventHandler(this.btnVar1_Click);
            // 
            // btnFechaPar
            // 
            this.btnFechaPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechaPar.Location = new System.Drawing.Point(323, 176);
            this.btnFechaPar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechaPar.Name = "btnFechaPar";
            this.btnFechaPar.Size = new System.Drawing.Size(46, 39);
            this.btnFechaPar.TabIndex = 20;
            this.btnFechaPar.Text = ")";
            this.btnFechaPar.UseVisualStyleBackColor = true;
            this.btnFechaPar.Click += new System.EventHandler(this.btnFechaPar_Click);
            // 
            // cmbFormulas
            // 
            this.cmbFormulas.FormattingEnabled = true;
            this.cmbFormulas.Location = new System.Drawing.Point(273, 49);
            this.cmbFormulas.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFormulas.Name = "cmbFormulas";
            this.cmbFormulas.Size = new System.Drawing.Size(244, 21);
            this.cmbFormulas.TabIndex = 19;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(4, 230);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 38);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "< Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnInserirFormula
            // 
            this.btnInserirFormula.Location = new System.Drawing.Point(466, 230);
            this.btnInserirFormula.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserirFormula.Name = "btnInserirFormula";
            this.btnInserirFormula.Size = new System.Drawing.Size(75, 38);
            this.btnInserirFormula.TabIndex = 17;
            this.btnInserirFormula.Text = "Inserir Formula";
            this.btnInserirFormula.UseVisualStyleBackColor = true;
            this.btnInserirFormula.Click += new System.EventHandler(this.btnInserirFormula_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare.Location = new System.Drawing.Point(471, 133);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(2);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(46, 39);
            this.btnSquare.TabIndex = 14;
            this.btnSquare.Text = "^";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnAbrePar
            // 
            this.btnAbrePar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrePar.Location = new System.Drawing.Point(273, 177);
            this.btnAbrePar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbrePar.Name = "btnAbrePar";
            this.btnAbrePar.Size = new System.Drawing.Size(46, 39);
            this.btnAbrePar.TabIndex = 13;
            this.btnAbrePar.Text = "(";
            this.btnAbrePar.UseVisualStyleBackColor = true;
            this.btnAbrePar.Click += new System.EventHandler(this.btnAbrePar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nome da formula:";
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(421, 133);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(2);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(46, 39);
            this.btnDivide.TabIndex = 12;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnTimes
            // 
            this.btnTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimes.Location = new System.Drawing.Point(371, 133);
            this.btnTimes.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(46, 39);
            this.btnTimes.TabIndex = 11;
            this.btnTimes.Text = "*";
            this.btnTimes.UseVisualStyleBackColor = true;
            this.btnTimes.Click += new System.EventHandler(this.btnTimes_Click);
            // 
            // btnMais
            // 
            this.btnMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Location = new System.Drawing.Point(323, 133);
            this.btnMais.Margin = new System.Windows.Forms.Padding(2);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(46, 39);
            this.btnMais.TabIndex = 10;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(273, 133);
            this.btnMenos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(46, 39);
            this.btnMenos.TabIndex = 2;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // txtFormula
            // 
            this.txtFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormula.Location = new System.Drawing.Point(274, 107);
            this.txtFormula.Margin = new System.Windows.Forms.Padding(2);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(246, 22);
            this.txtFormula.TabIndex = 9;
            this.txtFormula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validar);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Formula:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Caractere da variavel 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Caractere da variavel 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero de Variavel(is) necessaria(s)";
            // 
            // cmbNumVar
            // 
            this.cmbNumVar.FormattingEnabled = true;
            this.cmbNumVar.Location = new System.Drawing.Point(15, 49);
            this.cmbNumVar.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNumVar.Name = "cmbNumVar";
            this.cmbNumVar.Size = new System.Drawing.Size(176, 21);
            this.cmbNumVar.TabIndex = 4;
            // 
            // txtVar3
            // 
            this.txtVar3.Location = new System.Drawing.Point(15, 204);
            this.txtVar3.Margin = new System.Windows.Forms.Padding(2);
            this.txtVar3.Name = "txtVar3";
            this.txtVar3.Size = new System.Drawing.Size(176, 20);
            this.txtVar3.TabIndex = 3;
            this.txtVar3.Leave += new System.EventHandler(this.vartres);
            // 
            // txtVar2
            // 
            this.txtVar2.Location = new System.Drawing.Point(15, 154);
            this.txtVar2.Margin = new System.Windows.Forms.Padding(2);
            this.txtVar2.Name = "txtVar2";
            this.txtVar2.Size = new System.Drawing.Size(176, 20);
            this.txtVar2.TabIndex = 2;
            this.txtVar2.Leave += new System.EventHandler(this.vardois);
            // 
            // txtVar1
            // 
            this.txtVar1.Location = new System.Drawing.Point(15, 108);
            this.txtVar1.Margin = new System.Windows.Forms.Padding(2);
            this.txtVar1.Name = "txtVar1";
            this.txtVar1.Size = new System.Drawing.Size(176, 20);
            this.txtVar1.TabIndex = 1;
            this.txtVar1.Leave += new System.EventHandler(this.varum);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Caractere da variavel 1:";
            // 
            // ofdBuscarFoto
            // 
            this.ofdBuscarFoto.FileName = "openFileDialog1";
            // 
            // frmAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 422);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox txtNomeForma;
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