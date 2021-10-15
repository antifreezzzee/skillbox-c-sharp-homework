using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example_003
{
    class Program
    {

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
        /// Метод, заполняющий первых Count элементов массив Col
        /// </summary>
        /// <param name="Col">Массив целых чисел, который нужно заполнить</param>
        /// <param name="Count">Количество элементов, которые нужно изменить</param>
        static void Fill(int[] Col, int Count)
        {
            Random r = new Random();
            for (int i = 0; i < Count; i++)
            {
                Col[i] = r.Next(100);
            }
        }

        /// <summary>
        /// Метод, заполняющий первых Count элементов массив Col числами из диапазона BottomRange UpperRange.
        /// BottomRange должен быть строго меньше UpperRange
        /// </summary>
        /// <param name="Col">Массив целых чисел, который нужно заполнить</param>
        /// <param name="Count">Количество элементов, которые нужно изменить</param>
        /// <param name="BottomRange">Нижняя граница диапазона</param>
        /// <param name="UpperRange">Верхняя граница диапазона</param>
        static void Fill(int[] Col, int Count, int BottomRange, int UpperRange)
        {
            Random r = new Random();
            for (int i = 0; i < Count; i++)
            {
                Col[i] = r.Next(BottomRange, UpperRange);
            }
        }


        /// <summary>
        /// Метод, заполняющий элементы массив Col числами из диапазона BottomRange UpperRange.
        /// BottomRange должен быть строго меньше UpperRange
        /// </summary>
        /// <param name="Col">Массив целых чисел, который нужно заполнить</param>
        /// <param name="BottomRange">Нижняя граница диапазона</param>
        /// <param name="UpperRange">Верхняя граница диапазона</param>
        static void Fill(int[] Col, int BottomRange, int UpperRange)
        {
            Random r = new Random();
            for (int i = 0; i < Col.Length; i++)
            {
                Col[i] = r.Next(BottomRange, UpperRange);
            }
        }

        /// <summary>
        /// Метод, заполняющий элементы массив Col числами из диапазона BottomRange UpperRange.
        /// BottomRange должен быть строго меньше UpperRange
        /// </summary>
        /// <param name="Col">Массив целых чисел, который нужно заполнить</param>
        /// <param name="BottomRange">Нижняя граница диапазона</param>
        /// <param name="UpperRange">Верхняя граница диапазона</param>
        static void Fill(double[] Col, int BottomRange, int UpperRange)
        {
            Random r = new Random();
            for (int i = 0; i < Col.Length; i++)
            {
                Col[i] = r.Next(BottomRange, UpperRange);
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
                Console.Write($"{ Col[i],3}");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            #region Перегрузка метода

            // Перегрузка метода - это набор методов, имеющих одинаковое имя,
            // отличающиеся количеством формальных параметров или их типом

            #endregion

            int[] arr = new int[20];

            Fill(arr, 10);  // static void Fill(int[] Col, int Count)
            Print(arr);
            Console.ReadKey();

            Fill(arr); //static void Fill(int[] Col)
            Print(arr);
            Console.ReadKey();
            

            Fill(arr, -10, 0); //  static void Fill(int[] Col, int BottomRange, int UpperRange)
            Print(arr);
            Console.ReadKey();


            Fill(arr, 10, 1, 30); //  static void Fill(int[] Col, int Count, int BottomRange, int UpperRange)
            Print(arr);
            Console.ReadKey();






        }
    }
}
