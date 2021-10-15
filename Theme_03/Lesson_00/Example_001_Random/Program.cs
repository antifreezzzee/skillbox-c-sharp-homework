using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_001_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomize = new Random();    // Создание переменной randomize для получения псевослучайных чисел

            Console.WriteLine($"int.MaxValue = {int.MaxValue}");
            Console.WriteLine($"int.MinValue = {int.MinValue}\n");

            #region Замечание

            //Console.WriteLine($"byte.MaxValue = {byte.MaxValue}");
            //Console.WriteLine($"byte.MinValue = {byte.MinValue}\n");

            //Console.WriteLine($"uint.MaxValue = {uint.MaxValue}");
            //Console.WriteLine($"uint.MinValue = {uint.MinValue}\n");

            //Console.WriteLine($"long.MaxValue = {long.MaxValue}");
            //Console.WriteLine($"long.MinValue = {long.MinValue}\n");

            #endregion

            int randomIntResult = randomize.Next();     // Возвращает неотрицательное случайное целое число
                                                        // 32-разрядное целое число со знаком, 
                                                        // которое больше или равно 0 и меньше чем Int32.MaxValue.
            Console.WriteLine($"Пример 1. randomIntResult = {randomIntResult}");

            randomIntResult = randomize.Next(100);      // Возвращает неотрицательное случайное целое число, 
                                                        // которое меньше максимально допустимого значения
                                                        // от 0 до 100, не включая 100 
            Console.WriteLine($"Пример 2. randomIntResult = {randomIntResult}");

            randomIntResult = randomize.Next(10, 100);  // Возвращает неотрицательное случайное целое число, 
                                                        // которое больше минимально допустимого значения
                                                        // и меньше максимально допустимого значения
                                                        // от 10 до 100, не включая 100 

            Console.WriteLine($"Пример 3. randomIntResult = {randomIntResult}");

            double randomDoubleResult = randomize.NextDouble() + randomize.Next(100); // Возвращает случайное число с плавающей запятой, 
                                                                                        // которое больше или равно 0.0 и меньше 1.0
                                                                                        // не включая 1.0
            Console.WriteLine($"Пример 4. randomDoubleResult = {randomDoubleResult}");


        }
    }
}
