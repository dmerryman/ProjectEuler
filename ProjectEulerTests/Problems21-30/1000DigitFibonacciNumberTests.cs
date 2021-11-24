using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests.Problems21_30
{
    [TestClass]
    public class _1000DigitFibonacciNumberTests
    {
        [TestMethod]
        public void Test1000DigitFibonacciNumber()
        {
            Assert.AreEqual(4782, ProjectEuler.Problems21_30._1000DigitFibonacciNumber.Find1000DigitFibonacciNumber());
        }
    }
}
