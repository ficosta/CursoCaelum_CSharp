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
        public List<Conta> contas;
        private int numeroDeContas;

        public Form1()
        {
            InitializeComponent();
        }

        public void AdicionaConta(Conta conta)
        {
            contas.Add(conta);
            carregarCombo();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);
            int indice = Convert.ToInt32(comboContas.SelectedIndex);
            Conta contaSelecionada = contas[indice];

            if (contaSelecionada.Saca(valor))
            {
                lblStatus.Text = ($"Saque realizado com sucesso!");
                lblStatus.BackColor = Color.Red;
                txtValor.Clear();
                atualizaSaldo();
            }
            else
            {
                lblStatus.Text = ($"Erro ao sacar!");
                lblStatus.BackColor = Color.Red;
                txtValor.Clear();
                atualizaSaldo();
            }

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {

            double valor = Convert.ToDouble(txtValor.Text); //converter string em double(numero)  double.parse também converte.

            int indice = Convert.ToInt32(comboContas.SelectedIndex);
            Conta contaSelecionada = contas[indice];
            contaSelecionada.Deposita(valor);

            lblStatus.Text = ($"Depósito realizado com sucesso!");
            lblStatus.BackColor = Color.Green;
            txtValor.Clear();
            atualizaSaldo();

        }

        private void atualizaSaldo()
        {
            int indice = Convert.ToInt32(comboContas.SelectedIndex);
            Conta contaSelecionada = contas[indice];
            txtSaldo.Text = "R$ " + Convert.ToString(contaSelecionada.Saldo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new List<Conta>();
            criarConta("Victor", 1);
            criarConta("Mauricio", 2);
            criarConta("Osni", 3);

            //ITributavel t = new ITributavel();
        }

        public void criarConta(string Nome, int Numero, bool isContaCorrente = true)
        {
            Conta c1;
            if (isContaCorrente)
            {
                c1 = new ContaCorrente();
            }
            else
            {
                c1 = new ContaPoupanca();
            }

            c1.Titular = new Cliente(Nome);
            c1.Numero = Numero;
            AdicionaConta(c1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Relatorio rel = new Relatorio();
            rel.TotalizadorDeContas(contas);

            MessageBox.Show($"Total do Banco é:{rel.totalBanco}");

        }


        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            txtNumero.Text = Convert.ToString(selecionada.Numero);
            txtNome.Text = selecionada.Titular.Nome;
            txtSaldo.Text = Convert.ToString(selecionada.Saldo);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];

            int indiceDestino = comboContaDestino.SelectedIndex;
            Conta selecionadaDestino = contas[indiceDestino];

            if (selecionada.Transfere(selecionadaDestino, Convert.ToDouble(txtValor.Text)))
            {
                MessageBox.Show("Transferencia Realizada!!!");
                txtValor.Clear();
                atualizaSaldo();

            }
            else
            {
                MessageBox.Show("Erro na transferencia");
            }
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }

        private void btnExcluirConta_Click(object sender, EventArgs e)
        {
            //Conta contaexcluida= new Conta();
            //foreach (Conta conta in contas)
            //{
            //    if (conta.Titular.Nome == txtNome.Text)
            //    {
            //        contaexcluida = conta;
            //    }

            //}
            //contas.Remove(contaexcluida);
            contas.Remove((Conta)comboContas.SelectedItem);
            MessageBox.Show($"Conta Excluída: {(Conta)comboContas.SelectedItem}");

            carregarCombo();
        }
        private void carregarCombo()
        {
            comboContas.Items.Clear();
            comboContaDestino.Items.Clear();

            foreach (Conta conta in contas)
            {
                //comboContas.Items.Add(conta.Titular.Nome);
                //comboContaDestino.Items.Add(conta.Titular.Nome);
                comboContas.Items.Add(conta);
                comboContaDestino.Items.Add(conta);

            }

        }

        private void btnCalculaTributos_Click(object sender, EventArgs e)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Deposita(200);

            MessageBox.Show($"Imposto da CC: {conta.CalculaTributos()}");

            ITributavel t = conta;
            MessageBox.Show($"Imposto da conta pela Interface {t.CalculaTributos()}");

            SeguroVida sv = new SeguroVida();
            MessageBox.Show($"Imposto do Seguro de Vida {sv.CalculaTributos()}");

            t = sv;
            MessageBox.Show($"Imposto do seguro pela Interface {t.CalculaTributos()}");
        }
    }
}
