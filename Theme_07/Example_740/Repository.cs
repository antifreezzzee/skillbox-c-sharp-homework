using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_740
{
    struct Repository
    {
        private Worker[] workers;

        private string path;
        
        int index;
        string[] titles;

        public Repository(string Path)
        {
            this.path = Path;
            this.index = 0;
            this.titles = new string[5];
            this.workers = new Worker[2];
        }

        private void Resize(bool Flag)
        {
            if (Flag)
            {
                Array.Resize(ref this.workers, this.workers.Length * 2);
            }
        }

        public void Add(Worker ConcreteWorker)
        {
            this.Resize(index >= this.workers.Length);
            this.workers[index] = ConcreteWorker;
            this.index++;
        }

        public void Load()
        {
            using (StreamReader sr = new StreamReader(this.path))
            {
                titles = sr.ReadLine().Split(',');


                while (!sr.EndOfStream)
                {
                    string[] args = sr.ReadLine().Split(',');

                    Add(new Worker(args[0], args[1], args[2], Convert.ToUInt32(args[3]), args[4]));
                }
            }
        }

        public void PrintDbToConsole()
        {
            Console.WriteLine($"{this.titles[0], 15} {this.titles[1],15} {this.titles[4],15} {this.titles[2],15} {this.titles[3],10}");

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(this.workers[i].Print());
            }
          
        }

        /// <summary>
        /// Количество сотрудников
        /// </summary>
        public int Count { get { return this.index; } }


    }
}
