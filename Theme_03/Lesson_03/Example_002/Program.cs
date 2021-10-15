using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_002
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заказчик просит создать эмулятор игры, в которм у игрока есть возможность выбрать 
            // уровень сложности, в зависимости от которого будет генерироваться разный игровой мир

            Console.WriteLine("Введите уровень сложности. 1 - Простой, 2 - Средний, 3 - Сложный");
            int level;  // 1 - Простой
                        // 2 - Средний
                        // 3 - Сложный
                        // В зависимости от уровня определить количество генериуемых NPC
                        // Простой - Два NPC
                        // Средний - Четыре NPC
                        // Сложный - Пять NPC

            level = Convert.ToInt32(Console.ReadLine());

            #region if-else

            if (level == 1)
            {
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
            }
            else if (level == 2)
            {
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
            }
            else if (level == 3)
            {
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
            }
            else
            {
                Console.WriteLine("Выбран неизвестный уровень сложности");
            }

            #endregion

            #region switch

            switch (level)
            {
                case 1:
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    break;

                case 2:
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    break;

                case 3:
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    break;

                default:
                    Console.WriteLine("Выбран неизвестный уровень сложности");
                    break;
            }

            #endregion
        }
    }
}
