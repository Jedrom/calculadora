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
    }
}
