using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler;

namespace ProjectEulerTests.Problems1_10
{
    [TestClass]
    public class LargestPalindromeProductTests
    {
        [TestMethod]
        public void SmallTest()
        {
            Assert.AreEqual(9009, ProjectEuler.Problems11_20.LargestPalindromeProduct.FindLargestPalindromeProduct(numDigits: 2));
        }

        [TestMethod]
        public void LargeTest()
        {
            Assert.AreEqual(906609, ProjectEuler.Problems11_20.LargestPalindromeProduct.FindLargestPalindromeProduct(numDigits: 3));
        }
    }
}