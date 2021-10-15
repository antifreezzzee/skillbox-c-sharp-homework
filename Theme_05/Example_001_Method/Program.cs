using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_001_Method
{
    class Program
    {
        /// <summary>
        /// Метод, позволяющий сделать задержку закрытия консоли
        /// </summary>
        static void Delay()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// Метод, позволяющий вывести сообщение "Hello World" в консоль
        /// </summary>
        static public void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        /// <summary>
        /// Метод, позволяющий вывести сообщение в консоль
        /// </summary>
        /// <param name="Text">Текст сообщения</param>
        static void Print(string Text)
        {
            Console.WriteLine(Text);
        }
 
        static void Main(string[] args)
        {
            #region Теория

            // Метод может быть создан внутри класса, 
            // Общая структура 
            //
            // 
            // УровниДоступа МодификаторыДоступа ВозвращаемыйТип ИмяМетода(ПараметрыМетода)
            // {
            //    Тело метода
            //    return
            // }
            // 
            // УровниДоступа: public, protected, internal, private. 
            //   С помощью четырех модификаторов доступа можно объявить шесть уровней доступности.
            //
            // МодификаторыДоступа: static, abstract, async, extern, override, virtual
            //
            // ВозвращаемыйТип: int, double, string и т.д.
            //                  void если ничего возвращать не нужно
            // 
            // ИмяМетода: Строчные и прописные буквы латинского алфавита, цифры, _
            //            цифра не может быть на первом месте
            // 
            // ПараметрыМетода: аргументы, над которыми, как правило производятся какие-то действия
            //                  Формальные парамметры - параметры указанные при описании метода
            //                  Фактические параметры - параметры указанные при вызове метода
            // 
            // Соглашение об именах для методов - описательное имя для каждого слова начинается с прописной буквы.

            // Вызов метода:
            // Написать имя метода и указать фактические параметры, если они есть

            // Пример 1. Вызов метода void HelloWorld()
            HelloWorld();

            // Пример 2. Вызов метода void Print(string Text)
            Print("Текст в консоли");

            // Пример 3. Вызов метода void Delay()
            Delay();

            #endregion

        }
    }
}
