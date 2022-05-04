using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProblems.SlidingWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.SlidingWindow.Tests
{
    [TestClass()]
    public class Problem2LongestSubstringWithoutRepeatingCharactersTests
    {
        [TestMethod()]
        public void LengthOfLongestSubstring_Example1_Return_3()
        {
            Problem2LongestSubstringWithoutRepeatingCharacters solution = new Problem2LongestSubstringWithoutRepeatingCharacters();

            string inputString = "abcabcbb";
            Assert.AreEqual(3, solution.LengthOfLongestSubstring(inputString));
        }

        [TestMethod()]
        public void LengthOfLongestSubstring_Example2_Return_1()
        {
            Problem2LongestSubstringWithoutRepeatingCharacters solution = new Problem2LongestSubstringWithoutRepeatingCharacters();

            string inputString = "bbbbb";
            Assert.AreEqual(1, solution.LengthOfLongestSubstring(inputString));
        }

        [TestMethod()]
        public void LengthOfLongestSubstring_Example3_Return_3()
        {
            Problem2LongestSubstringWithoutRepeatingCharacters solution = new Problem2LongestSubstringWithoutRepeatingCharacters();

            string inputString = "pwwkew";
            Assert.AreEqual(3, solution.LengthOfLongestSubstring(inputString));
        }

        [TestMethod()]
        public void LengthOfLongestSubstring_Example4_OneCharacter_Return_1()
        {
            Problem2LongestSubstringWithoutRepeatingCharacters solution = new Problem2LongestSubstringWithoutRepeatingCharacters();

            string inputString = " ";
            Assert.AreEqual(1, solution.LengthOfLongestSubstring(inputString));
        }

        [TestMethod()]
        public void LengthOfLongestSubstring_Example5_Return_3()
        {
            Problem2LongestSubstringWithoutRepeatingCharacters solution = new Problem2LongestSubstringWithoutRepeatingCharacters();

            string inputString = "dvdf";
            Assert.AreEqual(3, solution.LengthOfLongestSubstring(inputString));
        }
    }
}