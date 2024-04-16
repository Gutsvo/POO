namespace Exercício
{
    partial class Atividade1
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
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblCporCarro = new System.Windows.Forms.Label();
            this.lblnumCarros = new System.Windows.Forms.Label();
            this.lblvalorCarro = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblsalarioTotal = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txtsalarioTotal = new System.Windows.Forms.TextBox();
            this.txtcomissao = new System.Windows.Forms.TextBox();
            this.txtnumCarros = new System.Windows.Forms.TextBox();
            this.txtvalorCarro = new System.Windows.Forms.TextBox();
            this.txtsalarioFixo = new System.Windows.Forms.TextBox();
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
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(472, 298);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 2;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(350, 298);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblCporCarro
            // 
            this.lblCporCarro.AutoSize = true;
            this.lblCporCarro.Location = new System.Drawing.Point(275, 104);
            this.lblCporCarro.Name = "lblCporCarro";
            this.lblCporCarro.Size = new System.Drawing.Size(130, 16);
            this.lblCporCarro.TabIndex = 4;
            this.lblCporCarro.Text = "Comissão por Carro:";
            // 
            // lblnumCarros
            // 
            this.lblnumCarros.AutoSize = true;
            this.lblnumCarros.Location = new System.Drawing.Point(294, 132);
            this.lblnumCarros.Name = "lblnumCarros";
            this.lblnumCarros.Size = new System.Drawing.Size(111, 16);
            this.lblnumCarros.TabIndex = 5;
            this.lblnumCarros.Text = "Carros Vendidos:";
            // 
            // lblvalorCarro
            // 
            this.lblvalorCarro.AutoSize = true;
            this.lblvalorCarro.Location = new System.Drawing.Point(304, 160);
            this.lblvalorCarro.Name = "lblvalorCarro";
            this.lblvalorCarro.Size = new System.Drawing.Size(101, 16);
            this.lblvalorCarro.TabIndex = 6;
            this.lblvalorCarro.Text = "Preço do Carro:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(324, 188);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(81, 16);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "Salário Fixo:";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(437, 251);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(29, 16);
            this.lbl5.TabIndex = 8;
            this.lbl5.Text = "5%:";
            // 
            // lblsalarioTotal
            // 
            this.lblsalarioTotal.AutoSize = true;
            this.lblsalarioTotal.Location = new System.Drawing.Point(231, 251);
            this.lblsalarioTotal.Name = "lblsalarioTotal";
            this.lblsalarioTotal.Size = new System.Drawing.Size(87, 16);
            this.lblsalarioTotal.TabIndex = 9;
            this.lblsalarioTotal.Text = "Salário Total:";
            // 
            // txt5
            // 
            this.txt5.Enabled = false;
            this.txt5.Location = new System.Drawing.Point(472, 248);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(100, 22);
            this.txt5.TabIndex = 10;
            // 
            // txtsalarioTotal
            // 
            this.txtsalarioTotal.Enabled = false;
            this.txtsalarioTotal.Location = new System.Drawing.Point(324, 248);
            this.txtsalarioTotal.Name = "txtsalarioTotal";
            this.txtsalarioTotal.Size = new System.Drawing.Size(100, 22);
            this.txtsalarioTotal.TabIndex = 11;
            // 
            // txtcomissao
            // 
            this.txtcomissao.Location = new System.Drawing.Point(411, 101);
            this.txtcomissao.Name = "txtcomissao";
            this.txtcomissao.Size = new System.Drawing.Size(100, 22);
            this.txtcomissao.TabIndex = 12;
            // 
            // txtnumCarros
            // 
            this.txtnumCarros.Location = new System.Drawing.Point(411, 129);
            this.txtnumCarros.Name = "txtnumCarros";
            this.txtnumCarros.Size = new System.Drawing.Size(100, 22);
            this.txtnumCarros.TabIndex = 13;
            // 
            // txtvalorCarro
            // 
            this.txtvalorCarro.Location = new System.Drawing.Point(411, 157);
            this.txtvalorCarro.Name = "txtvalorCarro";
            this.txtvalorCarro.Size = new System.Drawing.Size(100, 22);
            this.txtvalorCarro.TabIndex = 14;
            // 
            // txtsalarioFixo
            // 
            this.txtsalarioFixo.Location = new System.Drawing.Point(411, 185);
            this.txtsalarioFixo.Name = "txtsalarioFixo";
            this.txtsalarioFixo.Size = new System.Drawing.Size(100, 22);
            this.txtsalarioFixo.TabIndex = 15;
            // 
            // Atividade1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsalarioFixo);
            this.Controls.Add(this.txtvalorCarro);
            this.Controls.Add(this.txtnumCarros);
            this.Controls.Add(this.txtcomissao);
            this.Controls.Add(this.txtsalarioTotal);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.lblsalarioTotal);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblvalorCarro);
            this.Controls.Add(this.lblnumCarros);
            this.Controls.Add(this.lblCporCarro);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnSair);
            this.Name = "Atividade1";
            this.Text = "Carro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblCporCarro;
        private System.Windows.Forms.Label lblnumCarros;
        private System.Windows.Forms.Label lblvalorCarro;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblsalarioTotal;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txtsalarioTotal;
        private System.Windows.Forms.TextBox txtcomissao;
        private System.Windows.Forms.TextBox txtnumCarros;
        private System.Windows.Forms.TextBox txtvalorCarro;
        private System.Windows.Forms.TextBox txtsalarioFixo;
    }
}