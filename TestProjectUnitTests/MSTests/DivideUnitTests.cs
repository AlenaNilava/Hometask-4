namespace MSTests
{
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DivideUnitTests
    {

        [TestMethod]
        public void CheckDivideWithDouble()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int a = 355589;
            double b = 5.1;

            //Act
            var actualResult = calculator.Divide(a, b);

            //Assert
            Assert.AreEqual(69723.333333333343, actualResult);
        }

        [TestMethod]
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
