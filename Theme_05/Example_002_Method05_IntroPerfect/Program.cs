using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example_002_Method05_IntroPerfect
{
    class Program
    {


        /// <summary>
        /// Метод откладывающий закрытие консоли на Interval секунд 
        /// </summary>
        /// <param name="Interval">Количество секунд до закрытия консоли
        /// </param>
        static void Pause(int Interval)
        {
            Thread.Sleep(Interval * 1000);
        }

        /// <summary>
        /// Метод, заполняющий массив Col
        /// </summary>
        /// <param name="Col">Массив целых чисел, который нужно заполнить</param>
        static void Fill(int[] Col)
        {
            Random r = new Random();
            for (int i = 0; i < Col.Length; i++)
            {
                Col[i] = r.Next(100);
            }
        }

        /// <summary>
        /// Метод, выводы массива Col в консоль
        /// </summary>
        /// <param name="Col">Массив целых чисел, который нужно вывести в консоль</param>
        static void Print(int[] Col)
        {
            Random r = new Random();
            for (int i = 0; i < Col.Length; i++)
            {
                Console.Write($"{ Col[i]} ");
            }
            Console.WriteLine();
        }


        /// <summary>
        /// Метод, поиска максимального значения в массиве
        /// </summary>
        /// <param name="Col">Массив целых чисел, в котором нужно найти максимальный элемент</param>
        /// <returns>Максимальное значение в массиве</returns>
        static int Max(int[] Col)
        {
            if (Col.Length < 0) return -1;

            int localMax = Col[0];

            for (int i = 1; i < Col.Length; i++)
            {
                if (Col[i] > localMax) localMax = Col[i];
            }

            return localMax;
        }

        /// <summary>
        /// Метод, поиска минимального значения в массиве
        /// </summary>
        /// <param name="Col">Массив целых чисел, в котором нужно найти минимальный элемент</param>
        /// <returns>Минимальное значение в массиве</returns>
        static int Min(int[] Col)
        {
            if (Col.Length <= 0) return -1;

            int localMin = Col[0];

            for (int i = 1; i < Col.Length; i++)
            {
                if (Col[i] < localMin) localMin = Col[i];
            }

            return localMin;
        }

        static void Main(string[] args)
        {
            Random r = new Random();
            int N = r.Next(10, 20);
          

            int[] arr = new int[N];
           

            Fill(arr);
            Print(arr);
            Console.WriteLine($"maxArr = {Max(arr)}");
            Console.WriteLine($"minArr = {Min(arr)}\n");

            int M = r.Next(10, 20);
            int[] brr = new int[N];
            Pause(5);

            Fill(brr);
            //Fill(brr, Count);
            //Fill(brr, Count, BottomRange, UpperRange);
            Print(brr);
            Console.WriteLine($"maxBrr = {Max(brr)}");
            Console.WriteLine($"minBrr = {Min(brr)}\n");

            #region Важно

            // Сигнатура метода - это набор типов, которые возвращает метод и
            // принимает в качестве параметров.

            #endregion

        }
    }
}
