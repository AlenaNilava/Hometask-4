namespace MSTests
{
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IsPositiveUnitTests
    {
        [TestMethod]
        public void CheckIsPositiveWithDouble()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double a = - 88.36987521;

            //Act
            var actualResult = calculator.isPositive(a);

            //Assert
            Assert.AreEqual(false, actualResult);
        }

        [TestMethod]
        public void CheckIsPositiveWithInt()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int a = 2089650;

            //Act
            var actualResult = calculator.isPositive(a);

            //Assert
            Assert.AreEqual(true, actualResult);
        }
    }
}
