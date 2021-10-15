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
            // Пример 3. Заказчик просит вас написать прогрмму, в которой 
            // пользователь может ввести два целых числа start и end.
            // Программа должна вывести таблицу квадратов чисел от start до end
            //  (!) Разница между start и end не может превышать 20

            Console.Write("\nВведите start:");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nВведите end:");
            int end = Convert.ToInt32(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"{i,4}^2 = {i * i}");
            }
        }
    }
}
