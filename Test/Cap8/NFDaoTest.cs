using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
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
    public class NFDaoTest
    {
        [TestMethod]
        public void devePersistirNFGerada()
        {
            var dao = new Mock<NFDao>();
            var sap = new Mock<SAP>();

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(dao.Object, sap.Object);
            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            dao.Verify(t => t.Persiste(nf));
        }
    }
}
