using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ProjectEuler.SharedCode.Models;

namespace ProjectEulerTests.SharedCodeTests.Models
{
    /// <summary>
    /// Summary description for NumericPermutationTests
    /// </summary>
    [TestClass]
    public class NumericPermutationTests
    {
        public NumericPermutationTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestGetDigitCounts()
        {
            long value = 99987654321;
            NumericPermutation test = new NumericPermutation(numbericValue: value);
            Dictionary<int, int> digitCounts = test.GetDigitCounts();
            Assert.AreEqual(9, digitCounts.Keys.Count);
            Assert.AreEqual(3, digitCounts[9]);
        }

        [TestMethod]
        public void TestEquals()
        {
            long value = 99977531;
            NumericPermutation firstVal = new NumericPermutation(numbericValue: value);
            long otherValue = 13579799;
            NumericPermutation secondVal = new NumericPermutation(numbericValue: otherValue);
            long lastValue = 12345678;
            NumericPermutation thirdVal = new NumericPermutation(numbericValue: lastValue);
            Assert.IsFalse(firstVal.Equals(obj: null));
            Assert.IsFalse(firstVal.Equals(obj: otherValue));
            Assert.IsTrue(firstVal.Equals(secondVal));
            Assert.IsFalse(firstVal.Equals(thirdVal));
        }
    }
}
