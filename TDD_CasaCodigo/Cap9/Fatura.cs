using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_CasaCodigo.Cap9
{
    public class Fatura
    {
        public IList<Pagamento> Pagamentos { get; set; }
        public string Cliente { get; set; }
        public double Valor { get; set; }
        public bool Pago { get; set; }

        public Fatura(string _cliente, double _valor)
        {
            Cliente = _cliente;
            Valor = _valor;
            Pagamentos = new List<Pagamento>();
        }

        public void AdicionaPagamento(Pagamento pagamento)
        {
            this.Pagamentos.Add(pagamento);
            double valorTotal = 0;

            foreach (var p in Pagamentos)
            {
                valorTotal += p.Valor;
            }

            if(valorTotal >= Valor)
            {
                this.Pago = true;
            }
        }
    }
}
