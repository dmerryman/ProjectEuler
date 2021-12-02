using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests.Problems21_30
{
    [TestClass]
    public class QuadraticPrimesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(-59231, ProjectEuler.Problems21_30.QuadraticPrimes.FindQuadraticPrimes(limit: 1000));
        }
    }
}
