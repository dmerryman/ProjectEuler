using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler;

namespace ProjectEulerTests.Problems1_10
{
    [TestClass]
    public class _10001stPrime
    {
        [TestMethod]
        public void SmallTest()
        {
            Assert.AreEqual(13, ProjectEuler.Problems1_10._10001stPrime.FindNthPrime(n: 6));
        }

        [TestMethod]
        public void LargeTest()
        {
            Assert.AreEqual(104743, ProjectEuler.Problems1_10._10001stPrime.FindNthPrime(n: 10001));
        }
    }
}