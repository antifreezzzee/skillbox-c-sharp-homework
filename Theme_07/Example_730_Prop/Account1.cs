using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_731_Prop
{

    /// <summary>
    /// Пользователь
    /// </summary>
    struct Account1
    {
        /// <summary>
        /// Логин
        /// </summary>
        public string Login;

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password;

        /// <summary>
        /// Создание учетной записи
        /// </summary>
        /// <param name="Login">Логин</param>
        /// <param name="Password">Пароль</param>
        public Account1(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }
    }
}
