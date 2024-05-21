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
    public partial class Atividade5 : Form
    {
        public Atividade5()
        {
            InitializeComponent();
        }

        double num, x, i;
        
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu tela1 = new Menu();
            tela1.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFatorado.Clear();
            txtNumero.Clear();
        }

        private void btnLoopDoWhile_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(txtNumero.Text);
            i = num - 1;
            x = num * i;
            do
            {
                txtFatorado.Text = String.Concat(txtFatorado.Text, num, "x", i, "=", x.ToString(), "\r\n");
                i--;
                num = x;
                x = x * i;
            } while (x > 0);
        }

        private void btnLoopFor_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(txtNumero.Text);
            i = num - 1;
            x = num * i;
            txtFatorado.Text = String.Concat(txtFatorado.Text, num, "x", i, "=", x.ToString(), "\r\n");
            for (i = num - 2;x > 0; i--){
                num = x;
                x = num * i;
                txtFatorado.Text = String.Concat(txtFatorado.Text, num, "x", i, "=", x.ToString(), "\r\n");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(txtNumero.Text);
            i = num - 1;
            x = num * i;
            while (x > 0)
            {
                txtFatorado.Text = String.Concat(txtFatorado.Text, num, "x", i, "=", x.ToString(), "\r\n");
                i--;
                num = x;
                x = x * i;
            }
        }
        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
