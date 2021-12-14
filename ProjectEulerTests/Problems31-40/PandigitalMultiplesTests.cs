using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerTests.Problems31_40
{
    /// <summary>
    /// Summary description for PandigitalMultiplesTests
    /// </summary>
    [TestClass]
    public class PandigitalMultiplesTests
    {
        public PandigitalMultiplesTests()
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
        public void TestFindPandigitalMultiples()
        {
            Assert.AreEqual(932718654, ProjectEuler.Problems31_40.PandigitalMultiples.FindPandigitalMultiples());
        }

        //[TestMethod]
        //public void TestGetPandigitalMultiple()
        //{
        //    Assert.AreEqual(192384576, ProjectEuler.Problems31_40.PandigitalMultiples.GetPandigitalMultiple(testValue: 192));
        //}

        //[TestMethod]
        //public void TestIsItAPandigitalMultiple()
        //{
        //    Assert.IsTrue(ProjectEuler.Problems31_40.PandigitalMultiples.IsItAPandigitalMultiple(testValue: 192));
        //    Assert.IsFalse(ProjectEuler.Problems31_40.PandigitalMultiples.IsItAPandigitalMultiple(testValue: 100));
        //}
    }
}
