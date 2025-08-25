using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5CadastroPessoas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> listaNomes = new List<string>();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Recebendo e guardando na variável o nome da caixa de texto
            string nome = txtBoxNome.Text;

            //Adicionando o nome na lista de nomes
            listaNomes.Add(nome);

            MessageBox.Show($"Nome cadastrado com sucesso!");
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            listBoxNomes.Items.Clear();

            foreach (var item in listaNomes)
            {
                listBoxNomes.Items.Add(item);
            }
        }
    }
}
