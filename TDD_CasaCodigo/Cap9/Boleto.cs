using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_CasaCodigo.Cap9
{
    public class Boleto
    {
        public double Valor { get; set; }

        public Boleto(double _valor)
        {
            Valor = _valor;
        }
    }
}
