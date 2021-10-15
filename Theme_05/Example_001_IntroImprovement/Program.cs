using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_001_IntroImprovement
{
    class Program
    {
        static void Main(string[] args)
        {            
            // Есть два массива содержащие не менее 10 и не более 20 элементов элементов. 
            // Организовать заполнение и вывод на экран каждого из них
            // Найти максимальный и минимальный элементы в каждом массиве

            #region Пример 1

            Random r = new Random();

            // Первый массив
            int N = r.Next(10, 30);
            int[] arr = new int[N];
            Console.WriteLine("arr");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(20);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            // Максимум
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
            Console.WriteLine($"max = {max}");
            

            // Минимум
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            Console.WriteLine($"min = {min}");


            // Второй массив
            Console.WriteLine("\nbrr");

            int M = r.Next(10, 30);

            int[] brr = new int[M];
            for (int i = 0; i < brr.Length; i++)
            {
                brr[i] = r.Next(20);
                Console.Write($"{brr[i]} ");
            }
            Console.WriteLine();

            // Максимум
            max = brr[0];

            for (int i = 0; i < brr.Length; i++)
            {
                if (brr[i] > max) max = brr[i];
            }
            Console.WriteLine($"max = {max}");

            // Минимум
            min = brr[0];

            for (int i = 0; i < brr.Length; i++)
            {
                if (brr[i] < min) min = brr[i];
            }
            Console.WriteLine($"min = {min}");


            #region Примечание

            Console.WriteLine($"arrMax = {arr.Max()}");
            Console.WriteLine($"arrMix = {arr.Min()}");
            Console.WriteLine($"brrMax = {brr.Max()}");
            Console.WriteLine($"brrMix = {brr.Min()}");

            #endregion

            #endregion
        }
    }
}
