using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncapsulamentoBanco
{
    public partial class Form1 : Form
    {
        Conta conta = new Conta();
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            conta.Saca(10);
            atualizaSaldoTela();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conta.Saca(50);
            atualizaSaldoTela();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conta.Deposito(10);
            atualizaSaldoTela();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conta.Deposito(50);
            atualizaSaldoTela();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"O seu saldo é:{conta.Saldo}");
        }
        void atualizaSaldoTela()
        {
            label1.Text = $"O seu saldo é:{conta.Saldo}";
        }
    }
}
