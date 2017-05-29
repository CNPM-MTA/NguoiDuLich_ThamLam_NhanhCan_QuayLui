using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguoiDuLich_BB
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] C = new int[6, 6]
            {
                { 0, 20, 15, 0, 80, 0 },
                {40, 0, 0, 0, 10, 30 },
                {20, 4, 0, 0, 0, 10 },
                {36, 18, 15, 0, 0, 0 },
                {0, 0, 90, 15, 0, 0 },
                {0, 0, 45, 4, 10, 0 }
            };
            C = new int[5, 5]
            {
                {0, 3, 14, 18, 15 },
                {3, 0, 4, 22, 20 },
                {17, 9, 0, 16, 4 },
                {6, 2, 7, 0, 12 },
                {9, 15, 11, 5, 0 }
            };
            Branch_Bound bb = new Branch_Bound(C);
            bb.Try(1);



            Console.ReadKey();
        }
      
    }
}
