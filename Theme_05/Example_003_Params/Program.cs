using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_003_Params
{
    class Program
    {

        static int Sum(int V1) { return V1; }
        static int Sum(int V1, int V2) { return V1 + V2; }
        static int Sum(int V1, int V2, int V3) { return V1 + V2 + V3; }
        static int Sum(int V1, int V2, int V3, int V4) { return V1 + V2 + V3 + V4; }
        static int Sum(int V1, int V2, int V3, int V4, int V5) { return V1 + V2 + V3 + V4 + V5; }
        static int Sum(int V1, int V2, int V3, int V4, int V5, int V6) { return V1 + V2 + V3 + V4 + V5 + V6; }
        static int Sum(int[] Args)
        {
            int result = 0;

            foreach (var e in Args)
            {
                result += e;
            }

            return result;
        }

        static void Main(string[] args)
        {
            // Менеджер проекта просит написать метод, которыый будет 
            // Находить сумму наперед неизвестное количества целых чисел

            var res = Sum(1);
            res = Sum(1, 9);
            res = Sum(1, 9, 9);
            res = Sum(1, 9, 9, 0);
            res = Sum(1, 9, 9, 0, 2);
            res = Sum(1, 9, 9, 0, 2, 8);

            int[] col = new int[] { 2, 8, 0, 9, 9, 0 };
          
            Console.WriteLine(res);

            res = Sum(col);
            res = Sum(new int[] { 2, 8, 0, 9, 9, 0, 0, 1, 3, 5 });
            Console.WriteLine(res);

            res = Sum(new int[] { 2, 8, 0, 9 });
            Console.WriteLine(res);

            res = Sum(new int[] { 2, 8 });
            Console.WriteLine(res);

            res = Sum(new int[] { 2 });
            Console.WriteLine(res);

        }
    }
}
