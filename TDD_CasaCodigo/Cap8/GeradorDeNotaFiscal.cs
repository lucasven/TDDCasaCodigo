using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_CasaCodigo.Cap8
{
    public class GeradorDeNotaFiscal
    {
        private IList<IAcaoAposGerarNota> acoes;
        private IRelogio relogio;
        private ITabela tabela;

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> _acoes) : this(_acoes, new RelogioDoSistema(), new Tabela()) { }
        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> _acoes, ITabela _tabela) : this(_acoes, new RelogioDoSistema(), _tabela) { }
        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> _acoes, IRelogio _relogio, ITabela _tabela)
        {
            this.acoes = _acoes;
            this.relogio = _relogio;
            this.tabela = _tabela;
        }
        public NotaFiscal Gera(Pedido pedido)
        {
            NotaFiscal nf = new NotaFiscal(pedido.Cliente, tabela.ParaValor(pedido.ValorTotal), relogio.Hoje());

            foreach (var acao in acoes)
            {
                acao.Executa(nf);
            }

            return nf;
        }
    }
}
