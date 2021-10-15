using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_003
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример 2. Заказчик просит вас написать прогрмму, в которой 
            // пользователь вводит целое число start.
            // Программа должна вывести таблицу квадратов чисел от start до start+10

            Console.Write("\nВведите start:");
            int start = Convert.ToInt32(Console.ReadLine());
            int i = start;
            do
            {
                Console.WriteLine($"{i,4}^2 = {i * i}");
                i++;
            } while (i <= start + 10) ;
        }
    }
}
