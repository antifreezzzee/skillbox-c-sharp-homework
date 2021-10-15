using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_005_ConvertTo
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "2029";
            //int intValue = int.Parse(inputString);
            int intValue = Convert.ToInt32(inputString);
            Console.WriteLine(intValue);                // 2029

            long l = Convert.ToInt32(intValue);

            //double doubleValue = double.Parse(inputString);
            double doubleValue = Convert.ToDouble(inputString);
            Console.WriteLine(doubleValue);             // 2029

            //ulong ulongValue = ulong.Parse(inputString);
            ulong ulongValue = Convert.ToUInt64(inputString);
            Console.WriteLine(ulongValue);              // 2029

            //byte byteValue = byte.Parse(inputString);
            //byte byteValue = Convert.ToByte(inputString);
            //Console.WriteLine(byteValue);              // Необработанное исключение: 
            //                                           // System.OverflowException: Значение было недопустимо 
            //                                           // малым или недопустимо большим для беззнакового байта.

            #region Типы данных и их синонимы

            //Тип данных  Тип.NET
            //sbyte       System.SByte
            //short       System.Int16
            //int         System.Int32
            //long        System.Int64
            //byte        System.SByte
            //ushort      System.UInt16
            //uint        System.UInt32
            //ulong       System.UInt64
            //float       System.Single
            //double      System.Double
            //bool        System.Boolean

            #endregion

            #region Замечание

            //checked
            //{
            //    byte byteValue = (byte)intValue;
            //    Console.WriteLine(byteValue);
            //}

            //unchecked
            //{
            //    byte byteValue = (byte)intValue;
            //    Console.WriteLine(byteValue);
            //}

            #endregion

        }
    }
}
