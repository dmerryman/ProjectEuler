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
            Assert.AreEqual(73682, ProjectEuler.Problems31_40.CoinSums.FindCoinSums(pounds: 2, pence: 0));
        }

        [TestMethod]
        public void TestFindCoinSumsDP()
        {
            Assert.AreEqual(73682, ProjectEuler.Problems31_40.CoinSums.FindCoinSumsDP(pounds: 2, pence: 0));
        }

        [TestMethod]
        public void TestFindCoinSumsDPSmall()
        {
            Assert.AreEqual(4, ProjectEuler.Problems31_40.CoinSums.FindCoinSumsDP(pounds:0 , pence: 5));
        }

        [TestMethod]
        public void TestFindCoinSumsLarge()
        {
            Assert.AreEqual(321335886, ProjectEuler.Problems31_40.CoinSums.FindCoinSums(pounds: 10, pence: 0));
        }

        [TestMethod]
        public void TestFindCoinSumsDPLarge()
        {
            Assert.AreEqual(321335886, ProjectEuler.Problems31_40.CoinSums.FindCoinSumsDP(pounds: 10, pence: 0));
        }
    }
}
