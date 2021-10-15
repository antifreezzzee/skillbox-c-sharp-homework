using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_001_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Целое число может принимть множество вариантов
            // Применение if-else для всех значений может быть громоздко
            // поэтому в некоторых случаях выгоднее использовать оператор выбора Switch

            Console.Write("Введите номер дня: ");
            int dayIndex = int.Parse(Console.ReadLine());

            if (dayIndex == 1) Console.WriteLine("Понедельник");
            else if (dayIndex == 2) Console.WriteLine("Вторник");
            else if (dayIndex == 3) Console.WriteLine("Среда");
            else if (dayIndex == 4) Console.WriteLine("Четверг");
            else if (dayIndex == 5) Console.WriteLine("Пятница");
            else if (dayIndex == 6) Console.WriteLine("Суббота");
            else if (dayIndex == 7) Console.WriteLine("Воскресенье");
            else Console.WriteLine("На планете Земля в неделе семь дней");

            switch (dayIndex)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("На планете Земля в неделе семь дней");
                    break;
            }

        }
    }
}
