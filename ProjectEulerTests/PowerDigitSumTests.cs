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
    }
}
