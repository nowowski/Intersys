using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExistingPowers
{
    class Powers
    {
        public static string powerOfTwo(List<uint> listNumbers)
        {
            List<uint> powerOfTwo = new List<uint>();
            uint x;
            string result;

            foreach (uint number in listNumbers)
            {
                if ((number != 0) && ((number & (number - 1)) == 0))
                {
                    powerOfTwo.Add(number);
                    x = number;
                    while (x > 0)
                    {
                        if (!powerOfTwo.Contains(x)) powerOfTwo.Add(x);
                        x = x / 2;
                    }
                };
            };
            powerOfTwo.Sort();


            if (powerOfTwo.Count > 0)
            {
                result = String.Join("," , powerOfTwo);
            }
            else
            {
                result = "NA";
            }

            return result;
        }
    }
}