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
            Assert.AreEqual(837799, LongestCollatzSequence.FindLongestCollatzSequence(ceiling: 1000000));
        }
    }
}
