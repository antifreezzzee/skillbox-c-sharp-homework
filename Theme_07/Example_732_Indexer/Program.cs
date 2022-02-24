using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_732_Indexer
{

    class Program
    {
        static void Main(string[] args)
        {
            //Repository1 db1 = new Repository1(
            //    new Worker("Должность_1", 10000, "Имя_1"),
            //    new Worker("Должность_2", 10000, "Имя_2"),
            //    new Worker("Должность_3", 10000, "Имя_3"),
            //    new Worker("Должность_4", 10000, "Имя_4"),
            //    new Worker("Должность_5", 10000, "Имя_5")
            //    );

            //Console.WriteLine(db1.Workers[0].Print());

            #region db2
            //Repository2 db2 = new Repository2(
            //     new Worker("Должность_1", 10000, "Имя_1"),
            //     new Worker("Должность_2", 10000, "Имя_2"),
            //     new Worker("Должность_3", 10000, "Имя_3"),
            //     new Worker("Должность_4", 10000, "Имя_4"),
            //     new Worker("Должность_5", 10000, "Имя_5")
            //     );


            //Console.WriteLine(db2[0].Print());

            //db2[0] = new Worker("Должность_777", 10000, "Имя_777");

            //Console.WriteLine(db2[0].Print());
            //Console.ReadKey();
            #endregion

            #region db3

            //Repository3 db3 = new Repository3(
            //     new Worker("Должность_1", 10000, "Имя_444"),
            //     new Worker("Должность_2", 10000, "Имя_2"),
            //     new Worker("Должность_3", 10000, "Имя_3"),
            //     new Worker("Должность_4", 10000, "Имя_4"),
            //     new Worker("Должность_5", 10000, "Имя_5")
            //     );


            //Console.WriteLine(db3[0]);


            //Console.ReadKey();
            #endregion

            Repository4 db4 = new Repository4(
                 new Worker("Должность_1", 10000, "Имя_444"),
                 new Worker("Должность_2", 10000, "Имя_2"),
                 new Worker("Должность_3", 10000, "Имя_3"),
                 new Worker("Должность_4", 10000, "Имя_4"),
                 new Worker("Должность_5", 10000, "Имя_5")
                 );


            Console.WriteLine(db4[0]);

            Console.WriteLine(db4["*"]);





        }
    }
}
