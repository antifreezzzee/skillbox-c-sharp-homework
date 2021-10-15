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
            // Пример 4. Заказчик прочит вас написать программу по подсчёту 
            // среднего балла полученных студентами на экзамене
            // (i) Пользователь с клавиатуры вводит 10 чисел 
            // Требуется найти среднее арифметическое этих чисел

            double value;
            double average = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Введите {i}-й результат вступительного испытания: ");
                value = double.Parse(Console.ReadLine());
                average += value;
            }

            Console.WriteLine($"Среднее = {average / 10}");
        }
    }
}
