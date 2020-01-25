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
         Conta ContaForm { get; set; }
         

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
               ContaForm.sacar(Convert.ToDouble(txtValor.Text));
            atualizarSaldo();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            ContaForm.depositar(Convert.ToDouble(txtValor.Text));
            atualizarSaldo();
        }
        void atualizarSaldo()
        {
            lblSaldo.Text = Convert.ToString( ContaForm.Saldo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio();
            relatorio.TotalizadorDeSaldos(ContaForm);
            MessageBox.Show(Convert.ToString( relatorio.Saldo));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContaForm =  new ContaCorrente();
        }
    }
}
