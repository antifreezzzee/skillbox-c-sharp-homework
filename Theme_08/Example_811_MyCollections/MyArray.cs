using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_811_MyCollections
{
    /// <summary>
    /// Структура, для работы с данными
    /// </summary>
    struct MyArray
    {
        private int[] data;
        private int index;

        /// <summary>
        /// Создание экземпляра MyArray
        /// </summary>
        /// <param name="SizeArray">Количество элементов</param>
        public MyArray(int SizeArray)
        {
            this.data = new int[SizeArray];
            this.index = 0;
        }

        /// <summary>
        /// Добавление элемента в массив
        /// </summary>
        /// <param name="Element">Добавляемый элемент</param>
        public void Add(int Element)
        {
            if (index >= this.data.Length)
            {
                Array.Resize(ref this.data, this.data.Length * 3 / 2); //100 >> 150 >> 225 >> 337 >> 505 и т.д. 
            }
            this.data[index++] = Element;
        }

        /// <summary>
        /// Удаление элемента на выранной позиции
        /// </summary>
        /// <param name="Position">Позиция удаляемого элемента</param>
        public void RemoveAt(int Position)
        {
            for (int i = Position; i < this.index; i++)
            {
                this.data[i] = this.data[i + 1];
            }
            this.index--;
        }

        /// <summary>
        /// Метод, подготавливающий массив к печати 
        /// </summary>
        /// <param name="Text">Текст, перед выводом</param>
        public string Print(string Text = "")
        {
            string output = string.Empty;
            for (int i = 0; i < this.index; i++) output += $"{this.data[i]} ";
            return $"{Text} {output}".Trim();
        }

        /// <summary>
        /// Дотуп к элементам массива
        /// </summary>
        /// <param name="i">Позиция элемента</param>
        /// <returns></returns>
        public int this[int i]
        {
            get { return this.data[i]; }
            set { this.data[i] = value; }
        }

        /// <summary>
        /// Колличество элементов массива
        /// </summary>
        public int Count { get { return this.index; } }
    }
}
