using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairSums
{
    public static class PairSums
    {
        public static void printPairSums(int[] array, int sum)
        {
            Array.Sort(array);
            int first = 0;
            int last = array.Length - 1;
            while (first < last)
            {
                int s = array[first] + array[last];

                if (s == sum)
                {
                    Console.WriteLine(array[first] + " " + array[last]);
                    int pred_first = first;
                    int pred_last = last;

                    do
                    {
                        first++;
                        last--;

                    } while (array[first] == array[first - 1] && array[last] == array[last + 1] && (first < last));
                    
                }
                else
                {
                    if (s < sum) first++;
                    else last--;
                }
            }
        }
    }
}
