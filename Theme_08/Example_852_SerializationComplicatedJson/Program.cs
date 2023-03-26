using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_852_SerializationComplicatedJson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parse
          
            //string json = File.ReadAllText("telegram.json");
            //Console.WriteLine(json); Console.ReadLine();Console.Clear();

            //Console.WriteLine(JObject.Parse(json)["ok"].ToString());

            //var messages = JObject.Parse(json)["result"].ToArray();
            //Console.WriteLine();
            //foreach (var item in messages)
            //{
            //    Console.WriteLine(item["message"]["message_id"].ToString());
            //    Console.WriteLine(item["message"]["text"].ToString());
            //    Console.WriteLine(item["message"]["chat"]["username"].ToString());
            //    Console.WriteLine();
            //}

            //Console.ReadLine(); Console.Clear();
            #endregion

            #region Create
           

            //JArray array = new JArray();

            //JObject mainTree = new JObject();
            

            //mainTree["ok"] = true;

            //JObject o = new JObject();
            //o["update_id"] = 1880746;
            //o["message_id"] = 886;

            //array.Add(o);
            //array.Add(o);
            //array.Add(o);

            //mainTree["messages"] = array;

            //JObject userObj = new JObject();
            //userObj["id"] = 220310598;
            //userObj["first_name"] = "С.K.";
            //userObj["username"] = "sk";

            //mainTree["user"] = userObj;


            //string json = mainTree.ToString();

            //Console.WriteLine(json);

            #endregion

            #region _

            List<Worker> list = new List<Worker>();

            JObject data = new JObject();
            JArray jArray = new JArray();

            for (uint i = 1; i <= 5; i++)
            {
                JObject obj = new JObject
                {
                    ["FirstName"] = $"Имя_{i}",
                    ["LastName"] = $"Фамилия_{i}",
                    ["Position"] = $"Должность_{i}",
                    ["Department"] = $"Отдел_{i}",
                    ["Salary"] = i * 1000
                };

                jArray.Add(obj);
            }

            Console.WriteLine(jArray.ToString());



            #endregion

        }
    }
}
