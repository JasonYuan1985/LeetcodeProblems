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
    }
}