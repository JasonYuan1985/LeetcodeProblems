using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetcodeProblems.ArraysAndHashing.Tests
{
    [TestClass()]
    public class Problem4GroupAnagramsTests
    {
        [TestMethod()]
        public void GroupAnagrams_Example1()
        {
            Problem4GroupAnagrams solution = new Problem4GroupAnagrams();
            List<string> list = new List<string>() { "eat", "tea", "tan", "ate", "nat", "bat" };

            var result = solution.GroupAnagrams(list.ToArray());

            Assert.AreEqual(3, result.Count);
        }

        [TestMethod()]
        public void GroupAnagrams_Example2_NoString_Return_1()
        {
            Problem4GroupAnagrams solution = new Problem4GroupAnagrams();
            List<string> list = new List<string>() { "" };

            var result = solution.GroupAnagrams(list.ToArray());

            Assert.AreEqual(1, result.Count);
        }

        [TestMethod()]
        public void GroupAnagrams_Example2_OneString_Return_1()
        {
            Problem4GroupAnagrams solution = new Problem4GroupAnagrams();
            List<string> list = new List<string>() { "a" };

            var result = solution.GroupAnagrams(list.ToArray());

            Assert.AreEqual(1, result.Count);
        }
    }
}