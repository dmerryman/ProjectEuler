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

        [TestMethod]
        public void TestFindNumberSpiralDiagonalsNoSpiralSmall()
        {
            Assert.AreEqual(101,
                ProjectEuler.Problems21_30.NumberSpiralDiagonals.FindNumberSpiralDiagonalsNoSpiral(size: 5));
        }

        [TestMethod]
        public void TestFindNumberSpiralDiagonalsNoSpiralLarge()
        {
            Assert.AreEqual(669171001,
                ProjectEuler.Problems21_30.NumberSpiralDiagonals.FindNumberSpiralDiagonalsNoSpiral(size: 1001));
        }
    }
}
