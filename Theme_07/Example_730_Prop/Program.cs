using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_731_Prop
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cat1

            //Cat1 cat1 = new Cat1("Шотландская вислоухая", "Барсик");

            //Console.WriteLine(cat1.Breed);

            //cat1.Breed = "Рэгдолл";

            //Console.WriteLine(cat1.Breed);

            //Console.ReadKey();

            #endregion

            #region Cat2

            //Cat2 cat2 = new Cat2("Шотландская вислоухая", "Барсик");

            //Console.WriteLine(cat2.GetBreed());

            //// cat2.Breed = "Рэгдолл";
            //// Console.WriteLine(cat2.Breed);

            //Console.WriteLine(cat2.GetBreed());

            //Console.ReadKey();

            #endregion

            #region Account1

            Account1 account1 = new Account1("Admin", "qwerty");
            Console.WriteLine(account1.Password);
            Console.ReadKey();
            #endregion

                        
            #region Account2

            Account2 account2 = new Account2("Admin", "qwerty");
            //Console.WriteLine(account2.Password);
            account2.SetPassword("asdfghj");
            Console.ReadKey();

            #endregion

            Cat4 cat4 = new Cat4();
            cat4.Nickname = "Барсик";
            cat4.EyeColor = "Зеленые";
            cat4.EyeColor = "Голубые";
        }
    }
}
