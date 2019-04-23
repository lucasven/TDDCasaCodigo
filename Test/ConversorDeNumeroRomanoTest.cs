using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_CasaCodigo;

namespace Test
{
    [TestClass]
    public class ConversorDeNumeroRomanoTest
    {
        [TestMethod]
        public void DeveEntenderOSimboloI()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("I");
            Assert.AreEqual(1, numero);
        }

        [TestMethod]
        public void DeveEntenderOSimboloV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("V");
            Assert.AreEqual(5, numero);
        }

        [TestMethod]
        public void DeveEntenderSimbolosComoII()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("II");
            Assert.AreEqual(2, numero);
        }

        [TestMethod]
        public void DeveEntenderDoisSimbolosDoisADoisComoXXII()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("XXII");
            Assert.AreEqual(22, numero);
        }

        [TestMethod]
        public void DeveEntenderSimbolosComoIX()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("IX");
            Assert.AreEqual(9, numero);
        }

        [TestMethod]
        public void DeveEntenderNumeroComplexosComoXXIV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("XXIV");
            Assert.AreEqual(24, numero);
        }
    }
}
