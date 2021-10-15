using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_002_If
{
    class Program
    {
        static void Main(string[] args)
        {
            // Условные операторы используются для выполнения различных блоков кода на основе разных условий

            // Оператор if будет выполняться только в том случае, если условие в скобках будет "истина". 
            // Условие может включать в себя любое сравнение и логические операторы
            // т.е. bool результат

            Random rand = new Random();

            int x = rand.Next(3); // Выдаёт 0, 1 или 2
            Console.WriteLine($"Получено значение x = {x}");

            if (x < 2)
                Console.WriteLine("x равен 0 или 1");

            // Часто используемая форма записи

            if (x < 2)
            {
                Console.WriteLine("x равен 0 или 1");
            }

            
        }
    }
}
