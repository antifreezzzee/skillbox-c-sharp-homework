using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_003_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            // Чтобы проверить другие условия, оператор if может быть расширен любым количество if'ов.
            // Каждое дополнительное условие будет проверено, только если все предыдущие условия являются ложными.

            // Пример
            
            Random rand = new Random();

            int x = rand.Next(3); // Выдаёт 0, 1 или 2
            Console.WriteLine($"Получено значение x = {x}");

            //if (x == 1) Console.WriteLine("x == 1");
            //else Console.WriteLine("x != 1");

            //if (x==1)
            //{
            //    Console.WriteLine("x == 1");
            //}
            //else
            //{
            //    Console.WriteLine("x != 1");
            //}

            #region if-else-if

            if (x < 1) Console.WriteLine("x < 1");
            else if (x > 1) Console.WriteLine("x > 1");
            else Console.WriteLine("x = 1");

            #endregion

            #region Пример записи 1
            Console.ReadKey();

            if (x < 1)
            {
                Console.WriteLine("x < 1");
            }
            else if (x > 1)
            {
                Console.WriteLine("x > 1");
            }
            else
            {
                Console.WriteLine("x = 1");
            }

            #endregion

            #region Пример записи 2
            Console.ReadKey();

            if (true)
            {

            }
            else
            {
                if (true)
                {

                }
                else
                {
                    if (true)
                    {

                    }
                    else
                    {

                    }
                }
            }

            if (x < 1)
            {
                Console.WriteLine("x < 1");
            }
            else
            {
                if (x > 1)
                {
                    Console.WriteLine("x > 1");
                }
                else
                {
                    Console.WriteLine("x = 1");
                }
            }

            #endregion
        }
    }
}
