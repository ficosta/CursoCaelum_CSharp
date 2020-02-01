using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCaelum
{
    public class ContaCorrente : Conta
    {
        public override bool Saca(double valorSaque)
        {
            return base.Saca(valorSaque + 0.05);
        }

        public override void Deposita(double valorDeposito)
        {
            base.Deposita(valorDeposito-0.10);
        }
    }

}
