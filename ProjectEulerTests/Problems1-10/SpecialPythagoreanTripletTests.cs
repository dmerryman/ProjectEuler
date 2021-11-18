using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler;

namespace ProjectEulerTests.Problems1_10
{
    [TestClass]
    public class SpecialPythagoreanTripletTests
    {

        [TestMethod]
        public void LargeTestBruteForce()
        {
            Assert.AreEqual(31875000, ProjectEuler.Problems1_10.SpecialPythagoreanTriplet.FindSpecialPythagoreanTripletBruteForce(sum: 1000));
        }

        [TestMethod]
        public void LargeTestBetter()
        {
            Assert.AreEqual(31875000, ProjectEuler.Problems1_10.SpecialPythagoreanTriplet.FindSpecialPythagoreanTripletBetter(sum: 1000));
        }
    }
}