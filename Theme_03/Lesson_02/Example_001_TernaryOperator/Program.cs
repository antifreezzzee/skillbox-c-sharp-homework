using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_001_TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Тернарный оператор

            // В дополнение к оператору if есть, так называемый, тернарный оператор (?:).
            // Этот оператор может заменить одно предложение if-else, которое 
            // присваивает значение конкретной переменной. 
            // Оператор принимает три выражения. 
            // Если первый оценивается как true, будет возвращено второе выражение, 
            // и если оно false, то возвращается третий

            Random r = new Random();
            double x = r.NextDouble();       // Получение числа от 0.0 до 1.0, не включая 1.0

            int result = (x < 0.5) ? 0 : 1;  // Тернарный оператор (?:)
            Console.WriteLine($"result = {result}");
            
            if (x < 0.5)
            {
                result = 0;
            }
            else
            {
                result = 1;
            }

            Console.WriteLine($"result = {result}");

            #region Замечание

            Console.ReadKey();

            Console.WriteLine(x < 0.5 ? 0 : 1);

            if (x < 0.5)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }

            #endregion

        }
    }
}
