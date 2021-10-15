using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_007
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример 6.
            // Заказчик прочит вас написать игру "Угадай-ка", в которой
            // игрок должен угадать число из диапазона от 1 до 100 
            // за минимальное количество шагов.
            // При этом, после очередной попытки, игрок должен видеть сообщение
            // "Введенное число больше загаданного. Попробуйте ещё раз"
            // "Введенное число меньше загаданного. Попробуйте ещё раз"
            // или "Поздравляю, число угадано! Число попыток: {число}.

            Console.WriteLine("Игра \"Угадай-ка\"");

            Random rand = new Random();

            int iiNumber = rand.Next(1, 101);
            int count = 0;
            int userNumber;

            //for (; ; )
            //while (true)
            do
            {
                Console.Write("\nВведите число: ");
                count++;
                userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber < iiNumber)
                {
                    Console.WriteLine("Введенное число меньше загаданного. Попробуйте ещё раз");
                }
                else if (userNumber > iiNumber)
                {
                    Console.WriteLine("Введенное число больше загаданного. Попробуйте ещё раз");
                }
                else
                {
                    Console.WriteLine($"Поздравляю, число угадано! Число попыток: {count}.");
                    Console.ReadKey();
                    break;
                }
            }
            while (true);
        }
    }
}
