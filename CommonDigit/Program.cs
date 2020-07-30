using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 111, 222, 5 };
            int n = 4;
            char ans = Digits.commonDigit(n, array);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
