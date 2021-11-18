using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests.Problems11_20
{
    [TestClass]
    public class CountingSundaysTests
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(171, ProjectEuler.Problems11_20.CountingSundays.FindCountingSundays(endYear: 2000));
        }

        [TestMethod]
        public void TestEasy()
        {
            Assert.AreEqual(171, ProjectEuler.Problems11_20.CountingSundays.FindCountingSundaysEasy(endYear: 2000));
        }
    }
}
