﻿using System;
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
            int m = 1, n = 1;
            Primes.findPrimes(m, n);
            Console.ReadKey();
        }
    }
}