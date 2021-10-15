using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler;

namespace ProjectEulerTests
{
    [TestClass]
    public class LargestProductInASeriesTests
    {
        [TestMethod]
        public void SmallTest()
        {
            Assert.AreEqual(5832, ProjectEuler.LargestProductInASeries.findLargestProductInSeries(numDigits: 4));
        }

        [TestMethod]
        public void LargeTest()
        {
            Assert.AreEqual(23514624000, ProjectEuler.LargestProductInASeries.findLargestProductInSeries(numDigits: 13));
        }
    }
}