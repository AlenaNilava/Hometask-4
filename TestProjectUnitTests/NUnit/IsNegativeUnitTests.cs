using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnit
{
	[TestFixture]
    public class IsNegativeUnitTests
    {
		[Test]
	    public void CheckIsNegativeWithDouble()
	    {
            Thread.Sleep(10000);
            Calculator calculator = new Calculator();
            double a = - 18655559;

            //Act
            var actualResult = calculator.isNegative(a);

            //Assert
            Assert.AreEqual(true, actualResult);
        }

	}
}
