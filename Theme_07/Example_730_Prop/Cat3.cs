namespace Example_731_Prop
{

    /// <summary>
    /// Котик
    /// </summary>
    struct Cat3
    {

        /// <summary>
        /// Создание котика
        /// </summary>
        /// <param name="Breed">Порода</param>
        /// <param name="Nickname">Кличка</param>
        public Cat3(string Breed, string Nickname)
        {
            this.Breed = Breed;
            this.Nickname = Nickname;
        }

        /// <summary>
        /// Кличка
        /// </summary>
        private string Nickname;

        /// <summary>
        /// Изменение клички
        /// </summary>
        /// <param name="NewNickname">Новая порода</param>
        private void SetNickname(string NewNickname)
        {
            this.Nickname = NewNickname;
        }

        /// <summary>
        /// Получение информации о породе
        /// </summary>
        /// <returns>Порода</returns>
        public string GetNickname()
        {
            return this.Nickname;
        }

        /// <summary>
        /// Порода
        /// </summary>
        private string Breed;

        /// <summary>
        /// Изменение породы
        /// </summary>
        /// <param name="NewBreed">Новая порода</param>
        public void SetBreed(string NewBreed)
        {
            this.Breed = NewBreed;
        }

        /// <summary>
        /// Получение информации о породе
        /// </summary>
        /// <returns>Порода</returns>
        private string GetBreed()
        {
            return this.Breed;
        }
    }
}
