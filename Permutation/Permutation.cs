using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    class Permutation
    {
        public static bool arePermutations(int[] arr1, int[] arr2)
        {
            Dictionary<int, int> hashMap = new Dictionary<int, int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                int x = arr1[i];
                if (!hashMap.ContainsKey(x))
                    hashMap.Add(x, 1);
                else
                {
                    int k = hashMap[x];
                    hashMap.Remove(x);
                    hashMap.Add(x, k + 1);
                }
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                int x = arr2[i];

                if (!hashMap.ContainsKey(x))
                    return false;

                int k = hashMap[x];
                if (!hashMap.ContainsKey(x))
                    hashMap.Add(x, k - 1);
                else
                {
                    int a = hashMap[x];
                    hashMap.Remove(x);
                    hashMap.Add(x, a + 1);
                }
            }
            return true;
        }
    }
}
