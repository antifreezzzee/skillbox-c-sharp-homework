using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_823_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //string expression = "( ( 2 + 2 ) * 2 )"; Console.WriteLine($"Ожидаемый результат: {((2 + 2) * 2)}");
            //string expression = "( ( 9 + ( 4 * 6 ) ) / 10 )"; Console.WriteLine($"Ожидаемый результат: {((9.0 + (4 * 6)) / 10)}");
            string expression = "( ( 1 + ( 2 * 3 ) ) ^ 4 )";Console.WriteLine($"Ожидаемый результат: {Math.Pow(1 + (2 * 3), 4)}");

            var expressionArray = expression.Replace('(', ' ').Trim().Split(' ');   // Разбор арифметического выражения на составляющие

            //Console.WriteLine("expression");
            //foreach (var e  in expressionArray) Console.WriteLine(e);

            Stack<double> numbers = new Stack<double>();    // Стек для хранения чисел
            Stack<string> operations = new Stack<string>(); // Стек для хранения операций


            foreach (var e in expressionArray)  // просмотр составляющих арифметического выражения
            {
                double n;   // Вспомогательное число 

                if (String.IsNullOrEmpty(e)) continue; // игнорируемпустые элементы

                // Если элемент expressionArray число - добавляем в стек чисел
                if (double.TryParse(e, out n)) { numbers.Push(n); continue; }

                // Если элемент expressionArray операция - добавляем в стек с операциями
                if (@"+/*-^".IndexOf(e) > -1) { operations.Push(e); continue; }

                // Закрывающаяся скобка - призыв к действию
                if (e == ")")
                {
                    double n1 = numbers.Pop();  // Извлекаем два числа
                    double n2 = numbers.Pop();  // из стека с числами
                    string operation = operations.Pop(); // извлекаем операцию

                    
                    switch (operation)                                      //
                    {                                                       //
                        case "+": numbers.Push(n2 + n1); break;             // Выполняем операцию 
                        case "-": numbers.Push(n2 - n1); break;             // и кладем результат
                        case "/": numbers.Push(n2 / n1); break;             // в стек с числами
                        case "*": numbers.Push(n2 * n1); break;             //
                        case "^": numbers.Push(Math.Pow(n2,n1)); break;     //
                    }
                }
            }

            //Console.WriteLine("\n\nnumbers");

            //foreach (var item in numbers) Console.WriteLine(item);

            //Console.WriteLine("\n\noperations");

            //foreach (var item in operations) Console.WriteLine(item);

            Console.WriteLine($"Фактический результат: {numbers.Pop()}"); // Единственный элемент стека чисел - ответ
            

        }
    }
}
