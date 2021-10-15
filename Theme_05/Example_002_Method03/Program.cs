using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_002_Method03
{
    class Program
    {

        /// <summary>
        /// Метод генерации строки из набора случайных символов
        /// </summary>
        /// <returns>Случайная строка</returns>
        static string GetRandomString()
        {
            var result = Guid.NewGuid().ToString();
            return result;
        }

        /// <summary>
        /// Метод, возвращающий случайное приветствие
        /// </summary>
        /// <returns>Случайное приветствие</returns>
        static string GetRandomHi()
        {
            Random r = new Random();

            string text = string.Empty;

            switch (r.Next(5))
            {
                case 0: text = $"Привет!"; break;
                case 1: text = $"Добрый день!"; break;
                case 2: text = $"Приветствую тебя!"; break;
                case 3: text = $"Рад тебя видеть!"; break;
                default: text = $"Я так ждал тебя!"; break;
            }

            return text;
        }

        /// <summary>
        /// Метод, возвращающий полный путь к текущему приложению
        /// </summary>
        /// <returns>Полный путь к текущему приложению</returns>
        static string GetPath()
        {
            return Application.ExecutablePath;
        }


        static void Main(string[] args)
        {
            #region 03. Третья группа

            ////
            //// 
            ////
            //// ┌───────────────────────────────────────────┐
            //// │                                           └──────
            //// │                Что-то делает                     >>> выдаёт результат своей работы
            //// │                                           ┌──────
            //// └───────────────────────────────────────────┘
            ////
            // 
            //   static ТипДанных MethodName()
            //   {
            //      
            //   }

            #endregion

            string res = GetRandomString(); Console.WriteLine(res);
            res = GetRandomHi(); Console.WriteLine(res);
            res = GetPath(); Console.WriteLine(res);
            
            
        }
    }
}
