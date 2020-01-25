using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCaelum
{
    class Relatorio
    {
        public double Saldo { get; private set; }
        public void TotalizadorDeSaldos(Conta conta)
        {
            Saldo += conta.Saldo;
        }
    }
}
