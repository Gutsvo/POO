namespace Exercício
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nataçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gêneroEIdadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carroToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // carroToolStripMenuItem
            // 
            this.carroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nataçãoToolStripMenuItem});
            this.carroToolStripMenuItem.Name = "carroToolStripMenuItem";
            this.carroToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.carroToolStripMenuItem.Text = "Carro";
            this.carroToolStripMenuItem.Click += new System.EventHandler(this.carroToolStripMenuItem_Click);
            // 
            // nataçãoToolStripMenuItem
            // 
            this.nataçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gêneroEIdadeToolStripMenuItem});
            this.nataçãoToolStripMenuItem.Name = "nataçãoToolStripMenuItem";
            this.nataçãoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nataçãoToolStripMenuItem.Text = "Natação";
            this.nataçãoToolStripMenuItem.Click += new System.EventHandler(this.nataçãoToolStripMenuItem_Click);
            // 
            // gêneroEIdadeToolStripMenuItem
            // 
            this.gêneroEIdadeToolStripMenuItem.Name = "gêneroEIdadeToolStripMenuItem";
            this.gêneroEIdadeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gêneroEIdadeToolStripMenuItem.Text = "Gênero e Idade";
            this.gêneroEIdadeToolStripMenuItem.Click += new System.EventHandler(this.gêneroEIdadeToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nataçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gêneroEIdadeToolStripMenuItem;
    }
}

