using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler;

namespace ProjectEulerTests
{
    [TestClass]
    public class LargeSumTests
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("5537376230", ProjectEuler.LargeSum.FindLargeSum());
        }
    }
}