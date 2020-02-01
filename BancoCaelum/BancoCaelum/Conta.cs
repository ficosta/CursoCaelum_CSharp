using System.ComponentModel;

namespace BancoCaelum
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }
        //public string Tipo { get; set; }

        public abstract bool Saca(double valorSaque);
        

        public abstract void Deposita(double valorDeposito);
    
        public bool Transfere(Conta contaDestino, double valor)
        {
            if (Saldo >= valor)
            {
                Saca(valor);
                contaDestino.Deposita(valor);
                return true;

            }
            return false;

        }
        

    }
}