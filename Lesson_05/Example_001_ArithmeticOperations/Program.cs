using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_001_ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Арифметические операции -,*,/,+

            #region Сумма +

            //int valueA = 2_140_000_003; int valueB = 2_140_000_003;
            //double valueC = (double)valueA + (double)valueB;

            //Console.WriteLine(valueC);

            //double valueD = 20.22; double valueE = 20.25;
            //double valueI = valueD + valueE;

            //sbyte valueF = 123; short valueG = 22;
            //var valueH = valueF + valueG;

            //long valueK = 32; byte valueL = 11;
            //var valueM = valueK + valueL;

            #endregion

            #region  Разность -

            //int valueA = 3; int valueB = 2019;
            //int valueC = valueA - valueB;

            //double valueD = 20.22; double valueE = 20.25;
            //double valueI = valueD - valueE;

            //sbyte valueF = 123; short valueG = 22;
            //var valueH = valueF - valueG;

            //long valueK = 32; byte valueL = 11;
            //var valueM = valueK - valueL;

            #endregion

            #region  Произведение *

            //int valueA = 3; int valueB = 2019;
            //int valueC = valueA * valueB;

            //double valueD = 20.22; double valueE = 20.25;
            //double valueI = valueD * valueE;

            //sbyte valueF = 123; short valueG = 22;
            //var valueH = valueF * valueG;

            //long valueK = 32; byte valueL = 11;
            //double valueM = valueK * valueL;

            #endregion

            #region Частное /

            //int valueA = 10; int valueB = 2;
            //int valueC = valueA / valueB;
            //Console.WriteLine(valueC); // 5

            //double valueA = 5; double valueB = 2;
            //double valueC = valueA / valueB;
            //Console.WriteLine(valueC); // Ожидание:   2.5
            ////                           // Реальность: 2

            //////// Деление в целых чисах [ byte, int, ulong и т.д.]
            ////////
            //////// 56 / 7 = 8
            //////// Делимое / Делитель = Частное
            //////// 56 = 7 * 8
            //////// 
            //////// 59 / 8 = 7 + 3
            ////////
            //////// a = b * q + r
            //////// Делимое / Делитель = Неполное частное + Остаток [ 0 ⩽ Остаток < |Делитель| ]
            //////// 59 = 7 * 8 + [остаток] 3
            //////// 21 = 4 * 5 + [остаток] 1
            //Console.WriteLine("Деление в целых числах");
            //Console.WriteLine($"5/2 = {5 / 2}");
            //Console.WriteLine($"59/8 = {59 / 8}");
            //Console.WriteLine($"21/4 = {21 / 4}");

            //Console.WriteLine("Деление в вещественных");

            //Console.WriteLine($"5.0/2.0 = {5.0 / 2.0}");
            //Console.WriteLine($"59.0/8.0 = {59.0 / 8.0}");
            //Console.WriteLine($"21.0/4.0 = {21.0 / 4.0}");

            #endregion

            #region Остаток от деления %

            //////// Деление в целых чисах [ byte, int, ulong и т.д.]
            ////////
            //////// 56 / 7 = 8
            //////// Делимое / Делитель = Частное
            //////// 56 = 7 * 8
            //////// 
            //////// 59 / 8 = 7 + 3
            ////////
            //////// a = b * q + r
            //////// Делимое / Делитель = Неполное частное + Остаток [ 0 ⩽ Остаток < |Делитель| ]
            //////// 59 = 7 * 8 + [остаток] 3
            //////// 21 = 4 * 5 + [остаток] 1
            //Console.WriteLine("Деление в целых числах. Остаток");
            //Console.WriteLine($"5 / 2 = {5 / 2}");  // 2
            //Console.WriteLine($"5 % 2 = {5 % 2}");  // 1
            //Console.WriteLine($"59 % 8 = {59 % 8}");
            //Console.WriteLine($"21 % 4 = {21 % 4}");


            #endregion


        }
    }
}
