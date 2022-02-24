using System;

namespace Example_752
{
    /// <summary>
    /// Компьютер
    /// </summary>
    public struct Computer1
    {
        /// <summary>
        /// Имя компьютера
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Создание компьютера
        /// </summary>
        /// <param name="Title">Имя компьютера</param>
        public Computer1(string Title)
        {
            this.Title = Title;
        }

        #region Методы вкл\выкл

        /// <summary>
        /// Загрузка BIOS
        /// </summary>
        public void ActivationBIOS() { Console.WriteLine($"{this.Title} | Activation BIOS..."); }

        /// <summary>
        /// Загрузка OS
        /// </summary>
        public void ActivationOS() { Console.WriteLine($"{this.Title} | Activation OS..."); }

        /// <summary>
        /// Приветствие
        /// </summary>
        public void Greeting() { Console.WriteLine($"{this.Title} | Hello..."); }

        /// <summary>
        /// Выгрузка BIOS
        /// </summary>
        public void DeactivationBIOS() { Console.WriteLine($"{this.Title} | Deactivation BIOS..."); }

        /// <summary>
        /// Выгрузка OS
        /// </summary>
        public void DeactivationOS() { Console.WriteLine($"{this.Title} | Deactivation OS..."); }

        /// <summary>
        /// Прощание
        /// </summary>
        public void Parting() { Console.WriteLine($"{this.Title} | Bye..."); }

        #endregion

        /// <summary>
        /// Метод, демонстрирующий работу
        /// </summary>
        public void Calculation()
        {
            Console.WriteLine($"\n{this.Title} | Calculation...\n");
        }

    }
}
