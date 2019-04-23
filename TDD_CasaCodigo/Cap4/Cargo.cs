using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_CasaCodigo.Cap4
{
    //public enum Cargo
    //{
    //    DESENVOLVEDOR,
    //    DBA,
    //    TESTADOR
    //}

    public class Cargo
    {
        public Cargo DESENVOLVEDOR
        { get { return new Cargo(new DezOuVintePorCento()); } }
        public Cargo DBA
        { get { return new Cargo(new QuinzeOuVinceCincoPorCento()); } }
        public Cargo TESTADOR
        { get { return new Cargo(new QuinzeOuVinceCincoPorCento()); } }


        public RegraDeCalculo Regra { get; set; }
        private Cargo(RegraDeCalculo regra)
        {
            this.Regra = regra;
        }
    }
}
