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
    public class IsPositiveUnitTests
    {
        [TestMethod()]
        public void CheckIsPositiveWithDouble()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double a = - 88;

            //Act
            var actualResult = calculator.isPositive(a);

            //Assert
            Assert.AreEqual(false, actualResult);
        }

        [TestMethod()]
        public void CheckIsPositiveWithInt()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int a = 20896;

            //Act
            var actualResult = calculator.isPositive(a);

            //Assert
            Assert.AreEqual(true, actualResult);
        }
    }
}
