using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler;

namespace ProjectEulerTests
{
    [TestClass]
    public class SpecialPythagoreanTripletTests
    {

        [TestMethod]
        public void LargeTestBruteForce()
        {
            Assert.AreEqual(31875000, ProjectEuler.SpecialPythagoreanTriplet.FindSpecialPythagoreanTripletBruteForce(sum: 1000));
        }

        [TestMethod]
        public void LargeTestBetter()
        {
            Assert.AreEqual(31875000, ProjectEuler.SpecialPythagoreanTriplet.FindSpecialPythagoreanTripletBetter(sum: 1000));
        }
    }
}