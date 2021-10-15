using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Мы узнаем о

// 1. Считывании данных с консоли
// 2. Генераторе псевдослучайных чисел
// 3. Практическом применение логического типа 
// 4. Условном операторе (сокращённая форма)
// 5. Условном операторе (полная форма)
// 6. Условном операторе (каскады условий)

#endregion

namespace Example_000_DataRead
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вывод данных
            string name = "Билл Гейтс";
            byte age = 63;
            ushort costs = 118;

            #region _
            //Ввод данных

            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();

            Console.WriteLine("Введите возраст: ");
            age = byte.Parse(Console.ReadLine());

            Console.WriteLine("Введите сумму ежемесячных трат: ");
            costs = Convert.ToUInt16(Console.ReadLine());

            #endregion

            Console.WriteLine("Имя: " + name + " Возраст: " + age + " Расходы: $" + costs); // конкатенация строк
            Console.WriteLine("Имя: {0} Возраст: {1} Расходы: ${2}", name, age, costs);     // форматированный вывод
            Console.WriteLine($"Имя: {name} Возраст: {age} Расходы: ${costs}");             // интерполяция строк

            Console.ReadKey();


        }
    }
}
