using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Conta
    {
        public double saldo;
        public string titular;
        public int numero;

       public void Deposita(double valor)
        {
            saldo += valor;
        }
        public bool Saca(double valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                return true;
            }
            else
                return false;
        }
        public void Transferencia(double valor, Conta destino)
        {
            if(this.Saca(valor))
                destino.Deposita(valor);
        }
    }
    
}
