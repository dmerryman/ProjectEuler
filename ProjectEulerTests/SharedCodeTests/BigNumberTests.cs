using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectEuler.SharedCode;

namespace ProjectEulerTests.SharedCodeTests
{
    [TestClass]
    public class BigNumberTests
    {
        [TestMethod]
        public void TestIsNumericTrue()
        {
            Assert.IsTrue(BigNumber.IsNumeric("500"));
        }

        [TestMethod]
        public void TestIsNumericFalse()
        {
            Assert.IsFalse(BigNumber.IsNumeric("five hundred"));
        }

        [TestMethod]
        public void TestLeadingZeroes()
        {
            BigNumber number = new BigNumber("00500");
            Assert.AreEqual("500", number.ToString());
        }

        [TestMethod]
        public void TestToString()
        {
            BigNumber number = new BigNumber("500");
            Assert.AreEqual("500", number.ToString());
        }

        [TestMethod]
        public void TestAdditionWithCarry()
        {
            BigNumber num1 = new BigNumber("500");
            BigNumber num2 = new BigNumber("525");
            BigNumber result = num1.Addition(otherNumber: num2);
            Assert.AreEqual("1025", result.ToString());
        }

        [TestMethod]
        public void TestAddition()
        {
            BigNumber num1 = new BigNumber("300");
            BigNumber num2 = new BigNumber("525");
            BigNumber result = num1.Addition(otherNumber: num2);
            Assert.AreEqual("825", result.ToString());
        }

        [TestMethod]
        public void TestBigAddition()
        {
            BigNumber num1 = new BigNumber("11111111111111111111111111111111111111111111111111");
            BigNumber num2 = new BigNumber("11111111111111111111111111111111111111111111111111");
            BigNumber result = num1.Addition(otherNumber: num2);
            Assert.AreEqual("22222222222222222222222222222222222222222222222222", result.ToString());
        }

        [TestMethod]
        public void TestBigAdditionWithCarry()
        {
            BigNumber num1 = new BigNumber("99999999999999999999999999999999999999999999999999");
            BigNumber num2 = new BigNumber("99999999999999999999999999999999999999999999999999");
            BigNumber result = num1.Addition(otherNumber: num2);
            Assert.AreEqual("199999999999999999999999999999999999999999999999998", result.ToString());
        }

        [TestMethod]
        public void TestMultiplication()
        {
            BigNumber num1 = new BigNumber("9999");
            BigNumber num2 = new BigNumber("9999");
            num1.Multiplication(otherNumber: num2);
            Assert.AreEqual("99980001", num1.ToString());
        }

    }
}
