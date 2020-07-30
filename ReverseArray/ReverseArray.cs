using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class ReverseArray
    {
        public static int[] reverseArray(int[] arr)
        {
            int temp;
            int startIndex = 0;
            int endIndex = arr.Length - 1;

            while (startIndex < endIndex)
            {
                temp = arr[startIndex];
                arr[startIndex] = arr[endIndex];
                arr[endIndex] = temp;
                startIndex++;
                endIndex--;
            }
            return arr;

        }
    }
}
