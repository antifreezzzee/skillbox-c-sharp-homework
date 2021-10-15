using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_001_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Цикл for используется для прохождения через блок указанное число раз.
            // Он использует три параметра.
            // Первый параметр инициализирует счетчик и всегда выполняется один раз, перед циклом.
            // Второй параметр - условие для цикла, оно проверяется перед каждой итерацией.
            // Третий параметр содержит приращение счетчика и выполняется в конце каждой итерации.

            //   Первый   ; Второй; Третий
            for (int i = 0; i < 10; i++)
            {
                // Тело цикла
            }

             
            Console.WriteLine("Вывод чисел от 0 до 9");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n\nВывод чисел от -5 до 5");
            for (int i = -5; i <= 5; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n\nВывод чисел от 10 до 1. Вариант 1");
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{10 - j} ");
            }

            Console.WriteLine("\n\nВывод чисел от 10 до 1. Вариант 2");
            for (int k = 10; k >= 1; k--)
            {
                Console.Write($"{k} ");
            }


            Console.WriteLine("\n\nВывод чисел от 1 до 22 c шагом 3");
            for (int counter = 1; counter <= 22; counter += 3)
            {
                Console.Write($"{counter} ");
            }


            Console.WriteLine("\n\nВывод чисел от -1 до 1 c шагом 0.25");
            for (double step = -1; step <= 1; step += 0.25)
            {
                Console.Write($"{step}  ");
            }

            Console.WriteLine("\n\nВывод чисел от 1 до -1 c шагом 0.5");
            for (double interval = 1; interval >= -1; interval -= 0.5)
            {
                Console.Write($"{interval}  ");
            }


            Console.ReadKey();

        }
    }
}
