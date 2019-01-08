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
    public class MultiplyUnitTests
    {

        [TestMethod()]
        public void CheckMultiplyWithDoubleInt()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int a = 10;
            double b = 5;

            //Act
            var actualResult = calculator.Divide(a, b);

            //Assert
            Assert.AreEqual(50, actualResult);
        }
    }
}
