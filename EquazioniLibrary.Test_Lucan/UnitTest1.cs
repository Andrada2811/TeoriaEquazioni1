using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test_Lucan
{
    [TestClass]
    public class UnitTest1
    {
        //Controlli per verificare se un'equazione è determinata
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

        //Controlli per verificare se un'equazione è impossibile
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

        //Controlli per verificare se un'equazione è indeterminata
        public void Test_IsIndetermined()
        {
            double b = 0;
            double a = 0;
            bool Risultato = true;

            bool Risultato2 = Equazioni.IsIndetermined(a, b);

            Assert.AreEqual(Risultato, Risultato2);
        }

        [TestMethod]
        public void Test_IsIndetermined2()
        {
            double b = 1;
            double a = 0;
            bool Risultato = false;

            bool Risultato2 = Equazioni.IsIndetermined(a, b);

            Assert.AreEqual(Risultato, Risultato2);
        }

        [TestMethod]
        public void Test_IsIndetermined3()
        {
            double b = -1;
            double a = 1;
            bool Risultato = false;

            bool Risultato2 = Equazioni.IsIndetermined(a, b);

            Assert.AreEqual(Risultato, Risultato2);
        }

        //Controlli per verificare se un'equazione è di secondo grado
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

        //Contrtolli per il delta
        [TestMethod]
        public void Double()
        {
            double a = 1;
            double b = 1;
            double c = 1;
            double Risultato = -3;

            double Risultato2 = Equazioni.Delta(a, b, c);

            Assert.AreEqual(Risultato, Risultato2);
        }

        [TestMethod]
        public void Double1()
        {
            double a = 1;
            double b = 1;
            double c = 0;
            double Risultato = 1;

            double Risultato2 = Equazioni.Delta(a, b, c);

            Assert.AreEqual(Risultato, Risultato2);
        }

        [TestMethod]
        public void Double2()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double Risultato = 0;

            double Risultato2 = Equazioni.Delta(a, b, c);

            Assert.AreEqual(Risultato, Risultato2);
        }

        //Controlli per verificare se un'equazione è di 1 grado
        [TestMethod]
        public void EquationDegree1()
        {
            double a = 0;
            double b = 0;
            string Risultato = "L'equazione è indeterminata";

            string Risultato2 = Equazioni.EquationDegree1(a, b);

            Assert.AreEqual(Risultato, Risultato2);
        }

        [TestMethod]
        public void EquationDegree1_2()
        {
            double a = 1;
            double b = 0;
            string Risultato = "L'equazione è impossibile";

            string Risultato2 = Equazioni.EquationDegree1(a, b);

            Assert.AreEqual(Risultato, Risultato2);
        }

        [TestMethod]
        public void EquationDegree1_3()
        {
            double a = 6;
            double b = 2;
            string Risultato = "3";

            string Risultato2 = Equazioni.EquationDegree1(a, b);

            Assert.AreEqual(Risultato, Risultato2);
        }

    }
}
