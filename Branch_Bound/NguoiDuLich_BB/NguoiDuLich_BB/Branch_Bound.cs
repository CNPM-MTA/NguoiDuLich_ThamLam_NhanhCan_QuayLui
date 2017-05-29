using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguoiDuLich_BB
{
    public class Branch_Bound
    {
        private int N;
        private int[,] C;
        private bool[] Daxet;
        private int[] x;
        private int S = 0;
      
        private int Cmin;

        private int Gttu;

        public Branch_Bound(int[,] C)
        {
            this.N = (int)Math.Sqrt(C.Length);
            init(C);

        }
        private void init(int [,] C)
        {
            x = new int[N+ 1];
            int i, j;

            Cmin = int.MaxValue;
            Daxet = new bool[N+ 1];
            this.C = new int[N + 1, N + 1];

            for (i = 0; i <= N; i++)
            {
                Daxet[i] = false;
                this.C[0, i] = 0;
                this.C[i, 0] = 0;
            }
            for (i = 1; i <= N; i++)
                for (j = 1; j <= N; j++)
                {
                    this.C[i, j] = C[i-1, j-1];
                    if (C[i - 1, j - 1] > 0)
                    {
                        Cmin = C[i - 1, j - 1];
                        break;
                    }

                }
            for (i = 1; i <= N; i++)
                for (j = 1; j <= N; j++)
                    Cmin = (Cmin > C[i - 1, j - 1] && C[i-1, j-1] > 0) ? C[i - 1, j - 1] : Cmin;

            Gttu = int.MaxValue;
            S = 0;
            x[1] = 1;
            Daxet[1] = true;
        }
        public void Try(int i)
        {
            if (i <= 0) return;
            int j, Tong, g;
            for (j = 2; j <= N; j++)
            {
                if (!Daxet[j])
                {
                    x[i] = j;
                    Daxet[j] = true;
                    S += C[x[i - 1], x[i]];
                    //Console.WriteLine(i);
                    if (i == N-1)
                    {
                        //cập nhật tối ưu
                        Tong = S + C[x[N], x[1]];
                        if (Tong < Gttu)
                        {
                            Show(x, N);
                            Gttu = Tong;
                        }
                    }
                    else
                    {
                        g = S + (N - i + 1) * Cmin;//danh gia can
                        if (g < Gttu) Try(i + 1);
                    }
                    S -= C[x[i - 1], x[i]];
                    Daxet[j] = false;
                }
            }
        }
        int count = 0;
        private void Show(int[] x,int  N)
        {
            int i;
            Console.WriteLine("(" + count++ + ")");
            for (i = 0; i <= N; i++)
                Console.Write(" \t " + x[i]);
        }
    }
}
