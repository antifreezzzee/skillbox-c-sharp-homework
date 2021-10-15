using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_004
{
    class Program
    {
        static void Method1() { }
        static void Method2()
        {
            Method1();
        }

        static void Main(string[] args)
        {
            // 4. Понятие рекурсивной функции
            Method2();
        }
    }
}
