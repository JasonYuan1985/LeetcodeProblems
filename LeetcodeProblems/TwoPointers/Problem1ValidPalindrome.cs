using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.TwoPointers
{
    public class Problem1ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            int startIndex = 0;
            int endIndex = s.Length - 1;
            while (startIndex < endIndex)
            {
                char startChar = s[startIndex];
                char endChar = s[endIndex];

                if (!IsAlphanumeric(startChar))
                {
                    startIndex++;
                    continue;
                }

                if (!IsAlphanumeric(endChar))
                {
                    endIndex--;
                    continue;
                }

                //if (!char.IsLetterOrDigit(startChar))
                //{
                //    startIndex++;
                //    continue;
                //}

                //if (!char.IsLetterOrDigit(endChar))
                //{
                //    endIndex--;
                //    continue;
                //}

                if (char.ToLower(startChar) == char.ToLower(endChar))
                {
                    startIndex++;
                    endIndex--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsAlphanumeric(char c)
        {
            return c >= 'A' && c <= 'Z' ||
                c >= 'a' && c <= 'z' ||
                c >= '0' && c <= '9';
        }
    }
}
