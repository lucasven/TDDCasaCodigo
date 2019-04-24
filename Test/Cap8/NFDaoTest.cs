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
    public class NFDaoTest
    {
        [TestMethod]
        public void devePersistirNFGerada()
        {
            var acao1 = new Mock<IAcaoAposGerarNota>();
            var acao2 = new Mock<IAcaoAposGerarNota>();
            IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>(){ acao1.Object, acao2.Object };            
            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(acoes);
            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            acao1.Verify(t => t.Executa(nf));
            acao2.Verify(t => t.Executa(nf));
        }
    }
}
