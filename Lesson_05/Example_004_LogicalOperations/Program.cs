using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_004_LogicalOperations
{
    class Program
    {
        static void Main(string[] args)
        {


            // Высказывание (в математической логике) - Высказывание — это грамматически правильное 
            // повествовательное предложени языка (естественного или искусственного), 
            // которое выражает некоторый смысл и является либо истинным,
            // либо ложным, но не тем и другим сразу.

            // Пример 1. Na — металл - истина
            // Пример 2: 2 + 2 = 5 - ложь
            // Пример 3: Проксима Центавра - ближайшая к Земле звезде - Ложь
            bool variable1 = true;      // 1
            bool variable2 = false;     // 0
            #region Инверсия / Отрицание / Логическое "Не" / !

            Console.WriteLine("Инверсия: ");
            // Определение. Отрицанием высказывания, будет являться Высказывание
            //              «противоположное» исходному

            Console.WriteLine($"variable1 = {variable1}   !variable1 = {!variable1}");
            Console.WriteLine($"variable2 = {variable2}   !variable2 = {!variable2}");

            #endregion

            #region Конъюнкция / Логическое умножение / Логическое "И" / &&

            Console.WriteLine("\nКонъюнкция: ");

            // Определение 2. Конъюнкцией двух высказываний, будет является высказывание
            //                истинное тогда и только тогда, когда оба исходных суждения истинны

            // Пример 4: Nа — металл И Проксима Центавра - ближайшая к солнечной системе звезде 
            // Пример 5: Компьютер работает с нулями и единицами И все люди пьют воду

            //variable1 = true;
            //variable2 = false;

            //bool result = variable1 && variable2;

            //Console.WriteLine($" {true} && {true}  = {true && true}");
            //Console.WriteLine($" {true} && {false} = {true && false}");
            //Console.WriteLine($"{false} && {true}  = {false && true}");
            //Console.WriteLine($"{false} && {false} = {false && false}");
            //Console.ReadKey();
            #endregion

            #region Дизъюнкция  / Логическое сложение / Логическое "ИЛИ" / ||

            //Console.WriteLine("\nДизъюнкция: ");

            // Определение 3. Дизъюнкцией двух высказываний, будет является высказывание
            //                ложное тогда и только тогда, когда оба исходных высказывания ложны

            // Пример 6: Nа — металл  ИЛИ 2 + 2 = 5 
            // Пример 7: Проксима Центавра - ближайшая к Земле звезде ИЛИ все люди пьют воду


            //variable1 = true;
            //variable2 = false;

            //bool result = variable1 || variable2;

            //Console.WriteLine($" {true} || {true}  = {true || true}");
            //Console.WriteLine($" {true} || {false} = {true || false}");
            //Console.WriteLine($"{false} || {true}  = {false || true}");
            //Console.WriteLine($"{false} || {false} = {false || false}");
            //Console.ReadKey();
            #endregion

            #region Разделительная дизъюнкция  / Строгая дизъюнкция / Исключающее «ИЛИ» / ^

            Console.WriteLine("\nРазделительная дизъюнкция: ");

            // Определение 4. Разделительной дизъюнкцией двух высказываний, будет является высказывание
            //                истинное тогда и только тогда, когда только одно из исходных суждения истинно

            //variable1 = true;
            //variable2 = false;

            //bool result = variable1 ^ variable2;

            //Console.WriteLine($" {true} ^ {true}  = {true ^ true}");
            //Console.WriteLine($" {true} ^ {false} = {true ^ false}");
            //Console.WriteLine($"{false} ^ {true}  = {false ^ true}");
            //Console.WriteLine($"{false} ^ {false} = {false | false}");

            #endregion

            #region Другие операции

            bool flag1 = 4 > 5; Console.WriteLine(flag1);
            bool flag2 = 1 < 3; Console.WriteLine(flag2);

            char c = 'f';

            bool flag3 = c == 'f'; Console.WriteLine(flag3);
            bool flag4 = 28 == 28; Console.WriteLine(flag4);
            bool flag5 = 28 >= 24; Console.WriteLine(flag5);
            bool flag6 = 9 <= 9; Console.WriteLine(flag6);
            bool flag7 = 28 != 90; Console.WriteLine(flag7);

            string s = "C#";
            bool flag8 = 28 != 90 && s == "C#"; Console.WriteLine(flag8);

            #endregion
        }
    }
}
