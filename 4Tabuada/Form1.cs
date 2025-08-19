using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Limpar o listBox
            listBoxTabuada.Items.Clear();

            int numero = Convert.ToInt32(txtBoxNumero.Text);

            for (int i = 1; i <= 10; i++)
            {
                listBoxTabuada.Items.Add($"{numero} x {i} = {numero * i}");
            }
        }
    }
}
