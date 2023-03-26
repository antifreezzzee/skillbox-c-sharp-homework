using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Example_841_SerializationXml
{
    // Ролик 4. XML:Создание и чтение файлов
    class Program
    {

        /// <summary>
        /// Метод сериализации Worker
        /// </summary>
        /// <param name="СoncreteWorker">Экземпляр для сериализации</param>
        /// <param name="Path">Путь к файлу</param>
        static void SerializeWorker(Worker СoncreteWorker, string Path)
        {
            // Создаем сериализатор на основе указанного типа 
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Worker));
            
            // Создаем поток для сохранения данных
            Stream fStream = new FileStream(Path, FileMode.Create, FileAccess.Write);

            // Запускаем процесс сериализации
            xmlSerializer.Serialize(fStream, СoncreteWorker);

            // Закрываем поток
            fStream.Close();
        }

        /// <summary>
        /// Метод десериализации Worker
        /// </summary>
        /// <param name="СoncreteWorker">Экземпляр для сериализации</param>
        /// <param name="Path">Путь к файлу</param>
        static Worker DeserializeWorker(string Path)
        {
            Worker tempWorker = new Worker();
            // Создаем сериализатор на основе указанного типа 
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Worker));

            // Создаем поток для чтения данных
            Stream fStream = new FileStream(Path, FileMode.Open, FileAccess.Read);

            // Запускаем процесс десериализации
            tempWorker = xmlSerializer.Deserialize(fStream) as Worker;

            // Закрываем поток
            fStream.Close();

            // Возвращаем результат
            return tempWorker;
        }

        /// <summary>
        /// Метод сериализации List<Worker >
        /// </summary>
        /// <param name="СoncreteWorker">Коллекция для сериализации</param>
        /// <param name="Path">Путь к файлу</param>
        static void SerializeWorkerList(List<Worker> СoncreteWorkerList, string Path)
        {
            // Создаем сериализатор на основе указанного типа 
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Worker>));

            // Создаем поток для сохранения данных
            Stream fStream = new FileStream(Path, FileMode.Create, FileAccess.Write);

            // Запускаем процесс сериализации
            xmlSerializer.Serialize(fStream, СoncreteWorkerList);

            // Закрываем поток
            fStream.Close();
        }

        /// <summary>
        /// Метод десериализации Worker
        /// </summary>
        /// <param name="СoncreteWorker">Экземпляр для сериализации</param>
        /// <param name="Path">Путь к файлу</param>
        static List<Worker> DeserializeWorkerList(string Path)
        {
            List<Worker> tempWorkerCol = new List<Worker>();
            // Создаем сериализатор на основе указанного типа 
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Worker>));

            // Создаем поток для чтения данных
            Stream fStream = new FileStream(Path, FileMode.Open, FileAccess.Read);

            // Запускаем процесс десериализации
            tempWorkerCol = xmlSerializer.Deserialize(fStream) as List<Worker>;

            // Закрываем поток
            fStream.Close();

            // Возвращаем результат
            return tempWorkerCol;
        }


        static void Main(string[] args)
        {
            #region Worker

            Worker worker = new Worker("Bill", "Gates", "CEO", uint.MaxValue, "Microsoft Corporation");
            Console.WriteLine(worker.Print());

            SerializeWorker(worker, "_bill.xml");

            worker = DeserializeWorker("_satya.xml");
            Console.WriteLine(worker.Print());

            #endregion

            #region List<Worker>

            List<Worker> list = new List<Worker>();

            for (uint i = 1; i <= 5; i++)
            {
                list.Add(new Worker($"Имя_{i}", $"Фамилия_{i}", $"Должность_{i}", i * 1000, $"Департамент_{i}"));
            }

            SerializeWorkerList(list, "_listWorker.xml");

            list = DeserializeWorkerList("_listWorker.xml");

            #endregion
        }
    }
}
