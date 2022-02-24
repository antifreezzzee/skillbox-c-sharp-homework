namespace Example_731_Prop
{
    /// <summary>
    /// Котик
    /// </summary>
    struct Cat4
    {

        /// <summary>
        /// Создание котика
        /// </summary>
        /// <param name="Breed">Порода</param>
        /// <param name="Nickname">Кличка</param>
        public Cat4(string Breed, string Nickname)
        {
            this.breed = Breed;
            this.nickname = Nickname;
        }

        /// <summary>
        /// Кличка
        /// </summary>
        private string nickname;

        /// <summary>
        /// Свойство для доступа к кличке
        /// </summary>
        public string Nickname
        {
            get { return this.nickname; }
            set { this.nickname = value; }
        }

        #region Nickname old

        ///// <summary>
        ///// Кличка
        ///// </summary>
        //public string Nickname;


        ///// <summary>
        ///// Изменение клички
        ///// </summary>
        ///// <param name="NewNickname">Новая порода</param>
        //public void SetNickname(string value)
        //{
        //    this.Nickname = value;
        //}

        ///// <summary>
        ///// Получение информации о породе
        ///// </summary>
        ///// <returns>Порода</returns>
        //public string GetNickname()
        //{
        //    return this.Nickname;
        //}


        #endregion


        // =========================

        /// <summary>
        /// Порода
        /// </summary>
        private string breed;

        /// <summary>
        /// Свойство для доступа к породе
        /// </summary>
        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        #region Breed old


        ///// <summary>
        ///// Порода
        ///// </summary>
        //private string Breed;

        ///// <summary>
        ///// Изменение породы
        ///// </summary>
        ///// <param name="NewBreed">Новая порода</param>
        //public void SetBreed(string NewBreed)
        //{
        //    this.Breed = NewBreed;
        //}

        ///// <summary>
        ///// Получение информации о породе
        ///// </summary>
        ///// <returns>Порода</returns>
        //public string GetBreed()
        //{
        //    return this.Breed;
        //}

        #endregion

        public string EyeColor {   get; private set; }

    }
}
