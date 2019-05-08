using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_CasaCodigo.Cap10;

namespace Test.Cap10
{
    [TestClass]
    public class ProdutoDAOTest
    {
        private ISession session;
        private ITransaction transaction;

        [TestInitialize]
        public void Inicializa()
        {
            session = new CriadorDeSessoes().BancoDeTestes();
            transaction = session.BeginTransaction();
        }

        [TestMethod]
        public void DeveAdicionarUmProduto()
        {
            ProdutoDAO dao = new ProdutoDAO(session);

            Produto produto = new Produto("Geladeira", 150.0);

            dao.Adiciona(produto);

            // buscando no banco pelo id
            // para ver se está igual ao produto do cenário
            Produto salvo = dao.PorID(produto.ID);
            Assert.AreEqual(salvo, produto);
        }

        [TestMethod]
        public void DeveFiltrarAtivos()
        {
            ProdutoDAO dao = new ProdutoDAO(session);

            Produto ativo = new Produto("Geladeira", 150.0);
            Produto inativo = new Produto("Geladeira", 150.0);
            inativo.Inativa();

            session.Save(ativo);
            session.Save(inativo);

            List<Produto> produtos = dao.Ativos().ToList();

            Assert.AreEqual(1, produtos.Count);
            Assert.AreEqual(ativo, produtos[0]);
        }

        [TestCleanup]
        public void LimpaTudo()
        {
            transaction.Rollback();
            session.Close();
        }
    }
}
