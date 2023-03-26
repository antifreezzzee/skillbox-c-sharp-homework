using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ReSharper disable All

namespace Example_810_CollectionsIntro
{
    // Ролик 1. Коллекции: пространство System.Collections.Generic,коллекция List
    class Program
    {
        /// <summary>
        /// Метод печати массива в консоль
        /// </summary>
        /// <param name="Col">Массив, который нужно вывести в консоль</param>
        /// <param name="Text">Текст, перед выводом</param>
        static void PrintArray(int[] Col, string Text = "")
        {
            Console.WriteLine(Text);
            foreach (var element in Col)
            { Console.Write($"{element} "); }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Метод, удаления элемента массива
        /// </summary>
        /// <param name="Col">Массив, над которым будут производиться изменения</param>
        /// <param name="Position">Позиция элемента, который нужно удалить</param>
        /// <returns></returns>
        static bool RemoveAt(ref int[] Col, int Position)
        {
            bool result = false;

            if (Position >= 0 && Position <= Col.Length)
            {
                // 1 3 4 5 6
                for (int index = Position; index < Col.Length - 1; index++)
                { Col[index] = Col[index + 1]; }
                Array.Resize(ref Col, Col.Length - 1);
                result = true;
            }
            else
            { result = false; }
            return result;
        }


        static void Main(string[] args)
        {
            #region Добавление

            Console.WriteLine("Добавление: ");
            var a = new int[] { 1, 1, 2, 3, 5, 8 };
            PrintArray(a, "Исходный a:");
            Array.Resize(ref a, a.Length + 1);
            a[a.Length - 1] = 13;
            PrintArray(a, "Полученный a:");


            #endregion

            #region Удаление
            Console.WriteLine("Удаление: ");
            var b = new int[] { 1, 1, 2, 3, 5, 8, 13 };
            PrintArray(b, "Исходный Brr:");

            int pos = 3;

            if (RemoveAt(ref b, pos))
            { PrintArray(b, "Полученный b:"); }
            else
            { Console.WriteLine("Неверный индекс элемента"); }

            #endregion

        }
    }
}