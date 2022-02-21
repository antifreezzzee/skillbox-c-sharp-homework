using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Example_641_Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ролик 4.Работа с потоками: StreamWriter и StreamReader
            var dirs = new DirectoryInfo(@"c:\").GetDirectories();  // dirs хранит все каталоги диска C:\

            StreamWriter streamWriter = new StreamWriter("cDirs.txt");  // Создание "потока" для работы с файлом cDirs.txt

            foreach (DirectoryInfo dir in dirs)
            {
                streamWriter.WriteLine(dir.FullName);   // Записать текущее имя каталога в файл
                Console.WriteLine($">> {dir.FullName}");
            }

            Console.ReadKey();
            streamWriter.Flush();
            streamWriter.Close();                   // Закрываем "поток"

            // Замечание 1. После работы с поток обязательно нужно закрыть при помощи void Close();
            // или хотя бы записать в файл текущие данные, находящиеся в буфере при помощи void Flush();
            // streamWriter.Flush();

            // Замечание 2. StreamWriter разработан для вывода символов в определенной кодировке, 
            // тогда как классы, производные от Stream предназначены для ввода и вывода байтов.

            // Замечание 3. Для более удобной работы с потоками (в общем случае и не только) в C# есть 
            // оператор using предоставляющий удобный синтаксис, обеспечивающий правильное использование объектов IDisposable
            //
            //using (StreamWriter sw = new StreamWriter("cDirs.txt"))  // Создание "потока" для работы с файлом cDirs.txt
            //{
            //    foreach (DirectoryInfo dir in dirs)
            //    {
            //        sw.WriteLine(dir.Name);   // Записать текущее имя каталога в файл
            //    }
            //}


            // Поток для чтения

            using (StreamReader sr = new StreamReader("cDirs.txt"))  // Создание "потока" для работы с файлом cDirs.txt
            {
                while(!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());   // Записать текущее имя каталога в файл
                }
            }

        }
    }
}
