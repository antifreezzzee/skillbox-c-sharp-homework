using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_851_SerializationJson
{
    // Ролик 5. JSON:Создание и чтение файлов
    class Program
    {
        static void Main(string[] args)
        {
            // Install-Package Newtonsoft.Json -Version 10.0.3

            #region Worker

            Worker worker = new Worker("Bill", "Gates", "CEO", uint.MaxValue, "Microsoft Corporation");
            Console.WriteLine(worker.Print());

            string json = JsonConvert.SerializeObject(worker);

            File.WriteAllText("_bill.json", json);

            Console.WriteLine();
            json = File.ReadAllText("_satya.json");

            worker = JsonConvert.DeserializeObject<Worker>(json);
            Console.WriteLine(worker.Print());

            #endregion

            #region List<Worker>

            List<Worker> list = new List<Worker>();

            for (uint i = 1; i <= 5; i++)
            {
                list.Add(new Worker($"Имя_{i}", $"Фамилия_{i}", $"Должность_{i}", i * 1000, $"Департамент_{i}"));
            }

            json = JsonConvert.SerializeObject(list);
            File.WriteAllText("_listWorker.json", json);

            json = File.ReadAllText("_listWorker.json");
            list = JsonConvert.DeserializeObject<List<Worker>>(json);

            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine($"{item.LastName}");
            }

            #endregion
        }
    }
}
