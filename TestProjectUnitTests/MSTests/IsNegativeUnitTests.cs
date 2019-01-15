namespace MSTests
{
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IsNegativeUnitTests
    {
        [TestMethod]
        public void CheckIsNegativeWithDouble()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double a = 90268.987322;

            //Act
            var actualResult = calculator.isNegative(a);

            //Assert
            Assert.AreEqual(false, actualResult);
        }
    }
}
