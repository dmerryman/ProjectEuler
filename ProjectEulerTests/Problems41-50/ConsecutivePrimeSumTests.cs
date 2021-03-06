using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerTests.Problems41_50
{
    /// <summary>
    /// Summary description for ConsecutivePrimeSumTests
    /// </summary>
    [TestClass]
    public class ConsecutivePrimeSumTests
    {
        public ConsecutivePrimeSumTests()
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
        public void TestFindConsecutivePrimeSumSmall()
        {
            Assert.AreEqual(41, ProjectEuler.Problems41_50.ConsecutivePrimeSum.FindConsecutivePrimeSum(limit: 41));
            Assert.AreEqual(953, ProjectEuler.Problems41_50.ConsecutivePrimeSum.FindConsecutivePrimeSum(limit: 1000));
            Assert.AreEqual(997651,
                ProjectEuler.Problems41_50.ConsecutivePrimeSum.FindConsecutivePrimeSum(limit: 1000000));
        }
    }
}
