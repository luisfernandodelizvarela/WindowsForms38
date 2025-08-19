using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1ExBoasVindas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Recebendo o nome da caixa de texto
            string nome = textBox1.Text;

            //Apresentando a mensagem e o nome
            MessageBox.Show($"Bem-vindo {nome}");
        }
    }
}
