using System;

namespace Example_752
{

    /// <summary>
    /// Компьютер
    /// </summary>
    public struct Computer2
    {

        /// <summary>
        /// Имя компьютера
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Создание компьютера
        /// </summary>
        /// <param name="Title">Имя компьютера</param>
        public Computer2(string Title)
        {
            this.Title = Title;
        }

        #region Методы вкл\выкл

        /// <summary>
        /// Загрузка BIOS
        /// </summary>
        private void ActivationBIOS() { Console.WriteLine($"{this.Title} | Activation BIOS..."); }

        /// <summary>
        /// Загрузка OS
        /// </summary>
        private void ActivationOS() { Console.WriteLine($"{this.Title} | Activation OS..."); }

        /// <summary>
        /// Приветствие
        /// </summary>
        private void Greeting() { Console.WriteLine($"{this.Title} | Hello..."); }

        /// <summary>
        /// Выгрузка BIOS
        /// </summary>
        private void DeactivationBIOS() { Console.WriteLine($"{this.Title} | Deactivation BIOS..."); }

        /// <summary>
        /// Выгрузка OS
        /// </summary>
        public void DeactivationOS() { Console.WriteLine($"{this.Title} | Deactivation OS..."); }

        /// <summary>
        /// Прощание
        /// </summary>
        private void Parting() { Console.WriteLine($"{this.Title} | Bye..."); }

        #endregion

        /// <summary>
        /// Включение
        /// </summary>
        public void PowerOn()
        {
            this.ActivationBIOS();
            this.ActivationOS();
            this.Greeting();
            this.Calculation();
        }

        /// <summary>
        /// Выключение
        /// </summary>
        public void PowerOff()
        {
            this.Parting();
            this.DeactivationOS();
            this.DeactivationBIOS();
        }


        /// <summary>
        /// Метод, демонстрирующий работу
        /// </summary>
        private void Calculation()
        {
            Console.WriteLine($"\n{this.Title} | Calculation...\n");
        }

    }
}
