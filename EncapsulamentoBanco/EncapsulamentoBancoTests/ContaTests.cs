using Microsoft.VisualStudio.TestTools.UnitTesting;
using EncapsulamentoBanco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoBanco.Tests
{
    [TestClass()]
    public class ContaTests
    {
        Conta c = new Conta();

        [TestMethod()]
        public void SacaTest()
        {
            c.Deposito(100);
            Assert.IsTrue(c.Saca(100));
        }

        [TestMethod()]
        public void DepositoTest()
        {
            Conta c1 = new Conta();
            c1.Deposito(100);
            Assert.IsTrue(c1.Saldo == 100.0);
        }
    }
}