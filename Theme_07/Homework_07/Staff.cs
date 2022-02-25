using System;
using System.Text;

namespace Homework_07
{
    public struct Staff
    {
        internal int ID { set; get; }
        internal DateTime addDate { set; get; }
        internal String name { set; get; }
        internal int age { set; get; }
        internal int heigth { set; get; }
        internal DateTime bDay { set; get; }
        internal String bPlace { set; get; }
        
        public Staff(int ID, DateTime addDate, string name, int age, int heigth, DateTime bDay, string bPlace)
        {
            this.ID = ID;
            this.addDate = addDate;
            this.name = name;
            this.age = age;
            this.heigth = heigth;
            this.bDay = bDay;
            this.bPlace = bPlace;
        }

        //Вывод данных сотрудника
        public void printStaff()
        {
            Console.WriteLine($"{ID,3}{addDate,17:dd.MM.yyyy HH:mm}{name,25}{age,10}{heigth,7}{bDay,16:dd.MM.yyyy}{bPlace,25}");
        }

        //Преобразование данных сотрудника в валидную строку для записи в файл базы данных
        public String convertStaffToString()
        {
            StringBuilder newStaffLine = new StringBuilder("");
                
            //Затем добавляем введенные данные через разделитель
            newStaffLine.Append(ID).Append("#")
                .Append(addDate.ToString("dd.MM.yyyy HH:mm"))
                .Append("#").Append(name).Append("#").Append(age)
                .Append("#").Append(heigth).Append("#")
                .Append(bDay.ToString("dd.MM.yyyy"))
                .Append("#").Append(bPlace);

            return newStaffLine.ToString();
        }
    }
}