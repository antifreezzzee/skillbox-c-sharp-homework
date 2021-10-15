using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example_004_05Ege
{
    class Program
    {

        static int F(int N)
        {
            //Console.WriteLine($" F{N}");
            return (N > 2) ? F(N - 1) + G(N - 2) : N;
        }

        static int G(int N)
        {
            //Console.WriteLine($" G{N}");

            return (N > 2) ? G(N - 1) + F(N - 2) : N + 1;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(F(6));
            

            Console.WriteLine(F(13));
            Console.ReadKey();
            Console.WriteLine(F(13));

        }
    }
}
