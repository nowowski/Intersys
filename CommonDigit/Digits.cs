using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDigit
{
    class Digits
    {
        public static char commonDigit(int n, int[] arr)
        {
            char digit;
            string str = string.Join(" ", arr);
            var digitsGroup = str.GroupBy(x => x);
            var maxCount = digitsGroup.Max(g => g.Count());
            digit = digitsGroup.Where(x => x.Count() == maxCount).Select(x => x.Key).ToArray().Max();
            return digit;
        }
    }
}
