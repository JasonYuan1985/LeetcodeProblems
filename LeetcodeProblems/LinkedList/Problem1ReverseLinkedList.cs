namespace LeetcodeProblems.LinkedList
{
    public class Problem1ReverseLinkedList
    {
        /**
         * Definition for singly-linked list.
         * public class ListNode {
         *     public int val;
         *     public ListNode next;
         *     public ListNode(int val=0, ListNode next=null) {
         *         this.val = val;
         *         this.next = next;
         *     }
         * }
         */

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode ReverseList(ListNode head)
        {
            ListNode reverseListHead = null;
            if (head != null)
            {
                ListNode oldNode = head;
                reverseListHead = new ListNode(oldNode.val);

                while (oldNode != null && oldNode.next != null)
                {
                    ListNode nextNode = reverseListHead;
                    reverseListHead = new ListNode(oldNode.next.val, nextNode);
                    oldNode = oldNode.next;
                }
            }

            return reverseListHead;
        }
    }
}
