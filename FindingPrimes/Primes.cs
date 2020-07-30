using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingPrimes
{
    class Primes
    {
        public static void findPrimes(int m, int n)
        {
            int counter;
            int numberOfPrimes = 0;
            for (int num = m; num <= n; num++)
            {
                counter = 0;

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && num != 1)
                    numberOfPrimes++;
            }
            Console.WriteLine(numberOfPrimes);
        }
    }
}
