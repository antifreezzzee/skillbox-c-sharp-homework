using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_740
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"data.csv";


            Repository rep = new Repository(path);
            //rep.Load();
            rep.PrintDbToConsole();
            Console.WriteLine(rep.Count);

            rep.Add(new Worker("111","111","111",111,"111"));

            Console.ReadKey();

            rep.PrintDbToConsole();
            Console.WriteLine(rep.Count);


            Console.ReadKey();
             

        }
    }
}
