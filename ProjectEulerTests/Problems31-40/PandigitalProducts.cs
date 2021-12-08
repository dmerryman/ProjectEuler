using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests.Problems31_40
{
    [TestClass]
    public class PandigitalProducts
    {
        [TestMethod]
        public void TestFindPandigitalProducts()
        {
            Assert.AreEqual(1, ProjectEuler.Problems31_40.PandigitalProducts.FindPandigitalProducts());
        }
    }
}
