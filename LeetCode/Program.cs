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
            Console.WriteLine("Add Two Numbers.");
            Console.WriteLine($"Inputs: [{l1}], [{l2}]");
            sw.Start();
            Console.WriteLine($"Output: [{AddTwoNumbers.LinkedList(l1, l2)}]");
            sw.Stop();
            Console.WriteLine($"Runtime: {sw.ElapsedMilliseconds} ms.");
            Console.WriteLine(Environment.NewLine);

            // Find median sorted arrays.
            int[] nums1 = new int[2] { 1, 2 };
            int[] nums2 = new int[2] { 3, 4 };
            Console.WriteLine("Find median sorted arrays.");
            Console.WriteLine($"Input: [{string.Join(",", nums1)}], [{string.Join(",", nums1)}]");
            sw.Start();
            Console.WriteLine($"Output: {FindMedian.SortedArrays(nums1, nums2)}");
            sw.Stop();
            Console.WriteLine($"Runtime: {sw.ElapsedMilliseconds} ms.");
            Console.WriteLine(Environment.NewLine);

            // Find the longested Palindrome.
            // From front.
            string s1 = "aaaaszdsdkskkksdkfkfosoeeeksdfkefesfaaaaaaaaaaa";
            Console.WriteLine("Find the longested Palindrome from front.");
            Console.WriteLine($"Input: {s1}");
            sw.Start();
            Console.WriteLine($"Output: {LongestPalindrome.FromFront(s1)}");
            sw.Stop();
            Console.WriteLine($"Runtime: {sw.ElapsedMilliseconds} ms.");
            Console.WriteLine(Environment.NewLine);

            // From back.
            Console.WriteLine("Find the longested Palindrome from back.");
            Console.WriteLine($"Input: {s1}");
            sw.Start();
            Console.WriteLine($"Output: {LongestPalindrome.FromFront(s1)}");
            sw.Stop();
            Console.WriteLine($"Runtime: {sw.ElapsedMilliseconds} ms.");
            Console.WriteLine(Environment.NewLine);

            // Find the longest substring without repeating character.
            string s2 = "aaaaszdsdkskkk";
            Console.WriteLine("Find the longest substring without repeating character.");
            Console.WriteLine($"Input: {s2}");
            sw.Start();
            Console.WriteLine($"Output: {LengthOfLongestSubstring.WithoutRepeatingCharacters(s2)}");
            sw.Stop();
            Console.WriteLine($"Runtime: {sw.ElapsedMilliseconds} ms.");
            Console.WriteLine(Environment.NewLine);
        }
    }
}
