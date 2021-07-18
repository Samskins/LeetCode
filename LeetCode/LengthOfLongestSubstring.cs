using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class LengthOfLongestSubstring
    {
        public static int WithoutRepeatingCharacters(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            else if (s.Length == 1)
            {
                return 1;
            }

            int longestLength = 0;
            List<char> charList = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                charList.Add(s[i]);
                if (longestLength < charList.Count)
                {
                    longestLength = charList.Count;
                }

                if (i + 1 < s.Length)
                {
                    if (charList.Contains(s[i + 1]))
                    {
                        int firstIndex = charList.IndexOf(s[i + 1]);
                        int count = charList.Count - (firstIndex + 1);
                        char[] tempList = new char[count];
                        charList.CopyTo(firstIndex + 1, tempList, 0, count);
                        charList.Clear();
                        charList.AddRange(tempList);
                    }
                }
            }

            return longestLength;
        }
    }
}
