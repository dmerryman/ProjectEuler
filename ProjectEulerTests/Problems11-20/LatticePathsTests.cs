using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests.Problems11_20
{
    [TestClass]
    public class LatticePathsTests
    {
        [TestMethod]
        public void TestSmallSlowest()
        {
            Assert.AreEqual(6, ProjectEuler.Problems11_20.LatticePaths.FindLatticePathsSlowest(squareSize: 2));
        }

        // 20+ minutes!
        //[TestMethod]
        //public void TestLarge()
        //{
        //    Assert.AreEqual(137846528820, ProjectEuler.LatticePaths.FindLatticePathsSlowest(squareSize: 20));
        //}

        [TestMethod]
        public void TestSmallSlow()
        {
            Assert.AreEqual(6, ProjectEuler.Problems11_20.LatticePaths.FindLatticePathsIterative(squareSize: 2));
        }

        [TestMethod]
        public void TestLargeSlow()
        {
            Assert.AreEqual(137846528820, ProjectEuler.Problems11_20.LatticePaths.FindLatticePathsIterative(squareSize: 20));
        }

        [TestMethod]
        public void TestSmallRecursive()
        {
            Assert.AreEqual(6, ProjectEuler.Problems11_20.LatticePaths.FindLatticePathsRecursive(squareSize: 2));
        }

        [TestMethod]
        public void TestLargeRecursive()
        {
            Assert.AreEqual(137846528820, ProjectEuler.Problems11_20.LatticePaths.FindLatticePathsRecursive(squareSize: 20));
        }
    }
}
