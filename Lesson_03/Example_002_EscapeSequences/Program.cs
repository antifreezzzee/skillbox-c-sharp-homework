using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_002_EscapeSequences
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = "Александр";
            string lastName = "Пушкин";
            string specialization = "Писатель";

            byte age = 37;
            ulong yearOfBirth = 1799;


            string pattern = "Имя: {0} Фамилия: {1} Специализация: {2} Возраст: {3} Год рождения: {4}";

            #region newPattern

            string newPattern = "Имя: {0} \nФамилия: {1} \nСпециализация: {2} \nВозраст: {3} \nГод рождения: {4}";
            
            #endregion

            Console.WriteLine(newPattern,
                              firstName,
                              lastName,
                              specialization,
                              age,
                              yearOfBirth);

            Console.ReadKey();


            #region Вывод данных Escape-последовательности

            // \n Новая строка
            // \r Возврат каретки
            // \t Горизонтальная табуляция
            // \' Одиночная кавычка
            // \" Двойная кавычка
            // \\ Обратная косая черта
            // \? Литерал вопросительного знака

            #endregion


        }
    }
}
