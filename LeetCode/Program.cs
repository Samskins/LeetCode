using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            // Add Two Numbers.
            ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9)));
            PrintFunc2Inputs("Add Two Numbers.", l1, l2, AddTwoNumbers.LinkedList);

            // Find median sorted arrays.
            int[] nums1 = new int[2] { 1, 2 };
            int[] nums2 = new int[2] { 3, 4 };
            PrintFunc2Inputs("Find median sorted arrays.", nums1, nums2, FindMedian.SortedArrays);

            // Find the longested Palindrome.
            // From front.
            PrintFunc1Input("Find the longested Palindrome from front.",
                            "aaaaszdsdkskkksdkfkfosoeeeksdfkefesfaaaaaaaaaaa",
                            LongestPalindrome.FromFront);

            // From back.
            PrintFunc1Input("Find the longested Palindrome from back.",
                            "aaaaszdsdkskkksdkfkfosoeeeksdfkefesfaaaaaaaaaaa",
                            LongestPalindrome.FromBack);

            // From middle.


            // Find the longest substring without repeating character.
            PrintFunc1Input("Find the longest substring without repeating character.",
                            "aaaaszdsdkskkk",
                            LengthOfLongestSubstring.WithoutRepeatingCharacters);
        }

        public static void PrintFunc1Input<T1, T2>(string description, T1 input, Func<T1, T2> method)
        {
            Stopwatch sw = new Stopwatch();

            Console.WriteLine(description);
            string printable = string.Empty;

            if (input is Array array)
            {
                printable = string.Join(",", array);
            }
            else if (input is string)
            {
                printable = input.ToString();
            }

            Console.WriteLine($"Input: {printable}");
            sw.Start();
            Console.WriteLine($"Output: {method(input)}");
            sw.Stop();
            Console.WriteLine($"Runtime: {sw.ElapsedMilliseconds} ms.");
            Console.WriteLine(Environment.NewLine);
        }

        public static void PrintFunc2Inputs<T1, T2, T3>(string description, T1 input1, T2 input2, Func<T1, T2, T3> method)
        {
            Stopwatch sw = new Stopwatch();

            Console.WriteLine(description);
            string printable1 = string.Empty;
            string printable2 = string.Empty;

            if (input1 is int[] array1 && input2 is int[] array2)
            {
                printable1 = string.Join(",", array1);
                printable2 = string.Join(",", array2);
            }
            else
            {
                printable1 = input1.ToString();
                printable2 = input2.ToString();
            }

            Console.WriteLine($"Inputs: [{printable1}], [{printable2}]");
            sw.Start();
            Console.WriteLine($"Output: [{method(input1, input2)}]");
            sw.Stop();
            Console.WriteLine($"Runtime: {sw.ElapsedMilliseconds} ms.");
            Console.WriteLine(Environment.NewLine);
        }
    }
}
