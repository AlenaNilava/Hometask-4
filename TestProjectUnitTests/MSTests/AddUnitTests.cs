using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication3;
using System;
using System.Reflection;
using CSharpCalculator;

namespace ConsoleApplication3.Tests
{
	[TestClass()]
	public class AddUnitTests
	{

		[TestMethod()]
		public void CheckAddWithInt()
		{
            //Arrange
            Calculator calculator = new Calculator();
            int a = 3;
            double b = 2;

            //Act
            var actualResult = calculator.Add(a, b);

            //Assert
            Assert.AreEqual(5, actualResult);
		}

        [TestMethod()]
        [DataRow(3, 2, 5)]
        [DataRow(-3, -2, -5)]
        public void CheckDDTAddWithInt(int a, int b, int expectedValue)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            var actualResult = calculator.Add(a, b);

            //Assert
            Assert.AreEqual(expectedValue, actualResult);
        }

        [TestMethod()]
        public void CheckAddWithDouble()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double a = 3;
            double b = 2;

            //Act
            var actualResult = calculator.Add(a, b);

            //Assert
            Assert.AreEqual(5, actualResult);
        }

        [TestMethod()]
        public void CheckAddWithString()
        {
            //Arrange
            Calculator calculator = new Calculator();
            string a = "3";
            double b = 2;

            //Act
            var actualResult = calculator.Add(a, b);

            //Assert
            Assert.AreEqual(5, actualResult);
        }
	}
}