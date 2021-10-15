using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_001_DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Цикл do-while продолжает выполнение блока кода, только если условие продолжение истинно.
            // Условие проверяется только в конце каждой итерации.
            // В следствии чего, при использовании do-while, тело цикла быдет выполнено хотя бы один раз


            bool condition = false;
            do
            {
                // Тело цикла
            } while (condition);


            Console.WriteLine("Вывод чисел от 0 до 9");
            int i = 0;
            do
            {
                Console.Write($"{i} ");
                i++;
            } while (i < 10);


            Console.WriteLine("\n\nВывод чисел от -5 до 5");
            i = -5;
            do
            {
                Console.Write($"{i} ");
                i++;
            } while (i <= 5);


            Console.WriteLine("\n\nВывод чисел от 10 до 1. Вариант 1");
            int j = 0;
            do
            {
                Console.Write($"{10 - j} ");
                j++;
            } while (j < 10);


            Console.WriteLine("\n\nВывод чисел от 10 до 1. Вариант 2");
            int k = 10;
            do
            {
                Console.Write($"{k} ");
                k--;
            } while (k >= 1);


            Console.WriteLine("\n\nВывод чисел от 1 до 22 c шагом 3");
            int counter = 1;
            do
            {
                Console.Write($"{counter} ");
                counter += 3;
            } while (counter <= 22);


            Console.WriteLine("\n\nВывод чисел от -1 до 1 c шагом 0.25");
            double step = -1;
            do
            {
                Console.Write($"{step}  ");
                step += 0.25;
            } while (step <= 1);


            Console.WriteLine("\n\nВывод чисел от 1 до -1 c шагом 0.5");
            double interval = 1;
            do
            {
                Console.Write($"{interval}  ");
                interval -= 0.5;
            } while (interval >= -1);





            #region Замечание 1

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n\nЗамечание 1");

            Console.WriteLine("\n\nВывод чисел от 1 до 22 c шагом 3");
            counter = 28;
            do
            {
                Console.Write($"{counter} ");
                counter += 3;
            } while (counter <= 22);


            Console.WriteLine("\n\nВывод чисел от -1 до 1 c шагом 0.25");
            step = 9;
            do
            {
                Console.Write($"{step}  ");
                step += 0.25;
            } while (step <= 1);


            Console.WriteLine("\n\nВывод чисел от 1 до -1 c шагом 0.5");
            interval = -90;
            do
            {
                Console.Write($"{interval}  ");
                interval -= 0.5;
            } while (interval >= -1);

            #endregion

            #region Замечание 2

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n\nЗамечание 2");

            Console.WriteLine("\n\nВывод чисел от 1 до 22 c шагом 3");
            counter = 28;
            if (counter < 22)
            {
                do
                {
                    Console.Write($"{counter} ");
                    counter += 3;
                } while (counter <= 22);
            }

            Console.WriteLine("\n\nВывод чисел от -1 до 1 c шагом 0.25");
            step = 9;
            if (step == 1)
            {
                do
                {
                    Console.Write($"{step}  ");
                    step += 0.25;
                } while (step <= 1);
            }

            Console.WriteLine("\n\nВывод чисел от 1 до -1 c шагом 0.5");
            interval = -90;
            if (interval == 1)
            {
                do
                {
                    Console.Write($"{interval}  ");
                    interval -= 0.5;
                } while (interval >= -1);
            }
            #endregion

            Console.ReadKey();
        }
    }
}
