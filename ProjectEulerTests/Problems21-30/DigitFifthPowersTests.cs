using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests.Problems21_30
{
    [TestClass]
    public class DigitFifthPowersTests
    {
        [TestMethod]
        public void TestFindDigitFifthPowers()
        {
            Assert.AreEqual(443839, ProjectEuler.Problems21_30.DigitFifthPowers.FindDigitFifthPowers());
        }
    }
}
