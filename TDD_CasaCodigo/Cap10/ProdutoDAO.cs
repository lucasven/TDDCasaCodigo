using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_CasaCodigo.Cap10
{
    public class ProdutoDAO
    {
        private ISession session;

        public ProdutoDAO(ISession _session)
        {
            this.session = _session;
        }

        public void Adiciona(Produto produto)
        {
            session.Save(produto);
        }

        public Produto PorID(int id)
        {
            return session.Load<Produto>(id);
        }

        public IList<Produto> Ativos()
        {
            return session.CreateQuery("SELECT * FROM Produto p WHERE p.Ativo = true").List<Produto>();
        }
    }
}
