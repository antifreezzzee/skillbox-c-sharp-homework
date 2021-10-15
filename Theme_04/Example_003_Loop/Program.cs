using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_003_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Вложенные циклы, операторы break и continue

            #region Распечатать таблицу умножения

            // 2 x 1 = 2        3 x 1 = 3          4 x 1 = 4
            // 2 x 2 = 4        3 x 2 = 6          4 x 2 = 8
            // 2 x 3 = 6        3 x 3 = 9          4 x 3 = 12
            // 2 x 4 = 8        3 x 4 = 12         4 x 4 = 16
            // 2 x 5 = 10       3 x 5 = 15         4 x 5 = 20
            // 2 x 6 = 12       3 x 6 = 18         4 x 6 = 24
            // 2 x 7 = 14       3 x 7 = 21         4 x 7 = 28
            // 2 x 8 = 16       3 x 8 = 24         4 x 8 = 32
            // 2 x 9 = 18       3 x 9 = 27         4 x 9 = 36
            // 2 x 10 = 20      3 x 10 = 30        4 x 10 = 40

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"2 x {i} = {2 * i}");
            //}
            //Console.WriteLine();


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"3 x {i} = {3 * i}");
            //}
            //Console.WriteLine();


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"4 x {i} = {4 * i}");
            //}
            Console.WriteLine();

            #region ToDo

            //for (int i = 2; i < 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} x {j} = {i * j} ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #endregion

            #region Показать всевозможные трехбуквенные слова из алфавита S K I L
            //4 * 4 * 4 = 4^3

            #region ToDo

            //char[] symbols = { 'S', 'K', 'I', 'L' };
            //int count = 1;

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    for (int j = 0; j < symbols.Length; j++)
            //    {
            //        for (int k = 0; k < symbols.Length; k++)
            //        {
            //            Console.WriteLine($"{count++,3}: {symbols[i]}{symbols[j]}{symbols[k]}");
            //        }
            //    }
            //}

            #endregion

            #endregion

            #region Найти хотя бы одно решение уравнения в целых числах

            //     ┌                             ┐
            //     │     ┌   ┐ 3         ┌   ┐ 2 │
            //     │ 2 × │ a │    +  3 × │ b │   │ = 8337
            //     │     └   ┘           └   ┘   │
            //     └                             ┘

            // 2 * 1^3 + 3 * 1^2
            // 2 * 1^3 + 3 * 2^2
            // 2 * 1^3 + 3 * 3^2
            // 2 * 1^3 + 3 * 4^2
            // 2 * 1^3 + 3 * 5^2
            // ...
            // 2 * 2^3 + 3 * 1^2
            // 2 * 2^3 + 3 * 2^2
            // 2 * 2^3 + 3 * 3^2
            // 2 * 2^3 + 3 * 4^2
            // 2 * 2^3 + 3 * 5^2
            // ...
            // 2 * 3^3 + 3 * 1^2
            // 2 * 3^3 + 3 * 2^2
            // 2 * 3^3 + 3 * 3^2
            // 2 * 3^3 + 3 * 4^2
            // 2 * 3^3 + 3 * 5^2

            #region ToDo

            //for (double a = -500; a < 500; a++)
            //{
            //    for (double b = -500; b < 500; b++)
            //    {
            //        if ((2 * a * a * a + 3 * b * b) == 8337) Console.WriteLine($"a = {a}  b = {b}");
            //    }
            //}

            #endregion

            #endregion

            #region break и continue

            int count = 0;
            
            for (int i = 0; i < 1_000; i++)
            {
                //if (i % 2 == 0) continue;
                for (int j = 0; j < 1_000; j++)
                {
                    break;
                    //Console.Write($"({i} {j})  ");

                   
                }
                count++;
            }

            Console.WriteLine($"count = {count}");

            Console.WriteLine();
            #endregion

        }
    }
}
