using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests
{
    [TestClass]
    public class CountingSundaysTests
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(171, ProjectEuler.CountingSundays.FindCountingSundays(endYear: 2000));
        }

        [TestMethod]
        public void TestEasy()
        {
            Assert.AreEqual(171, ProjectEuler.CountingSundays.FindCountingSundaysEasy(endYear: 2000));
        }
    }
}
