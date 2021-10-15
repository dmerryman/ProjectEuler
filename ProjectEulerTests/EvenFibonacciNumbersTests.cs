using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler;

namespace ProjectEulerTests
{
    [TestClass]
    public class EvenFibonacciNumbersTests
    {
        [TestMethod]
        public void SmallTest()
        {
            Assert.AreEqual(44, ProjectEuler.EvenFibonacciNumbers.FindEvenFibonacciNumbers(limit: 100));
        }

        [TestMethod]
        public void LargeTest()
        {
            Assert.AreEqual(4613732, ProjectEuler.EvenFibonacciNumbers.FindEvenFibonacciNumbers(limit: 4000000));
        }
    }
}