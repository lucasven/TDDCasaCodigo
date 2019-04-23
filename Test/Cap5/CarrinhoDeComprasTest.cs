using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_CasaCodigo.Cap5;

namespace Test.Cap5
{
    /// <summary>
    /// Descrição resumida para MaiorPrecoTest
    /// </summary>
    [TestClass]
    public class CarrinhoDeComprasTest
    {
        private CarrinhoDeCompras carrinho;
        [TestInitialize]
        public void Inicializa()
        {
            this.carrinho = new CarrinhoDeCompras();
        }

        [TestMethod]
        public void DeveRetornarZeroSeCarrinhoVazio()
        {
            Assert.AreEqual(0.0, carrinho.EncontraMaiorValor(carrinho), 0.00001);
        }

        [TestMethod]
        public void DeveRetornarValorDoItemSeCarrinhoCom1Elemento()
        {
            carrinho.Adiciona(new Item("Geladeira", 1, 900.00));

            Assert.AreEqual(900.00, carrinho.EncontraMaiorValor(carrinho), 0.000001);
        }

        [TestMethod]
        public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos()
        {
            carrinho.Adiciona(new Item("Geladeira", 1, 900.00));
            carrinho.Adiciona(new Item("Fogão", 1, 1500.00));
            carrinho.Adiciona(new Item("Máquina de Lavar", 1, 750.00));

            Assert.AreEqual(1500.00, carrinho.EncontraMaiorValor(carrinho), 0.00001);
        }
    }
}
