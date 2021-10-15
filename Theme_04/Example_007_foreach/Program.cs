using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_007_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7. Цикл foreach

            #region Задача 1

            //Console.WriteLine("Сформировать массив из N случайных чисел от -5 до 5");

            ////Решение

            //Console.Write("Введите n: ");               // Приглашение ко вводу числа
            //int n = int.Parse(Console.ReadLine());      // Ввод числа с клавиатуры

            //Random random = new Random();               // Инициализация генератора псевдослучайных чисел

            //int[] numbs = new int[n];                   // Объявление и инициализация массива

            //for (int i = 0; i < numbs.Length; i++)      //
            //{                                           //
            //    numbs[i] = random.Next(-5, 6);          // Заполнение массива
            //}                                           // 

            //for (int i = 0; i < numbs.Length; i++)      //
            //{                                           //
            //    Console.Write($"{numbs[i]} ");          // Вывод массива на экран
            //}                                           //
            //Console.WriteLine();

            //foreach (var e in numbs)
            //{
            //    Console.Write($"{e} ");
            //}

            //Console.ReadKey();

            #endregion

            #region int[][] dataTime

            //int[][] dataTime = new int[24][];

            ////int[][][] vs = new int[3][][];
            ////vs[0] = new int[3][];


            //for (int j = 0; j < dataTime.Length; j++)
            //{
            //    dataTime[j] = (j >= 9 && j < 21) ? new int[12] : new int[4];
            //}

            ////for (int i = 0; i < dataTime.Length; i++)
            ////{
            ////    for (int j = 0; j < dataTime[i].Length; j++)
            ////    {
            ////        Console.Write($"{dataTime[i][j],3} ");
            ////    }
            ////    Console.WriteLine();
            ////}

            //foreach (var array in dataTime)
            //{
            //    foreach (var e in array)
            //    {
            //        Console.Write($"{e,3} ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region String

            //string message = "Я С#-разработчик";

            //for (int i = 0; i < message.Length; i++)
            //{
            //    Console.Write($"{message[i]} ");
            //}

            //Console.WriteLine();

            //foreach (var c in message)
            //{
            //    Console.Write($"{c} ");
            //}

            Console.WriteLine();
            Console.ReadKey();

            #endregion

        }
    }
}
