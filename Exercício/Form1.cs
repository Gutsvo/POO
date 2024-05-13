using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atividade1 tela = new Atividade1();
            tela.Show();
        }

        private void nataçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atividade2 tela = new Atividade2();
            tela.Show();
        }

        private void gêneroEIdadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atividade3 tela = new Atividade3();
            tela.Show();
        }

        private void fatoraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atividade5 tela = new Atividade5();
            tela.Show();
        }
    }
}
