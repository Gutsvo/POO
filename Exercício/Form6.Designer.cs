namespace Exercício
{
    partial class Atividade5
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblFator = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtFatorado = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLoopDoWhile = new System.Windows.Forms.Button();
            this.btnLoopWhile = new System.Windows.Forms.Button();
            this.btnLoopFor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(296, 153);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(92, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Digite um número:";
            // 
            // lblFator
            // 
            this.lblFator.AutoSize = true;
            this.lblFator.Location = new System.Drawing.Point(299, 179);
            this.lblFator.Name = "lblFator";
            this.lblFator.Size = new System.Drawing.Size(89, 13);
            this.lblFator.TabIndex = 1;
            this.lblFator.Text = "Número fatorado:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(394, 150);
            this.txtNumero.Multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // txtFatorado
            // 
            this.txtFatorado.Enabled = false;
            this.txtFatorado.Location = new System.Drawing.Point(394, 176);
            this.txtFatorado.Multiline = true;
            this.txtFatorado.Name = "txtFatorado";
            this.txtFatorado.Size = new System.Drawing.Size(100, 60);
            this.txtFatorado.TabIndex = 3;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(713, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(353, 322);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLoopDoWhile
            // 
            this.btnLoopDoWhile.Location = new System.Drawing.Point(353, 270);
            this.btnLoopDoWhile.Name = "btnLoopDoWhile";
            this.btnLoopDoWhile.Size = new System.Drawing.Size(75, 23);
            this.btnLoopDoWhile.TabIndex = 6;
            this.btnLoopDoWhile.Text = "Do...While";
            this.btnLoopDoWhile.UseVisualStyleBackColor = true;
            this.btnLoopDoWhile.Click += new System.EventHandler(this.btnLoopDoWhile_Click);
            // 
            // btnLoopWhile
            // 
            this.btnLoopWhile.Location = new System.Drawing.Point(240, 270);
            this.btnLoopWhile.Name = "btnLoopWhile";
            this.btnLoopWhile.Size = new System.Drawing.Size(75, 23);
            this.btnLoopWhile.TabIndex = 7;
            this.btnLoopWhile.Text = "While";
            this.btnLoopWhile.UseVisualStyleBackColor = true;
            this.btnLoopWhile.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLoopFor
            // 
            this.btnLoopFor.Location = new System.Drawing.Point(454, 270);
            this.btnLoopFor.Name = "btnLoopFor";
            this.btnLoopFor.Size = new System.Drawing.Size(75, 23);
            this.btnLoopFor.TabIndex = 8;
            this.btnLoopFor.Text = "For";
            this.btnLoopFor.UseVisualStyleBackColor = true;
            this.btnLoopFor.Click += new System.EventHandler(this.btnLoopFor_Click);
            // 
            // Atividade5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoopFor);
            this.Controls.Add(this.btnLoopWhile);
            this.Controls.Add(this.btnLoopDoWhile);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtFatorado);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblFator);
            this.Controls.Add(this.lblNumero);
            this.Name = "Atividade5";
            this.Text = "Fatoração";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblFator;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtFatorado;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnLoopDoWhile;
        private System.Windows.Forms.Button btnLoopWhile;
        private System.Windows.Forms.Button btnLoopFor;
    }
}