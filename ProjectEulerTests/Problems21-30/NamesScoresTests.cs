using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests.Problems21_30
{
    [TestClass]
    public class NamesScoresTests
    {
        [TestMethod]
        public void TestFindNamesScores()
        {
            Assert.AreEqual(871198282, ProjectEuler.Problems21_30.NamesScores.FindNamesScores());
        }
    }
}
