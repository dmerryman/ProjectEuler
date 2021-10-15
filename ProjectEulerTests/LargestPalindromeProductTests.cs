using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler;

namespace ProjectEulerTests
{
    [TestClass]
    public class LargestPalindromeProductTests
    {
        [TestMethod]
        public void SmallTest()
        {
            Assert.AreEqual(9009, ProjectEuler.LargestPalindromeProduct.FindLargestPalindromeProduct(numDigits: 2));
        }

        [TestMethod]
        public void LargeTest()
        {
            Assert.AreEqual(906609, ProjectEuler.LargestPalindromeProduct.FindLargestPalindromeProduct(numDigits: 3));
        }
    }
}