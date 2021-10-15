using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_004_01SequenceFib
{
    class Program
    {
        static int Fib(int N)
        {
            return (N == 1 || N == 2) ? 1 : Fib(N - 1) + Fib(N - 2);
        }

        static int FibLoop(int N)
        {
            int a1 = 1;
            int a2 = 1;
            int t = a2;

            for (int i = 2; i < N; i++)
            {
                t = a1 + a2;
                a1 = a2;
                a2 = t;
            }

            return t;
        }



        static void Main(string[] args)
        {
            // 1  1  2  3  5  8  13  21  34  55
            // fib(1) = 1
            // fib(2) = 1
            // fib(n) = fib(n-1) fib(n-2), n >= 3

            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine($"Fib({i,2}) = {Fib(i)}  {FibLoop(i)}");
            }
        }
    }
}
