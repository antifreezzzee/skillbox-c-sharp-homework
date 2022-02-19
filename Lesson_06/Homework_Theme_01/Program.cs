using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;

            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.

            // 3. Реализовать возможность печатки информации на консоли при помощи 
            //    - обычного вывода;
            //    - форматированного вывода;
            //    - использования интерполяции строк;

            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев

            // **
            // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
            //    возможность вывода данных в центре консоли.

            // Создание переменных:
            // Подразумевается возможность изменения данных, 
            // поэтому начальные значения не задаются, создаются поля
            string name;            // Имя
            int age;                // Возраст
            float height;           // Рост
            int historyScore;       // Балл по истории
            int mathScore;          // Балл по математике
            int rusLangScore;       // Балл по русскому

            // Заполнение переменных значениями:
            name = "Serega";
            age = 26;
            height = 184.5f;
            historyScore = 4;
            mathScore = 5;
            rusLangScore = 5;

            // Автоматический подсчёт среднего балла по трем предметам:
            float averageScore = (historyScore + mathScore + rusLangScore) / 3f;

            // Печать информации на консоли:
            // Обычный вывод:
            Console.WriteLine("Обычный вывод");
            Console.WriteLine("\nИмя: " + name +
                                "\nВозраст: " + age +
                                "\nРост: " + height +
                                "\nБалл по истории: " + historyScore +
                                "\nБалл по математике: " + mathScore +
                                "\nБалл по русскому языку: " + rusLangScore +
                                "\nСредний балл: " + averageScore);
            // Форматированный вывод:
            Console.WriteLine("\n\nФорматированный вывод");
            Console.WriteLine("\nИмя: {0}\nВозраст: {1}\nРост: {2}\nБалл по истории: {3}\nБалл по математике: {4}\nБалл по русскому языку: {5}\nСредний балл: {6}",
                                name, age, height, historyScore, mathScore, rusLangScore, averageScore);

            // Интерполяция строк:
            Console.WriteLine("\n\nИнтерполяция строк");
            Console.WriteLine($"\nИмя: {name}\nВозраст: {age}\nРост: {height}\nБалл по истории: {historyScore}\nБалл по математике: {mathScore}\nБалл по русскому языку: {rusLangScore}\nСредний балл: {averageScore}");

            Console.ReadKey();

            // Вывод по центру консоли:
            // Очищаем консоль:
            Console.Clear();

            // Получаем координаты центра консоли и заносим
            // их в переменные
            // Ширина:
            int centerWidth = Console.WindowWidth / 2;
            // Высота:
            int centerHeight = Console.WindowHeight / 2;

            // Переменные для хранения координат курсора:
            // Для первой строки совпадают с центром консоли
            int cursorX = centerWidth;
            int cursorY = centerHeight;

            // Устанавливаем курсор в эти координаты и
            // печатаем первую строку:
            Console.SetCursorPosition(cursorX, cursorY);
            Console.WriteLine("Вывод по центру консоли");

            // Смещаемся на две строки ниже, чтобы сделать отступ
            // и выводим следующую строку:
            cursorY += 2;
            Console.SetCursorPosition(cursorX, cursorY);
            Console.WriteLine("Имя: " + name);

            // И так для каждой строки:
            cursorY++;
            Console.SetCursorPosition(cursorX, cursorY);
            Console.WriteLine("Возраст: " + age);

            cursorY++;
            Console.SetCursorPosition(cursorX, cursorY);
            Console.WriteLine("Рост: " + height);

            cursorY++;
            Console.SetCursorPosition(cursorX, cursorY);
            Console.WriteLine("Балл по истории: " + historyScore);

            cursorY++;
            Console.SetCursorPosition(cursorX, cursorY);
            Console.WriteLine("Балл по математике: " + mathScore);

            cursorY++;
            Console.SetCursorPosition(cursorX, cursorY);
            Console.WriteLine("Балл по русскому языку: " + rusLangScore);

            cursorY++;
            Console.SetCursorPosition(cursorX, cursorY);
            Console.WriteLine("Средний балл: " + averageScore);

            Console.ReadKey();

        }
    }
}
