using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerTests.Problems31_40
{
    /// <summary>
    /// Summary description for DoubleBasePalindromesTests
    /// </summary>
    [TestClass]
    public class DoubleBasePalindromesTests
    {
        public DoubleBasePalindromesTests()
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
        public void TestFindDoubleBasePalindromes()
        {
            Assert.AreEqual(1,
                ProjectEuler.Problems31_40.DoubleBasePalindromes.FindDoubleBasePalindromes(limit: 1000000));
        }

        [TestMethod]
        public void TestConvertToBaseTwo()
        {
            Assert.AreEqual(101, ProjectEuler.Problems31_40.DoubleBasePalindromes.ConvertToBaseTwo(value: 5));
        }
    }
}
