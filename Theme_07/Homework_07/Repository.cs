using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace Homework_07
{
    public struct Repository
    {
        private String filePath;
        private Staff[] staffsArray;
        private String[] staffsLinesArray;

        //Конструктор для хранилища, принимающий аргументом имя файла базы данных
        public Repository(string FilePath)
        {
            filePath = FilePath;
            staffsArray = null;
            staffsLinesArray = null;
        }

        //Метод, читающий в файле базы данных все строки и возвращающий их в виде массива
        public String[] readFile()
        {
            return File.ReadAllLines(filePath);
        }

        //Метод, преобразующий каждую строку из файла базы данных в экземпляр структуры Staff 
        //и заносящий его в массив структур
        public void fillStaffsArray()
        {
            //Получаем массив строк из файла
            String[] linesFromFile = readFile();

            //На основании количества строк, создаем массив для хранения экземпляров структуры Staff
            staffsArray = new Staff[linesFromFile.Length];

            //Проходим по каждой строке
            for (int i = 0; i < linesFromFile.Length; i++)
            {
                //Делим строку через разделитель и заносим строковые и числовые данные в переменные
                String[] currentLineStaffData = linesFromFile[i].Split('#');
                int currentStaffID = Convert.ToInt32(currentLineStaffData[0]);
                String currentStaffName = currentLineStaffData[2];
                int currentStaffAge = Convert.ToInt32(currentLineStaffData[3]);
                int currentStaffHeight = Convert.ToInt32(currentLineStaffData[4]);
                String currentStaffBPlace = currentLineStaffData[6];

                //Здесь скорее всего написан дичайший костыль, но я не смог на данном этапе
                //в документации найти более правильное решение. Поэтому делим дату создания на отдельные
                //цифры и из них заново собираем DateTime
                String[] addDataTimeArray = currentLineStaffData[1].Split('.', ' ', ':');
                DateTime currentStaffAddDateTime = new DateTime(Convert.ToInt32(addDataTimeArray[2]),
                    Convert.ToInt32(addDataTimeArray[1]), Convert.ToInt32(addDataTimeArray[0]),
                    Convert.ToInt32(addDataTimeArray[3]), Convert.ToInt32(addDataTimeArray[4]), 0);
                String[] bDayTimeArray = currentLineStaffData[5].Split('.');
                
                //Парсим строку дня рождения в DateTime
                DateTime currentStaffBDayDateTime = DateTime.Parse(currentLineStaffData[5]);

                //Создаем экземпляр структуры, передавая в конструктор полученные выше переменные 
                //и заносим в массив структур
                staffsArray[i] = new Staff(currentStaffID, currentStaffAddDateTime, currentStaffName, currentStaffAge,
                    currentStaffHeight, currentStaffBDayDateTime, currentStaffBPlace);
            }
        }

        //Метод, преобразующий экземпляры из массива структур в массив валидных строк 
        //для записи в файл базы данных
        public void fillStaffsLinesArray()
        {
            //На основании количества экземпляров структуры Staff, создаем массив для хранения строк
            staffsLinesArray = new String[staffsArray.Length];
            
            //Проходим по всем экземплярам и с помощью геттеров формируем строку
            for (int i = 0; i < staffsLinesArray.Length; i++)
            {
                StringBuilder newStaffLine = new StringBuilder("");
                newStaffLine.Append(staffsArray[i].ID).Append("#")
                    .Append(staffsArray[i].addDate.ToString("dd.MM.yyyy HH:mm"))
                    .Append("#").Append(staffsArray[i].name).Append("#").Append(staffsArray[i].age)
                    .Append("#").Append(staffsArray[i].heigth).Append("#")
                    .Append(staffsArray[i].bDay.ToString("dd.MM.yyyy"))
                    .Append("#").Append(staffsArray[i].bPlace);
                
                //Добавляем строку в массив
                staffsLinesArray[i] = newStaffLine.ToString();
            }
        }

        //Метод, сохраняющий массив строк в файл базы данных
        public void saveFile(String[] staffsArray)
        {
            File.WriteAllLines(filePath, staffsArray);
        }

        //Метод, добавляющий сотрудника в базу данных
        public void addData()
        {
            //Создаем переменные и заполняем их данные
            Console.WriteLine("Введите имя сотрудника: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            string age = Console.ReadLine();
            Console.WriteLine("Введите рост: ");
            string height = Console.ReadLine();
            Console.WriteLine("Введите день рождения в формате ДД.ММ.ГГГГ: ");
            string bDay = Console.ReadLine();
            Console.WriteLine("Введите место рождения: ");
            string bCountry = Console.ReadLine();

            //ID сотрудника соответствует номеру строки в файле. Чтобы получить ID очередного соотрудника,
            //необходимо получить массив уже имеющихся строк, узнать его размер и инкрементировать значение 
            int id = readFile().Length + 1;

            //Начинаем формировать новую строку для сотрудника. Сначала переходим на новую строку
            StringBuilder newStaff = new StringBuilder("\n");

            //Затем добавляем введенные данные через разделитель
            newStaff.Append(id).Append("#").Append(DateTime.Now).Append("#").Append(name).Append("#").Append(age)
                .Append("#").Append(height).Append("#").Append(bDay).Append("#").Append(bCountry);

            //Добавляем строку в конец файла и предлагаем добавить еще одного сотрудника
            File.AppendAllText(filePath, newStaff.ToString());
            Console.WriteLine("Сотрудник добавлен. Добавить еще одного? д/н");
            String key = Console.ReadLine();

            //Если пользователь согласен, вводим данные еще раз
            if (key == "д" || key == "Д")
            {
                addData();
            }

            //Если пользователь отказывается, обновляем массив сотрудников из файла и выводим в консоль
            else
            {
                showData();
            }
        }
        
        //Вывод шапки таблицы
        private void printTableTitle()
        {
            Console.WriteLine(
                $"{"ID",3}{"Дата добавления",17}{"Сотрудник",25}{"Возраст",10}{"Рост",7}{"Дата рождения",16}{"Место рождения",25}\n");
        }

        //Метод, выводящий всю базу данных в консоль
        public void showData()
        {
            fillStaffsArray();
            printTableTitle();
            foreach (var staff in staffsArray)
            {
                staff.printStaff();
            }
        }

        //Перегрузка, позволяющая выводить одного сотрудника по ID
        public void showData(int ID)
        {
            fillStaffsArray();
            printTableTitle();
            //Получаем сотрудника по ID. Т.к. индексация массива идет с нуля, а ID c единицы,
            //нужный нам элемент будет находиться по индексу ID - 1
            //Читаем файл и достаем нужную строку.
            Staff staff = staffsArray[ID - 1];
            staff.printStaff();
        }

        //Метод, удаляющий сотрудника из базы данных
        public void deleteData(int ID)
        {
            //Создаем массив сотрудников, который будет вмещать на один элемент меньше, чем текущий
            Staff[] trimStaffArray = new Staff[staffsArray.Length - 1];

            //Создаем счетчик, для этого массива
            int j = 0;

            //Проходим по изначальному массиву
            for (int i = 0; i < staffsArray.Length; i++)
            {
                //Если ID текущего сотрудника не совпадает с удаляемым, то добавляем его
                //в новый массив и увеличиваем счетчик
                if (staffsArray[i].ID != ID)
                {
                    trimStaffArray[j] = staffsArray[i];
                    j++;
                }
            }

            //Проходим по новому массиву и исправляем у всего списка ID
            String[] newStaffLines = new String[trimStaffArray.Length];
            for (int i = 0; i < trimStaffArray.Length; i++)
            {
                trimStaffArray[i].ID = i + 1;

                //Теперь нужно обновить данные в файле,
                //чтобы можно было корректно инициализировать
                //массив объектов Staff с учетом изменившихся данных
                //Начинаем формировать новую строку для сотрудника
                StringBuilder newStaffLine = new StringBuilder("");

                //Затем добавляем введенные данные через разделитель
                newStaffLine.Append(trimStaffArray[i].ID).Append("#")
                    .Append(trimStaffArray[i].addDate.ToString("dd.MM.yyyy HH:mm"))
                    .Append("#").Append(trimStaffArray[i].name).Append("#").Append(trimStaffArray[i].age)
                    .Append("#").Append(trimStaffArray[i].heigth).Append("#")
                    .Append(trimStaffArray[i].bDay.ToString("dd.MM.yyyy"))
                    .Append("#").Append(trimStaffArray[i].bPlace);

                //Добавляем отредактированного сотрудника в массив новых строк
                newStaffLines[i] = newStaffLine.ToString();
            }

            //Сохраняем файл. Запись удалена, все ID на месте и идут по порядку
            saveFile(newStaffLines);
        }

        //Метод, позволяющий изменить данные сотрудника по ID
        public void changeData(int ID)
        {
            String mode = "";
            while (true)
            {
                Console.WriteLine("Что вы хотите изменить?\n" +
                                  "1 - имя\n2 - день рождения\n3 - возраст\n4 - рост\n5 - город\nВведите цифру:");
                mode = Console.ReadLine();
                if (mode != "1" && mode != "2" && mode != "3" && mode != "4" && mode != "5")
                {
                    Console.WriteLine("Неверный ввод!\n");
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < staffsArray.Length; i++)
            {
                if (staffsArray[i].ID == ID)
                {
                    switch (mode)
                    {
                        case "1":
                            Console.WriteLine("Введите имя: ");
                            staffsArray[i].name = Console.ReadLine();
                            break;
                        case "2":
                            Console.WriteLine("Введите день рождения в формате ДД.ММ.ГГГГ: ");
                            staffsArray[i].bDay = DateTime.Parse(Console.ReadLine());
                            break;
                        case "3":
                            Console.WriteLine("Введите возраст: ");
                            staffsArray[i].age = Convert.ToInt32(Console.ReadLine());
                            break;
                        case "4":
                            Console.WriteLine("Введите рост: ");
                            staffsArray[i].heigth = Convert.ToInt32(Console.ReadLine());
                            break;
                        case "5":
                            Console.WriteLine("Введите город: ");
                            staffsArray[i].bPlace = Console.ReadLine();
                            break;
                    }
                }
            }
            fillStaffsLinesArray();
            saveFile(staffsLinesArray);
            showData();
        }

        public void sortByDate(bool up)
        {
        }
    }
}