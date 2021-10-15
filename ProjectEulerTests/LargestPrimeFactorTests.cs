using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler;

namespace ProjectEulerTests
{
    [TestClass]
    public class LargestPrimeFactorTests
    {
        [TestMethod]
        public void SmallTest()
        {
            Assert.AreEqual(29, ProjectEuler.LargestPrimeFactor.FindLargestPrimeFactor(number: 13195));
        }

        [TestMethod]
        public void LargeTest()
        {
            Assert.AreEqual(6857, ProjectEuler.LargestPrimeFactor.FindLargestPrimeFactor(number: 600851475143));
        }
    }
}