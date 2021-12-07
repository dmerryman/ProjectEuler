using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests.Problems31_40
{
    [TestClass]
    public class CoinSumsTests
    {
        [TestMethod]
        public void TestFindCoinSums()
        {
            Assert.AreEqual(1, ProjectEuler.Problems31_40.CoinSums.FindCoinSums(pounds: 2));
        }
    }
}
