﻿namespace MSTests
{
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SubUnitTests
    {

        [TestMethod]
        public void CheckSubWithDouble()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double a = 550.36;
            double b = 98;

            //Act
            var actualResult = calculator.Sub(a, b);

            //Assert
            Assert.AreEqual(452.36, actualResult);
        }

        [TestMethod]
        public void CheckSubWithInt()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int a = 800;
            int b = 900;

            //Act
            var actualResult = calculator.Sub(a, b);

            //Assert
            Assert.AreEqual(-100, actualResult);
        }
    }
}