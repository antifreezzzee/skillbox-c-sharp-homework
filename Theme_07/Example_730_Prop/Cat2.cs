using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_731_Prop
{

    /// <summary>
    /// Котик
    /// </summary>
    struct Cat2
    {

        /// <summary>
        /// Создание котика
        /// </summary>
        /// <param name="Breed">Порода</param>
        /// <param name="Nickname">Кличка</param>
        public Cat2(string Breed, string Nickname)
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
        private string Breed;


        /// <summary>
        /// Получение информации о породе
        /// </summary>
        /// <returns>Порода</returns>
        public string GetBreed()
        {
            return this.Breed;
        }
    }
}
