using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler;

namespace ProjectEulerTests
{
    [TestClass]
    public class MultiplesOf3And5Tests
    {
        [TestMethod]
        public void SmallTest()
        {
            Assert.AreEqual(23, ProjectEuler.MultiplesOf3And5.FindMultiplesOf3And5(limit: 10));
        }

        [TestMethod]
        public void LargeTest()
        {
            Assert.AreEqual(233168, ProjectEuler.MultiplesOf3And5.FindMultiplesOf3And5(limit: 1000));
        }
    }
}
