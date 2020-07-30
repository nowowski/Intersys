using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExistingPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<uint> uintList = new List<uint>() { 3, 5, 6, 7,  9 };
            Powers.powerOfTwo(uintList);
            Console.ReadKey();
         
        }
    }
}
