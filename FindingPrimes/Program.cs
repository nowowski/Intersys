using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 100, n = 200;
            int ans = Primes.findPrimes(m, n);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
