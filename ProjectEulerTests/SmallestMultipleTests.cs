using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler;

namespace ProjectEulerTests
{
    [TestClass]
    public class SmallestMultipleTests
    {
        [TestMethod]
        public void SmallTest()
        {
            Assert.AreEqual(2520, ProjectEuler.SmallestMultiple.FindSmallestMultiple(ceiling: 10));
        }

        [TestMethod]
        public void LargeTest()
        {
            Assert.AreEqual(232792560, ProjectEuler.SmallestMultiple.FindSmallestMultiple(ceiling: 20));
        }
    }
}