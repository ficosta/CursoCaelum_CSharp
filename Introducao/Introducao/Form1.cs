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

        private void button6_Click(object sender, EventArgs e)
        {
            double saldo = 100;
            double valorSaldo = 10;
            if (saldo >= valorSaldo)
            {
                saldo -= valorSaldo;
                MessageBox.Show($"Saque realizado com sucesso!");

            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double saldo = 5;
            double valorSaque = 10;

            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double saldo = 500;
            if (saldo <0.0)
            {
                MessageBox.Show("Voce esta negativo");
            }
            else if (saldo <1000000.0)
            {
                MessageBox.Show("Voce é um bom cliente");
            }
            else
            {
                MessageBox.Show("Voce é um milionario");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int idade = 16;
            bool brasileira = true;

            if (idade >= 16 && brasileira)
            {
                MessageBox.Show("Apta a votar");

            }
            else
            {
                MessageBox.Show("Nao pode votar!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double valorNotaFiscal = 500;
            double imposto;
            if (valorNotaFiscal < 1000)
            {
                imposto = 2;
            }
            else if (valorNotaFiscal < 3000)
            {
                imposto = 2.5;
            }
            else if (valorNotaFiscal < 7000)
            {
                imposto = 2.8;
            }
            else
            {
                imposto = 3;
            }
            MessageBox.Show($"Valor da nota {valorNotaFiscal + (valorNotaFiscal * imposto / 100)}");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //int valor = 15;
            //string mensagem = "";

            //if(valor > 10)
            //{
            //    mensagem = "Maior que 10";
            //}
            //else
            //{
            //    mensagem = "Menor que 10";
            //}
            //MessageBox.Show(mensagem);


            //condição ? expressão1_se_true : expressão2_se_false
            int valor = 15;
            string mensagem = "";

            mensagem = valor > 10 ? "Maior que 10" : "Menor que 10";

            MessageBox.Show(mensagem);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int quantidade = 2;
            int codigo = 103;
            
            switch (codigo)
            {
                case 100:
                    MessageBox.Show($"Valor final R${quantidade * 39.90}");
                    break;
                case 101:
                    MessageBox.Show($"Valor final R${quantidade * 4000}");
                    break;
                case 102:
                    MessageBox.Show($"Valor final R${quantidade * 695}");
                    break;
                case 103:
                    MessageBox.Show($"Valor final R${quantidade * 10}");
                    break;

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double valorAplicado = 1000;
            int meses = 1;

            while(valorAplicado <= 1500)
            {
                valorAplicado = valorAplicado * 1.01;
                    meses++;
                }
            MessageBox.Show($"Para chegar em {valorAplicado} precisamos de {meses} meses");
        }
    }
}
