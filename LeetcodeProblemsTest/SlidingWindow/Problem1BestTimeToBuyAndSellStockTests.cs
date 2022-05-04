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
    public class Problem1BestTimeToBuyAndSellStockTests
    {
        [TestMethod()]
        public void MaxProfit_Example1_Return_5()
        {
            Problem1BestTimeToBuyAndSellStock solution = new Problem1BestTimeToBuyAndSellStock();

            List<int> inputString = new List<int>() { 7, 1, 5, 3, 6, 4 };
            Assert.AreEqual(5, solution.MaxProfit(inputString.ToArray()));
        }

        [TestMethod()]
        public void MaxProfit_Example2_Return_0()
        {
            Problem1BestTimeToBuyAndSellStock solution = new Problem1BestTimeToBuyAndSellStock();

            List<int> inputString = new List<int>() { 7, 6, 4, 3, 1 };
            Assert.AreEqual(0, solution.MaxProfit(inputString.ToArray()));
        }
    }
}