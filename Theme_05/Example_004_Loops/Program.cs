using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example_004_Loops
{
    class Program
    {
        static void Infinity()
        {
            Console.Write("O_- "); // Шаг рекурсии
            //Thread.Sleep(100);         // 
            Infinity();                //
        }

        static void NotInfinity(int Count)
        {
            Console.WriteLine("O_- ");
            Thread.Sleep(100);
            Count = Count - 1;
            if (Count > 0) // Базовый случай
                NotInfinity(Count);
        }

        static void Main(string[] args)
        {
            //Infinity();
            NotInfinity(200000000);
        }
    }
}
