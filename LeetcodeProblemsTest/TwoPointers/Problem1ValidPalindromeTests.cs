using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProblems.TwoPointers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.TwoPointers.Tests
{
    [TestClass()]
    public class Problem1ValidPalindromeTests
    {
        [TestMethod()]
        public void IsPalindrome_Example1_Return_True()
        {
            Problem1ValidPalindrome solution = new Problem1ValidPalindrome();
            string inputString = "A man, a plan, a canal: Panama";

            Assert.AreEqual(true, solution.IsPalindrome(inputString));
        }

        [TestMethod()]
        public void IsPalindrome_Example2_Return_False()
        {
            Problem1ValidPalindrome solution = new Problem1ValidPalindrome();
            
            string inputString = "race a car";

            Assert.AreEqual(false, solution.IsPalindrome(inputString));
        }

        [TestMethod()]
        public void IsPalindrome_Example3_Return_True()
        {
            Problem1ValidPalindrome solution = new Problem1ValidPalindrome();

            string inputString = " ";

            Assert.AreEqual(true, solution.IsPalindrome(inputString));
        }
    }
}