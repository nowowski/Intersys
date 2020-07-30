using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 4, 3 };
            int n = 4;
            int ans = Digits.digitSum(n, array);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
