using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8Imagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbImagem.Visible = false;
        }

        private void btnVasco_Click(object sender, EventArgs e)
        {
            pbImagem.Visible = true;
            pbImagem.Image = Properties.Resources.logoVasco;
        }

        private void btnFlamengo_Click(object sender, EventArgs e)
        {
            pbImagem.Visible = true;
            pbImagem.Image = Properties.Resources.logoFlamengo;
        }
    }
}
