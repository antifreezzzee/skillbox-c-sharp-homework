using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_813_ListWorker
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>();
            Random rand = new Random();

            for (int i = 1; i <= 10; i++)
            {
                workers.Add(
                    new Worker(
                        $"Имя_{i}", 
                        $"Фамилия_{i}",
                        $"Должность_{i}", 
                        (uint)rand.Next(1000,2000), 
                        $"Отдел_{i}"));
            }

            foreach (var item in workers)
            {
                Console.WriteLine(item.Print());
            }

        }
    }
}
