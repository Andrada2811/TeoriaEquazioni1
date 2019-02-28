using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test_Lucan
{
    [TestClass]
    public class UnitTest1
    {
        //Controlli per un'equazione determinata
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

        //Controlli per un'equazione impossibile
        [TestMethod]
        public void Test_IsInconsisted()
        {
            double b = 0;
            double a = 1;
            bool Risultato = false;

            bool Risultato2 = Equazioni.IsInconsisted(a,b);

            Assert.AreEqual(Risultato, Risultato2);
        }

        [TestMethod]
        public void Test_IsInconsisted1()
        {
            double b = 1;
            double a = 0;
            bool Risultato = true;

            bool Risultato2 = Equazioni.IsInconsisted(a,b);

            Assert.AreEqual(Risultato, Risultato2);
        }

        [TestMethod]
        public void Test_IsInconsisted2()
        {
            double b = -1;
            double a = 0;
            bool Risultato = true;

            bool Risultato2 = Equazioni.IsInconsisted(a,b);

            Assert.AreEqual(Risultato, Risultato2);
        }

        //Controlli per un'equazione di secondo grado
        [TestMethod]
        public void Test_IsDegree2()
        {
            double a = 1;
            bool Risultato = true;

            bool Risultato2 = Equazioni.IsDetermined(a);

            Assert.AreEqual(Risultato, Risultato2);
        }

        [TestMethod]
        public void Test_IsDegree2_1()
        {
            double a = 0;
            bool Risultato = false;

            bool Risultato2 = Equazioni.IsDetermined(a);

            Assert.AreEqual(Risultato, Risultato2);
        }

        [TestMethod]
        public void Test_IsDegree2_2()
        {
            double a = -1;
            bool Risultato = true;

            bool Risultato2 = Equazioni.IsDetermined(a);

            Assert.AreEqual(Risultato, Risultato2);
        }

    }
}
