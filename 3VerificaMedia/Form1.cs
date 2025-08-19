using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3VerificaMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificaAprov_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtBoxPrimeiraNota.Text);
            double n2 = Convert.ToDouble(txtBoxSegundaNota.Text);

            double media = (n1 + n2) / 2;

            //Verifica aprovação
            if (media >= 6)
            {
                MessageBox.Show($"O aluno está aprovado com média: {media}");
                btnVerificaAprov.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show($"O aluno está reprovado com média: {media}");
                btnVerificaAprov.BackColor= Color.Red;
            }

        }
    }
}
