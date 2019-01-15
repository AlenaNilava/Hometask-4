namespace MSTests
{
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MultiplyUnitTests
    {

        [TestMethod]
        public void CheckMultiplyWithDoubleInt()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int a = -105000;
            double b = 5.36666;

            //Act
            var actualResult = calculator.Multiply(a, b);

            //Assert
            Assert.AreEqual(-563499.3, actualResult);
        }
    }
}
