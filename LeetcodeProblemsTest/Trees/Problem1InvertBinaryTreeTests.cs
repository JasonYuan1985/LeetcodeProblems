using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProblems.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetcodeProblems.Trees.Problem1InvertBinaryTree;

namespace LeetcodeProblems.Trees.Tests
{
    [TestClass()]
    public class Problem1InvertBinaryTreeTests
    {
        [TestMethod()]
        public void InvertTree_Example1_3Layers()
        {
            TreeNode tree = new TreeNode(4,
                new TreeNode(2,
                    new TreeNode(1), new TreeNode(3)),
                new TreeNode(7,
                    new TreeNode(6), new TreeNode(9))
                );
            Problem1InvertBinaryTree solution = new Problem1InvertBinaryTree();
            var result = solution.InvertTree(tree);
            Assert.AreEqual(7, result.left.val);
            Assert.AreEqual(9, result.left.left.val);
            Assert.AreEqual(6, result.left.right.val);
            Assert.AreEqual(2, result.right.val);
            Assert.AreEqual(3, result.right.left.val);
            Assert.AreEqual(1, result.right.right.val);
        }
    }
}