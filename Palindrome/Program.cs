using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string checkString = "@allula 7689679";
            var checkOnlyLetters = new String(checkString.ToLower().Where(Char.IsLetter).ToArray());
            Console.WriteLine(Palindrome.isPalindrome(checkOnlyLetters) ? "YES" : "NO");
            Console.ReadKey();
        }
    }
}
