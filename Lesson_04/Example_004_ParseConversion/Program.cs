using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_004_ParseConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //string inputString = "2029";
            //int intValue = (int)inputString;     // Ошибка CS0029  
            //                                // Не удается неявно преобразовать тип "string" в "int".


            string inputString = "2029";
            int intValue = int.Parse(inputString);
            Console.WriteLine(intValue);                // 2029

            double doubleValue = double.Parse(inputString);
            Console.WriteLine(doubleValue);             // 2029

            ulong ulongValue = ulong.Parse(inputString);
            Console.WriteLine(ulongValue);              // 2029

            byte byteValue = byte.Parse(inputString);
            Console.WriteLine(byteValue);              // Необработанное исключение: 
                                                       // System.OverflowException: Значение было недопустимо 
                                                       // малым или недопустимо большим для беззнакового байта.




        }
    }
}
