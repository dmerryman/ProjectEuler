using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEulerTests.Problems21_30
{
    [TestClass]
    public class FindReciprocalCyclesTests
    {
        [TestMethod]
        public void FindReciprocalCyclesTestSmall()
        {
            Assert.AreEqual(7, ProjectEuler.Problems21_30.ReciprocalCycles.FindReciprocalCycle(d: 10));
        }

        [TestMethod]
        public void FindReciprocalCyclesTestLarge()
        {
            Assert.AreEqual(983, ProjectEuler.Problems21_30.ReciprocalCycles.FindReciprocalCycle(d: 1000));
        }
    }
}
