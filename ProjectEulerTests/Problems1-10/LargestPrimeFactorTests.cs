using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler;

namespace ProjectEulerTests.Problems1_10
{
    [TestClass]
    public class LargestPrimeFactorTests
    {
        [TestMethod]
        public void SmallTest()
        {
            Assert.AreEqual(29, ProjectEuler.Problems1_10.LargestPrimeFactor.FindLargestPrimeFactor(number: 13195));
        }

        [TestMethod]
        public void LargeTest()
        {
            Assert.AreEqual(6857, ProjectEuler.Problems1_10.LargestPrimeFactor.FindLargestPrimeFactor(number: 600851475143));
        }
    }
}