using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetcodeProblems.ArraysAndHashing.Tests
{
    [TestClass()]
    public class Problem1ContainsDuplicateTests
    {
        [TestMethod()]
        public void ContainsDuplicate_Example1_Return_True()
        {
            Problem1ContainsDuplicate solution = new Problem1ContainsDuplicate();

            List<int> inputs = new List<int> { 1, 2, 3, 1 };
            Assert.AreEqual(true, solution.ContainsDuplicate(inputs.ToArray()));
        }

        [TestMethod()]
        public void ContainsDuplicate_Example2_Return_False()
        {
            Problem1ContainsDuplicate solution = new Problem1ContainsDuplicate();

            List<int> inputs = new List<int> { 1, 2, 3, 4 };
            Assert.AreEqual(false, solution.ContainsDuplicate(inputs.ToArray()));
        }

        [TestMethod()]
        public void ContainsDuplicate_Example3_Return_True()
        {
            Problem1ContainsDuplicate solution = new Problem1ContainsDuplicate();

            List<int> inputs = new List<int> { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            Assert.AreEqual(true, solution.ContainsDuplicate(inputs.ToArray()));
        }
    }
}