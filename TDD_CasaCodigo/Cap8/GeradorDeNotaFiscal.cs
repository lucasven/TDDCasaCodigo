using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_CasaCodigo.cap8;

namespace TDD_CasaCodigo.Cap8
{
    public class GeradorDeNotaFiscal
    {
        private NFDao dao;
        private SAP sap;

        public GeradorDeNotaFiscal(NFDao _dao, SAP _sap)
        {
            this.dao = _dao;
            this.sap = _sap;
        }
        public NotaFiscal Gera(Pedido pedido)
        {
            NotaFiscal nf = new NotaFiscal(pedido.Cliente, pedido.ValorTotal * 0.94, DateTime.Now);

            dao.Persiste(nf);
            sap.Envia(nf);

            return nf;
        }
    }
}
