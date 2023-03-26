using System;
using System.Collections.Generic;

namespace Homework_08
{
    public class Task1
    {
        private static Random random = new Random();
        /// <summary>
        /// Заполнение списка
        /// </summary>
        /// <param name="list">Список, который нужно заполнить</param>
        /// <param name="elementsCount">Количество создаваемых элементов</param>
        /// <param name="minValue">Минимальное значение элемента</param>
        /// <param name="maxValue">Максимальное значение элемента</param>
        private static void FillList(List<int> list, int elementsCount, int minValue, int maxValue)
        {
            for (int i = 0; i < elementsCount; i++)
            {
                list.Add(random.Next(minValue, maxValue + 1));
            }
        }
        /// <summary>
        /// Вывод списка в консоль
        /// </summary>
        /// <param name="list">Список, который необходимо показать</param>
        private static void PrintList(List<int> list)
        {
            foreach (var element in list)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Удаление элементов, находящихся в заданном диапазоне
        /// </summary>
        /// <param name="list">Список, из которого удаляются элементы</param>
        /// <param name="fromValue">Минимальное значение диапазона(не включительно)</param>
        /// <param name="toValue">Максимальное значение диапазона(не включительно)</param>
        private static void DeleteElements(List<int> list, int fromValue, int toValue)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > fromValue && list[i] < toValue)
                    list.Remove(i);
            }
        }
        // public static void Main(string[] args)
        // {
        //     List<int> myList = new List<int>();
        //     FillList(myList,100, 0, 101);
        //     Console.WriteLine($"Исходный список:\n");
        //     PrintList(myList);
        //     Console.WriteLine("Удаление элементов...");
        //     DeleteElements(myList,25, 50);
        //     Console.WriteLine($"Новый список:\n");
        //     PrintList(myList);
        // }
    }
}