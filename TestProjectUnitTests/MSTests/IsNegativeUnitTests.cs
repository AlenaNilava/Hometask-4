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
    public class IsNegativeUnitTests
    {
        [TestMethod()]
        public void CheckIsNegativeWithDouble()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double a = 9;

            //Act
            var actualResult = calculator.isNegative(a);

            //Assert
            Assert.AreEqual(false, actualResult);
        }
    }
}
