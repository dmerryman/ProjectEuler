using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerTests.Problems41_50
{
    /// <summary>
    /// Summary description for SubstringDivisibilityTests
    /// </summary>
    [TestClass]
    public class SubstringDivisibilityTests
    {
        public SubstringDivisibilityTests()
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
        public void TestFindSubstringDivisibilityPermutations()
        {
            Assert.AreEqual(16695334890,
                ProjectEuler.Problems41_50.SubstringDivisibility.FindSubstringDivisibilityPermutations());
        }

        [TestMethod]
        public void TestFindSubstringDivisibilitySlow()
        {
            Assert.AreEqual(16695334890,
                ProjectEuler.Problems41_50.SubstringDivisibility.FindSubstringDivisibilitySlow());
        }
        [TestMethod]
        public void TestGetSubstring()
        {
            Assert.AreEqual(406, ProjectEuler.Problems41_50.SubstringDivisibility.GetSubstring(number: 1406357289, startDigit: 2, endDigit: 4));
            Assert.AreEqual(63, ProjectEuler.Problems41_50.SubstringDivisibility.GetSubstring(number: 1406357289, startDigit: 3, endDigit: 5));
            Assert.AreEqual(63572, ProjectEuler.Problems41_50.SubstringDivisibility.GetSubstring(number: 1406357289, startDigit: 3, endDigit: 8));
            Assert.AreEqual(289, ProjectEuler.Problems41_50.SubstringDivisibility.GetSubstring(number: 1406357289, startDigit: 8, endDigit: 10));
            Assert.AreEqual(289, ProjectEuler.Problems41_50.SubstringDivisibility.GetSubstring(number: 149635728, startDigit: 8, endDigit: 10));
        }

        [TestMethod]
        public void TestIsItSubstringDivisible()
        {
            Assert.IsTrue(ProjectEuler.Problems41_50.SubstringDivisibility.IsItSubstringDivisible(testValue: 1406357289));
        }

        [TestMethod]
        public void TestIsItPandigital()
        {
            Assert.IsTrue(ProjectEuler.Problems41_50.SubstringDivisibility.IsItPandigital(number: 1406357289));
        }

        [TestMethod]
        public void TestGetPermutations()
        {
            Assert.Equals(3628800, ProjectEuler.Problems41_50.SubstringDivisibility.GetPermutations(number: 1234567890).Count);
        }
    }
}
