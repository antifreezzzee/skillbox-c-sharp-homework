using System;
using System.Collections.Generic;

namespace Homework_08
{
    public class Task3
    {
        #region Строковые константы

        private const string EnterValue = "Введите число, чтобы добавить его в HashSet или нажмите Enter, чтобы завершить ввод:";
        private const string WrongInput = "Неверный ввод";
        private const string ContainsValue = "Такое число уже содержится в HashSet";
        private const string NotContainsValue = "Число добавлено в HashSet";
        private const string Total = "Итоговый HashSet:";
        
        #endregion
        /// <summary>
        /// Добавление значения в HashSet
        /// </summary>
        /// <param name="hashSet">HashSet, который нужно заполнить</param>
        private static void AddValueToHashSet(HashSet<double> hashSet)
        {
            while (true)
            {
                Console.Write($"{EnterValue}\n");
                string enteredString = Console.ReadLine();
                if (enteredString == "") break;
                double enteredValue;
                try
                {
                    enteredValue = Convert.ToDouble(enteredString);
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"{WrongInput}\n");
                    continue;
                }
                if (hashSet.Contains(enteredValue)) Console.WriteLine($"{ContainsValue}\n");
                else
                {
                    hashSet.Add(enteredValue);
                    Console.WriteLine($"{NotContainsValue}\n");
                }
            }
        }
        /// <summary>
        /// Вывод результата в консоль
        /// </summary>
        /// <param name="hashSet">HashSet, который нужно вывести</param>
        private static void PrintHashSet(HashSet<double> hashSet)
        {
            Console.Write($"{Total}\n");
            foreach (var value in hashSet)
            {
                Console.Write($"{value} ");
            }
        }
        // public static void Main(string[] args)
        // {
        //     HashSet<double> hashSet = new HashSet<double>();
        //     AddValueToHashSet(hashSet);
        //     PrintHashSet(hashSet);
        // }
    }
}