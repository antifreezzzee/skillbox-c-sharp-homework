using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_002_ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Основные методы работы с одномерными массивами
            #region Задача 4

            Console.Clear();
            Console.WriteLine("Массив из N элементов состоит из нулей и единиц.\nПоставить нули в начало, а единицы – в конец.");

            // Решение
            Random random = new Random();               // Инициализация генератора псевдослучайных чисел

            Console.Write("\nКоличество элементов: ");  // Приглашение ко вводу числа
            int n = int.Parse(Console.ReadLine());      // Ввод искомого числа с клавиатуры
            int [] numbs = new int[n];                  // Объявление и инициализация массива

            Console.Write("\nИсходный массив: ");       // 

            for (int i = 0; i < numbs.Length; i++)      //
            {                                           //
                numbs[i] = random.Next(0, 2);           // Заполнение массива
                Console.Write($"{numbs[i]} ");          // Вывод массива на экран
            }                                           // 

            //     0  1  0  0  0  0  1  0  1  0
            //     ^                          ^
            //                                  

            #region Old

            //int head = 0;                               // Указатель головного элемента
            //int tail = numbs.Length - 1;                // Указатель хвостового элемента

            //bool flag = true;                           // Флаг, показывающий увеличивать позицию головного - flag = true
            //                                            // или уменьшать позицию хвостового - flag = false

            //while (head < tail)                         // Пока "голова" меньше "хвоста"
            //{
            //    if (flag)                               // flag = true
            //    {                                       //
            //        if (numbs[head] == 1) flag = false; // Работаем с головным элементом
            //        else head++;                        //
            //    }
            //    else                                    // иначе flag = false
            //    {                                       //
            //        if (numbs[tail] == 0) flag = true;  // Работаем с хвостовым элементом
            //        else tail--;                        // 
            //    }

            //    if (numbs[head] == 1 && numbs[tail] == 0)  // Если головной элемент = 1 и хвостовой = 0
            //    {
            //        int temp = numbs[head];             //
            //        numbs[head] = numbs[tail];          // Меняем их местами
            //        numbs[tail] = temp;                 //

            //        head++;                             // Сдвигаем голову 
            //        tail--;                             // и хвост
            //    }
            //}

            #endregion

            #region ToDo

            Array.Sort(numbs);  

            #endregion

            Console.Write("\nПолучившийся массив: ");

            for (int i = 0; i < numbs.Length; i++)      //
            {                                           //
                Console.Write($"{numbs[i]} ");          // Вывод массива на экран
            }

            Console.ReadKey();

            #endregion

        }
    }
}
