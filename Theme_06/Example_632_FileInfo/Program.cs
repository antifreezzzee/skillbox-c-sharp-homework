using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_632_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FileInfo

            //using System.IO;
            // Предоставляет свойства и методы экземпляра для создания, копирования, удаления,
            // перемещения и открытия файлов, а также позволяет создавать объекты System.IO.FileStream.
            // Этот класс не наследуется. Просмотреть исходный код .NET Framework для этого
            // типа Reference Source.

            FileInfo fileInfo = new FileInfo(@"E:\data.txt");

            Console.WriteLine(fileInfo.Attributes);     // Archive
            Console.WriteLine(fileInfo.Exists);         // True
            Console.WriteLine(fileInfo.Extension);      // .txt
            Console.WriteLine(fileInfo.IsReadOnly);     // False
            Console.WriteLine(fileInfo.LastAccessTime); // 22.08.2025 18:52:14
            Console.WriteLine(fileInfo.LastWriteTime);  // 22.08.2025 18:52:14

            Console.WriteLine(fileInfo.FullName);       // E:\data.txt
            Console.WriteLine(fileInfo.Name);           // data.txt
            Console.WriteLine(fileInfo.DirectoryName);  // E:\

            #endregion
        }
    }
}
