using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_821_OtherCollections
{
    // Ролик 2. Использование других коллекций: Dictionary, HashSet, Stack, Queue
    class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary


            Dictionary<string, string> pairs = new Dictionary<string, string>();
            //         ключ ,  значение
            // Add -  Добавляет указанные ключ и значение в словарь
            // Count -  Возвращает число пар "ключ-значение", содержащихся в словаре
            // Clear - Удаляет все ключи и значения из словаря 
            // [] - Возвращает или задает значение, связанное с указанным ключом
            // ContainsKey - Определяет, содержится ли указанный ключ в словаре
            // Remove - Удаляет значение с указанным ключом из словаря
            // Keys - Возвращает коллекцию, содержащую ключи из словаря 
            // Values - Возвращает коллекцию, содержащую значения из словаря 
            // KeyValuePair<string, string>

            //pairs.Add("Учитель", "Teacher");
            //pairs.Add("Проверка", "Check");
            //pairs.Add("Компьютер", "Computer");
            //pairs.Add("Автомобиль", "Car");

            //Console.WriteLine("\npairs");
            //foreach (KeyValuePair<string, string> e in pairs) Console.WriteLine($"{e} ");      // Вывод всех пар       

            //Console.WriteLine($"\n\npairs[\"Учитель\"] = {pairs["Учитель"]}"); // Teacher

            //Console.WriteLine("\npairs.Keys");
            //foreach (var e in pairs.Keys) Console.Write($"{e} ");      // Вывод всех ключей

            //Console.WriteLine("\n\npairs.Values");
            //foreach (var e in pairs.Values) Console.Write($"{e} ");      // Вывод всех Значений

            //Console.WriteLine("\n\nУдаление \"Учитель\"");

            //pairs.Remove("Учитель");  // Удаление по ключу

            //Console.WriteLine("\npairs");
            //foreach (KeyValuePair<string, string> e in pairs) Console.WriteLine($"{e} ");      // Вывод всех пар      

            //Console.WriteLine("\n");

            //Console.WriteLine($"Элементов в словаре: {pairs.Count}"); // 3
            //pairs.Clear();             // Очистить словарь
            //Console.WriteLine("pairs.Clear(); выполнен");
            //Console.WriteLine($"Элементов в словаре: {pairs.Count}"); // 0

            #endregion

            #region Queue

            //Queue<int> queue = new Queue<int>();

            //// Enqueue - Добавляет объект в конец очереди
            //// Dequeue - Удаляет объект из начала очереди и возвращает его
            ////
            //// Peek - Возвращает объект, находящийся в начале очереди, но не удаляет его
            //// Count - Получает число элементов, содержащихся в очереди
            //// Clear - Удаляет все объекты из очереди
            //// First In First Out = FIFO

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //foreach (var e in queue) Console.Write($"{e} "); // 1 2 3 4 5
            //Console.WriteLine("\n");

            //Console.WriteLine($"queue.Dequeue() = {queue.Dequeue()}"); // 1
            //foreach (var e in queue) Console.Write($"{e} "); // 2 3 4 5
            //Console.WriteLine("\n");


            //Console.WriteLine($"queue.Peek() = {queue.Peek()}"); // 2
            //foreach (var e in queue) Console.Write($"{e} "); // 2 3 4 5
            //Console.WriteLine("\n");


            #endregion

            #region Stack


            // Stack<int> stack = new Stack<int>();
            // First In Last Out - FILO

            // Push - Вставляет объект как верхний элемент стека
            // Pop - Возвращает объект в верхней части без его удаления
            //
            // Peek - Возвращает объект в верхней части стека без его удаления
            // Count - Получает число элементов, содержащихся в стеке
            // Clear - Удаляет все объекты из стека

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //foreach (var e in stack) Console.Write($"{e} "); // 5 4 3 2 1
            //Console.WriteLine("\n");

            //Console.WriteLine($"stack.Pop() = {stack.Pop()}"); // 5
            //foreach (var e in stack) Console.Write($"{e} "); // 4 3 2 1
            //Console.WriteLine("\n");


            //Console.WriteLine($"stack.Peek() = {stack.Peek()}"); // 4
            //foreach (var e in stack) Console.Write($"{e} "); // 4 3 2 1
            //Console.WriteLine("\n");

            #endregion

            #region HashSet

            //Console.ReadLine();
            //// Add - Добавляет указанный элемент в коллекцию
            //// Remove - Удаляет указанный элемент из коллекции
            //// Contains - Определяет, содержит ли указанный элемент
            //// UnionWith - Изменяет текущий объект так, чтобы он содержал все элементы, 
            ////             имеющиеся в нем или в указанной коллекции либо как в нем, так и в указанной коллекции
            //// IntersectWith - Изменяет текущий объект так, чтобы он содержал только элементы, 
            ////                 которые имеются в этом объекте и в указанной коллекции
            //// ExceptWith - Удаляет все элементы в указанной коллекции из текущего объекта
            //// IsSubsutOf - Определяет, является ли объект подмножеством указанной коллекции
            //// IsSuperSetOf - Определяет, является ли объект супермножеством указанной коллекции
            //// IsProperSubsetOf - Определяет, является ли объект строгим подмножеством указанной коллекции
            //// IsProperSupersetOf - Определяет, является ли объект строгим супермножеством указанной коллекции

            //HashSet<int> set1 = new HashSet<int>(new int[] { 1, 1, 1, 1, 1, 1, 1, 2, 3, 4, 5, 5 });
            //Console.WriteLine("set1: ");

            //foreach (var e in set1) { Console.Write($"{e} "); }

            //Console.WriteLine($"\n\nЭлемент '3' Присутствует в set1: {set1.Contains(3)}");
            //Console.WriteLine($"Элемент '20' Присутствует в set1: {set1.Contains(20)}\n");

            //Console.WriteLine("set2: ");

            //HashSet<int> set2 = new HashSet<int>() { 1, 3, 5, 7, 9, 11, 15 };
            //foreach (var e in set2) { Console.Write($"{e} "); }

            //set1.UnionWith(set2);

            //Console.WriteLine("\n\nset1 после UnionWith: ");
            //foreach (var e in set1) { Console.Write($"{e} "); }

            //set1.ExceptWith(new int[] { 3, 5, 15 });

            //Console.WriteLine("\n\nset1 после ExceptWith(new int[] { 3, 5, 15 }): ");
            //foreach (var e in set1) { Console.Write($"{e} "); }

            //// A: 1 2 3 4 5
            //// B: 1 3 5 7 9 
            //// A ꓴ B = 1 2 3 4 5 7 9
            //// A ꓵ B = 1 3 5
            //// A \ B = 2 4 
            //// B \ A = 7 9
            //// A ∆ B = 2 4 7 9

            //// https://ru.wikipedia.org/wiki/Множество
            //// https://ru.wikipedia.org/wiki/Множество#Операции_над_множествами

            #endregion

            #region Other

            // System.Collections.Generic.SortedSet
            // System.Collections.Generic.SortedList
            // System.Collections.Generic.SortedDictionary

            #endregion

        }
    }
}
