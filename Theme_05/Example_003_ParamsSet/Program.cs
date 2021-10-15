using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_003_ParamsSet
{
    class Program
    {
        static int Sum(int Factor, params int[] Args)
        {
            int result = 0;

            foreach (var e in Args)
            {
                result += e;
            }

            return result * Factor;
        }

        static int Sum(int Factor, string Msg, params int[] Args) { return 0; }
        static int Sum(double Factor, string Msg, params int[] Args) { return 0; }
        static int Sum(double Factor, string Msg, params double[] Args) { return 0; }


        static void Main(string[] args)
        {
            var res = Sum(1);
            res = Sum(1, 9);
            res = Sum(1, 9, 9);
            res = Sum(1, 9, 9, 0);
            res = Sum(1, 9, 9, 0, 2);
            res = Sum(1, 9, 9, 0, 2, 8);

            int[] col = new int[] { 2, 8, 0, 9, 9, 0 };

            Console.WriteLine(res);

            res = Sum(13, col);
            res = Sum(13, new int[] { 2, 8, 0, 9, 9, 0, 0, 1, 3, 5 });
            Console.WriteLine(res);

            res = Sum(8,  2, 8, 0, 9 );
            Console.WriteLine(res);

            res = Sum(5, new int[] { 2, 8 });
            Console.WriteLine(res);

            res = Sum(3, new int[] { 2 });
            Console.WriteLine(res);
        }
    }
}
