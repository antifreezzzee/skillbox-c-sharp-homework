namespace Example_813_ListWorker
{
    struct Worker
    {
        #region Конструкторы

        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name="FirstName">Имя</param>
        /// <param name="LastName">Фамилия</param>
        /// <param name="Position">Должность</param>
        /// <param name="Department">Отдел</param>
        /// <param name="Salary">Оплата труда</param>
        public Worker(string FirstName, string LastName, string Position, uint Salary, string Department)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.position = Position;
            this.department = Department;
            this.salary = Salary;
        }

        #endregion

        #region Методы

        public string Print()
        {
            return $"{this.firstName,15} {this.lastName,15} {this.department,15} {this.position,15} {this.salary,10}";
        }

        #endregion

        #region Свойства

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }

        /// <summary>
        /// Должность
        /// </summary>
        public string Position { get { return this.position; } set { this.position = value; } }

        /// <summary>
        /// Отдел
        /// </summary>
        public string Department { get { return this.department; } set { this.department = value; } }

        /// <summary>
        /// Оплата труда
        /// </summary>
        public uint Salary { get { return this.salary; } set { this.salary = value; } }

        /// <summary>
        /// Почасовая оплата
        /// </summary>
        public double HourRate
        {
            get
            {
                byte workingDays = 25; // Рабочих дней в месяце
                byte workingHours = 8; // Рабочих часов в день
                return ((double)Salary) / workingDays / workingHours;
            }
        }

        #endregion

        #region Поля

        /// <summary>
        /// Поле "Имя"
        /// </summary>
        private string firstName;

        /// <summary>
        /// Поле "Фамилия"
        /// </summary>
        private string lastName;

        /// <summary>
        /// Поле "Должность"
        /// </summary>
        private string position;

        /// <summary>
        /// Поле "Отдел"
        /// </summary>
        private string department;

        /// <summary>
        /// Поле "Оплата труда"
        /// </summary>
        private uint salary;

        #endregion
    }
}
