using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ReverseArray.reverseArray(a);
            printArray(a);
            Console.ReadKey();
        }


        static void printArray(int[] arr)
        {
            int size = arr.Length;

            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");

        }
    }
}
