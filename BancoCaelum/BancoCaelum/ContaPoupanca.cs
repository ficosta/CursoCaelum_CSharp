using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCaelum
{
   public class ContaPoupanca : Conta
    {
        public override bool Saca(double valorSaque)
        {
            return base.Saca(valorSaque+0.10);
        }

    }
}
