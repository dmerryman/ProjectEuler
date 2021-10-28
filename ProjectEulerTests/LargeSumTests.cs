using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler;

namespace ProjectEulerTests
{
    [TestClass]
    public class LargeSumTests
    {
        [TestMethod]
        public void TestLarge()
        {
            Assert.AreEqual("5537376230", ProjectEuler.LargeSum.FindLargeSumFirstNDigits(numDigits: 10));
        }

        [TestMethod]
        public void TestSmall()
        {
            Assert.AreEqual("553", ProjectEuler.LargeSum.FindLargeSumFirstNDigits(numDigits: 3));
        }

        [TestMethod]
        public void TestLarger()
        {
            Assert.AreEqual("553737623039087663730204874683298597177365983189", ProjectEuler.LargeSum.FindLargeSumFirstNDigits(numDigits: 48));
        }
    }
}