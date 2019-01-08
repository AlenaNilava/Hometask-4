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
    public class SinUnitTests
    {
        [TestMethod()]
        public void CheckSin360()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double a = 360;

            //Act
            var actualResult = calculator.Sin(a);

            //Assert
            Assert.AreEqual(1, actualResult);
        }
    }   
}
