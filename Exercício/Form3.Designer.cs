namespace Exercício
{
    partial class Atividade2
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.lblM = new System.Windows.Forms.Label();
            this.lblDinRec = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtDinRec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(713, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(304, 208);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(397, 208);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(75, 23);
            this.btnLimpa.TabIndex = 2;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(280, 131);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(111, 16);
            this.lblM.TabIndex = 3;
            this.lblM.Text = "Metros Nadados:";
            // 
            // lblDinRec
            // 
            this.lblDinRec.AutoSize = true;
            this.lblDinRec.Location = new System.Drawing.Point(268, 159);
            this.lblDinRec.Name = "lblDinRec";
            this.lblDinRec.Size = new System.Drawing.Size(123, 16);
            this.lblDinRec.TabIndex = 4;
            this.lblDinRec.Text = "Dinheiro Recebido:";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(397, 128);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(100, 22);
            this.txtM.TabIndex = 5;
            // 
            // txtDinRec
            // 
            this.txtDinRec.Enabled = false;
            this.txtDinRec.Location = new System.Drawing.Point(397, 156);
            this.txtDinRec.Name = "txtDinRec";
            this.txtDinRec.Size = new System.Drawing.Size(100, 22);
            this.txtDinRec.TabIndex = 6;
            // 
            // Atividade2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDinRec);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.lblDinRec);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnSair);
            this.Name = "Atividade2";
            this.Text = "Natação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblDinRec;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtDinRec;
    }
}