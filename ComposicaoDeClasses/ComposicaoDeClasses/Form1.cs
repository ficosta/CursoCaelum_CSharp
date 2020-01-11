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

namespace ComposicaoDeClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
            Cliente cli1 = new Cliente();
            c1.titular = cli1;
            c1.titular.nome = "Victor";
            c1.titular.idade = 19;

            if (c1.titular.EhMaiorDeIdade())
                MessageBox.Show("EhMaior");
                //Debug.Print("É Maior");
            else
                MessageBox.Show("Eh menor");
                //Debug.Print("É Menor");

        }
    }
}
