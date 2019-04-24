using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_CasaCodigo.Cap8
{
    public class Pedido
    {
        public string Cliente { get; set; }
        public double ValorTotal { get; set; }
        public int QuantidadeItens { get; set; }

        public Pedido(string _cliente, double _valorTotal, int _quantidadeItens)
        {
            this.Cliente = _cliente;
            this.ValorTotal = _valorTotal;
            this.QuantidadeItens = _quantidadeItens;
        }
    }
}
