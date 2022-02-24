namespace Example_732_Indexer
{

    /// <summary>
    /// Репозиторий
    /// </summary>
    struct Repository1
    {
        /// <summary>
        /// База данных сотрудников
        /// </summary>
        public Worker[] Workers;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Args">Список сотрудников</param>
        public Repository1(params Worker[] Args)
        {
            Workers = Args;
        }
    }
}
