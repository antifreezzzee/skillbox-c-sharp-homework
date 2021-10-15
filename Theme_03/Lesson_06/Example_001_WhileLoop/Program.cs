using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_001_WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            // Цикл while выполняет блок кода, только если его условие истинно и 
            // будет продолжаться до тех пор, пока условие остается верным.
            // Условие проверяется только в начале каждой итерации.

            bool condition = false;
            while (condition)
            {
                // Тело цикла
            }


            Console.WriteLine("Вывод чисел от 0 до 9");
            int i = 0;
            while ( i < 10)
            {
                Console.Write($"{i} ");
                i++;
            }


            Console.WriteLine("\n\nВывод чисел от -5 до 5");
            i = -5;
            while(i <= 5)
            {
                Console.Write($"{i} ");
                i++;
            }


            Console.WriteLine("\n\nВывод чисел от 10 до 1. Вариант 1");
            int j = 0;
            while (j < 10)
            {
                Console.Write($"{10 - j} ");
                j++;
            }


            Console.WriteLine("\n\nВывод чисел от 10 до 1. Вариант 2");
            int k = 10;
            while ( k >= 1)
            {
                Console.Write($"{k} ");
                k--;
            }


            Console.WriteLine("\n\nВывод чисел от 1 до 22 c шагом 3");
            int counter = 1;
            while ( counter <= 22)
            {
                Console.Write($"{counter} ");
                counter += 3;
            }


            Console.WriteLine("\n\nВывод чисел от -1 до 1 c шагом 0.25");
            double step = -1;
            while ( step <= 1)
            {
                Console.Write($"{step}  ");
                step += 0.25;
            }


            Console.WriteLine("\n\nВывод чисел от 1 до -1 c шагом 0.5");
            double interval = 1;
            while ( interval >= -1)
            {
                Console.Write($"{interval}  ");
                interval -= 0.5;
            }

            Console.ReadKey();
        }
    }
}
