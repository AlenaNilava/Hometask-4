namespace MSTests
{
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AbsUnitTests
    {
        [TestMethod]
        public void CheckAbsWithDouble()
        {
     
            //Arrange
            Calculator calculator = new Calculator();
            double a = -4;

            //Act
            var actualResult = calculator.Abs(a);

            //Assert
            Assert.AreEqual(4, actualResult);
        }
    }
}
