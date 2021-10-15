using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_002_Method04
{
    class Program
    {


        /// <summary>
        /// Метод генерации строки из набора случайных символов
        /// </summary>
        /// <param name="Count">Количество символов</param>
        /// <returns>Случайная строка</returns>
        static string GetRandomString(int Count)
        {
            return Guid.NewGuid().ToString().Substring(0, Count);
        }

        /// <summary>
        /// Метод, возвращающий полный путь к текущему приложению
        /// </summary>
        /// <returns>Полный путь к текущему приложению</returns>
        static string GetPath(bool FileName)
        {
            return FileName ? Application.ExecutablePath : Application.StartupPath;
        }

        /// <summary>
        /// Метод, возвращающий максимальное из двух чисел
        /// </summary>
        /// <param name="Value1">Первое число</param>
        /// <param name="Value2">Второе число</param>
        /// <returns>Максимальнео число</returns>
        static int Max(int Value1, int Value2)
        {
            return Value1 > Value2 ? Value1 : Value2;
        }
        
        /// <summary>
        /// Метод, принимающий массив целых чисел и возвращающий массив с противолоными числами
        /// </summary>
        /// <param name="Args">Входной массив</param>
        /// <returns>Преобразованный массив</returns>
        static int[] Inverse(int[] Args)
        {
            int[] t = new int[Args.Length];

            for (int i = 0; i < Args.Length; i++)
            {
                t[i] = -Args[i];
            }
            return t;
        }


        static void Main(string[] args)
        {
            #region 04. Четвертая группа
            //// 
            ////
            ////    │    Что-то     │
            ////    │   принимает   │
            ////    │  аргументами  │
            //// ┌──┘               └────────────────────────┐
            //// │                                           └──────
            //// │                Что-то делает                     >>> выдаёт результат своей работы
            //// │                                           ┌──────
            //// └───────────────────────────────────────────┘
            //
            // 
            //   static ТипДанных MethodName(ФормаьныеПараметры)
            //   {
            //      
            //   }

            #endregion

            Console.WriteLine(GetRandomString(5));    // Вызов метода GetRandomString
            Console.WriteLine(GetRandomString(10));   // Вызов метода GetRandomString
            Console.WriteLine(GetRandomString(15));   // Вызов метода GetRandomString

            Console.WriteLine(GetPath(true));         // Вызов метода GetPath
            Console.WriteLine(GetPath(false));        // Вызов метода GetPath
            Console.WriteLine();


            int[] col = { 1, 3, 5, 7, 9 };

            foreach (var e in col) Console.Write($"{e} ");
            Console.WriteLine();
            int[] inverseCol = Inverse(col);          // Вызов метода Inverse
            foreach (var e in inverseCol) Console.Write($"{e} ");



        }
    }
}
