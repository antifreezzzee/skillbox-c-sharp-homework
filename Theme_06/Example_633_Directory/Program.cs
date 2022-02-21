using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_633_Directory
{
    class Program
    {

        /// <summary>
        /// Получение всех файлов и папок выбранного каталога
        /// </summary>
        /// <param name="path">Путь к каталогу</param>
        /// <param name="trim">Количество отступов</param>
        static void GetDir(string path, string trim = "")
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);  // Получаем информацию о текущем каталоге

            foreach (var item in directoryInfo.GetDirectories())    // Перебираем все подкаталоги текущего каталога
            {
                Console.WriteLine($"{trim}{item.Name}");            // Выводим информацию о нём
                GetDir(item.FullName, trim + "    ");               // Запускаем "просмотре" вложенного каталога
            }

            foreach (var item in directoryInfo.GetFiles())          // Перебираем все файлы текущего каталога
            {
                Console.WriteLine($"{trim}{item.Name}");            // Выводим информацию о них
            }
        }

        static void Main(string[] args)
        {
            #region Directory, DirectoryInfo

            // using System.IO;
            // Предоставляет статические методы для создания, перемещения и перечисления в каталогах и вложенных каталогах. 

            //Directory.CreateDirectory
            //Directory.Delete
            //Directory.Exists
            //Directory.Move


            DirectoryInfo directoryInfo = new DirectoryInfo(@"c:\");

            //directoryInfo.Attributes
            //directoryInfo.Create
            //directoryInfo.Delete
            //directoryInfo.Exists
            //directoryInfo.FullName
            //directoryInfo.Name
            //directoryInfo.Root
            //directoryInfo.GetDirectories
            //directoryInfo.GetFiles

            GetDir(@"D:\ Work\Skill");
            //GetDir(@"C:\Program Files\Windows Defender");



            #endregion
        }
    }
}
