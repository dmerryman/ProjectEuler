using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler;

namespace ProjectEulerTests.Problems1_10
{
    [TestClass]
    public class MultiplesOf3And5Tests
    {
        [TestMethod]
        public void SmallTest()
        {
            Assert.AreEqual(23, ProjectEuler.Problems1_10.MultiplesOf3And5.FindMultiplesOf3And5(limit: 10));
        }

        [TestMethod]
        public void LargeTest()
        {
            Assert.AreEqual(233168, ProjectEuler.Problems1_10.MultiplesOf3And5.FindMultiplesOf3And5(limit: 1000));
        }
    }
}
