using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests
{
    [TestClass]
    public class PowerDigitSumTests
    {
        [TestMethod] public void TestSmall()
        {
            Assert.AreEqual(26, ProjectEuler.PowerDigitSum.FindPowerDigitSum(exponent: 15));
        }

        [TestMethod]
        public void TestLarge()
        {
            Assert.AreEqual(1366, ProjectEuler.PowerDigitSum.FindPowerDigitSum(exponent: 1000));
        }

        [TestMethod]
        public void TestSmallBigInt()
        {
            Assert.AreEqual(26, ProjectEuler.PowerDigitSum.FindPowerDigitSumCheatingWithBigInt(exponent: 15));
        }

        [TestMethod]
        public void TestLargeBigInt()
        {
            Assert.AreEqual(1366, ProjectEuler.PowerDigitSum.FindPowerDigitSumCheatingWithBigInt(exponent: 1000));
        }
    }
}
