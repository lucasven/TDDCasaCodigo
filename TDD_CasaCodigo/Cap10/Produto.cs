using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_CasaCodigo.Cap10
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public bool Ativo { get; set; }

        public Produto(string _nome, double _valor)
        {
            Nome = _nome;
            Valor = _valor;
        }

        public void Inativa()
        {
            Ativo = false;
        }
    }
}
