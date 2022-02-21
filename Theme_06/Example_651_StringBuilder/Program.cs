using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_651_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Проблема string

            //string s1 = "Првет";
            //string s2 = s1.Insert(2, "и");
            //Console.WriteLine($"s1 = {s1}, s2 = {s2}");
            //Console.WriteLine("Объём выделенной памяти");
            //Console.WriteLine($"s1 = {s1.Length * 2} байт, s2 = {s2.Length * 2} байт");
            //Console.WriteLine(s1[1]);
            //s1[1] = '!';

            #endregion

            #region StringBuilder

            // using System.Text;
            // StringBuilder // Предоставляет изменяемую строку символов.

            StringBuilder sb1 = new StringBuilder("Првет");
            Console.WriteLine($"\nДлина sb1 = {sb1.Length}");
            Console.WriteLine($"Вместимость sb1 = {sb1.Capacity}");

            StringBuilder sb2 = new StringBuilder(100);
            Console.WriteLine($"\nДлина sb2 = {sb2.Length}");
            Console.WriteLine($"Вместимость sb2 = {sb2.Capacity}");

            //public StringBuilder();
            //  public StringBuilder(int capacity);
            //  public StringBuilder(string value);
            //public StringBuilder(string value, int capacity);
            //public StringBuilder(int capacity, int maxCapacity);
            //public StringBuilder(string value, int startIndex, int length, int capacity);

            sb2.Append("Один "); // Добавляет копию указанной строки к данному экземпляру.
            Console.WriteLine($"\nsb2 = {sb2}, sb2.Length = {sb2.Length}, sb2.Capacity = {sb2.Capacity}");

            sb2.AppendFormat("{0} {1} ", "Два", "Три"); // Добавляет к данному экземпляру строку, возвращаемую в результате обработки строки
                                                       // составного формата

            Console.WriteLine($"\nsb2 = {sb2}, sb2.Length = {sb2.Length}, sb2.Capacity = {sb2.Capacity}");

            sb2.AppendLine(); // Добавляет знак завершения строки по умолчанию в конец
            Console.WriteLine($"\nsb2 = {sb2}, sb2.Length = {sb2.Length}, sb2.Capacity = {sb2.Capacity}");

            sb2.AppendLine("Четыре"); // Добавляет копию указанной строки и знак завершения строки по умолчанию в конец
                                      // текущего объекта 
            Console.WriteLine($"\nsb2 = {sb2}, sb2.Length = {sb2.Length}, sb2.Capacity = {sb2.Capacity}");


            sb2.Remove(14, 9); // Удаляет указанный диапазон символов из данного экземпляра.
            Console.WriteLine(sb2);

            sb2.Replace('Д', 'д'); // Замещает все вхождения указанного символа в данном экземпляре на другой указанный знак.
            sb2.Replace('Т', 'т'); // Замещает все вхождения указанного символа в данном экземпляре на другой указанный знак.
            sb2.Replace('О', 'о'); // Замещает все вхождения указанного символа в данном экземпляре на другой указанный знак.
            //public StringBuilder Replace(string oldValue, string newValue);
            //public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count);
            //public StringBuilder Replace(char oldChar, char newChar);
            //public StringBuilder Replace(char oldChar, char newChar, int startIndex, int count);

            sb2[4] = '!';

            Console.WriteLine(sb2);


            #endregion

            #region Рекомендации по использованию 

            //String StringBuilder
            // Небольшом количество операций и изменений элементов строки
            // Когда требуется выполнять поиск, например IndexOf, т е StringBuilder не имеет подобных методов.

            // 
            // Если неизвестно количество операций, которые будут произвоится над строками в процессе работы программы


            #endregion


        }
    }
}
