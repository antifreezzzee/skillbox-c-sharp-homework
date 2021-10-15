using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example_002_Method02
{
    class Program
    {

        /// <summary>
        /// Метод откладывающий закрытие консоли на Interval секунд 
        /// </summary>
        /// <param name="Interval">Количество секунд до закрытия консоли
        /// </param>
        static void Pause(int Interval)
        {
            Thread.Sleep(Interval * 1000);
        }

        /// <summary>
        /// Вывод персонифицированного приветствия в консоль
        /// </summary>
        /// <param name="Name">Имя, кото нужно поприветствовать</param>
        static void Hi(string Name)
        {
            Random r = new Random();

            string text = string.Empty;

            switch (r.Next(5))
            {
                case 0: text = $"Привет, {Name}!"; break;
                case 1: text = $"Добрый день, {Name}!"; break;
                case 2: text = $"Приветствую тебя, {Name}!"; break;
                case 3: text = $"Рад тебя видеть, {Name}!"; break;
                default: text = $"Я так ждал тебя, {Name}!"; break;
            }

            Console.WriteLine(text);
        }

        /// <summary>
        /// Упорядоченный беспорядок на экране нужное количество раз
        /// </summary>
        /// <param name="Text1">Первый текст для вывода на экран</param>
        /// <param name="Text2">Второй текст для вывода на экран</param>
        /// <param name="Count">Сколько раз нужно вывести один из случайным образом выбранных текстов</param>
        static void ApplauseAndOvations(string Text1, string Text2, int Count)
        {
            Random r = new Random();
            int max = new int[] { Text1.Length, Text1.Length }.Max();

            for (int i = 0; i < Count; i++)
            {
                int posX = r.Next(Console.WindowWidth - max);   // Получение ширины консоли
                int posY = r.Next(Console.WindowHeight);        // Получение высоты консоли
                Console.SetCursorPosition(posX, posY + 1);      // Установка курсора в случайную позицию на экране
                Console.Write(r.Next(2) == 0 ? Text1 : Text2);  // Вывод одного из радостных сообщений
            }
        }

        static void Main(string[] args)
        {
            #region 02. Вторая группа
            ////
            ////    │    Что-то     │
            ////    │   принимает   │
            ////    │  аргументами  │
            //// ┌──┘               └────────────────────────┐
            //// │                                           │
            //// │                Что-то делает              │
            //// │                                           │
            //// └───────────────────────────────────────────┘
            // 
            //   static void MethodName(ФормаьныеПараметры)
            //   {
            //
            //   }

            #endregion

            //Hi("Илон"); // Вызов метода Hi
            ApplauseAndOvations("Огого!", "Ёёёёууу!", 70); // Вызов метода ApplauseAndOvations
            Pause(20); // Вызов метода Pause

        }
    }
}
