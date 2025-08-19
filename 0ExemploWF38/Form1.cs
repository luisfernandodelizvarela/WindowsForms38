using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0ExemploWF38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Olá! Seja bem-vindo ao meu sistema.");

            //Capturar o valor armazenado na caixa de texto
            string nome = textBox1.Text;
            int idade = Convert.ToInt32(textBox2.Text);

            MessageBox.Show($"Olá, {nome}! Você tem {idade} anos");
        }
    }
}
