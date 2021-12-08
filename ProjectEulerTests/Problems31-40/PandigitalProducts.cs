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

        [TestMethod]
        public void TestIsPandigitalProductTrue()
        {
            Assert.IsTrue(ProjectEuler.Problems31_40.PandigitalProducts.IsPandigitalProduct(first: 39, second: 186, product: 7254));
        }

        [TestMethod]
        public void TestIsPandigitalProductFalse()
        {
            Assert.IsFalse(ProjectEuler.Problems31_40.PandigitalProducts.IsPandigitalProduct(first: 40, second: 42, product: 7254));
        }
    }
}
