using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_730_Ctor
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker w = new Worker("Программист", 1111, "Иван", "Иванов", new DateTime(1980, 1, 2));
            Console.WriteLine(w.Print());

            w = new Worker("Иван IV");
            Console.WriteLine(w.Print());

        }
    }
}
