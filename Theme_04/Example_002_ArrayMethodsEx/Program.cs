using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Example_002_ArrayMethodsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new int[] { 1, 5, 2, 5, 4, 6, 5, 7, 6, 8, 6, 9, 5, 1 };

            Console.WriteLine("Исходный массив: ");

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine($"data.Length = {data.Length}"); // Получает общее число элементов во всех измерениях массива

            int result = Array.IndexOf(data, 5); // Выполняет поиск указанного объекта внутри 
                                                 // всего одномерного массива и возвращает индекс его первого вхождения.

            Console.WriteLine($"Array.IndexOf(data, 5) = {result}");

            result = Array.LastIndexOf(data, 5);
            Console.WriteLine($"Array.LastIndexOf(data, 5) = {result}");

            int rank = data.Rank; // Получает ранг (число измерений) массива. 

            Console.WriteLine($"data.Rank = {rank}");

            Array.Sort(data);   // Сортирует элементы во всем массиве 

            Console.WriteLine("\nМассив после применения Array.Sort(data): ");

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();

            Array.Reverse(data);   // Изменяет порядок элементов во всем одномерном массиве на обратный.

            Console.WriteLine("Массив после применения Array.Reverse(data): ");

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();

            Array.Clear(data, 7, 3);    // Задает для диапазона элементов в массиве значение, предусмотренное по умолчанию

            Console.WriteLine("Массив после применения Array.Clear(data, 7, 3): ");

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();

            int[] copyData = new int[20];

            Array.ConstrainedCopy(data, 2, copyData, 10, 5);
            // Копирует диапазон элементов из массива (data), начиная с заданного индекса (2)
            // источника, и вставляет его в другой массив (copyData) , начиная с заданного
            // индекса (10) назначения. Гарантирует, что в случае невозможности успешно скопировать
            // весь диапазон, все изменения будут отменены.
            // 5 - количество копируемых элементов

            //Array.Copy()

            Console.WriteLine("Массив copyData: ");

            for (int i = 0; i < copyData.Length; i++)
            {
                Console.Write($"{copyData[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("Массив copyData после применения  Array.ConstrainedCopy(data, 4, copyData, 10, 5): ");

            for (int i = 0; i < copyData.Length; i++)
            {
                Console.Write($"{copyData[i]} ");
            }
            Console.WriteLine("\n");

        }
    }
}
