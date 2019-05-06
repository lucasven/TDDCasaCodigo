using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_CasaCodigo.Cap8;

namespace Test.Cap8
{
    [TestClass]
    public class GeradorDeNotaFiscalTest
    {
        [TestMethod]
        public void DeveGerarNFComValorDeImpostoDescontado()
        {
            var acao1 = new Mock<IAcaoAposGerarNota>();
            var acao2 = new Mock<IAcaoAposGerarNota>();
            IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>(){ acao1.Object, acao2.Object };

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(acoes);
            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            Assert.AreEqual(1000 * 0.94, nf.Valor, 0.00001);
        }

        [TestMethod]
        public void DeveConsultarATabelaParaCalcularValor()
        {
            // mockando uma tabela, que ainda nem existe
            var tabela = new Mock<ITabela>();
            // definindo o futuro comportamento "paraValor",
            // que deve retornar 0.2 caso o valor seja 1000.0
            tabela.Setup(t => t.ParaValor(1000.0)).Returns(200);
            IList<IAcaoAposGerarNota> nenhumaAcao =
            new List<IAcaoAposGerarNota>();
            GeradorDeNotaFiscal gerador =
            new GeradorDeNotaFiscal(nenhumaAcao, tabela.Object);
            Pedido pedido = new Pedido("Mauricio", 1000, 1);
            NotaFiscal nf = gerador.Gera(pedido);
            // garantindo que a tabela foi consultada
            tabela.Verify(t => t.ParaValor(1000.0));
            Assert.AreEqual(1000 * 0.2, nf.Valor, 0.00001);
        }
    }
}
