using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_611_MathDateConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ролик 1. Встроенные методы. Класс Math и Convert, DateTime, TimeSpan

            #region Convert
            // Преобразует значение одного базового типа данных к другому базовому типу данных.

            //bool
            //byte
            //char
            //DateTime
            //decimal
            //double
            //short
            //int
            //long
            //sbyte
            //float
            //string
            //ushort
            //uint
            //ulong

            //int i = Convert.ToByte("20");
            //byte j = 0 ;
            //j = (byte)int.Parse("2011");
            //i = Convert.ToByte(12.45);
            //i = Convert.ToByte(56.78f);
            //i = Convert.ToByte(89.09m);

            #endregion

            #region Math

            //// Console.ReadKey();
            //// Предоставляет константы и статические методы для тригонометрических, логарифмических
            //// и иных общих математических функций. 

            //// Вычислить площадь окружности. Радиусом 2;
            ////               
            //// S окр. = πr²

            ////Math.PI // Представляет отношение длины окружности к ее диаметру, определяемое константой
            ////Math.E //Представляет основание натурального логарифма, определяемое константой e.

            //// Math.Abs - Возвращает абсолютное значение числа 

            //// Sin, Cos, Tan, Atan, Tanh и т.д.
            //// Log, Log10
            //// Max, Min
            //// var result = Math.Max(11,22);

            ////Возвращает наименьшее целое число, которое больше или равно заданному десятичному
            //Console.WriteLine(Math.Ceiling(1.2));   // 2
            //Console.WriteLine(Math.Ceiling(-1.2));  // -1

            //// Возвращает значение e, возведенное в указанную степень.
            //Console.WriteLine(Math.Exp(2)); // e²

            //// Возвращает наибольшее целое число, которое меньше или равно указанному десятичному числу.
            //Console.WriteLine(Math.Floor(1.2)); // 1
            //Console.WriteLine(Math.Floor(-1.2)); // -2

            //// Возвращает указанное число, возведенное в указанную степень.
            //Console.WriteLine(Math.Pow(4,3));       // 4³
            //Console.WriteLine(Math.Pow(2020,2));    // 2020²

            //// Округляет десятичное значение до указанного числа дробных разрядов.
            //Console.WriteLine(Math.Round(1.2345)); // 1
            //Console.WriteLine(Math.Round(1.5345)); // 2
            //Console.WriteLine(Math.Round(-1.5345)); // -2
            //Console.WriteLine(Math.Round(-1.56789,3)); // -1,568


            //// Возвращает целое число, указывающее знак 8-разрядного целого числа со знаком.
            //Console.WriteLine(Math.Sign(-20));  // -1
            //Console.WriteLine(Math.Sign(20));   // 1



            //int r = 2;
            //double s = Math.PI * Math.Pow(r, 2);
            //Console.WriteLine(s);

            //Console.ReadKey();
            #endregion

            #region DateTime TimeSpan

            //Console.ReadKey();

            DateTime date = new DateTime(2020, 09, 28, 01, 30, 00);
            Console.WriteLine($"{date}"); // 28.09.2020 1:30:00

            // date.Year         // Возвращает компонент года даты, представленной этим экземпляром.
            // date.Month        // Возвращает компонент месяца даты, представленной этим экземпляром.
            // date.Day          // Возвращает день месяца, представленный этим экземпляром.
            // date.Hour         // Возвращает компонент часа даты, представленной этим экземпляром.
            // date.Minute       // Возвращает компонент минуты даты, представленной этим экземпляром.
            // date.Second       // Возвращает компонент секунды даты, представленной этим экземпляром.
            // date.Millisecond  // Возвращает компонент миллисекунд для даты, представленной в данном экземпляре. 

            Console.WriteLine(date.ToShortTimeString());        // Получение только времени    1:30
            Console.WriteLine(date.ToShortDateString());        // Получение только даты       28.09.2020

            DateTime newDate = date.AddDays(10);
            Console.WriteLine($"{newDate}"); // 08.10.2020 1:30:00

            // Console.WriteLine(DateTime.Now);     // Возвращает System.DateTime, которому присвоены текущие дата и время 
                                                    // данного компьютера, выраженные как местное время.

            TimeSpan span = newDate - date;
            Console.WriteLine(span);                     // 10.00:00:00
            Console.WriteLine(span.TotalMinutes);        // 14400


            Console.Clear();

            date = DateTime.Now;

            double sum = 0;

            for (int k = 0; k <= 1_000_000_000; k++)
            {
                sum += k;
            }

            Console.WriteLine($"sum = {sum}");

            TimeSpan timeSpan = DateTime.Now.Subtract(date);
            Console.WriteLine($"timeSpan.TotalMilliseconds = {timeSpan.TotalMilliseconds}");

            #endregion



        }
    }
}
