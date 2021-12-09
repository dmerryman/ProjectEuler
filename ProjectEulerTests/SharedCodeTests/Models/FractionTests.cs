using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler.SharedCode.Models;

namespace ProjectEulerTests.SharedCodeTests.Models
{
    [TestClass]
    public class FractionTests
    {
        [TestMethod]
        public void TestReduce()
        {
            Fraction newFraction = new Fraction(numerator: 2, denominator: 4);
            Assert.IsTrue(newFraction.Reduce());
            Assert.AreEqual(1, newFraction.Numerator);
            Assert.AreEqual(2, newFraction.Denominator);
            newFraction = new Fraction(5040, denominator: 362880);
            Assert.IsTrue(newFraction.Reduce());
            Assert.AreEqual(1, newFraction.Numerator);
            Assert.AreEqual(72, newFraction.Denominator);
        }
    }
}
