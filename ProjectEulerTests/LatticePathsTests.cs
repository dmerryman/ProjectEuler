using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests
{
    [TestClass]
    public class LatticePathsTests
    {
        [TestMethod]
        public void TestSmall()
        {
            Assert.AreEqual(6, ProjectEuler.LatticePaths.FindLatticePaths(squareSize: 2));
        }

        [TestMethod]
        public void TestLarge()
        {
            Assert.AreEqual(137846528820, ProjectEuler.LatticePaths.FindLatticePaths(squareSize: 20));
        }
    }
}
