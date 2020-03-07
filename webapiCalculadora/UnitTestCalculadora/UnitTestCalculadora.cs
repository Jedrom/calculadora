using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using webapiCalculadora.Controllers;

namespace UnitTestCalculadora
{
    [TestClass]
    public class UnitTestCalculadora
    {
        [TestMethod]
        public void TestAddGet1()
        {
            //Arrange
            CalculatorController Calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numres = 7;

            //Act = Ejecución
            int result = Calc.Add(numa, numb);
            //Assert = Verificación
            Assert.AreEqual(numres, result);

        }

        [TestMethod]
        public void TestAddGet2()
        {
            //Arrange
            CalculatorController Calc = new CalculatorController();
            int numa = -3;
            int numb = -4;
            int numres = -7;

            //Act = Ejecución
            int result = Calc.Add(numa, numb);
            //Assert = Verificación
            Assert.AreEqual(numres, result);

        }
        [TestMethod]
        public void TestAddGet3()
        {
            //Arrange
            CalculatorController Calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numc = 5;
            int numres = 7;

            //Act = Ejecución
            int result = Calc.Add(numa, numb, numc);
            //Assert = Verificación
            Assert.AreEqual(numres, result);

        }
        [TestMethod]
        public void TestAddGet4()
        {
            //Arrange
            CalculatorController Calc = new CalculatorController();
            int numa = -3;
            int numb = -4;
            int numc = -5;
            int numres = -7;

            //Act = Ejecución
            int result = Calc.Add(numa, numb, numc);
            //Assert = Verificación
            Assert.AreEqual(numres, result);

        }
        [TestMethod]
        public void TestMultiplyGet1()
        {
            //Arrange
            CalculatorController Calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numres = 12;

            //Act = Ejecución
            int result = Calc.Multiply(numa, numb);
            //Assert = Verificación
            Assert.AreEqual(numres, result);

        }
        [TestMethod]
        public void TestMultiplyGet2()
        {
            //Arrange
            CalculatorController Calc = new CalculatorController();
            int numa = -3;
            int numb = -4;
            int numres = 12;

            //Act = Ejecución
            int result = Calc.Multiply(numa, numb);
            //Assert = Verificación
            Assert.AreEqual(numres, result);

        }

        [TestMethod]
        public void TestMultiplyGet3()
        {
            //Arrange
            CalculatorController Calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numc = 2;
            int numres = 12;

            //Act = Ejecución
            int result = Calc.Multiply(numa, numb, numc);
            //Assert = Verificación
            Assert.AreEqual(numres, result);

        }

        [TestMethod]
        public void TestMultiplyGet4()
        {
            //Arrange
            CalculatorController Calc = new CalculatorController();
            int numa = -3;
            int numb = -4;
            int numc = -2;
            int numres = 12;

            //Act = Ejecución
            int result = Calc.Multiply(numa, numb, numc);
            //Assert = Verificación
            Assert.AreEqual(numres, result);

        }
    }
}
