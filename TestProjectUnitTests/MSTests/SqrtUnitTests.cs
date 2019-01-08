using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTests
{
    [TestClass()]
    public class SqrtUnitTests
    {
        [TestMethod()]
        public void CheckSqrt()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double a = 100;

            //Act
            var actualResult = calculator.Sqrt(a);

            //Assert
            Assert.AreEqual(10, actualResult);
        }

        [TestMethod()]
        public void CheckSqrt300()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double a = 300;

            //Act
            var actualResult = calculator.Sqrt(a);

            //Assert
            Assert.AreEqual(17.320508075688775, actualResult);
        }
    }
}
