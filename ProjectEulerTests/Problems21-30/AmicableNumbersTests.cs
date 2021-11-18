using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests.Problems21_30
{
    [TestClass]
    public class AmicableNumbersTests
    {
        [TestMethod]
        public void TestFindAmicableNumbers()
        {
            Assert.AreEqual(31626, ProjectEuler.Problems21_30.AmicableNumbers.FindAmicableNumbers(10000));
        }
    }
}
