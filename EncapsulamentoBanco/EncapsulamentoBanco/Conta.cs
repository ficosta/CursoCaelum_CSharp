using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoBanco
{
    class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }


        public void Saca(double valor)
        {
            if(Saldo >= valor)
            {
                Saldo -= valor;
            }
        }

       public void Deposito(double valor)
        {
            if (valor > 0)
                Saldo += valor;

        }
    }
}
