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
            Assert.AreEqual(376, ProjectEuler.Problems51_60.PokerHands.FindPokerHands());
        }

        [TestMethod]
        public void TestStraightFlushFails()
        {
            string highestRelevantCard = String.Empty;
            Assert.IsFalse(ProjectEuler.Problems51_60.PokerHands.IsItAStraightFlush(
                new string[] { "5H", "6H", "7H", "8H", "9D" }, highestRelevantCard: ref highestRelevantCard));
            Assert.IsFalse(ProjectEuler.Problems51_60.PokerHands.IsItAStraightFlush(
                new string[] { "5H", "6H", "7H", "8H", "TH" }, highestRelevantCard: ref highestRelevantCard));
        }

        [TestMethod]
        public void TestStraightFlush()
        {
            string highestRelevantCard = String.Empty;
            Assert.IsTrue(ProjectEuler.Problems51_60.PokerHands.IsItAStraightFlush(
                new string[] { "5H", "6H", "7H", "8H", "9H" }, highestRelevantCard: ref highestRelevantCard));
            Assert.IsTrue(ProjectEuler.Problems51_60.PokerHands.IsItAStraightFlush(
                new string[] { "QH", "KH", "AH", "2H", "3H" }, highestRelevantCard: ref highestRelevantCard));
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
            string highestRelevantCard = String.Empty;
            Assert.IsTrue(
                ProjectEuler.Problems51_60.PokerHands.IsItFourOfAKind(hand: new string[]
                    { "JH", "JD", "JC", "JS", "AH" }, highestRelevantCard: ref highestRelevantCard));
        }

        [TestMethod]
        public void TestIsItFourOfAKindFail()
        {
            string highestRelevantCard = String.Empty;
            Assert.IsFalse(
                ProjectEuler.Problems51_60.PokerHands.IsItFourOfAKind(hand: new string[]
                    { "JH", "JD", "JC", "AH", "AS" }, highestRelevantCard: ref highestRelevantCard));
        }

        [TestMethod]
        public void TestIsItAFullHouse()
        {
            string highestRelevantCard = String.Empty;
            Assert.IsTrue(
                ProjectEuler.Problems51_60.PokerHands.IsItAFullHouse(
                    hand: new string[] { "KH", "KC", "KD", "QH", "QC" }, highestRelevantCard: ref highestRelevantCard));
        }

        [TestMethod]
        public void TestIsItAFullHouseFail()
        {
            string highestRelevantCard = String.Empty;
            Assert.IsFalse(
                ProjectEuler.Problems51_60.PokerHands.IsItAFullHouse(
                    hand: new string[] { "KH", "KC", "KD", "QH", "AC" }, highestRelevantCard: ref highestRelevantCard));
        }

        [TestMethod]
        public void TestIsItAFlush()
        {
            string highestRelevantCard = String.Empty;
            Assert.IsTrue(
                ProjectEuler.Problems51_60.PokerHands.IsItAFlush(hand: new string[] { "KH", "5H", "3H", "9H", "QH" },
                    highestRelevantCard: ref highestRelevantCard));
        }

        [TestMethod]
        public void TestIsItAFlushFail()
        {
            string highestRelevantCard = String.Empty;
            Assert.IsFalse(
                ProjectEuler.Problems51_60.PokerHands.IsItAFlush(hand: new string[] { "KH", "5H", "3H", "9H", "QD" },
                    highestRelevantCard: ref highestRelevantCard));
        }

        [TestMethod]
        public void TestIsItAStraight()
        {
            string highestRelevantCard = String.Empty;
            Assert.IsTrue(ProjectEuler.Problems51_60.PokerHands.IsItAStraight(
                hand: new string[] { "2H", "3D", "4C", "5S", "6H" }, highestRelevantCard: ref highestRelevantCard));
        }

        public void TestIsItAStraightFail()
        {
            string highestRelevantCard = String.Empty;
            Assert.IsFalse(ProjectEuler.Problems51_60.PokerHands.IsItAStraight(
                hand: new string[] { "2H", "3D", "4C", "5S", "9H" }, highestRelevantCard: ref highestRelevantCard));
        }

        [TestMethod]
        public void TestIsItThreeOfAKind()
        {
            string highestRelevantCard = String.Empty;
            Assert.IsTrue(
                ProjectEuler.Problems51_60.PokerHands.IsItThreeOfAKind(hand: new string[]
                    { "2H", "2D", "2C", "5S", "9H" }, highestRelevantCard: ref highestRelevantCard));
        }

        [TestMethod]
        public void TestIsItThreeOfAKindFail()
        {
            string highestRelevantCard = String.Empty;
            Assert.IsFalse(ProjectEuler.Problems51_60.PokerHands.IsItAStraight(
                hand: new string[] { "2H", "2D", "4C", "5S", "9H" }, highestRelevantCard: ref highestRelevantCard));
        }

        [TestMethod]
        public void TestIsItTwoPairs()
        {
            string highestRelevantCard = String.Empty;
            Assert.IsTrue(
                ProjectEuler.Problems51_60.PokerHands.IsItTwoPairs(hand: new string[]
                    { "2H", "2D", "3C", "3S", "9H" }, highestRelevantCard: ref highestRelevantCard));
        }

        [TestMethod]
        public void TestIsItTwoPairsFail()
        {
            string highestRelevantCard = String.Empty;
            Assert.IsFalse(
                ProjectEuler.Problems51_60.PokerHands.IsItTwoPairs(hand: new string[]
                    { "2H", "2D", "3C", "4S", "9H" }, highestRelevantCard: ref highestRelevantCard));
        }

        [TestMethod]
        public void TestIsItOnePair()
        {
            string highestRelevantCard = String.Empty;
            Assert.IsTrue(
                ProjectEuler.Problems51_60.PokerHands.IsItOnePair(hand: new string[]
                    { "2H", "2D", "3C", "4S", "9H" }, highestRelevantCard: ref highestRelevantCard));
        }

        [TestMethod]
        public void TestIsItOnePairFail()
        {
            string highestRelevantCard = String.Empty;
            Assert.IsFalse(
                ProjectEuler.Problems51_60.PokerHands.IsItOnePair(hand: new string[]
                    { "2H", "KD", "3C", "4S", "9H" }, highestRelevantCard: ref highestRelevantCard));
        }
    }
}
