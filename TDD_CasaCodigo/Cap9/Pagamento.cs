using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_CasaCodigo.Cap9
{
    public class Pagamento
    {
        public double Valor { get; set; }
        public MeioDePagamentoEnum MeioDePagamento { get; set; }
        public Pagamento(double _valor, MeioDePagamentoEnum _meioDePagamento)
        {
            Valor = _valor;
            MeioDePagamento = _meioDePagamento;
        }
    }
}
