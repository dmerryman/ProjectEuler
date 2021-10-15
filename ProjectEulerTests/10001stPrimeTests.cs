using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler;

namespace ProjectEulerTests
{
    [TestClass]
    public class _10001stPrime
    {
        [TestMethod]
        public void SmallTest()
        {
            Assert.AreEqual(13, ProjectEuler._10001stPrime.FindNthPrime(n: 6));
        }

        [TestMethod]
        public void LargeTest()
        {
            Assert.AreEqual(104743, ProjectEuler._10001stPrime.FindNthPrime(n: 10001));
        }
    }
}