using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_001_ArrayExs
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задача 1

            //Console.WriteLine("Сформировать массив из N случайных чисел от -5 до 5");

            //// Решение

            //Console.Write("Введите n: ");               // Приглашение ко вводу числа
            //int n = int.Parse(Console.ReadLine());      // Ввод числа с клавиатуры

            //Random random = new Random();               // Инициализация генератора псевдослучайных чисел

            //int[] numbs = new int[n];                   // Объявление и инициализация массива

            //for (int i = 0; i < numbs.Length; i++)      //
            //{                                           //
            //    numbs[i] = random.Next(-5, 6);          // Заполнение массива
            //    Console.Write($"{numbs[i]} ");          // Вывод массива на экран
            //}                                           // 

                                                  
            Console.ReadKey();

            #endregion

            #region Задача 2

            //Console.Clear();
            //Console.WriteLine("Сформировать массив N случайных чисел. Подсчитать количество четных чисел");

            Random random = new Random();
            //// Решение
          
            //Console.Write("Введите n: ");               // Приглашение ко вводу числа
            //int n = int.Parse(Console.ReadLine());          // Ввод числа с клавиатуры
            
            //var numbs = new int[n];                         // Объявление и инициализация массива

            //int evenElement = 0;                        // Количество четных элементов

            //for (int i = 0; i < numbs.Length; i++)      //
            //{                                           //
            //    numbs[i] = random.Next(10);             // Заполнение массива
            //    Console.Write($"{numbs[i]} ");          // Вывод массива на экран
            //    if (numbs[i] % 2 == 0) evenElement++;    // Подсчёт чётных элементов
            //}                                           // 

           
 
            //                                        //

            //Console.WriteLine($"\nЧётных: {evenElement}");

            //Console.ReadKey();

            #endregion

            #region Задача 3

            //Console.Clear();
            //Console.WriteLine("В массиве из 10 чисел вычислить, сколько раз встречается введенное число");

            //// Решение

            //int[] numbs = new int[10];                         // Объявление и инициализация массива

            //for (int i = 0; i < numbs.Length; i++)      //
            //{                                           //
            //    numbs[i] = random.Next(10);             // Заполнение массива
            //    Console.Write($"{numbs[i]} ");          // Вывод массива на экран
            //}                                           // 

            //Console.Write("\nКакое число ищём: ");      // Приглашение ко вводу числа
            //int n = int.Parse(Console.ReadLine());      // Ввод искомого числа с клавиатуры

            //int find = 0;                               // Результат поиска


            //for (int i = 0; i < numbs.Length; i++)      //
            //{                                           //
            //    if (numbs[i] == n) find++;              // Поиск искомого элемента
            //}

            //Console.WriteLine($"\nЭлемент '{n}' найден: {find} р. ");

            //Console.ReadKey();

            #endregion

            #region Задача 4
 
            Console.Clear();
            Console.WriteLine("Массив из N элементов состоит из нулей и единиц.\nПоставить нули в начало, а единицы – в конец.");

            // Решение

            Console.Write("\nКоличество элементов: ");  // Приглашение ко вводу числа
            int n = int.Parse(Console.ReadLine());      // Ввод искомого числа с клавиатуры
            int[] numbs = new int[n];                   // Объявление и инициализация массива

            Console.Write("\nИсходный массив: ");       // 

            for (int i = 0; i < numbs.Length; i++)      //
            {                                           //
                numbs[i] = random.Next(0, 2);           // Заполнение массива
                Console.Write($"{numbs[i]} ");          // Вывод массива на экран
            }                                           // 

            //     0  0  0  0  0  0  0  1  1  1
            //                       ^  ^     
            //                                  

            int head = 0;                               // Указатель головного элемента
            int tail = numbs.Length - 1;                // Указатель хвостового элемента

            bool flag = true;                           // Флаг, показывающий увеличивать позицию головного - flag = true
                                                        // или уменьшать позицию хвостового - flag = false

            while (head < tail)                         // Пока "голова" меньше "хвоста"
            {
                if(flag)                                // flag = true
                {                                       //
                    if (numbs[head] == 1) flag = false; // Работаем с головным элементом
                    else head++;                        //
                }
                else                                    // иначе flag = false
                {                                       //
                    if (numbs[tail] == 0) flag = true;  // Работаем с хвостовым элементом
                    else tail--;                        // 
                }

                if(numbs[head]==1 && numbs[tail] == 0)  // Если головной элемент = 1 и хвостовой = 0
                {
                    int temp = numbs[head];             //
                    numbs[head] = numbs[tail];          // Меняем их местами
                    numbs[tail] = temp;                 //

                    head++;                             // Сдвигаем голову 
                    tail--;                             // и хвост
                }
            }

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
