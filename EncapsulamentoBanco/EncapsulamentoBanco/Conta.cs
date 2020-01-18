using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoBanco
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public bool Saca(double valor)
        {
            if(Saldo >= valor)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }

       public void Deposito(double valor)
        {
            if (valor > 0)
                Saldo += valor;

        }

    }
}
