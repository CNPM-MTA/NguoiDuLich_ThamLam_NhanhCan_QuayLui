using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTS
{
    struct Point
    {
        public int cost;
        public bool isChecked;
    }
    /// <summary>
    /// Bài toán người du lịch theo phương pháp tham lam
    /// </summary>
    class GTS
    {
        public int  GreedyMethod(int[,]arr, int number,ref  int[] TOUR, int Ddau)
        {
            int v, //đỉnh đang xét
                k, //duyệt qua n đỉnh để chọn
                w= 0; //đỉnh được chọn trong mỗi bước
            int mini; // chọn các cạnh trong mỗi bước
            int COST = 0; //trọng số nhỏ nhất của chu trình
            int[] Daxet = new int[number];
            int i = 0;
            v = Ddau;
            for (k = 0; k < number; k++)
                Daxet[k] = 0;

            TOUR[i] = v;
            Daxet[v] = 1;//đỉnh v đã được xét


            while(i< number)
            {
                mini = int.MaxValue;
                for(k= 0; k< number; k++)
                    if(Daxet[k] == 0) 
                        if(mini > arr[v, k])
                        {
                            mini = arr[v, k];
                            w = k;
                        }
                v = w;
                i++;
                if (i == number) break;
                TOUR[i] = v;
                Daxet[v] = 1;
                COST += mini;
            }
            COST += arr[v, Ddau];
            return COST;
        }
    }
}
