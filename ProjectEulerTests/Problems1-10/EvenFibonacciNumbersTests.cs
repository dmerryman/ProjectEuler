using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler;

namespace ProjectEulerTests.Problems1_10
{
    [TestClass]
    public class EvenFibonacciNumbersTests
    {
        [TestMethod]
        public void SmallTest()
        {
            Assert.AreEqual(44, ProjectEuler.Problems1_10.EvenFibonacciNumbers.FindEvenFibonacciNumbers(limit: 100));
        }

        [TestMethod]
        public void LargeTest()
        {
            Assert.AreEqual(4613732, ProjectEuler.Problems1_10.EvenFibonacciNumbers.FindEvenFibonacciNumbers(limit: 4000000));
        }
    }
}