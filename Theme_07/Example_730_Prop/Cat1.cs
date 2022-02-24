namespace Example_731_Prop
{

    /// <summary>
    /// Котик
    /// </summary>
    struct Cat1
    {

        /// <summary>
        /// Создание котика
        /// </summary>
        /// <param name="Breed">Порода</param>
        /// <param name="Nickname">Кличка</param>
        public Cat1(string Breed, string Nickname)
        {
            this.Breed = Breed;
            this.Nickname = Nickname;
        }

        /// <summary>
        /// Кличка
        /// </summary>
        public string Nickname;

        /// <summary>
        /// Порода
        /// </summary>
        public string Breed;
    }

}
