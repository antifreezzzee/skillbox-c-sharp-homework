using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Example_621_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ролик 2. Работа со строками: статический класс String, методы экземпляров

            string str = "Visual alusiV";
            Console.WriteLine($"str = {str} ");
            // Возвращает индекс с отсчетом от нуля первого вхождения указанного символа Юникода в данной строке.
            Console.WriteLine($"str.IndexOf('i') = {str.IndexOf('i')}");
            Console.WriteLine($"str.IndexOf('%') = {str.IndexOf('%')}");

            // Возвращает позицию индекса с отсчетом от нуля последнего вхождения указанного
            // символа Юникода в пределах данного экземпляра.
            Console.WriteLine($"str.LastIndexOf('i') = {str.LastIndexOf('i')}");

            // Отсчитываемое от нуля значение индекса параметра value, если этот знак найден;
            // в противном случае — значение -1.
            Console.WriteLine($"str.LastIndexOf('z') = {str.LastIndexOf('z')}");

            // Возвращает новую строку, в которой указанная строка вставляется в указанной позиции
            // индекса в данном экземпляре.
            string s = str.Insert(str.IndexOf(' ') + 1, "C# ");
            Console.WriteLine($"s = {s}");

            // Возвращает новую строку, в которой были удалены все символы, начиная с указанной позиции
            Console.WriteLine($"str.Remove(6) = {str.Remove(6)}");
            // Возвращает новую строку, в которой были удалены все символы, начиная с указанной позиции count элементов
            Console.WriteLine($"str.Remove(6, 3) = {str.Remove(6, 3)}");

            // Возвращает новую строку, в которой все вхождения заданного знака Юникода в текущем
            // экземпляре заменены другим заданным знаком Юникода.
            Console.WriteLine($"str.Replace('a','z') = {str.Replace('a','z')}");


            // Извлекает подстроку из данного экземпляра. Подстрока начинается в указанном положении
            // символов и продолжается до конца строки.
            Console.WriteLine($"str.Substring(4) = {str.Substring(4)}");


            Console.WriteLine($"str.ToUpper() = {str.ToUpper()}");
            Console.WriteLine($"str.ToLower() = {str.ToLower()}");


            //str.Trim();       // Удаляет все начальные и конечные символы-разделители из текущего объекта System.String.
            //str.TrimEnd();    // Удаляет все конечные символы-разделители из текущего объекта System.String.
            //str.TrimStart();  // Удаляет все начальные символы-разделители из текущего объекта System.String.

            // Разбивает строку на подстроки в зависимости от символов в массиве.
            string[] array = "1 2 3 4,5 6;7 8 9;10".Split(' ', ',', ';');


            string test = null;
            
            Console.WriteLine($"String.IsNullOrEmpty(test) = {String.IsNullOrEmpty(test)}");    // True

            test = String.Empty;
            Console.WriteLine($"String.IsNullOrEmpty(test) = {String.IsNullOrEmpty(test)}");    // True

            test = "Skill";
            Console.WriteLine($"String.IsNullOrEmpty(test) = {String.IsNullOrEmpty(test)}");    // False
 
        }
    }
}
