using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_CasaCodigo.Cap4
{
    public class CalculadoraDeSalario
    {
        public double CalculaSalario(Funcionario funcionario)
        {
            if (funcionario.Cargo.Equals(Cargo.DESENVOLVEDOR))
            {
                if (funcionario.Salario > 3000) return funcionario.Salario * 0.8;
                return funcionario.Salario*0.9;
            }

            if (funcionario.Salario > 2500)
                return funcionario.Salario * 0.75;

            return funcionario.Salario * 0.85;
        }
    }
}
