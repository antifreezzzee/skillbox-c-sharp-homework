using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_003_ParamsAct
{
    class Program
    {
        static int Sum(params int[] Args)
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
