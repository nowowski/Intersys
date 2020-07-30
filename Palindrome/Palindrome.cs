using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Palindrome
    {
        public static bool isPalindrome(string sentence)
        {
            for (int l = 0, r = sentence.Length - 1; l < r; l++, r--)
                if (sentence[l] != sentence[r]) return false;
            return true;
        }
    }
}
