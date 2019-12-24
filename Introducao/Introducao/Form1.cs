using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introducao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = "Felipe";

            //interpolacao de string
            MessageBox.Show($"O nome do cliente é {nome}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idadeSonia = 67;
            int idadeMarjory = 31;
            int idadeFelipe = 32;

            float mediaIdade = (idadeSonia + idadeMarjory + idadeFelipe) / 3;
           
            MessageBox.Show($"A media idade é: {mediaIdade}");

        }

        private void button3_Click(object sender, EventArgs e)
        {
           // int pi = 3.14;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;

            MessageBox.Show("piQuebrado: " + piQuebrado);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = 2;
            int c = -15;

            double delta, a1, a2;

            delta = b * b - 4 * a * c;
            a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show($"A1: {a1} A2: {a2}");

        }
    }
}
