using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ProjectEulerTests.SharedCodeTests
{
    [TestClass]
    public class StringsTests
    {
        [TestMethod]
        public void TestGetPermutations()
        {
            List<string> permutations = ProjectEuler.SharedCode.Strings.GetPermutations("cat");

            Assert.AreEqual(6, permutations.Count);
            Assert.IsTrue(permutations.Contains("act"));
        }

        [TestMethod]
        public void TestIsItAPalindrome()
        {
            Assert.IsTrue(ProjectEuler.SharedCode.Strings.IsItAPalindrome("ABBA"));
            Assert.IsTrue(ProjectEuler.SharedCode.Strings.IsItAPalindrome("RacECAR"));
            Assert.IsFalse(ProjectEuler.SharedCode.Strings.IsItAPalindrome("NotAPalindrome"));
        }
    }
}
