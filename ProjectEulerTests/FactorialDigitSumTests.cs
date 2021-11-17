using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests
{
    [TestClass]
    public class FactorialDigitSumTests
    {
        [TestMethod]
        public void TestSmall()
        {
            Assert.AreEqual(27, ProjectEuler.FactorialDigitSum.FindFactorialDigitSum(ceiling: 10));
        }

        [TestMethod]
        public void TestLarge()
        {
            Assert.AreEqual(648, ProjectEuler.FactorialDigitSum.FindFactorialDigitSum(ceiling: 100));
        }

        [TestMethod]
        public void TestSmallCheatString()
        {
            Assert.AreEqual(27, ProjectEuler.FactorialDigitSum.FindFactorialDigitSumCheatString(ceiling: 10));
        }

        [TestMethod]
        public void TestSmallCheatModulus()
        {
            Assert.AreEqual(27, ProjectEuler.FactorialDigitSum.FindFactorialDigitSumCheatModulus(ceiling: 10));
        }

        [TestMethod]
        public void TestLargeCheatString()
        {
            Assert.AreEqual(648, ProjectEuler.FactorialDigitSum.FindFactorialDigitSumCheatString(ceiling: 100));
        }

        [TestMethod]
        public void TestLargeCheatModulus()
        {
            Assert.AreEqual(648, ProjectEuler.FactorialDigitSum.FindFactorialDigitSumCheatModulus(ceiling: 100));
        }
    }
}
