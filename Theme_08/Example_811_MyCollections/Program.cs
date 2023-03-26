using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_811_MyCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray my = new MyArray(3);

            Console.WriteLine(my.Print("Тест 1:"));

            my.Add(1);

            Console.WriteLine(my.Print("Тест 2:"));

            my.Add(2);
            my.Add(3);
            Console.WriteLine(my.Print("Тест 3:"));

            Random r = new Random();

            for (int i = 0; i < 30; i++)
            {
                my.Add(r.Next(100));
            }

            Console.WriteLine(my.Print("Тест 4:"));

            my.Add(11235813);

            Console.WriteLine(my.Print());

        }
    }
}
