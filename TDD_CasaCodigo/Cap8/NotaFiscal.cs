using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_CasaCodigo.Cap8
{
    public class NotaFiscal
    {
        public string Cliente { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }

        public NotaFiscal(String _cliente, double _valor, DateTime _data)
        {
            this.Cliente = _cliente;
            this.Valor = _valor;
            this.Data = _data;
        }
    }
}
