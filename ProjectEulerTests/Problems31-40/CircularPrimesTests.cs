using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests.Problems31_40
{
    [TestClass]
    public class CircularPrimesTests
    {
        [TestMethod]
        public void TestFindCircularPrimesSmall()
        {
            Assert.AreEqual(13, ProjectEuler.Problems31_40.CircularPrimes.FindCircularPrimes(limit: 100));
        }

        [TestMethod]
        public void TestFindCircularPrimesLarge()
        {
            Assert.AreEqual(13, ProjectEuler.Problems31_40.CircularPrimes.FindCircularPrimes(limit: 1000000));
        }
    }
}
