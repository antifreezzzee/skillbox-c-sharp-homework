using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository("db.txt");
            repository.fillStaffsArray();
            bool atWork = true;

            while (atWork)
            {
                Console.WriteLine("\nЧто вы хотите сделать?\n\n" +
                                  "1 - показать всю базу\n" +
                                  "2 - показать сотрудника по ID\n" +
                                  "3 - добавить сотрудника\n" +
                                  "4 - удалить сотрудника по ID\n" +
                                  "5 - редактировать сотрудника по ID\n" +
                                  "6 - показать сотрудников за период\n" +
                                  "7 - показать сортированный список\n" +
                                  "любой другой символ - выход");

                String mode = Console.ReadLine();
                switch (mode)
                {
                    case "1":
                        repository.showData();
                        break;
                    case "2":
                        Console.WriteLine("Введите ID: ");
                        repository.showData(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case "3":
                        repository.addData();
                        break;
                    case "4":
                        Console.WriteLine("Введите ID: ");
                        repository.deleteData(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case "5":
                        Console.WriteLine("Введите ID: ");
                        repository.changeData(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case "6":
                        Console.WriteLine("Введите даты в формате ДД.ММ.ГГГГ ЧЧ:ММ\nначало периода:  ");
                        String from = Console.ReadLine();
                        Console.WriteLine("\nконец периода: ");
                        String until = Console.ReadLine();
                        repository.showData(from, until);
                        break;
                    case "7":
                        Console.WriteLine("Сортировать по возрастанию? д/н: ");
                        String key = Console.ReadLine();
                        if (key == "д" || key == "Д")
                        {
                            repository.showData(repository.sortByDate(true));
                        }
                        else
                        {
                            repository.showData(repository.sortByDate(false));
                        }

                        break;
                    default:
                        atWork = false;
                        break;
                }
            }
        }
    }
}