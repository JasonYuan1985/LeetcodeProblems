using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProblems.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetcodeProblems.Trees.Problem2MaximunDepthOfBinaryTree;

namespace LeetcodeProblems.Trees.Tests
{
    [TestClass()]
    public class Problem2MaximunDepthOfBinaryTreeTests
    {
        [TestMethod()]
        public void MaxDepth_Example1_3_9_20_null_null_15_7_Return_3()
        {
            //[3,9,20,null,null,15,7]
            Problem2MaximunDepthOfBinaryTree solution = new Problem2MaximunDepthOfBinaryTree();
            var root = new TreeNode(3,
                new TreeNode(9),
                new TreeNode(20,
                    new TreeNode(15), new TreeNode(7)));

            Assert.AreEqual(3, solution.MaxDepth(root));
        }

        [TestMethod()]
        public void MaxDepth_Example2_1_null_2_Return_2()
        {
            //[1,null,2]
            Problem2MaximunDepthOfBinaryTree solution = new Problem2MaximunDepthOfBinaryTree();
            var root = new TreeNode(1,
                null,
                new TreeNode(2));

            Assert.AreEqual(2, solution.MaxDepth(root));
        }
    }
}