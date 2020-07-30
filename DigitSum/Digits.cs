using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitSum
{
    class Digits
    {
        public static int digitSum (int n, int[] arr)
        {
            arr = Array.ConvertAll(arr, x => x.ToString().Select(digit => int.Parse(digit.ToString())).ToArray().Sum());
            int maxValue = arr.Max();
            return Array.LastIndexOf(arr, maxValue);
        }

    }
}
