namespace Exercício
{
    partial class Atividade3
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalLiqu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtSalFinal = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.txtSalar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(535, 337);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 19);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalLiqu
            // 
            this.btnSalLiqu.Location = new System.Drawing.Point(222, 232);
            this.btnSalLiqu.Name = "btnSalLiqu";
            this.btnSalLiqu.Size = new System.Drawing.Size(75, 23);
            this.btnSalLiqu.TabIndex = 1;
            this.btnSalLiqu.Text = "Calcular";
            this.btnSalLiqu.UseVisualStyleBackColor = true;
            this.btnSalLiqu.Click += new System.EventHandler(this.btnSalLiqu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite seu salário:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(137, 114);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 3;
            // 
            // txtSalFinal
            // 
            this.txtSalFinal.Location = new System.Drawing.Point(197, 187);
            this.txtSalFinal.Name = "txtSalFinal";
            this.txtSalFinal.ReadOnly = true;
            this.txtSalFinal.Size = new System.Drawing.Size(100, 20);
            this.txtSalFinal.TabIndex = 4;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(137, 69);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 20);
            this.txtSex.TabIndex = 5;
            // 
            // txtAbono
            // 
            this.txtAbono.Location = new System.Drawing.Point(303, 187);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.ReadOnly = true;
            this.txtAbono.Size = new System.Drawing.Size(100, 20);
            this.txtAbono.TabIndex = 6;
            // 
            // txtSalar
            // 
            this.txtSalar.Location = new System.Drawing.Point(137, 25);
            this.txtSalar.Name = "txtSalar";
            this.txtSalar.Size = new System.Drawing.Size(100, 20);
            this.txtSalar.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sexo (M ou F):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Idade:";
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(303, 232);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(75, 23);
            this.btnLimpa.TabIndex = 10;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // Atividade3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalar);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtSalFinal);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalLiqu);
            this.Controls.Add(this.btnSair);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Atividade3";
            this.Text = "Gênero e Idade";
            this.Load += new System.EventHandler(this.Atividade3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalLiqu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtSalFinal;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.TextBox txtSalar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpa;
    }
}