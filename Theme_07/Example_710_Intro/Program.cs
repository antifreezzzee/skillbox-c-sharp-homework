using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_710_Intro
{

    class Program
    {
        static void Main(string[] args)
        {
            // Структуры и введение в ООП
            // Ролик 1. Структуры: описание, использование

            #region Задание 1. Theme_04 Lesson_08

            // Задание 1. Theme_04 Lesson_08
            // Заказчик просит вас написать приложение по учёту финансов
            // и продемонстрировать его работу.
            // Суть задачи в следующем: 
            // Руководство фирмы по 12 месяцам ведет учет расходов и поступлений средств. 
            // За год получены два массива – расходов и поступлений.
            // Определить прибыли по месяцам
            // Количество месяцев с положительной прибылью.
            // Добавить возможность вывода трех худших показателей по месяцам, с худшей прибылью, 
            // если есть несколько месяцев, в некоторых худшая прибыль совпала - вывести их все.
            // Организовать дружелюбный интерфейс взаимодействия и вывода данных на экран

            // Пример
            //       
            // Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.
            //     1              100 000             80 000                 20 000
            //     2              120 000             90 000                 30 000
            //     3               80 000             70 000                 10 000
            //     4               70 000             70 000                      0
            //     5              100 000             80 000                 20 000
            //     6              200 000            120 000                 80 000
            //     7              130 000            140 000                -10 000
            //     8              150 000             65 000                 85 000
            //     9              190 000             90 000                100 000
            //    10              110 000             70 000                 40 000
            //    11              150 000            120 000                 30 000
            //    12              100 000             80 000                 20 000
            // 
            // Худшая прибыль в месяцах: 7, 4, 1, 5, 12
            // Месяцев с положительной прибылью: 10

            int[] income = new int[12];         // массив хранящий доходы
            int[] consumption = new int[12];    // массив хранящий расходы
            int[] arrived = new int[12];        // массив хранящий прибыль

            #endregion

            #region MonthlyReport

            MonthlyReport january = new MonthlyReport();

            january.Month = "Январь";
            january.Income = 10_000;
            january.consumption = 3_000;
            january.arrived = january.Income - january.consumption;


            // Январь: Доход: 10000 Расход: 3000 Прибыль: 7000
            Console.WriteLine("{0}: Доход: {1} Расход: {2} Прибыль: {3}",
                                january.Month,
                                january.Income,
                                january.consumption,
                                january.arrived);
            #endregion

            #region Worker

            Worker worker = new Worker()
            {
                Position = "Инженер",
                FirstName = "Роберт",
                LastName = "Иванов",
                Salary = 10_000,
                DateOfBirth = new DateTime(1990, 09, 28)
            };

            #endregion

            #region Замечание

            // В Visual Studio 2017 нет шаблона структуры, 
            // поэтому нужно добавить класс, а затем сменить тип вручную.

            #endregion

        }
    }
}
