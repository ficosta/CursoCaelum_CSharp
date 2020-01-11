using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaRepeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 2;
            for (int i = 0; i < 5; i++)
            {
                total = total * 2;
            }
            MessageBox.Show($"{ total}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int soma =0 ;
            for (int i = 1; i <= 1000; i++)
            {
                soma += i;
            }
            MessageBox.Show($"{soma}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i % 3 ==0)
                    System.Diagnostics.Debug.Print(i.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                    soma += i;
            }
            MessageBox.Show($"{soma}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 30; i++)
            {
                if (i % 3 == 0 || i % 4 == 0)
                    System.Diagnostics.Debug.Print(i.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int nfat = 0;
            int fat = 1;
            for (int i = 1; i <= 10; i++)
            {
                fat = fat * i;
                nfat++;
                MessageBox.Show($"O fat de {nfat} é {fat}");
            }
        }
    }
}
