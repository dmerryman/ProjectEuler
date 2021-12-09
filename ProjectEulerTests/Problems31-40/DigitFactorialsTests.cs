using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests.Problems31_40
{
    [TestClass]
    public class DigitFactorialsTests
    {
        [TestMethod]
        public void TestFindDigitFactorials()
        {
            Assert.AreEqual(40730, ProjectEuler.Problems31_40.DigitFactorials.FindDigitFactorials());
        }
    }
}
