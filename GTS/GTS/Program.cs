using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTS
{
    class Program
    {
        static void Main(string[] args)
        {
            GTS gm = new GTS();
            const int N = 5;
            int[,] arr = new int[N, N]
            {
                {0, 1, 2, 7, 5 },
                {1, 0 ,4, 4, 3 },
                {2,4, 0, 1,2 },
                {7, 4, 1, 0, 3 },
                {5, 3, 2, 3, 0 }
            };
            int[] TOUR = new int[N];
            gm.GreedyMethod(arr, N, ref TOUR, 0);

            int i;
            for (i = 0; i < N; i++)
                Console.Write("\t" + TOUR[i]);


            Console.ReadKey();
        }
    }
}
