using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace ProjectEulerTests.Problems51_60
{
    /// <summary>
    /// Summary description for CombinatoricSelectionsTests
    /// </summary>
    [TestClass]
    public class CombinatoricSelectionsTests
    {
        public CombinatoricSelectionsTests()
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
        public void TestFindCombinatoricsSelections()
        {
            Assert.AreEqual(4075, ProjectEuler.Problems51_60.CombinatoricSelections.FindCombinatoricSelections());
        }

        [TestMethod]
        public void TestFindCombinatoricsSelectionsFaster()
        {
            Assert.AreEqual(4075, ProjectEuler.Problems51_60.CombinatoricSelections.FindCombinatoricSelectionsFaster());
        }

        //[TestMethod]
        //public void TestCalculateNumberOfCombinations()
        //{
        //    Assert.AreEqual(10, ProjectEuler.Problems51_60.CombinatoricSelections.CalculateNumberOfCombinations(n: 5, r: 3));
        //}
    }
}
