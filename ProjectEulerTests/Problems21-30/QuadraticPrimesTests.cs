using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests.Problems21_30
{
    [TestClass]
    public class QuadraticPrimesTests
    {
        [TestMethod]
        public void TestFindQuadraticPrimes()
        {
            Assert.AreEqual(-59231, ProjectEuler.Problems21_30.QuadraticPrimes.FindQuadraticPrimes(limit: 1000));
        }

        [TestMethod]
        public void TestFindQuadraticPrimesSieve()
        {
            Assert.AreEqual(-59231, ProjectEuler.Problems21_30.QuadraticPrimes.FindQuadraticPrimesSieve(limit: 1000));
        }
    }
}
