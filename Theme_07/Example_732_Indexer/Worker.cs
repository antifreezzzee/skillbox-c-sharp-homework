using System;

namespace Example_732_Indexer
{
    /// <summary>
    /// Структура, описывающая рабочего
    /// </summary>
    struct Worker
    {
        /// <summary>
        /// Должность
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Зарплата
        /// </summary>
        public uint Salary { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }

 
        /// <summary>
        /// Вывод данных о сотрунике
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return $"Должность: {Position} Зарплата: {Salary} Имя: {FirstName}";
        }

        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name="Position">Должность</param>
        /// <param name="Salary">Зарплата</param>
        /// <param name="FirstName">Имя</param>
        public Worker(string Position, uint Salary, string FirstName)
        {
            this.Position = Position;
            this.Salary = Salary;
            this.FirstName = FirstName;
        }
    }
}
