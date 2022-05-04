using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetcodeProblems.TwoPointers.Tests
{
    [TestClass()]
    public class Problem2TwoSumIIInputArrayIsSortedTests
    {
        [TestMethod()]
        public void TwoSum_Example1_Return_1_2()
        {
            Problem2TwoSumIIInputArrayIsSorted solution = new Problem2TwoSumIIInputArrayIsSorted();

            List<int> inputString = new List<int>() { 2, 7, 11, 15 };
            int target = 9;

            var result = solution.TwoSum(inputString.ToArray(), target);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
        }

        [TestMethod()]
        public void TwoSum_Example2_Return_1_3()
        {
            Problem2TwoSumIIInputArrayIsSorted solution = new Problem2TwoSumIIInputArrayIsSorted();

            List<int> inputString = new List<int>() { 2, 3, 4 };
            int target = 6;

            var result = solution.TwoSum(inputString.ToArray(), target);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(3, result[1]);
        }

        [TestMethod()]
        public void TwoSum_Example3_Return_Negative1_0()
        {
            Problem2TwoSumIIInputArrayIsSorted solution = new Problem2TwoSumIIInputArrayIsSorted();

            List<int> inputString = new List<int>() { -1, 0 };
            int target = -1;

            var result = solution.TwoSum(inputString.ToArray(), target);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
        }
    }
}