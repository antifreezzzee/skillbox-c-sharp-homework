using System;
using System.Collections.Generic;
 
using System.Text;
using System.Threading.Tasks;

namespace Example_812_List
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List<T>

            // Add - Добавляет объект в конец
            // AddRange -  Добавляет элементы указанной коллекции в конец списка
            // Remove - Удаляет первое вхождение указанного объекта из коллекции 
            // RemoveAt - Удаляет элемент списка с указанным индексом
            // Contains - Определяет, входит ли элемент в коллекцию
            // IndexOf - Осуществляет поиск указанного объекта и возвращает отсчитываемый от нуля индекс
            //           первого вхождения, найденного в пределах всего списка
            // LastIndexOf - Осуществляет поиск указанного объекта и возвращает отсчитываемый от нуля индекс
            //               последнего вхождения, найденного в пределах всего списка 
            // [] - Возвращает или задает элемент по указанному индексу
            // Insert - Вставляет элемент в коллекцию по указанному индексу
            // Count - Получает число элементов, содержащихся в коллекции
            // Clear - Удаляет все элементы из коллекции 
            //Сортировка списка
            // Sort или Sort(функция_сравнения)
            // Reverse

            List<int> list = new List<int>();
            
            //  List<int> list = new List<int>(){ 1, 2, 3, 4, 5 };
            list.Add(145); 
            list.Add(2);
            list[1] = 11;

            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            for (int i = 0; i < list.Count; i++) Console.Write($"{list[i]} ");

            list.Sort();
            Console.WriteLine("\n");
            for (int i = 0; i < list.Count; i++) Console.Write($"{list[i]} ");


            // SortedList<> - аналог List<>, за исключением того, что отсортирован по умолчаию


            #endregion
        }
    }
}
