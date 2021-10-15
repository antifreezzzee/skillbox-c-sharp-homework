using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_001_Intro
{
     class Program
    {
        static void Main(string[] args)
        {
            // 1. Разделение логики: использование методов

            // Есть два массива содержащие не менее 10 и не более 20 элементов элементов. 
            // Организовать заполнение и вывод на экран каждого из них
            // Найти максимальный и минимальный элементы в каждом массиве

            #region Пример 1

            Random r = new Random();

            // Первый массив
            int N = r.Next(10, 20);

            int[] arr = new int[N];
            int[] brr = new int[N];


            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(20);
                brr[i] = r.Next(20);
            }

            // Поиск
            int maxArr = arr[0];
            int minArr = arr[0];
            int maxBrr = brr[0];
            int minBrr = brr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxArr) maxArr = arr[i];
                if (arr[i] < minArr) minArr = arr[i];

                if (brr[i] > maxBrr) maxBrr = brr[i];
                if (brr[i] < minBrr) minBrr = brr[i];
            }

            Console.WriteLine("arr");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i],3}");
            }

            Console.WriteLine($"\nmaxArr = {maxArr}");
            Console.WriteLine($"minArr = {minArr}");

            Console.WriteLine("\nbrr");

            for (int i = 0; i < brr.Length; i++)
            {
                Console.Write($"{brr[i],3}");
            }
            Console.WriteLine();
            Console.WriteLine($"maxBrr = {maxBrr}");
            Console.WriteLine($"minBrr = {minBrr}");







            #endregion


        }
    }
}
