using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler;

namespace ProjectEulerTests.Problems1_10
{
    [TestClass]
    public class SmallestMultipleTests
    {
        [TestMethod]
        public void SmallTest()
        {
            Assert.AreEqual(2520, ProjectEuler.Problems1_10.SmallestMultiple.FindSmallestMultiple(ceiling: 10));
        }

        [TestMethod]
        public void LargeTest()
        {
            Assert.AreEqual(232792560, ProjectEuler.Problems1_10.SmallestMultiple.FindSmallestMultiple(ceiling: 20));
        }
    }
}