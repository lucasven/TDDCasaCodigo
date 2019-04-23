using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_CasaCodigo.Cap5
{
    public class CarrinhoDeCompras
    {
        public IList<Item> Itens { get; set; }
 
        public CarrinhoDeCompras()
        {
            this.Itens = new List<Item>();
        }

        public void Adiciona(Item item)
        {
            this.Itens.Add(item);
        }

        public double EncontraMaiorValor(CarrinhoDeCompras carrinho)
        {
            if (carrinho.Itens.Count == 0)
                return 0;

            double maior = carrinho.Itens[0].ValorTotal;
            foreach (var item in carrinho.Itens)
            {
                if (item.ValorTotal > maior)
                    maior = item.ValorTotal;
            }

            return maior;
        }
    }
}
