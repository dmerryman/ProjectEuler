using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler;

namespace ProjectEulerTests
{
    [TestClass]
    public class SumSquareDifferenceTests
    {
        [TestMethod]
        public void SmallTestSlow()
        {
            Assert.AreEqual(2640, ProjectEuler.SumSquareDifference.FindSumSquareDifferenceSlow(limit: 10));
        }

        [TestMethod]
        public void LargeTestSlow()
        {
            Assert.AreEqual(25164150, ProjectEuler.SumSquareDifference.FindSumSquareDifferenceSlow(limit: 100));
        }

        [TestMethod]
        public void SmallTestFaster()
        {
            Assert.AreEqual(2640, ProjectEuler.SumSquareDifference.FindSumSquareDifferenceFaster(limit: 10));
        }

        [TestMethod]
        public void LargeTestFaster()
        {
            Assert.AreEqual(25164150, ProjectEuler.SumSquareDifference.FindSumSquareDifferenceFaster(limit: 100));
        }
    }
}