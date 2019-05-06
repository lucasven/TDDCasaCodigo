using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_CasaCodigo.Cap8
{
    public class Tabela : ITabela
    {
        public double ParaValor(double valor)
        {
            return valor * 0.94;
        }
    }
}
