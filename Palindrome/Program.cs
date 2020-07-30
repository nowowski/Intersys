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
            string checkString = "@alula 7689679";
            string ans = Palindrome.isPalindrome(checkString);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
