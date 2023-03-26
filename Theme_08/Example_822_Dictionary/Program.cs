using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_822_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Создать частотный словарь 

            List<int> list = new List<int>();

            Random r = new Random();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(r.Next(20));
            }

            var dictionary = new Dictionary<int, int>();

            foreach (var e in list)
            {
                if (!dictionary.ContainsKey(e)) dictionary.Add(e, 0);
                dictionary[e]++;
            }

            foreach (KeyValuePair<int,int> e in dictionary)
            {
                Console.WriteLine($"{e.Key,3} встречается {e.Value,4} р.");
            }

            #endregion
        }
    }
}
