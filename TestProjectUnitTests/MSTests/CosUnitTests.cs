namespace MSTests
{
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Threading;

    [TestClass]
    public class CosUnitTests
    {
        [TestMethod]
        public void CheckCos180()
        {
            Thread.Sleep(10000);
            //Arrange
            Calculator calculator = new Calculator();
            double a = 180;

            //Act
            var actualResult = calculator.Cos(a);

            //Assert
            Assert.AreEqual(-1, actualResult);
        }

        [TestMethod]
        public void CheckCos360()
        {
            Thread.Sleep(10000);
            //Arrange
            Calculator calculator = new Calculator();
            double a = 360;

            //Act
            var actualResult = calculator.Cos(a);

            //Assert
            Assert.AreEqual(1, actualResult);
        }
    }
}
