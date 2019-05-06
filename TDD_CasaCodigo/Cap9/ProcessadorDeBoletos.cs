using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_CasaCodigo.Cap9
{
    public class ProcessadorDeBoletos
    {
        public void Processa(IList<Boleto> boletos, Fatura fatura)
        {
            foreach (var boleto in boletos)
            {
                Pagamento pagamento = new Pagamento(boleto.Valor, MeioDePagamentoEnum.BOLETO);
                fatura.AdicionaPagamento(pagamento);
            }
        }
    }
}
