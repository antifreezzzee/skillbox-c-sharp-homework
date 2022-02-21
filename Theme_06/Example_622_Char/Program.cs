using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_622_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = 'c';
            // Char.IsDigit         // Показывает, относится ли указанный символ Юникода к категории десятичных цифр.
            // Char.IsLetter        // Показывает, относится ли указанный символ Юникода к категории букв Юникода.
            // Char.IsLower         // Показывает, относится ли указанный символ Юникода к категории букв нижнего регистра.
            // Char.IsUpper         // Показывает, относится ли указанный символ Юникода к категории букв верхнего регистра.

            char[] symbols = "symbols".ToCharArray();
            foreach (var item in symbols) Console.Write($"{item} ");

            string s = new String(symbols);


        }
    }
}
