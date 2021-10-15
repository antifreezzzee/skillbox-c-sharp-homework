using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_004_02Numbers
{
    class Program
    {
        public static string Numbers(int n)
        {
            return n < 10 ? n.ToString() : $"{n % 10} {Numbers(n / 10)}";
        }
        
        static void Main(string[] args)
        {
            //Выведите все цифры натурального числа N по одной
            Console.WriteLine(Numbers(1234654));
        }
    }
}
