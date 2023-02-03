using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculos_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(txtPrimeiroNumero.Text);
            int valor2 = Convert.ToInt32(txtSegundoNumero.Text);
            int resposta = valor1 - valor2;
            txtResultado.Text = resposta.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
