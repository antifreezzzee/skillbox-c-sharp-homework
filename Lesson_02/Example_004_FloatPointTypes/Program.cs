using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_004_FloatPointTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Типы с плавающей точкой могут хранить действительные числа с разной точностью.


            // Постоянные числа с плавающей точкой в C# всегда сохраняются как переменные типа double,
            // Для использования типа float требуется в конце добавить символ F или f 
            // Аналогично для типа decimal  требуется в конце добавить символ M или m 
            // Аналогично для типа double добавление в конце символа D или d необязательно 

            // Пример
            float floatVariable = 3.14F; 
            double doubleVariable = 3.14;
            decimal decimalVariable = 3.14M;


            // Тип float принимает значения От ±1,5 x 10^(−45) до ±3,4 x 10^38 точность - 7 цифр

            floatVariable = 1.12345678910f;
            Console.WriteLine(floatVariable); // 1.1234567

            // Тип double принимает значения  От от ±5,0 × 10^(−324) до ±1,7 × 10^308 точность - 15 цифр            doubleVariable = 1.1234567898765431d;

            doubleVariable = 1.1234567898765431d;
            Console.WriteLine(doubleVariable); // 1,12345678987654

            // Тип decimal принимает значения от ±1,0 x 10^(-28) до ±7,9228 x 10^28 точность - 28 цифр

            decimalVariable = 1.12345678912345678901234567891234m;
            Console.WriteLine(decimalVariable); // 1,1234567891234567890123456789


        }
    }
}
