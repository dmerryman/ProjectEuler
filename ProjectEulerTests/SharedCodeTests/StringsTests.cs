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
    }
}
