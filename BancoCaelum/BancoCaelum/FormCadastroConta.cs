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
    public partial class FormCadastroConta : Form
    {
        private Form1 FormPrincipal;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.FormPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void FormCadastroConta_Click(object sender, EventArgs e)
        {


            this.FormPrincipal.criarConta(textTitular.Text, Convert.ToInt32(textNumero.Text), rdbContaCorrente.Checked);
           

         
            this.Close();
        }
    }
}
