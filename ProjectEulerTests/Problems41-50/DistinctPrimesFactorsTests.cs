using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerTests.Problems41_50
{
    /// <summary>
    /// Summary description for DistinctPrimesFactorsTests
    /// </summary>
    [TestClass]
    public class DistinctPrimesFactorsTests
    {
        public DistinctPrimesFactorsTests()
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
        public void TestFindDistinctPrimesFactors()
        {
            Assert.AreEqual(14,
                ProjectEuler.Problems41_50.DistinctPrimesFactors.FindDistinctPrimesFactors(numConsecutive: 2));
            Assert.AreEqual(14,
                ProjectEuler.Problems41_50.DistinctPrimesFactors.FindDistinctPrimesFactors(numConsecutive: 2));
        }

        [TestMethod]
        public void TestGetNumberOfDistinctPrimeFactors()
        {
            Assert.AreEqual(2,
                ProjectEuler.Problems41_50.DistinctPrimesFactors.GetNumberOfDistinctPrimeFactors(number: 14));
            Assert.AreEqual(2,
                ProjectEuler.Problems41_50.DistinctPrimesFactors.GetNumberOfDistinctPrimeFactors(number: 15));
            Assert.AreEqual(3,
                ProjectEuler.Problems41_50.DistinctPrimesFactors.GetNumberOfDistinctPrimeFactors(number: 644));
        }
    }
}
