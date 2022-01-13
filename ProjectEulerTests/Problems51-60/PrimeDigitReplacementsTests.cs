using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerTests.Problems51_60
{
    /// <summary>
    /// Summary description for PrimeDigitReplacementsTests
    /// </summary>
    [TestClass]
    public class PrimeDigitReplacementsTests
    {
        public PrimeDigitReplacementsTests()
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
        public void TestFindPrimeDigitReplacements()
        {
            Assert.AreEqual(121313, ProjectEuler.Problems51_60.PrimeDigitReplacements.FindPrimeDigitReplacements(targetNumber: 8));
        }

        [TestMethod]
        public void TestFindPrimeDigitReplacementsSmall()
        {
            Assert.AreEqual(13, ProjectEuler.Problems51_60.PrimeDigitReplacements.FindPrimeDigitReplacements(targetNumber: 6));
        }

        [TestMethod]
        public void TestFindPrimeDigitReplacementMedium()
        {
            Assert.AreEqual(56003, ProjectEuler.Problems51_60.PrimeDigitReplacements.FindPrimeDigitReplacements(targetNumber: 7));
        }

        //[TestMethod]
        //public void TestCombinations()
        //{
        //    var combinations = ProjectEuler.Problems51_60.PrimeDigitReplacements.GetPossibleVariations(input: "11");
        //    Assert.AreEqual(4, combinations.Count);
        //}

        //[TestMethod]

        //public void TestGetNumberOfPrimesForReplacement()
        //{
        //    bool[] primeSieve = ProjectEuler.SharedCode.Math.GeneratePrimeSieve(limit: 10000000);
        //    Assert.AreEqual(7, ProjectEuler.Problems51_60.PrimeDigitReplacements.GetNumberOfPrimesForReplacement(primeSieve: primeSieve, variation: "56XX3"));
        //}
    }
}
