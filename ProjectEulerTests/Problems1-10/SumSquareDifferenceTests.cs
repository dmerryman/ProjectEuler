using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler;

namespace ProjectEulerTests.Problems1_10
{
    [TestClass]
    public class SumSquareDifferenceTests
    {
        [TestMethod]
        public void SmallTestSlow()
        {
            Assert.AreEqual(2640, ProjectEuler.Problems1_10.SumSquareDifference.FindSumSquareDifferenceSlow(limit: 10));
        }

        [TestMethod]
        public void LargeTestSlow()
        {
            Assert.AreEqual(25164150, ProjectEuler.Problems1_10.SumSquareDifference.FindSumSquareDifferenceSlow(limit: 100));
        }

        [TestMethod]
        public void SmallTestFaster()
        {
            Assert.AreEqual(2640, ProjectEuler.Problems1_10.SumSquareDifference.FindSumSquareDifferenceFaster(limit: 10));
        }

        [TestMethod]
        public void LargeTestFaster()
        {
            Assert.AreEqual(25164150, ProjectEuler.Problems1_10.SumSquareDifference.FindSumSquareDifferenceFaster(limit: 100));
        }
    }
}