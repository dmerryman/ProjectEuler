using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerTests.Problems31_40
{
    /// <summary>
    /// Summary description for TrunctablePrimesTests
    /// </summary>
    [TestClass]
    public class TrunctablePrimesTests
    {
        public TrunctablePrimesTests()
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
        public void TestFindTrunctablePrimes()
        {
            Assert.AreEqual(748317, ProjectEuler.Problems31_40.TrunctablePrimes.FindTrunctablePrimes());
        }

        [TestMethod]
        public void TestFindTrunctablePrimesWithSieve()
        {
            Assert.AreEqual(748317, ProjectEuler.Problems31_40.TrunctablePrimes.FindTrunctablePrimesWithSieve());
        }

        [TestMethod]
        public void TestGetNumberVariations()
        {
            List<int> variations = ProjectEuler.Problems31_40.TrunctablePrimes.GetNumberVariations(value: 3742);
            Assert.AreEqual(7, variations.Count);
            Assert.AreEqual(742, variations[6]);
        }
    }
}
