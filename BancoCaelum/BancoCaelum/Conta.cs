using System;

namespace BancoCaelum
{
    internal class Conta
    {
        public double Saldo { get; private set; }
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        internal bool sacar(double v)
        {
            if (v <= Saldo && v > 0)
            {
                Saldo -= v;
                return true;
            }
            return false;
        }

        internal bool depositar(double v)
        {
            if (v > 0)
            {
                Saldo += v;
                return true;
            }
            return false;
        }
    }
}