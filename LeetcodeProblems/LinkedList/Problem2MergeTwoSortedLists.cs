using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.LinkedList
{
    public class Problem2MergeTwoSortedLists
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

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode comparelist1 = list1;
            ListNode comparelist2 = list2;
            ListNode finalResult = new ListNode();
            ListNode temp = finalResult;

            //get the start of the node
            //finalResult = this.IsFirstNodeAhead(comparelist1, comparelist2) ? comparelist1 : comparelist2;
            //temp = finalResult;

            while (comparelist1 != null && comparelist2 != null)
            {
                //compare each node, change the link
                if (this.IsFirstNodeAhead(comparelist1, comparelist2))
                {
                    temp.next = comparelist1;
                    comparelist1 = comparelist1.next;
                }
                else
                {
                    temp.next = comparelist2;
                    comparelist2 = comparelist2.next;
                }

                temp = temp.next;
            }

            temp.next = GetUnFinishListNodeToFinalNext(comparelist1,comparelist2);

            return finalResult.next;
        }

        private bool IsFirstNodeAhead(ListNode firstNode, ListNode secondNode)
        {
            return firstNode.val < secondNode.val;
        }

        private ListNode GetUnFinishListNodeToFinalNext(ListNode firstNode, ListNode secondNode)
        {
            return firstNode == null ? secondNode : firstNode;
        }
    }
}
