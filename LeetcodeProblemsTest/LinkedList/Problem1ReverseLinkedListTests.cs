using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetcodeProblems.LinkedList.Problem1ReverseLinkedList;

namespace LeetcodeProblems.LinkedList.Tests
{
    [TestClass()]
    public class Problem1ReverseLinkedListTests
    {
        [TestMethod()]
        public void ReverseListTest()
        {
            Problem1ReverseLinkedList solution = new Problem1ReverseLinkedList();
            var head = new ListNode(1, new ListNode(2, null));
            var result = solution.ReverseList(head);
            Assert.AreEqual(2, result.val);
            Assert.AreEqual(1, result.next.val);
        }

        [TestMethod()]
        public void ReverseList_1_2_3_4_5()
        {
            Problem1ReverseLinkedList solution = new Problem1ReverseLinkedList();
            var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
            var result = solution.ReverseList(head);
            Assert.AreEqual(5, result.val);
            Assert.AreEqual(4, result.next.val);
            Assert.AreEqual(3, result.next.next.val);
            Assert.AreEqual(2, result.next.next.next.val);
            Assert.AreEqual(1, result.next.next.next.next.val);
        }
    }
}