using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests.Problems21_30
{
    [TestClass]
    public class NonAbundantSumsTests
    {
        // Takes like 15 mins to run.
        //[TestMethod]
        //public void TestFindNonAbundantSumsSlowest()
        //{
        //    Assert.AreEqual(4179871, ProjectEuler.Problems21_30.NonAbundantSums.FindNonAbundantSumsSlowest());
        //}

        [TestMethod]
        public void TestFindNonAbundantSumsSieve()
        {
            Assert.AreEqual(4179871, ProjectEuler.Problems21_30.NonAbundantSums.FindNonAbundantSumsSieve());
        }
    }
}
