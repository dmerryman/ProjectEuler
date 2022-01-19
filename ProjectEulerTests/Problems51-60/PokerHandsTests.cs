using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void TestStraightFlushFails()
        {
            Assert.IsFalse(ProjectEuler.Problems51_60.PokerHands.IsItAStraightFlush(new string[]{ "5H", "6H", "7H", "8H", "9D"}));
            Assert.IsFalse(ProjectEuler.Problems51_60.PokerHands.IsItAStraightFlush(new string[] { "5H", "6H", "7H", "8H", "TH" }));
        }

        [TestMethod]
        public void TestStraightFlush()
        {
            Assert.IsTrue(ProjectEuler.Problems51_60.PokerHands.IsItAStraightFlush(new string[] { "5H", "6H", "7H", "8H", "9H" }));
            Assert.IsTrue(ProjectEuler.Problems51_60.PokerHands.IsItAStraightFlush(new string[] { "QH", "KH", "AH", "2H", "3H" }));
        }

        [TestMethod]
        public void TestGetLowestValue()
        {
            Assert.AreEqual("5",
                ProjectEuler.Problems51_60.PokerHands.GetLowestValue(new string[] { "5H", "6H", "7H", "8H", "9D" }));
        }

        [TestMethod]
        public void TestIsItInIncreasingOrder()
        {
            Assert.IsTrue(
                ProjectEuler.Problems51_60.PokerHands.IsInIncreasingOrder(new string[]
                    { "5H", "6H", "7H", "8H", "9D" }, "5"));
        }

        [TestMethod]
        public void TestIsItInIncreasingOrderFails()
        {
            Assert.IsFalse(
                ProjectEuler.Problems51_60.PokerHands.IsInIncreasingOrder(new string[]
                    { "4H", "6H", "7H", "8H", "9D" }, "4"));
            Assert.IsFalse(
                ProjectEuler.Problems51_60.PokerHands.IsInIncreasingOrder(new string[]
                    { "2H", "4H", "5H", "AH", "KD" }, "2"));
        }

        [TestMethod]
        public void TestIsItInIncreasingOrderWithOverflow()
        {

            Assert.IsTrue(
                ProjectEuler.Problems51_60.PokerHands.IsInIncreasingOrder(new string[]
                    { "JH", "QH", "KH", "AH", "2D" }, "2"));
            Assert.IsTrue(
                ProjectEuler.Problems51_60.PokerHands.IsInIncreasingOrder(new string[]
                    { "AH", "5H", "4H", "3H", "2D" }, "2"));
        }

        [TestMethod]
        public void TestIsItARoyalFlush()
        {
            Assert.IsTrue(
                ProjectEuler.Problems51_60.PokerHands.IsItARoyalFlush(hand: new string[]
                    { "JH", "TH", "QH", "KH", "AH" }));
        }

        [TestMethod]
        public void TestIsItARoyalFlushFail()
        {
            Assert.IsFalse(
                ProjectEuler.Problems51_60.PokerHands.IsItARoyalFlush(hand: new string[]
                    { "5H", "TH", "QH", "KH", "AH" }));
            Assert.IsFalse(
                ProjectEuler.Problems51_60.PokerHands.IsItARoyalFlush(hand: new string[]
                    { "JD", "TH", "QH", "KH", "AH" }));
        }
    }
}
