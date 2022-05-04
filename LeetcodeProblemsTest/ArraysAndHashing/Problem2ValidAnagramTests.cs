using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeProblems.ArraysAndHashing.Tests
{
    [TestClass()]
    public class Problem2ValidAnagramTests
    {
        [TestMethod()]
        public void IsAnagram_Example1_SameWord_Return_True()
        {
            Problem2ValidAnagram solution = new Problem2ValidAnagram();
            string source = "anagram";
            string target = "nagaram";
            Assert.AreEqual(true, solution.IsAnagram(source, target));
        }

        [TestMethod()]
        public void IsAnagram_Example2_DifferentWord_Return_False()
        {
            Problem2ValidAnagram solution = new Problem2ValidAnagram();
            string source = "rat";
            string target = "car";
            Assert.AreEqual(false, solution.IsAnagram(source, target));
        }
    }
}