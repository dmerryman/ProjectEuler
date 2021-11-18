using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ProjectEuler;
using ProjectEuler.Problems1_10;

namespace ProjectEulerTests.Problems1_10
{
    /// <summary>
    /// Summary description for SummationOfPrimesTests
    /// </summary>
    [TestClass]
    public class SummationOfPrimesTests
    {
        public SummationOfPrimesTests()
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
        public void SmallTestFaster()
        {
            Assert.AreEqual(17, SummationOfPrimes.FindSummationOfPrimesFaster(limit: 10));
        }

        [TestMethod]
        public void LargeTestFaster()
        {
            Assert.AreEqual(142913828922, SummationOfPrimes.FindSummationOfPrimesFaster(limit: 2000000));
        }
    }
}
