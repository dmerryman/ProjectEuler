using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler;

namespace ProjectEulerTests
{
    [TestClass]
    public class LongestCollatzSequenceTests
    {

        [TestMethod]
        public void TestLarge()
        {
            Assert.AreEqual(837799, LongestCollatzSequence.FindLongestCollatzSequenceSlow(ceiling: 1000000));
        }

        [TestMethod]
        public void TestLargeFaster()
        {
            Assert.AreEqual(837799, LongestCollatzSequence.FindLongestCollatzSequenceFaster(ceiling: 1000000));
        }
    }
}
