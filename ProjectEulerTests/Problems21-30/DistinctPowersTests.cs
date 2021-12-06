using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests.Problems21_30
{
    [TestClass]
    public class DistinctPowersTests
    {
        [TestMethod]
        public void TestFindDistinctPowersSmall()
        {
            Assert.AreEqual(15, ProjectEuler.Problems21_30.DistinctPowers.FindDistinctPowers(limit: 5));
        }

        [TestMethod]
        public void TestFindDistinctPowersLarge()
        {
            Assert.AreEqual(9183, ProjectEuler.Problems21_30.DistinctPowers.FindDistinctPowers(limit: 100));
        }
    }
}
