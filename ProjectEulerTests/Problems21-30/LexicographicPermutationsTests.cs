using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests.Problems21_30
{
    [TestClass]
    public class LexicographicPermutationsTests
    {
        [TestMethod]
        public void TestLexicographicPermutations()
        {
            Assert.AreEqual("2783915460",
                ProjectEuler.Problems21_30.LexicographicPermutations.FindLexicographicPermutations(
                    permutationNumber: 1000000));
        }

        [TestMethod]
        public void TestLexicographicPermutationsFactoradic()
        {
            Assert.AreEqual("2783915460",
                ProjectEuler.Problems21_30.LexicographicPermutations.FindLexicographicPermutationsFactoradic(
                    permutationNumber: 1000000));
        }
    }
}
