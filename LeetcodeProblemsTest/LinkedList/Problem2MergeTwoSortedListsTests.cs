using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProblems.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetcodeProblems.LinkedList.Problem2MergeTwoSortedLists;

namespace LeetcodeProblems.LinkedList.Tests
{
    [TestClass()]
    public class Problem2MergeTwoSortedListsTests
    {
        [TestMethod()]
        public void MergeTwoListsTest()
        {
            Problem2MergeTwoSortedLists solution = new Problem2MergeTwoSortedLists();
            var list1 = new ListNode(1,new ListNode(2,new ListNode(4,null)));
            var list2 = new ListNode(1, new ListNode(3, new ListNode(4, null)));
            var resultList = solution.MergeTwoLists(list1, list2);
            Assert.AreEqual(1, resultList.val);
            Assert.AreEqual(1, resultList.next.val);
            Assert.AreEqual(2, resultList.next.next.val);
            Assert.AreEqual(3, resultList.next.next.next.val);
            Assert.AreEqual(4, resultList.next.next.next.next.val);
            Assert.AreEqual(4, resultList.next.next.next.next.next.val);
        }
    }
}