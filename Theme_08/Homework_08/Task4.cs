using System;
using System.Xml.Linq;

namespace Homework_08
{
    public class Task4
    {
        #region Строковые константы

        private const string EnterName = "Введите ФИО:";
        private const string EnterStreet = "Введите улицу:";
        private const string EnterHouseNumber = "Введите номер дома:";
        private const string EnterFlatNumber = "Введите номер квартиры:";
        private const string EnterMobilePhone = "Введите мобильный телефон:";
        private const string EnterFlatPhone = "Введите домашний телефон:";
        private const string WrongInput = "Неверный ввод";

        #endregion
        /// <summary>
        /// Создание Xml файла, содержащего данные о контакте
        /// </summary>
        private static void CreateXMLPerson()
        {
            XElement elementPerson = new XElement("Person");
            Console.WriteLine($"{EnterName}");
            string name = Console.ReadLine();
            XAttribute nameAttribute = new XAttribute("name", name);
            XElement elementAddress = new XElement("Address");
            Console.WriteLine($"{EnterStreet}");
            string street = Console.ReadLine();
            XElement elementStreet = new XElement("Street", street);
            XElement elementHouseNumber;
            while (true)
            {
                try
                {
                    Console.WriteLine($"{EnterHouseNumber}");
                    int houseNumber = Convert.ToInt32(Console.ReadLine());
                    elementHouseNumber = new XElement("HouseNumber", houseNumber);
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"{WrongInput}\n");
                    continue;
                }
            }
            XElement elementFlatNumber;
            while (true)
            {
                try
                {
                    Console.WriteLine($"{EnterFlatNumber}");
                    int flatNumber = Convert.ToInt32(Console.ReadLine());
                    elementFlatNumber = new XElement("FlatNumber", flatNumber);
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"{WrongInput}\n");
                    continue;
                }
            }
            XElement elementPhone = new XElement("Phone");
            Console.WriteLine($"{EnterMobilePhone}");
            string mobilePhone = Console.ReadLine();
            XElement elementMobilePhone = new XElement("MobilePhone", mobilePhone);
            Console.WriteLine($"{EnterFlatPhone}");
            string flatPhone = Console.ReadLine();
            XElement elementFlatPhone = new XElement("FlatPhone", flatPhone);
            elementPerson.Add(elementAddress, elementPhone, nameAttribute);
            elementAddress.Add(elementStreet, elementHouseNumber, elementFlatNumber);
            elementPhone.Add(elementMobilePhone, elementFlatPhone);
            elementPerson.Save("person.xml");
        }
        // public static void Main(string[] args)
        // {
        //     CreateXMLPerson();
        // }
    }
}