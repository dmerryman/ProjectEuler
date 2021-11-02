using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests
{
    [TestClass]
    public class LatticePathsTests
    {
        [TestMethod]
        public void TestSmallSlowest()
        {
            Assert.AreEqual(6, ProjectEuler.LatticePaths.FindLatticePathsSlowest(squareSize: 2));
        }

        // 20+ minutes!
        //[TestMethod]
        //public void TestLarge()
        //{
        //    Assert.AreEqual(137846528820, ProjectEuler.LatticePaths.FindLatticePathsSlowest(squareSize: 20));
        //}


    }
}
