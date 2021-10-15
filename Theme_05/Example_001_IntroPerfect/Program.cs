using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_001_IntroPerfect
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int N = r.Next(10, 20);
            int M = r.Next(10, 20);

            int[] arr = new int[N];
            int[] brr = new int[M];

            Fill(arr);
            Print(arr);

            Fill(brr);
            Fill(brr, N);
            Fill(brr, N, 10, 20);

            Print(brr);

            int maxArr = Max(arr);
            int maxBrr = Max(brr);
            int minArr = Min(arr);
            int minBrr = Min(brr);

            #region ToDo

            //int maxArr = arr.Max();
            //int maxBrr = arr.Max();
            //int minArr = brr.Min();
            //int minBrr = brr.Max();

            #endregion


        }
    }
}
