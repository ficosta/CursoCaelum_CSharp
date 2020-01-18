using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoCaelum
{
    public partial class Form1 : Form
    {
        Cliente titular = new Cliente();
        Conta conta = new Conta();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            conta.sacar(100);
            atualizarSaldo();
            MessageBoxPersonalizado("Saque realziado com sucesso", MessageBoxIcon.Error);
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            conta.depositar(Convert.ToDouble(txtValor.Text));
            atualizarSaldo();
        }
        void atualizarSaldo()
        {
            lblSaldo.Text = Convert.ToString( conta.Saldo);
        }
        void MessageBoxPersonalizado(string mensagem, MessageBoxIcon icon)
        {
            MessageBox.Show(mensagem, "", MessageBoxButtons.OK, icon);
        }
    }
}
