using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Palindrome
    {
        public static string isPalindrome(string sentence)
        {
            var checkOnlyLetters = new String(sentence.ToLower().Where(Char.IsLetter).ToArray());
            for (int leftIndex = 0, rightIndex = checkOnlyLetters.Length - 1; leftIndex < rightIndex; leftIndex++, rightIndex--)
                if (checkOnlyLetters[leftIndex] != checkOnlyLetters[rightIndex]) return "NO";
            return "YES";
        }
    }
}
