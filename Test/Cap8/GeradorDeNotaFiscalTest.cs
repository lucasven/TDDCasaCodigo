using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_CasaCodigo.cap8;
using TDD_CasaCodigo.Cap8;

namespace Test.Cap8
{
    [TestClass]
    public class GeradorDeNotaFiscalTest
    {
        [TestMethod]
        public void DeveGerarNFComValorDeImpostoDescontado()
        { 
            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(new NFDao());
            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            Assert.AreEqual(1000 * 0.94, nf.Valor, 0.00001);
        }
    }
}
