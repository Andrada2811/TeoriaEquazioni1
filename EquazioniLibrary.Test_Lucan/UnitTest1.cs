using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test_Lucan
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_IsDetermined()
        {
            double a = 1;
            bool Risultato = true;

            bool Risultato2 = Equazioni.IsDetermined(a);

            Assert.AreEqual(Risultato, Risultato2);
        }

        [TestMethod]
        public void Test_IsDetermined1()
        {
            double a = 0;
            bool Risultato = false;

            bool Risultato2 = Equazioni.IsDetermined(a);

            Assert.AreEqual(Risultato, Risultato2);
        }

        [TestMethod]
        public void Test_IsDetermined2()
        {
            double a = -1;
            bool Risultato = true;

            bool Risultato2 = Equazioni.IsDetermined(a);

            Assert.AreEqual(Risultato, Risultato2);
        }
    }
}
