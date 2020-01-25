using System;

namespace BancoCaelum
{
    internal class Conta
    {
        public double Saldo { get; private set; }
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public virtual bool sacar(double valor)
        {
            if (valor <= Saldo && valor > 0)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }

        public virtual bool depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                return true;
            }
            return false;
        }
    }
}