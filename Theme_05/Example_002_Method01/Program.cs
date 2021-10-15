using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_002_Method01
{
    class Program
    {
        static void MethodName()
        {

        }

        /// <summary>
        /// Метод задержки закрытия консоли
        /// </summary>
        static void Pause()
        {
            Console.ReadKey();
        }
        
        /// <summary>
        /// Вывод приветствия в консоль
        /// </summary>
        static void Hi()
        {
            Console.WriteLine("Привет!");
        }

        /// <summary>
        /// Беспорядок в консоли
        /// </summary>
        static void ApplauseAndOvations()
        {
            Random r = new Random();

            for (int i = 0; i < r.Next(30,50); i++)
            {
                int posX = r.Next(Console.WindowWidth-5);   // Получение ширины консоли
                int posY = r.Next(Console.WindowHeight-1);  // Получение высоты консоли
                Console.SetCursorPosition(posX, posY + 1);  // Установка курсора в случайную позицию на экране
                Console.Write(r.Next(2)==0?"Ура!":"Ууу!");  // Вывод одного из радостных сообщений
            }
        }


        static void Main(string[] args)
        {
            #region 01. Первая группа

            ////
            //// ┌───────────────────────────────────────────┐
            //// │                                           │
            //// │                Что-то делает              │
            //// │                                           │
            //// └───────────────────────────────────────────┘
            ////
            ////
            //   static void MethodName()
            //   {
            //
            //   }

            #endregion

            Hi(); // Вызов метода Hi
            ApplauseAndOvations(); // Вызов метода ApplauseAndOvations
            Pause(); // Вызов метода Pause
        }
    }
}
