using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCaelum
{
    class ContaCorrente: Conta
    {
        public override bool sacar(double valor)
        {
            return base.sacar(valor + 0.10);
        }
        public override bool depositar(double valor)
        {
            return base.depositar(valor - 0.05);
        }
    }
}
