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
            
            // repository.showData();
            // repository.showData(1);
            // repository.deleteData(1);
            repository.showData();
            Console.ReadKey();
            repository.changeData(3);
            Console.ReadKey();

        }
    }
}
