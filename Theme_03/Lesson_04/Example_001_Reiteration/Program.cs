using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_001_Reiteration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример 1. Сгенерировать 10 случайных чисел от -8 до 9

            Random rand = new Random();

            Console.WriteLine($"1-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"2-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"3-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"4-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"5-e случайное число {rand.Next(-8, 10)}");

            Console.WriteLine($"6-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"7-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"8-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"9-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"10-e случайное число {rand.Next(-8, 10)}");

            Console.WriteLine($"11-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"12-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"13-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"14-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"15-e случайное число {rand.Next(-8, 10)}");

            Console.WriteLine($"16-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"17-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"18-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"19-e случайное число {rand.Next(-8, 10)}");
            Console.WriteLine($"20-e случайное число {rand.Next(-8, 10)}");



        }
    }
}
