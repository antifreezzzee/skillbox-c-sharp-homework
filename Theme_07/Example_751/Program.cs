using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_751
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"data.csv";

            Repository rep = new Repository(path);

            rep.PrintDbToConsole();
            //Console.WriteLine(rep.Count);
            rep.Add(new Worker("Новое Имя", "Новая Фамилия", "Новая должность", 7777, "Новый отдел"));
            //rep.Save("newdata.csv");

            Console.ReadKey();
        }
    }
}
