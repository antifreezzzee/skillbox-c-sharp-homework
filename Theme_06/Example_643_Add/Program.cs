using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_643_Add
{
    class Program
    {
        static void Main(string[] args)
        {

            //using (StreamReader sr = new StreamReader("db.txt", Encoding.Unicode))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        var c = sr.Read();
            //        //Console.WriteLine($"{c} - {(char)c}");
            //    }
            //}

            //Console.WriteLine();

            //using (StreamReader sr = new StreamReader("db.txt", Encoding.Unicode))
            //{
            //    Console.WriteLine(sr.ReadToEnd());
            //}



            #region BinaryWriter, BinaryReader

            //Console.WriteLine($"Нажмите Enter для продолжения\n");

            //Console.ReadKey(); Console.Clear();

            //string[] names = { "Юлия", "Ирина", "Светлана", "Екатерина", "Алиса" };

            //string path = @"BinaryNames.dat";


            //using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            //{
            //    // записываем в файл значение каждого поля структуры
            //    foreach (var name in names)
            //    {
            //        writer.Write(name);
            //    }
            //}
            //Console.WriteLine($"Файл {path} успешно создать. Нажмите Enter для продолжения\n");
            //Console.ReadLine();

            //using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            //{
            //    // пока не достигнут конец файла
            //    // считываем каждое значение из файла
            //    while (reader.PeekChar() > -1)
            //    {
            //        string name = reader.ReadString();
            //        Console.WriteLine(name);
            //    }
            //}

            #endregion

            #region FileStream

            //Console.WriteLine($"Нажмите Enter для продолжения\n");

            //Console.ReadKey(); Console.Clear();
            //Console.Write("Введите строку: ");
            //string text = Console.ReadLine();

            //// запись в файл
            //using (FileStream fstream = new FileStream(@"note.txt", FileMode.Create))
            //{
            //    byte[] array = System.Text.Encoding.Default.GetBytes(text); // преобразуем строку в байты
            //    fstream.Write(array, 0, array.Length);                      // запись массива байтов в файл
            //}

            //// чтение из файла
            //using (FileStream fstream = File.OpenRead(@"note.txt"))
            //{

            //    byte[] array = new byte[fstream.Length];    // преобразуем строку в байты

            //    fstream.Read(array, 0, array.Length);       // считываем данные

            //    text = System.Text.Encoding.Default.GetString(array);    // декодируем байты в строку
            //    Console.WriteLine($"Текст : {text}");
            //}

            //Console.ReadLine();

            #endregion

            #region GZipStream

            string source = "voina-i-mir.txt";
            string compressed = "voina-i-mir.zip";
            using (FileStream ss = new FileStream(source, FileMode.OpenOrCreate))
            {
                using (FileStream ts = File.Create(compressed))   // поток для записи сжатого файла
                {
                    // поток архивации
                    using (GZipStream cs = new GZipStream(ts, CompressionMode.Compress))
                    {
                        ss.CopyTo(cs); // копируем байты из одного потока в другой
                        Console.WriteLine("Сжатие файла {0} завершено. Было: {1}  стало: {2}.",
                                          source,
                                          ss.Length,
                                          ts.Length);
                    }
                }
            }

            Console.WriteLine($"Нажмите Enter для продолжения\n");

            Console.ReadKey();


            using (FileStream ss = new FileStream(compressed, FileMode.OpenOrCreate))  // поток для чтения из сжатого файла
            {
                
                using (FileStream ts = File.Create($"{source}_.txt")) // поток для записи восстановленного файла
                {
                    // поток разархивации
                    using (GZipStream ds = new GZipStream(ss, CompressionMode.Decompress))
                    {
                        ds.CopyTo(ts);
                        Console.WriteLine($"{source} восстановлен");

                        Console.WriteLine("Востановление файла {0} завершено. Было: {1}  стало: {2}.",
                                          source,
                                          ss.Length,
                                          ts.Length);
                    }
                }
            }






            #endregion

        }
    }
}