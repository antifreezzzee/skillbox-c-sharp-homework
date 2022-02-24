using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_751
{
    /// <summary>
    /// Структура по работе с данными
    /// </summary>
    struct Repository
    {
        private Worker[] workers; // Основной массив для хранения данных

        private string path; // путь к файлу с данными
        
        int index; // текущий элемент для добавления в workers

        string[] titles; // массив, храняий заголовки полей. используется в PrintDbToConsole

        /// <summary>
        /// Констрктор
        /// </summary>
        /// <param name="Path">Путь в файлу с данными</param>
        public Repository(string Path)
        {
            this.path = Path; // Сохранение пути к файлу с данными
            this.index = 0; // текущая позиция для добавления сотрудника в workers
            this.titles = new string[0]; // инициализаия массива заголовков   
            this.workers = new Worker[1]; // инициализаия массива сотрудников.    | изначально предпологаем, что данных нет

            this.Load(); // Загрузка данных
        }

        /// <summary>
        /// Метод увеличения текущего хранилища
        /// </summary>
        /// <param name="Flag">Условие увеличения</param>
        private void Resize(bool Flag)
        {
            if (Flag)
            {
                Array.Resize(ref this.workers, this.workers.Length * 2);
            }
        }

        /// <summary>
        /// Метод добавления сотрудника в хранилище
        /// </summary>
        /// <param name="ConcreteWorker">Сотрудник</param>
        public void Add(Worker ConcreteWorker)
        {
            this.Resize(index >= this.workers.Length);
            this.workers[index] = ConcreteWorker;
            this.index++;
        }

        /// <summary>
        /// Метод загрузки данных
        /// </summary>
        private void Load()
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
        
        /// <summary>
        /// Метод сохранения данных
        /// </summary>
        /// <param name="Path">Путь к файлу сохранения</param>
        public void Save(string Path)
        {
            string temp = String.Format("{0},{1},{2},{3},{4}",
                                            this.titles[0],
                                            this.titles[1],
                                            this.titles[2],
                                            this.titles[3],
                                            this.titles[4]);

            File.AppendAllText(Path, $"{temp}\n");

            for (int i = 0; i < this.index; i++)
            {
                temp = String.Format("{0},{1},{2},{3},{4}",
                                        this.workers[i].FirstName,
                                        this.workers[i].LastName,
                                        this.workers[i].Position,
                                        this.workers[i].Salary,
                                        this.workers[i].Department);
                File.AppendAllText(Path, $"{temp}\n");
            }
        }

        /// <summary>
        /// Вывод данных в консоль
        /// </summary>
        public void PrintDbToConsole()
        {
            Console.WriteLine($"{this.titles[0], 15} {this.titles[1],15} {this.titles[4],15} {this.titles[2],15} {this.titles[3],10}");

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(this.workers[i].Print());
            }
        }

        /// <summary>
        /// Количество сотрудников в хранилище
        /// </summary>
        public int Count { get { return this.index; } }


    }
}
