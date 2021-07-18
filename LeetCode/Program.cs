using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Add Two Numbers.
            //ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            //ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9)));
            //AddTwoNumbers(l1, l2);

            // Find median sorted arrays.
            //int[] nums1 = new int[2] { 1, 2 };
            //int[] nums2 = new int[2] { 3, 4 };
            //FindMedianSortedArrays(nums1, nums2);

            // Find the longested Palindrome.
            string s = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Palindrome.LongestPalindromeFromFront(s);
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
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

                if (l1 != null)
                {
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    l2 = l2.next;
                }

                // l1 = l1?.next ?? null;
                // l2 = l2?.next ?? null;

                // If we are at the last entry and there is an additional carry, add it as the final node.
                // if (l1 == null && l2 == null && carry != 0)
                // {
                //     current.next = new ListNode(carry);
                // }
            }

            if (carry > 0)
            {
                current.next = new ListNode(carry);
            }

            return dummyHead.next;
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] result = new int[nums1.Length + nums2.Length];
            if (nums1.Length == 0)
            {
                nums2.CopyTo(result, 0);
            }
            else if (nums2.Length == 0)
            {
                nums1.CopyTo(result, 0);
            }
            else
            {
                nums1.CopyTo(result, 0);
                nums2.CopyTo(result, nums1.Length);
            }

            Array.Sort(result);

            int index = result.Length / 2;
            if (result.Length % 2 == 0) // Even
            {
                return (result[index] + result[index - 1]) / 2.0;
            }
            else // Odd
            {
                return result[index];
            }
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
    }
}
