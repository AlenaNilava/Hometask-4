namespace MSTests
{
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PowUnitTests
    {

        [TestMethod]
        public void CheckPowWithInt()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int a = 2;
            int b = 2;

            //Act
            var actualResult = calculator.Pow(a, b);

            //Assert
            Assert.AreEqual(4, actualResult);
        }

        [TestMethod]
        public void CheckPowWithDouble()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double a = 3;
            double b = 4;

            //Act
            var actualResult = calculator.Pow(a, b);

            //Assert
            Assert.AreEqual(81, actualResult);
        }
    }
}
