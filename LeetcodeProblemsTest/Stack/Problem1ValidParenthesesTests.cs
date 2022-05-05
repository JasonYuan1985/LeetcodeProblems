using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProblems.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Stack.Tests
{
    [TestClass()]
    public class Problem1ValidParenthesesTests
    {
        [TestMethod()]
        public void IsValid_Example4_With_1_Full_RoundBrackets_Return_True()
        {
            Problem1ValidParentheses solution = new Problem1ValidParentheses();

            string inputString = "()";
            Assert.AreEqual(true, solution.IsValid(inputString));
        }

        [TestMethod()]
        public void IsValid_Example5_With_Mix_Full_Brackets_Return_False()
        {
            Problem1ValidParentheses solution = new Problem1ValidParentheses();

            string inputString = "([)]";
            Assert.AreEqual(false, solution.IsValid(inputString));
        }

        [TestMethod()]
        public void IsValid_Example6_With_One_Close_Brackets_Return_False()
        {
            Problem1ValidParentheses solution = new Problem1ValidParentheses();

            string inputString = "]";
            Assert.AreEqual(false, solution.IsValid(inputString));
        }
    }
}