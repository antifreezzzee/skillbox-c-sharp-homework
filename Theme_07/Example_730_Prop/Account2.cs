namespace Example_731_Prop
{
    /// <summary>
    /// Пользователь
    /// </summary>
    struct Account2
    {
        /// <summary>
        /// Логин
        /// </summary>
        public string Login;

        /// <summary>
        /// Пароль
        /// </summary>
        private string Password;

        /// <summary>
        /// Установка нового пароля
        /// </summary>
        /// <param name="NewPassword">Новый пароль</param>
        public void SetPassword(string NewPassword)
        {
            this.Password = NewPassword;
        }

        /// <summary>
        /// Создание учетной записи
        /// </summary>
        /// <param name="Login">Логин</param>
        /// <param name="Password">Пароль</param>
        public Account2(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }
    }
}
