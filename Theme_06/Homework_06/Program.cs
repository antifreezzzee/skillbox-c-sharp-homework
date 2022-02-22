using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06
{
    class Program
    {
        // Создайте справочник «Сотрудники».
        //
        // Разработайте для предполагаемой компании программу, которая будет добавлять записи новых сотрудников
        // в файл.Файл должен содержать следующие данные:
        //
        // ID
        // Дату и время добавления записи
        // Ф.И.О.
        // Возраст
        // Рост
        // Дату рождения
        // Место рождения
        //     
        // Для этого необходим ввод данных с клавиатуры.
        // После ввода данных:
        //
        // если файла не существует, его необходимо создать;
        // если файл существует, то необходимо записать данные сотрудника в конец файла.
        //    
        // При запуске программы должен быть выбор:
        //
        // введём 1 — вывести данные на экран;
        // введём 2 — заполнить данные и добавить новую запись в конец файла.

        //Объявляем глобальные переменные для хранения режима работы и пути к файлу
        static string mode = "";
        static string path = "staff.txt";

        //Данный метод осуществляет вывод сотрудников в консоль
        private static void showStaffs()
        {
            //Переменная для хранения количества сотрудников
            int staffCount = 0;
            
            //Проверяем, существует ли файл
            if (File.Exists(path))
            {
                //Если да, то получаем из него все строки
                string[] staffs = File.ReadAllLines(path);

                //Количество строк соответствует количеству сотрудников
                staffCount = staffs.Length;

                //Если нет ни одной строки, то сообщаеем эту печальную новость пользователю
                if (staffCount == 0)
                {
                    Console.WriteLine("Нет ни одного сотрудника");
                }

                //В ином случае производим вывод
                else
                {
                    //Формируем шапку таблицы
                    Console.WriteLine($"{"ID",3}{"Дата добавления",23}{"Сотрудник",30}{"Возраст",10}{"Рост",7}" +
                                      $"{"Дата рождения",16}{"Место рождения",25}\n");

                    //Проходимся по каждому сотруднику из списка
                    foreach (string staff in staffs)
                    {
                        //Получаем массив данных сотрудника путем дробления строки с помощью разделителя
                        string[] currentStuff = staff.Split('#');
                        {
                            //Выводим данные сотрудника
                            Console.WriteLine($"{currentStuff[0],3}{currentStuff[1],23}{currentStuff[2],30}" +
                                              $"{currentStuff[3],10}{currentStuff[4],7}{currentStuff[5],16}" +
                                              $"{currentStuff[6],25}");
                        }
                    }
                }
                
                //Предлагаем добавить еще одного сотрудника
                Console.WriteLine("Добавить еще одного сотрудника? д/н");
                String key = Console.ReadLine();
                if (key == "д" || key == "Д")
                {
                    addStaff();
                }
            }

            //Если файла не существует, то сообщаеем эту печальную новость пользователю
            else
            {
                Console.WriteLine("Файла не существует! Создать новый файл? д/н");
                String key = Console.ReadLine();
                
                //Если пользователь согласен, вызываем метод добавления
                if (key == "д" || key == "Д")
                {
                    addStaff();
                }
            }
            
           
        }

        //Данный метод осуществляет добавление сотрудников в файл
        private static void addStaff()
        {
            //Создаем переменные и заполняем их данные
            Console.WriteLine("Введите имя сотрудника: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            string age = Console.ReadLine();
            Console.WriteLine("Введите рост: ");
            string height = Console.ReadLine();
            Console.WriteLine("Введите дату рождения: ");
            string bDay = Console.ReadLine();
            Console.WriteLine("Введите место рождения: ");
            string bCountry = Console.ReadLine();
            
            //ID сотрудника соответствует номеру строки в файле. Чтобы получить ID очередного соотрудника,
            //необходимо получить массив уже имеющихся строк, узнать его размер и инкрементировать значение 
            int id = File.ReadAllLines(path).Length + 1;
            
            //Начинаем формировать новую строку для сотрудника. Сначала переходим на новую строку
            StringBuilder newStaff = new StringBuilder("\n");
            
            //Затем добавляем введенные данные через разделитель
            newStaff.Append(id).Append("#").Append(DateTime.Now).Append("#").Append(name).Append("#").Append(age)
                .Append("#").Append(height).Append("#").Append(bDay).Append("#").Append(bCountry);
            
            //Добавляем строку в конец файла и предлагаем добавить еще одного сотрудника
            File.AppendAllText(path, newStaff.ToString());
            Console.WriteLine("Сотрудник добавлен. Добавить еще одного? д/н");
            String key = Console.ReadLine();
            
            //Если пользователь согласен, вводим данные еще раз
            if (key == "д" || key == "Д")
            {
                addStaff();
            }
            
            //Если пользователь отказывается, выводим новый список
            else
            {
                Console.WriteLine("Новый список:");
                showStaffs();
            }

        }

        static void Main(string[] args)
        {
            
            //Предлагаем пользователю ввести режим работы приложения, пока не будут введены корректные данные
            while (true)
            {
                Console.WriteLine("Выберите режим работы:\n\n1 - чтение данных\n2 - запись данных\n\nВведите число: ");
                mode = Console.ReadLine();
                
                //Если ввод неверный, предлагаем повторить
                if (!mode.Equals("1") && !mode.Equals("2"))
                {
                    Console.WriteLine(
                        "Неверный ввод!\n");
                }
                
                //Иначе выходим из цикла
                else
                {
                    break;
                }
            }

            //Проверяем ввод и вызываем соответствующий введенному режиму метод
            if (Convert.ToInt32(mode) == 1)
            {
                showStaffs();
            }
            else
            {
                addStaff();
            }
        }
    }
}