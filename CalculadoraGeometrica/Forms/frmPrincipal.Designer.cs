﻿
namespace CalculadoraGeometrica.Forms
{
    partial class frmPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.cmbForma = new System.Windows.Forms.ComboBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo ao Space Geo";
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(12, 84);
            this.picImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(348, 247);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 2;
            this.picImage.TabStop = false;
            // 
            // cmbForma
            // 
            this.cmbForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForma.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbForma.FormattingEnabled = true;
            this.cmbForma.Location = new System.Drawing.Point(107, 352);
            this.cmbForma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbForma.Name = "cmbForma";
            this.cmbForma.Size = new System.Drawing.Size(140, 31);
            this.cmbForma.TabIndex = 4;
            this.cmbForma.SelectedValueChanged += new System.EventHandler(this.CarregarImagemForma);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(107, 395);
            this.btnSelecionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(140, 39);
            this.btnSelecionar.TabIndex = 5;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(107, 440);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(140, 57);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar Fórmulas";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 508);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.cmbForma);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(387, 547);
            this.MinimumSize = new System.Drawing.Size(387, 547);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.VisibleChanged += new System.EventHandler(this.CarregarFormulas);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.ComboBox cmbForma;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnAdicionar;
    }
}