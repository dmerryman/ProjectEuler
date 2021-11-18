using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler;

namespace ProjectEulerTests.Problems1_10
{
    [TestClass]
    public class LargestProductInASeriesTests
    {
        [TestMethod]
        public void SmallTest()
        {
            Assert.AreEqual(5832, ProjectEuler.Problems1_10.LargestProductInASeries.findLargestProductInSeries(numDigits: 4));
        }

        [TestMethod]
        public void LargeTest()
        {
            Assert.AreEqual(23514624000, ProjectEuler.Problems1_10.LargestProductInASeries.findLargestProductInSeries(numDigits: 13));
        }
    }
}