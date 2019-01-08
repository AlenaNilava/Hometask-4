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
    public class DivideUnitTests
    {

        [TestMethod()]
        public void CheckDivideWithDouble()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int a = 355;
            double b = 5;

            //Act
            var actualResult = calculator.Divide(a, b);

            //Assert
            Assert.AreEqual(71, actualResult);
        }

        [TestMethod()]
        public void CheckDivideIntDouble()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double a = 110.10;
            int b = 10;

            //Act
            var actualResult = calculator.Divide(a, b);

            //Assert
            Assert.AreEqual(11.01, actualResult);
        }
    }
}
