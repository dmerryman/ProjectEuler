using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests.Problems21_30
{
    [TestClass]
    public class NonAbundantSumsTests
    {
        [TestMethod]
        public void TestFindNonAbundantSums()
        {
            Assert.AreEqual(4179871, ProjectEuler.Problems21_30.NonAbundantSums.FindNonAbundantSums());
        }
    }
}
