using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_CasaCodigo.Cap8
{
    public class RelogioDoSistema : IRelogio
    {
        public DateTime Hoje()
        {
            return DateTime.Now();
        }
    }
}
