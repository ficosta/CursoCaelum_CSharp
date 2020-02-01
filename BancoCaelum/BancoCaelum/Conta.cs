using System.ComponentModel;

namespace BancoCaelum
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }
        //public string Tipo { get; set; }

        public virtual bool Saca(double valorSaque)
        {
            if (this.Saldo >= valorSaque)
            {
                this.Saldo = this.Saldo - (valorSaque);
                return true;
            }
            return false;
        }

        public virtual void Deposita(double valorDeposito)
        {
            if (valorDeposito > 0)
            {
                Saldo += valorDeposito;
            }
        }
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