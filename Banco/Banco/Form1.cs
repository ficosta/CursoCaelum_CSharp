using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta contaVitor = new Conta();
            contaVitor.titular = "Vitor";
            contaVitor.numero = 1;
            contaVitor.Deposita(100);
            MessageBox.Show($"{contaVitor.saldo}");
            if(contaVitor.Saca(50))
                MessageBox.Show("Saque realizado");
            else
                MessageBox.Show("Imposivel sacar");
            MessageBox.Show($"{contaVitor.saldo}");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            Conta c1 = new Conta();

            if (c==c1)
                MessageBox.Show("Verdadeiro");
            else
                MessageBox.Show("Falso");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta origem = new Conta();
            origem.saldo = 900;

            Conta destino = new Conta();
            destino.saldo = 500;

            origem.Transferencia(110, destino);

            MessageBox.Show($"O saldo da origem é {origem.saldo} e do destino é {destino.saldo}");
        }
    }
}
