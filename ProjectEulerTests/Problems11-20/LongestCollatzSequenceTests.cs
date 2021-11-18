using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ProjectEuler;
using ProjectEuler.Problems11_20;

namespace ProjectEulerTests.Problems11_20
{
    [TestClass]
    public class LongestCollatzSequenceTests
    {

        [TestMethod]
        public void TestLarge()
        {
            Assert.AreEqual(837799, LongestCollatzSequence.FindLongestCollatzSequenceSlowest(ceiling: 1000000));
        }

        [TestMethod]
        public void TestLargeFaster()
        {
            Assert.AreEqual(837799, LongestCollatzSequence.FindLongestCollatzSequenceFast(ceiling: 1000000));
        }

        [TestMethod]
        public void TestLargeBest()
        {
            Assert.AreEqual(837799, LongestCollatzSequence.FindNumberOfStepsInCollatzSequenceFaster(ceiling: 1000000));
        }
    }
}
