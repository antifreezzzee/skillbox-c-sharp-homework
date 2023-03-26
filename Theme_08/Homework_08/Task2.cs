using System;
using System.Collections.Generic;

namespace Homework_08
{
    public class Task2
    {
        #region Строковые константы

        private const string EnterPhone = "Введите номер телефона или нажмите Enter для отмены:";
        private const string EnterName = "Введите ФИО или нажмите Enter для отмены:";
        private const string SearchOwner = "Введите номер телефона для поиска владельца или нажмите Enter для отмены:";
        private const string OwnerNotExist = "Владельца по такому номеру телефона не зарегистрировано";
        private const string OwnerName = "Владелец номера:";

        #endregion
        /// <summary>
        /// Заполнение данных телефонного справочника
        /// </summary>
        /// <param name="dictionary">Справочник, который нужно заполнить</param>
        private static void FillDictionary(Dictionary<string, string> dictionary)
        {
            while (true)
            {
                Console.Write($"{EnterPhone}\n");
                string phone = Console.ReadLine();
                if (phone == "") break;
                Console.Write($"{EnterName}\n");
                string name = Console.ReadLine();
                if (name == "") break;
                dictionary.Add(phone, name);
            }
        }
        /// <summary>
        /// Поиск данных в телефонном справочнике
        /// </summary>
        /// <param name="dictionary">Справочник, в котором производится поиск</param>
        private static void SearchPhoneOwner(Dictionary<string, string> dictionary)
        {
            while (true)
            {
                Console.Write($"{SearchOwner}\n");
                string phone = Console.ReadLine();
                if (phone == "") break;
                dictionary.TryGetValue(phone, out string owner);
                if (owner == null) Console.Write($"{OwnerNotExist}\n");
                else Console.Write($"{OwnerName} {owner}\n");
            }
        }
        // public static void Main(string[] args)
        // {
        //     Dictionary<string, string> phoneDictionary = new Dictionary<string, string>();
        //     FillDictionary(phoneDictionary);
        //     SearchPhoneOwner(phoneDictionary);
        // }
    }
}