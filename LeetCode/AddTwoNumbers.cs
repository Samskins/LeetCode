using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class AddTwoNumbers
    {
        public static ListNode LinkedList(ListNode l1, ListNode l2)
        {
            // Carry value for when the numbers you add exceed a sum of 9.
            int carry = 0;

            // Set a dummyHead to hold all values of the linked list until we are ready to return them.
            ListNode dummyHead = new ListNode(0);

            // Make a current linked list to do all the calculations.
            // By making the current = dummyHead, we can create a reference to any actions taken by the current with the dummyHead.
            ListNode current = dummyHead;

            // Check if either has reached the end of their list.  If both have reached the end, then we are done adding.
            while (l1 != null || l2 != null)
            {
                // Use the values of the linkedList if they are not null, otherwise use 0.
                int nodeVal1 = l1?.val ?? 0;
                int nodeVal2 = l2?.val ?? 0;

                // Get the sum of both numbers and any carry from a sum being larger than 9;
                int sum = nodeVal1 + nodeVal2 + carry;

                // Calculate carry.
                carry = sum / 10;

                // Add the sum to the next node.  Using modulus incase the sum is greater than 10, we want just the remainder since the carry
                // will be carried over in the list loop.
                current.next = new ListNode(sum % 10);

                // Current next can now be assigned to the current for calculations in the next loop.  Remember these linkedList are being overriden
                // in the current linkedList, but the reference to the dummyHead is what hold all the values we are going to return.
                current = current.next;

                // Set the next nodes to current for the inputs.  We could save these in another variable, but there is nothing to gain.
                l1 = l1?.next ?? null;
                l2 = l2?.next ?? null;
            }

            // If we are at the last entry and there is an additional carry, add it as the final node.
            if (carry > 0)
            {
                current.next = new ListNode(carry);
            }

            return dummyHead.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public override string ToString()
        {
            string s = $"{val}";
            ListNode temp = (ListNode)next.MemberwiseClone();
            while (temp != null)
            {
                s += $", {temp.val}";
                temp = temp.next;
            }

            return s;
        }
    }
}
