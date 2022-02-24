namespace Example_732_Indexer
{

    /// <summary>
    /// Репозиторий
    /// </summary>
    struct Repository2
    {
        /// <summary>
        /// База данных сотрудников
        /// </summary>
        private Worker[] Workers;

        public Worker this[int index]
        {
            get { return Workers[index]; }
            set { Workers[index] = value; }
        }
 
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Args">Список сотрудников</param>
        public Repository2(params Worker[] Args)
        {
            Workers = Args;
        }
    }
}
