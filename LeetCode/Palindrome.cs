using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Palindrome
    {
        public static string LongestPalindromeFromBack(string s)
        {
            // Edge case: empty string.
            if (s.Length == 0)
            {
                return s;
            }

            // HashSet of possible paildromes.
            HashSet<string> possiblities = new HashSet<string>();
            int index = 0;

            // Start temp off with the first char and start the for loop at i = 1;
            string temp = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                temp = s.Substring(index, s.Length - i);

                // Found palidrome, add to dictionary and clear the temp string.
                if (temp.Length != 0 && temp[0] == temp[temp.Length - 1])
                {
                    bool isPalindrome = true;

                    if (!(possiblities.Count != 0 && temp.Length < possiblities.Select(x => x.Length).Max()))
                    {
                        // Is this actually a palindrome?  Stop at the ceiling of the median - 1 to end at the middle (for odd lengths) or first median (for even lengths). 
                        // j = 1 to skip the first element that we know will match.
                        for (int j = 1; j < Math.Ceiling(temp.Length / 2.0); j++)
                        {
                            if (temp[j] != temp[temp.Length - 1 - j])
                            {
                                isPalindrome = false;
                                break;
                            }
                        }

                        if (isPalindrome)
                        {
                            possiblities.Add(temp);
                        }
                    }
                }

                // Reset if we have gone through the entire string.
                if (i == s.Length - 1)
                {
                    i = index++;
                }
            }

            string result = possiblities.Where(x => x.Length == possiblities.Select(y => y.Length).Max()).First().ToString();
            return result;
        }

        public static string LongestPalindromeFromFront(string s)
        {
            // Edge case: empty string.
            if (s.Length == 0)
            {
                return s;
            }

            // HashSet of possible paildromes.
            HashSet<string> possiblities = new HashSet<string>();
            int index = 0;

            // Start temp off with the first char and start the for loop at i = 1;
            string temp = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                temp += s[i];

                // Found palidrome, add to dictionary and clear the temp string.
                if (temp[0] == s[i])
                {
                    bool isPalindrome = true;

                    // Is this actually a palindrome?  Stop at the ceiling of the median - 1 to end at the middle (for odd lengths) or first median (for even lengths). 
                    // j = 1 to skip the first element that we know will match.
                    for (int j = 1; j < Math.Ceiling(temp.Length / 2.0); j++)
                    {
                        if (temp[j] != temp[temp.Length - 1 - j])
                        {
                            isPalindrome = false;
                            break;
                        }
                    }

                    if (isPalindrome)
                    {
                        possiblities.Add(temp);
                    }
                }

                // Reset if we have gone through the entire
                if (i == s.Length - 1)
                {
                    i = index++;
                    temp = string.Empty;
                }
            }

            string result = possiblities.Where(x => x.Length == possiblities.Select(y => y.Length).Max()).First().ToString();
            return result;
        }
    }
}