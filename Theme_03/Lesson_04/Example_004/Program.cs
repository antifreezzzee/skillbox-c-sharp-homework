using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_004
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример 4. Заказчик прочит вас написать программу по подсчёту 
            // среднего балла полученных студентами на экзамене
            // Пользователь с клавиатуры вводит 10 чисел 
            // Требуется найти среднее арифметическое этих чисел



            Console.Write("Введите 1-й результат вступительного испытания: ");
            double value1 = double.Parse(Console.ReadLine());

            Console.Write("Введите 2-й результат вступительного испытания: ");
            double value2 = double.Parse(Console.ReadLine());

            Console.Write("Введите 3-й результат вступительного испытания: ");
            double value3 = double.Parse(Console.ReadLine());

            Console.Write("Введите 4-й результат вступительного испытания: ");
            double value4 = double.Parse(Console.ReadLine());

            Console.Write("Введите 5-й результат вступительного испытания: ");
            double value5 = double.Parse(Console.ReadLine());

            Console.Write("Введите 6-й результат вступительного испытания: ");
            double value6 = double.Parse(Console.ReadLine());

            Console.Write("Введите 7-й результат вступительного испытания: ");
            double value7 = double.Parse(Console.ReadLine());

            Console.Write("Введите 8-й результат вступительного испытания: ");
            double value8 = double.Parse(Console.ReadLine());

            Console.Write("Введите 9-й результат вступительного испытания: ");
            double value9 = double.Parse(Console.ReadLine());

            Console.Write("Введите 10-й результат вступительного испытания: ");
            double value10 = double.Parse(Console.ReadLine());

            double average = (value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10) / 10;
            Console.WriteLine($"Среднее = {average}");

        }
    }
}
