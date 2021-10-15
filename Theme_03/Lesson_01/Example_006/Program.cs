using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_006
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заказчик просит написать приложение, которое по введённому номеру дня недели
            // выведет на экран название этого дня или сообщит, что введённое число не корректно
            
            Console.Write("Введите номер дня: ");
            int dayIndex = int.Parse(Console.ReadLine());

            #region Вариант 1

            if (dayIndex == 1)
            {
                Console.WriteLine("Понедельник");
            }
            else
            {
                if (dayIndex == 2)
                {
                    Console.WriteLine("Вторник");
                }
                else
                {
                    if (dayIndex == 3)
                    {
                        Console.WriteLine("Среда");
                    }
                    else
                    {
                        if (dayIndex == 4)
                        {
                            Console.WriteLine("Четверг");
                        }
                        else
                        {
                            if (dayIndex == 5)
                            {
                                Console.WriteLine("Пятница");
                            }
                            else
                            {
                                if (dayIndex == 6)
                                {
                                    Console.WriteLine("Суббота");
                                }
                                else
                                {
                                    if (dayIndex == 7)
                                    {
                                        Console.WriteLine("Воскресенье");
                                    }
                                    else
                                    {
                                        Console.WriteLine("На планете Земля в неделе семь дней");
                                    }
                                }
                            }
                        }
                    }
                }
            }


            #endregion

            #region Вариант 2

            if (dayIndex == 1) Console.WriteLine("Понедельник");
            else if (dayIndex == 2) Console.WriteLine("Вторник");
            else if (dayIndex == 3) Console.WriteLine("Среда");
            else if (dayIndex == 4) Console.WriteLine("Четверг");
            else if (dayIndex == 5) Console.WriteLine("Пятница");
            else if (dayIndex == 6) Console.WriteLine("Суббота");
            else if (dayIndex == 7) Console.WriteLine("Воскресенье");
            else Console.WriteLine("На планете Земля в неделе семь дней");

            #endregion
        }
    }
}


#region

// Мы узнали как
// 1. Считывать данные с консоли
// 2. Генерировать псевдослучайные числа
// 3. Применять логический тип при использовании условного оператора
// 4. Применять условный оператор (сокращённая форма)
// 5. Применять условный оператор (полная форма)
// 6. Применять условный оператор (каскады условий)

#endregion
