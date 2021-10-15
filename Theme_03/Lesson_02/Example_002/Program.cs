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
            // Заказчик просит написать программу, которая должна генерировать три случайных числа
            // из диапазона от -21 до 22 после чего на экране должно быть выведено максимальное из чисел.
            // Если максимальных чисил несколько ( т.е. каких-то два или все три числа равны) 
            // на экране показать одно число без дополнительных сообщений

            #region Решение if-else

            Random rand = new Random();

            int firstNumber = rand.Next(-21, 23);   // Выдаёт от -21 до 23
            int secondNumber = rand.Next(-21, 23);  // Выдаёт от -21 до 23
            int thirdNumber = rand.Next(-21, 23);   // Выдаёт от -21 до 23

            int maxValue;

            // Если первое число больше двух других, 
            if((firstNumber > secondNumber) && (firstNumber > thirdNumber))
            {
                maxValue = firstNumber; // то оно максимальное
            }
            else // Если первое число меньше второго или меньше третьего, то максимальное среди двух оставшихся
            {
                if (secondNumber> thirdNumber) // Сравниваем второе и третье число, если второе больше третьего
                {
                    maxValue = secondNumber;   // то максимальное - второе
                }
                else// иначе 
                {
                    maxValue = thirdNumber;// максимальное - третье
                }
            }

            Console.WriteLine($"Максимальное значение = {maxValue}");   // Выводим результат на экран

            #endregion

            #region Решение ?:

            Console.ReadKey();

            int a = rand.Next(-21, 23);   // Выдаёт от -21 до 23
            int b = rand.Next(-21, 23);   // Выдаёт от -21 до 23
            int c = rand.Next(-21, 23);   // Выдаёт от -21 до 23
            maxValue = (a > b) && (a > c) ? a : (b > c) ? b : c;

            maxValue = (firstNumber > b) && (firstNumber > thirdNumber) ? firstNumber : (secondNumber > thirdNumber) ? secondNumber : thirdNumber;


            Console.WriteLine($"Максимальное значение = {maxValue}");   // Выводим результат на экран

            #endregion

        }
    }
}
