using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests.Problems21_30
{
    [TestClass]
    public class NumberSpiralDiagonals
    {
        [TestMethod]
        public void TestFindNumberSpiralDiagonalsSmall()
        {
            Assert.AreEqual(101, ProjectEuler.Problems21_30.NumberSpiralDiagonals.FindNumberSpiralDiagnoals(size: 5));
        }

        [TestMethod]
        public void TestFindNumberSpiralDiagonalsLarge()
        {
            Assert.AreEqual(669171001,
                ProjectEuler.Problems21_30.NumberSpiralDiagonals.FindNumberSpiralDiagnoals(size: 1001));
        }
    }
}
