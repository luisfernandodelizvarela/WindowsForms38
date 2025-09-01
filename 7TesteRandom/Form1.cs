using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7TesteRandom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int numAleatorio = r.Next();

            lblResNext.Text = numAleatorio.ToString();
        }

        private void btnNextParametro_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int valor = Convert.ToInt32(txtValor.Text);

            int numAleatorio = r.Next(valor);

            lblResNextParametro.Text = numAleatorio.ToString();
        }

        private void txtValorFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGerarIntervalo_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int valorInicial = Convert.ToInt32(txtValorInicial.Text);
            int valorFinal = Convert.ToInt32(txtValorFinal.Text);

            int numAleatorio = r.Next(valorInicial, valorFinal);

            lblResValorIF.Text = numAleatorio.ToString();
        }
    }
}
