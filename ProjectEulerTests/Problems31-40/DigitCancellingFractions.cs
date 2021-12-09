using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests.Problems31_40
{
    [TestClass]
    public class DigitCancellingFractions
    {
        [TestMethod]
        public void TestFindDigitCancellingFractions()
        {
            Assert.AreEqual(100, ProjectEuler.Problems31_40.DigitCancellingFractions.FindDigitCancellingFractions());
        }
    }
}
