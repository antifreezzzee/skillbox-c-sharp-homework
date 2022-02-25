using System;
using System.IO;
using System.Text;

namespace Homework_07
{
    public struct Repository
    {
        #region Переменные

        private String filePath;
        private Staff[] staffsArray;
        private Staff[] staffsSortedArray;
        private String[] staffsLinesArray;

        #endregion

        //Конструктор для хранилища, принимающий аргументом имя файла базы данных
        public Repository(string FilePath)
        {
            filePath = FilePath;
            staffsArray = null;
            staffsLinesArray = null;
            staffsSortedArray = null;
        }

        #region Методы

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
                //Если строка пустая, игнорируем
                if (linesFromFile[i] == "")
                {
                    continue;
                }

                //Делим строку через разделитель и заносим строковые и числовые данные в переменные
                String[] currentLineStaffData = linesFromFile[i].Split('#');
                int currentStaffID = Convert.ToInt32(currentLineStaffData[0]);
                String currentStaffName = currentLineStaffData[2];
                int currentStaffAge = Convert.ToInt32(currentLineStaffData[3]);
                int currentStaffHeight = Convert.ToInt32(currentLineStaffData[4]);
                String currentStaffBPlace = currentLineStaffData[6];

                //Парсим строку дня рождения и даты создания в DateTime
                DateTime currentStaffAddDateTime = DateTime.Parse(currentLineStaffData[1] + ":00");
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
        public void saveFile()
        {
            StringBuilder toWrite = new StringBuilder("");
            for (int i = 0; i < staffsLinesArray.Length; i++)
            {
                toWrite.Append(staffsLinesArray[i]);
                if (i < staffsLinesArray.Length - 1)
                {
                    toWrite.Append("\n");
                }
            }

            // Console.WriteLine("СТРОКА К СОХРАНЕНИЮ\n\n" + toWrite);
            // Console.ReadKey();
            File.WriteAllLines(filePath, staffsLinesArray);
        }

        //Метод, добавляющий сотрудника в файл базы данных
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
            newStaff.Append(id).Append("#").Append(DateTime.Now.ToString("dd.MM.yyyy HH:mm")).Append("#").Append(name)
                .Append("#").Append(age)
                .Append("#").Append(height).Append("#").Append(bDay).Append("#").Append(bCountry);

            //Добавляем строку в конец файла и предлагаем добавить еще одного сотрудника
            File.AppendAllText(filePath, newStaff.ToString());

            //Перезаполняем массив структур Staff с учетом изменения
            fillStaffsArray();

            //Удаляем структуры, появившиеся из пустых строк
            for (int i = 0; i < staffsArray.Length; i++)
            {
                if (staffsArray[i].ID == 0)
                {
                    deleteData(0);
                }
            }

            //Перезаполняем массив строковых представлений структур и сохраняем файл
            fillStaffsLinesArray();
            saveFile();

            //Предлагаем добавить еще
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
                $"\n{"ID",3}{"Дата добавления",17}{"Сотрудник",25}{"Возраст",10}{"Рост",7}{"Дата рождения",16}{"Место рождения",25}\n");
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

        //Перегрузка, выводящая сортированную базу данных в консоль
        public void showData(Staff[] staffsList)
        {
            printTableTitle();
            foreach (var staff in staffsList)
            {
                staff.printStaff();
            }
        }

        //Перегрузка, выводящая записи из диапазона дат
        public void showData(String from, String until)
        {
            //Парсим из входных данных границы дат
            DateTime fromDate = DateTime.Parse(from);
            DateTime untilDate = DateTime.Parse(until);
            printTableTitle();

            //Флаг, показывающий есть ли результаты для вывода
            bool empty = true;

            //Проходим по массиву сотрудников и выясняем,
            //подходит ли текущий элемент по параметрам
            foreach (var staff in staffsArray)
            {
                if (staff.addDate > fromDate && staff.addDate < untilDate)
                {
                    staff.printStaff();

                    //Если есть хоть один подходящий элемент,
                    //меняем флаг
                    empty = false;
                }
            }

            //Если нет результатов, сообщаем
            if (empty)
            {
                Console.WriteLine("Нет данных за период");
            }
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

            //Создем массив для хранения нового списка строк данных сотрудников
            //и последующей записи их в файл базы данных
            String[] newStaffLines = new String[trimStaffArray.Length];

            //Проходим по новому массиву сотрудников после удаления, исправляем у всего списка ID
            //и добавляем сотрудника с исправленным ID в вышесозданный массив
            for (int i = 0; i < trimStaffArray.Length; i++)
            {
                trimStaffArray[i].ID = i + 1;
                newStaffLines[i] = trimStaffArray[i].convertStaffToString();
            }


            staffsLinesArray = newStaffLines;
            fillStaffsArray();
            //Сохраняем файл. Запись удалена, все ID на месте и идут по порядку
            saveFile();
            showData();
        }

        //Метод, позволяющий изменить данные сотрудника по ID
        public void changeData(int ID)
        {
            String mode = "";
            while (true)
            {
                //Узнаем что нужно поменять и записываем в переменную mode.
                //Если ввод неверный, просим повторить
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

            //Находим нужный элемент по ID и предлагаем ввести новые данные
            //для выбранного поля
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

            //Обновляем массив строк и сохраняем файл
            fillStaffsLinesArray();
            saveFile();
            showData();
        }

        //Метод, позволяющий отсортировать базу данных по возрастанию или убыванию
        public Staff[] sortByDate(bool up)
        {
            //Читаем актуальные данные из файла
            fillStaffsArray();

            //Инициализируем массив для хранения сортированных данных и копируем в него 
            //исходный список
            staffsSortedArray = new Staff[staffsArray.Length];
            Array.Copy(staffsArray, staffsSortedArray, staffsArray.Length);

            //Сортируем массив сотрудников по возрастанию даты добавления методом выбора

            //Проход по всему массиву, за исключением последнего элемента, который некуда переставлять
            for (int i = 0; i < staffsSortedArray.Length - 1; i++)
            {
                //Назначаем элемент массива, в который будем считать минимальным
                Staff min = staffsSortedArray[i];

                //Проход по несортированной части массива и поиск фактического минимального значения
                for (int j = i + 1; j < staffsSortedArray.Length; j++)
                {
                    //Сравниваем дату добавления текущего элемента итерации цикла и элемента назначенного минимальным
                    //Если текущий элемент имеет более раннюю дату, то назначаем минимальным его
                    if (staffsSortedArray[j].addDate < min.addDate) min = staffsSortedArray[j];
                }

                //Проход по несортированной части массива с перестановкой элемента, назначенного минимальным на первый фактически минимальный 
                for (int j = i + 1; j < staffsSortedArray.Length; j++)
                {
                    if (staffsSortedArray[j].addDate == min.addDate)
                    {
                        Staff temp = staffsSortedArray[i];
                        staffsSortedArray[i] = staffsSortedArray[j];
                        staffsSortedArray[j] = temp;
                        break;
                    }
                }
            }

            //Если флаг установлен в false, инвертируем результат
            if (!up)
            {
                Array.Reverse(staffsSortedArray);
            }

            return staffsSortedArray;
        }

        #endregion
    }
}