using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests
{
    [TestClass]
    public class NumberLetterCountsTest
    {
        [TestMethod]
        public void TestSmall()
        {
            Assert.AreEqual(19, ProjectEuler.NumberLetterCounts.FindNumberLetterCounts(ceiling: 5));
        }

        [TestMethod]
        public void TestLarge()
        {
            Assert.AreEqual(21124, ProjectEuler.NumberLetterCounts.FindNumberLetterCounts(ceiling: 1000));
        }

        [TestMethod]
        public void TestSpecificNumbers()
        {
            Assert.AreEqual(11, ProjectEuler.NumberLetterCounts.GetNumberOfLettersInValue(value: 1000));
            Assert.AreEqual(11, ProjectEuler.NumberLetterCounts.GetNumberOfLettersInValue(value: 500));
            Assert.AreEqual(19, ProjectEuler.NumberLetterCounts.GetNumberOfLettersInValue(value: 540));
            Assert.AreEqual(22, ProjectEuler.NumberLetterCounts.GetNumberOfLettersInValue(value: 542));
            Assert.AreEqual(22, ProjectEuler.NumberLetterCounts.GetNumberOfLettersInValue(value: 513));
            Assert.AreEqual(17, ProjectEuler.NumberLetterCounts.GetNumberOfLettersInValue(value: 502));
            Assert.AreEqual(16, ProjectEuler.NumberLetterCounts.GetNumberOfLettersInValue(value: 101));
            Assert.AreEqual(5, ProjectEuler.NumberLetterCounts.GetNumberOfLettersInValue(value: 40));
            Assert.AreEqual(9, ProjectEuler.NumberLetterCounts.GetNumberOfLettersInValue(value: 45));
            Assert.AreEqual(8, ProjectEuler.NumberLetterCounts.GetNumberOfLettersInValue(value: 13));
            Assert.AreEqual(3, ProjectEuler.NumberLetterCounts.GetNumberOfLettersInValue(value: 10));
            Assert.AreEqual(5, ProjectEuler.NumberLetterCounts.GetNumberOfLettersInValue(value: 7));
            Assert.AreEqual(16, ProjectEuler.NumberLetterCounts.GetNumberOfLettersInValue(value: 110));
        }
    }
}
