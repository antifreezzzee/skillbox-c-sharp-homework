using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_002_ImplicitTypeСonversion
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Тиды данных

            // byte от 0 до 255
            // ushort от 0 до 65535
            // uint от 0 до 2^32-1 >>> от 0 до 4 294 967 296
            // ulong от 0 до 2^64-1 >>> от 0 до 18 446 744 073 709 551 616


            // sbyte от -128 дo +127
            // short от -32768 дo +32767
            // int от -2^31 дo +2^31-1 >>> от -2 147 483 648 до +2 147 483 647
            // long от -2^63 дo +2^63-1 >>> от -9 223 372 036 854 775 808 до +9 223 372 036 854 775 807

            // Тип float принимает значения От от ±5,0 × 10^(−324) до ±1,7 × 10^308 точность - 15 цифр
            // Тип double принимает значения От ±1,5 x 10^(−45) до ±3,4 x 10^38 точность - 7 цифр
            // Тип decimal принимает значения от ±1,0 x 10^(-28) до ±7,9228 x 10^28 точность - 28 цифр

            #endregion

            byte byteValue = 1;                 // Задание значения переменной типа byte
            short shortValue = byteValue;       // Неявное приведение byte к short
            int intValue = shortValue;          // Неявное приведение short к int
            long longValue = intValue;          // Неявное приведение int к long
            double doubleValue = longValue;     // Неявное приведение long к double

            //char c = 'я';
            //int d = c;

            Console.WriteLine(d);
        }
    }
}
