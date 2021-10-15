using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_005
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заказчик просит написать программу, которая должна генерировать два случайных числа
            // из диапазона от -10 до 10 после чего на экране должно быть выведено:
            // 1.1. Максимальное из чисел
            // 1.2. Минимальное из чисел
            // 2. Добавить в программу возможность определения равенства чисел 
            // и вывода соответствующего сообщения на экран
            // 3. Добавить возможность ввода данных с клавиатуры

            Random rand = new Random();

            Console.Write("Введите первое число: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int secondNumber = int.Parse(Console.ReadLine());

            #region Пункт 1 вариант 1

            Console.WriteLine("Пункт 1 вариант 1");

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"Максимальное число = {firstNumber}");
            }
            else
            {
                Console.WriteLine($"Максимальное число = {secondNumber}");
            }

            if (firstNumber < secondNumber)
            {
                Console.WriteLine($"Минимальное число = {firstNumber}");
            }
            else
            {
                Console.WriteLine($"Минимальное число = {secondNumber}");
            }

            #endregion

            #region Пункт 1 вариант 2

            Console.WriteLine("\nПункт 1 вариант 2");

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"Максимальное число = {firstNumber}");
                Console.WriteLine($"Минимальное число = {secondNumber}");
            }
            else
            {
                Console.WriteLine($"Максимальное число = {secondNumber}");
                Console.WriteLine($"Минимальное число = {firstNumber}");
            }

            #endregion

            #region Пункт 1 вариант 3

            Console.WriteLine("\nПункт 1 вариант 3");

            bool flag = firstNumber > secondNumber;

            if (flag)
            {
                Console.WriteLine($"Максимальное число = {firstNumber}");
                Console.WriteLine($"Минимальное число = {secondNumber}");
            }
            else
            {
                Console.WriteLine($"Максимальное число = {secondNumber}");
                Console.WriteLine($"Минимальное число = {firstNumber}");
            }

            #endregion

            #region Пункт 1 вариант 4

            Console.WriteLine("\nПункт 1 вариант 4");

            int maxValue, minValue;

            if (firstNumber > secondNumber)
            {
                maxValue = firstNumber;
                minValue = secondNumber;
            }
            else
            {
                maxValue = secondNumber;
                minValue = firstNumber;

            }

            Console.WriteLine($"Максимальное число = {maxValue}");
            Console.WriteLine($"Минимальное число = {minValue}");

            #endregion

            #region Пункт 2

            Console.WriteLine("\nПункт 2");

            if (firstNumber > secondNumber)
            {
                maxValue = firstNumber;
                minValue = secondNumber;
            }
            else if(firstNumber < secondNumber)
            {
                maxValue = secondNumber;
                minValue = firstNumber;
            }
            else
            {
                Console.WriteLine("Числа равны");
            }

            Console.WriteLine($"Максимальное число = {maxValue}");
            Console.WriteLine($"Минимальное число = {minValue}");

            #endregion

            #region Пункт 3

            //Console.Write("Введите первое число: ");
            //int firstNumber = int.Parse(Console.ReadLine());

            //Console.Write("Введите второе число: ");
            //int secondNumber = int.Parse(Console.ReadLine());

            #endregion

        }
    }
}
