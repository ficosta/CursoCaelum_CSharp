using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCaelum
{
   public class ContaPoupanca : Conta
    {
        public override void Deposita(double valorDeposito)
        {
            if (valorDeposito > 0)
            {
                Saldo += valorDeposito;
            }
        }

        public override bool Saca(double valorSaque)
        {
            if (this.Saldo >= valorSaque)
            {
                this.Saldo = this.Saldo - (valorSaque +.1);
                return true;
            }
            return false;
        }

        public override string ToString()
        {

            return $"{Numero} - CP - {Titular.Nome}";
        }

        
    }
}
