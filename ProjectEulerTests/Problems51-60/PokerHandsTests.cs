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
                    { "5H", "6H", "7H", "8H", "9D" }));
            Assert.IsTrue(
                ProjectEuler.Problems51_60.PokerHands.IsInIncreasingOrder(new string[]
                    { "TH", "JH", "QH", "KH", "AD" }));
        }

        [TestMethod]
        public void TestIsItInIncreasingOrderFails()
        {
            Assert.IsFalse(
                ProjectEuler.Problems51_60.PokerHands.IsInIncreasingOrder(new string[]
                    { "4H", "6H", "7H", "8H", "9D" }));
            Assert.IsFalse(
                ProjectEuler.Problems51_60.PokerHands.IsInIncreasingOrder(new string[]
                    { "2H", "4H", "5H", "AH", "KD" }));
        }

        [TestMethod]
        public void TestIsItInIncreasingOrderWithOverflow()
        {

            Assert.IsTrue(
                ProjectEuler.Problems51_60.PokerHands.IsInIncreasingOrder(new string[]
                    { "JH", "QH", "KH", "AH", "2D" }));
            Assert.IsTrue(
                ProjectEuler.Problems51_60.PokerHands.IsInIncreasingOrder(new string[]
                    { "AH", "5H", "4H", "3H", "2D" }));
        }

        [TestMethod]
        public void TestIsItARoyalFlush()
        {
            String highestRelevantCard = String.Empty;
            Assert.IsTrue(
                ProjectEuler.Problems51_60.PokerHands.IsItARoyalFlush(hand: new string[]
                    { "JH", "TH", "QH", "KH", "AH" }, highestRelevantCard: ref highestRelevantCard));
        }

        [TestMethod]
        public void TestIsItARoyalFlushFail()
        {
            String highestRelevantCard = String.Empty;
            Assert.IsFalse(
                ProjectEuler.Problems51_60.PokerHands.IsItARoyalFlush(hand: new string[]
                    { "5H", "TH", "QH", "KH", "AH" }, highestRelevantCard: ref highestRelevantCard));
            Assert.IsFalse(
                ProjectEuler.Problems51_60.PokerHands.IsItARoyalFlush(hand: new string[]
                    { "JD", "TH", "QH", "KH", "AH" }, highestRelevantCard: ref highestRelevantCard));
        }

        [TestMethod]

        public void TestIsItFourOfAKind()
        {
            Assert.IsTrue(
                ProjectEuler.Problems51_60.PokerHands.IsItFourOfAKind(hand: new string[]
                    { "JH", "JD", "JC", "JS", "AH" }));
        }

        [TestMethod]
        public void TestIsItFourOfAKindFail()
        {
            Assert.IsFalse(
                ProjectEuler.Problems51_60.PokerHands.IsItFourOfAKind(hand: new string[]
                    { "JH", "JD", "JC", "AH", "AS" }));
        }

        [TestMethod]
        public void TestIsItAFullHouse()
        {
            Assert.IsTrue(
                ProjectEuler.Problems51_60.PokerHands.IsItAFullHouse(
                    hand: new string[] { "KH", "KC", "KD", "QH", "QC" }));
        }

        [TestMethod]
        public void TestIsItAFullHouseFail()
        {
            Assert.IsFalse(
                ProjectEuler.Problems51_60.PokerHands.IsItAFullHouse(
                    hand: new string[] { "KH", "KC", "KD", "QH", "AC" }));
        }

        [TestMethod]
        public void TestIsItAFlush()
        {
            Assert.IsTrue(
                ProjectEuler.Problems51_60.PokerHands.IsItAFlush(hand: new string[] { "KH", "5H", "3H", "9H", "QH" }));
        }

        [TestMethod]
        public void TestIsItAFlushFail()
        {
            Assert.IsFalse(
                ProjectEuler.Problems51_60.PokerHands.IsItAFlush(hand: new string[] { "KH", "5H", "3H", "9H", "QD" }));
        }

        [TestMethod]
        public void TestIsItAStraight()
        {
            Assert.IsTrue(ProjectEuler.Problems51_60.PokerHands.IsItAStraight(hand: new string[]{"2H", "3D", "4C", "5S", "6H"}));
        }

        public void TestIsItAStraightFail()
        {
            Assert.IsFalse(ProjectEuler.Problems51_60.PokerHands.IsItAStraight(hand: new string[] { "2H", "3D", "4C", "5S", "9H" }));
        }

        [TestMethod]
        public void TestIsItThreeOfAKind()
        {
            Assert.IsTrue(
                ProjectEuler.Problems51_60.PokerHands.IsItThreeOfAKind(hand: new string[]
                    { "2H", "2D", "2C", "5S", "9H" }));
        }

        [TestMethod]
        public void TestIsItThreeOfAKindFail()
        {
            Assert.IsFalse(ProjectEuler.Problems51_60.PokerHands.IsItAStraight(hand: new string[] { "2H", "2D", "4C", "5S", "9H" }));
        }

        [TestMethod]
        public void TestIsItTwoPairs()
        {
            Assert.IsTrue(
                ProjectEuler.Problems51_60.PokerHands.IsItTwoPairs(hand: new string[]
                    { "2H", "2D", "3C", "3S", "9H" }));
        }

        [TestMethod]
        public void TestIsItTwoPairsFail()
        {
            Assert.IsFalse(
                ProjectEuler.Problems51_60.PokerHands.IsItTwoPairs(hand: new string[]
                    { "2H", "2D", "3C", "4S", "9H" }));
        }

        [TestMethod]
        public void TestIsItOnePair()
        {
            Assert.IsTrue(
                ProjectEuler.Problems51_60.PokerHands.IsItOnePair(hand: new string[]
                    { "2H", "2D", "3C", "4S", "9H" }));
        }

        [TestMethod]
        public void TestIsItOnePairFail()
        {
            Assert.IsFalse(
                ProjectEuler.Problems51_60.PokerHands.IsItOnePair(hand: new string[]
                    { "2H", "KD", "3C", "4S", "9H" }));
        }
    }
}
