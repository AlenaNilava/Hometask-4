namespace MSTests
{
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SqrtUnitTests
    {
        [TestMethod]
        public void CheckSqrt()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double a = 100;

            //Act
            var actualResult = calculator.Sqrt(a);

            //Assert
            Assert.AreEqual(10, actualResult);
        }

        [TestMethod]
        public void CheckSqrtDouble()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double a = 855.10;

            //Act
            var actualResult = calculator.Sqrt(a);

            //Assert
            Assert.AreEqual(9.2195444572928871, actualResult);
        }
    }
}
