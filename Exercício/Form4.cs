using System;
using System.Windows.Forms;

namespace Exercício
{
    public partial class Atividade3 : Form
    {
        public Atividade3()
        {
            InitializeComponent();
        }
        double Abono;
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu tela1 = new Menu();
            tela1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Atividade3_Load(object sender, EventArgs e)
        {

        }

        private void btnSalLiqu_Click(object sender, EventArgs e)
        {
            double Salario, Idade, SalLiq;
            char sexo;
            Salario = Convert.ToDouble(txtSalar.Text);
            Idade = Convert.ToDouble(txtIdade.Text);
            sexo = Convert.ToChar(txtSex.Text);
            if (sexo == 'M')
            {
                if (Idade >= 30)
                {
                    Abono = 100;
                }
                else if (Idade < 30)
                {
                    Abono = 80;
                }
            }
            else if (sexo == 'F')
            {
                if (Idade >= 30)
                {
                    Abono = 200;
                }
                else if (Idade < 30)
                {
                    Abono = 50;
                }
            }
            SalLiq = Salario + Abono;

            txtSalFinal.Text = SalLiq.ToString();
            txtAbono.Text = Abono.ToString();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtAbono.Clear();
            txtSalFinal.Clear();
            txtIdade.Clear();
            txtSalar.Clear();
            txtSex.Clear();
        }
    }
}
