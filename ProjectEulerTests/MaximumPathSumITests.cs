using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ProjectEulerTests
{
    [TestClass]
    public class MaximumPathSumITests
    {
        [TestMethod]
        public void TestSmall()
        {
            Assert.AreEqual(23, ProjectEuler.MaximumPathSumI.FindMaximumPathSumISmall());
        }

        [TestMethod]
        public void TestLarge()
        {
            Assert.AreEqual(1074, ProjectEuler.MaximumPathSumI.FindMaximumPathSumILarge());
        }

    }

    
}
