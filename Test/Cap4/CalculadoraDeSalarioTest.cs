using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_CasaCodigo.Cap4;

namespace Test.Cap4
{
    //[TestClass]
    //public class CalculadoraDeSalarioTest
    //{
    //    [TestMethod]
    //    public void DeveCalcularSalarioParaDesenvolvedoresAbaixoDoLimite()
    //    {
    //        CalculadoraDeSalario calculadora = new CalculadoraDeSalario();

    //        Funcionario desenvolvedor = new Funcionario("Mauricio", 1500.00, new DESENVOLVEDOR());

    //        double salario = calculadora.CalculaSalario(desenvolvedor);

    //        Assert.AreEqual(1500.0 * 0.9, salario, 0000.1);
    //    }

    //    [TestMethod]
    //    public void DeveCalcularSalarioParaDesenvolvedorAcimaDoLimite()
    //    {
    //        CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
    //        Funcionario desenvolvedor = new Funcionario("Mauricio", 4000.00, Cargo.DESENVOLVEDOR);

    //        double salario = calculadora.CalculaSalario(desenvolvedor);

    //        Assert.AreEqual(4000 * 0.8, salario, 0.00001);
    //    }

    //    [TestMethod]
    //    public void DeveCalcularSalariosParaDBAsComSalarioAbaixoDoLimite()
    //    {
    //        CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
    //        Funcionario dba = new Funcionario("Mauricio", 500.00, Cargo.DBA);

    //        double salario = calculadora.CalculaSalario(dba);

    //        Assert.AreEqual(500 * 0.85, salario, 0.00001);
    //    }

    //    [TestMethod]
    //    public void DeveCalcularSalariosParaDBAsComSalarioAcimaDoLimite()
    //    {
    //        var salarioBase = 3000.00;
    //        CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
    //        Funcionario dba = new Funcionario("Mauricio", salarioBase, Cargo.DBA);

    //        double salario = calculadora.CalculaSalario(dba);

    //        Assert.AreEqual(salarioBase * 0.75, salario, 0.00001);
    //    }

    //    [TestMethod]
    //    public void DeveCalcularSalariosParaTestadoresComSalarioAbaixoDoLimite()
    //    {
    //        CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
    //        Funcionario testador = new Funcionario("Mauricio", 1000.00, Cargo.TESTADOR);

    //        double salario = calculadora.CalculaSalario(testador);

    //        Assert.AreEqual(1000.00 * 0.85, salario, 0.00001);
    //    }

    //    [TestMethod]
    //    public void DeveCalcularSalariosParaTestadoresComSalarioAcimaDoLimite()
    //    {
    //        var salarioBase = 5000.00;
    //        CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
    //        Funcionario testador = new Funcionario("Mauricio", salarioBase, Cargo.TESTADOR);

    //        double salario = calculadora.CalculaSalario(testador);

    //        Assert.AreEqual(salarioBase * 0.75, salario, 0.00001);
    //    }
    //}
}
