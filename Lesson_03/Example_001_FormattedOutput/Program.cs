using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_001_FormattedOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Составное форматирование
            string firstName = "Александр";
            string lastName = "Пушкин";
            string specialization = "Писатель";

            byte age = 37;
            ulong yearOfBirth = 1799;

            // АлександрПушкинПисатель371799
            Console.WriteLine(firstName + lastName + specialization + age + yearOfBirth);
            Console.ReadKey();


            // Александр Пушкин Писатель 37 1799
            Console.WriteLine(firstName + " " + lastName + " " + specialization + " " + age + " " + yearOfBirth);
            Console.ReadKey();

            // Имя: Александр Фамилия: Пушкин Специализация: Писатель Возраст: 37 Год рождения:1799
            Console.WriteLine("Имя: " + firstName + " Фамилия: " + lastName + " Специализация: " + specialization + " Возраст: " + age + " Год рождения: " + yearOfBirth);
            Console.ReadKey();

            // Имя: Александр Фамилия: Пушкин Специализация: Писатель Возраст: 37 Год рождения:1799
            Console.WriteLine("Имя: {0} Фамилия: {1} Специализация: {2} Возраст: {3} Год рождения: {4}",
                               firstName,
                               lastName,
                               specialization,
                               age,
                               yearOfBirth);
            Console.ReadKey();

            // Имя: Александр Фамилия: Пушкин Специализация: Писатель Возраст: 37 Год рождения:1799

            string pattern = "Имя: {0} Фамилия: {1} Специализация: {2} Возраст: {3} Год рождения: {4}";
            Console.WriteLine(pattern,
                              firstName,
                              lastName,
                              specialization,
                              age,
                              yearOfBirth);


            #region переиспользование pattern

            string fName = "Ада";
            string lName = "Лавлейс";
            string profession = "Программист";

            byte years = 37;
            ulong birth = 1815;

            Console.WriteLine(pattern,
                              fName,
                              lName,
                              profession,
                              years,
                              birth);


            #endregion


        }
    }
}
