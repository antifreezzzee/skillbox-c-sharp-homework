using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_002_IncrementAndDecrement
{
    class Program
    {
        static void Main(string[] args)
        {

            #region +=
            //Console.ReadKey(); Console.WriteLine("\n+=");

            //int a = 2_000_000_000;
            //int b = 2_000_000_000;
            //int c = a + b;
            //Console.WriteLine(c);  // 25

            //a = a + b;
            //a += b;
            
            //Console.WriteLine(a);  // 25

            #endregion

            #region -=
            Console.ReadKey(); Console.WriteLine("\n-=");

            int a = 12;
            int b = 13;
            int c = a - b;

            Console.WriteLine(c);  // -1

            //a = a - b;
            a -= b; 

            Console.WriteLine(a);  // -1

            #endregion

            #region *=
            Console.ReadKey(); Console.WriteLine("\n*=");

            a = 4;
            b = 5;
            c = a * b;

            Console.WriteLine(c);  // 20

            //a = a * b;
            a *= b; 

            Console.WriteLine(a);  // 20

            #endregion

            #region /=
            Console.ReadKey(); Console.WriteLine("\n/=");

            a = 33;
            b = 11;
            c = a / b;

            Console.WriteLine(c);  // 3

            //a = a / b;
            a /= b;

            Console.WriteLine(a);  // 3

            a = 30;
            b = 11;
            c = a / b;
            Console.WriteLine(c); //2

            a /= b;
            Console.WriteLine(a); //2

            double d = 10;
            double e = 4;
            d /= e;
            Console.WriteLine(d); //2.5

            #endregion

            #region %=
            Console.ReadKey(); Console.WriteLine("\n%=");

            a = 14;
            b = 5;
            c = a % b;

            Console.WriteLine(c);  // 4

            //a = a % b;
            a %= b;

            Console.WriteLine(a);  // 4

            #endregion


            #region ++

            Console.ReadKey(); Console.WriteLine("\n++");

            a = 10;

            a += 20;
            Console.WriteLine(a); //30

            a += 1;
            Console.WriteLine(a); //31

            a++; // постфиксный инкремент
            Console.WriteLine(a); //32

            ++a;// префиксный инкремент
            Console.WriteLine(a); //33



            #endregion

            #region --
            Console.ReadKey(); Console.WriteLine("\n--");
            a = 50;

            a -= 20;
            Console.WriteLine(a); //30

            a -= 1;
            Console.WriteLine(a); //29

            a--; // постфиксный инкремент
            Console.WriteLine(a); //28

            --a;// префиксный инкремент
            Console.WriteLine(a); //27

            #endregion



        }
    }
}
