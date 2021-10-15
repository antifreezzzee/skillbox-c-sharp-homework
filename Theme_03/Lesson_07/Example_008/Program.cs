using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_008
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0) continue;

                Debug.Write(">>> ");
                Debug.Write($"{i} ");
            }

            Console.ReadKey();
        }
    }
}
