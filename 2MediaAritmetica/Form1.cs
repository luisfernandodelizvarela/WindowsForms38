using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2MediaAritmetica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Capturar e guardar as notas em variáveis
            double n1 = Convert.ToDouble(txtBoxPrimeiraNota.Text);
            double n2 = Convert.ToDouble(txtBoxSegundaNota.Text);

            //Cálculo da média aritmética
            double media = (n1 + n2) / 2;

            //Apresentar a média
            MessageBox.Show($"A média das notas é: {media}");
        }
    }
}
