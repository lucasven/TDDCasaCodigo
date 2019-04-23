using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_CasaCodigo.Cap4
{
    public abstract class RegraDeCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.Salario > Limite())
            {
                return funcionario.Salario * PorcentagemAcimaDoLimite();
            }
            return funcionario.Salario * PorcentagemBase();
        }
        protected abstract int Limite();
        protected abstract double PorcentagemAcimaDoLimite();
        protected abstract double PorcentagemBase();
    }

    public class DezOuVintePorCento : RegraDeCalculo
    {
        protected override double PorcentagemBase()
        {
            return 0.9;
        }
        protected override double PorcentagemAcimaDoLimite()
        {
            return 0.8;
        }
        protected override int Limite()
        {
            return 3000;
        }
    }

    public class QuinzeOuVinceCincoPorCento : RegraDeCalculo
    {
        protected override double PorcentagemBase()
        {
            return 0.85;
        }
        protected override double PorcentagemAcimaDoLimite()
        {
            return 0.75;
        }
        protected override int Limite()
        {
            return 2499;
        }
    }
}
