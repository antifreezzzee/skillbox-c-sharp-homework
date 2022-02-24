namespace Example_732_Indexer
{
    /// <summary>
    /// Репозиторий
    /// </summary>
    struct Repository3
    {
        /// <summary>
        /// База данных сотрудников
        /// </summary>
        private Worker[] Workers;


        public string this[int index]
        {
            get { return this.Workers[index].Print(); }
        }


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Args">Список сотрудников</param>
        public Repository3(params Worker[] Args)
        {
            Workers = Args;
        }
    }
}
