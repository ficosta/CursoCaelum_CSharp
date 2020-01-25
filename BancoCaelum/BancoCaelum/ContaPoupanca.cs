using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCaelum
{
    class ContaPoupanca : Conta
    {
        public override bool sacar(double valor)
        {
            return base.sacar(valor + 0.10);
        }
    }
}
