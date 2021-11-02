using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ProjectEuler;

namespace ProjectEulerTests
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
