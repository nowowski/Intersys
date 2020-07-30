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
            List<uint> uintList = new List<uint>() { 1, 3, 4 };
            string ans = Powers.powerOfTwo(uintList);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
