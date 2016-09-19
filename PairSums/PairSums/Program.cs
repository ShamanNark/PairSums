using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairSums
{
    class Program
    {
        void Main(string[] args)
        {
            int[] array = { -2, -1, 0, 3, 5, 6, 7, 9, 13, 14 };
            PairSums.printPairSums(array, 12);
            Console.ReadKey();
        }
    }
}
