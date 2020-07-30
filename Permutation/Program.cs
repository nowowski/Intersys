using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] arr2 = { 6, 5, 4, 3, 2, 0, 11, 10, 9, 8, 7 };

            Console.WriteLine(Permutation.arePermutations(arr1, arr2) ? "YES" : "NO");
            Console.ReadKey();
        }
    }
}
