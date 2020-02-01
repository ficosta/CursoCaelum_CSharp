using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCaelum
{
    public class ContaCorrente : Conta, ITributavel
    {
        public override bool Saca(double valorSaque)
        {
            if (this.Saldo >= valorSaque)
            {
                this.Saldo = this.Saldo - (valorSaque + .05);
                return true;
            }
            return false;
        }
      

        public override void Deposita(double valorDeposito)
        {
            if (valorDeposito > 0)
            {
                Saldo += valorDeposito - .1;
            }
        }

        public override string ToString()
        {

            return $"{Numero} - CC - {Titular.Nome}";
        }

        public double CalculaTributos()
        {
            return Saldo * 0.05;
        }
    }
    
}
