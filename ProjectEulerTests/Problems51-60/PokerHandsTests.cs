﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerTests.Problems51_60
{
    /// <summary>
    /// Summary description for PokerHandsTests
    /// </summary>
    [TestClass]
    public class PokerHandsTests
    {
        public PokerHandsTests()
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
        public void TestFindPokerHands()
        {
            Assert.AreEqual(1, ProjectEuler.Problems51_60.PokerHands.FindPokerHands());
        }

        [TestMethod]
        public void TestStraightFlush()
        {
            Assert.IsFalse(ProjectEuler.Problems51_60.PokerHands.IsItAStraightFlush(new string[]{ "5H", "6H", "7H", "8H", "9D"}));
        }

        [TestMethod]
        public void TestGetLowestValue()
        {
            Assert.AreEqual("5",
                ProjectEuler.Problems51_60.PokerHands.GetLowestValue(new string[] { "5H", "6H", "7H", "8H", "9D" }));
        }
    }
}
