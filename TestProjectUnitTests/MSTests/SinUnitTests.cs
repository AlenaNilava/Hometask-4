namespace MSTests
{
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SinUnitTests
    {
        [TestMethod]
        public void CheckSin360()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double a = 360;

            //Act
            var actualResult = calculator.Sin(a);

            //Assert
            Assert.AreEqual(1, actualResult, 0.05);
        }
    }   
}
