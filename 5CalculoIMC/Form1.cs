using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5CalculoIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPeso.Text = "";
            txtAltura.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txtPeso.Text);
            double altura = Convert.ToDouble(txtAltura.Text);

            double imc = peso / (altura * altura);
            //double imcMath = peso / Math.Pow(altura, 2);

            lblResultado.Text = imc.ToString("F2");

            if (imc < 18.5)
            {
                lblClassificacao.Text = "Magreza";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                lblClassificacao.Text = "Normal";
            }
            else if (imc > 24.9 && imc <= 29.9)
            {
                lblClassificacao.Text = "Sobrepeso";
            }
            else if (imc >= 30 && imc <= 39.9)
            {
                lblClassificacao.Text = "Obesidade";
            }
            else if (imc > 40)
            {
                lblClassificacao.Text = "Obesidade grave";
            }




        }
    }
}
