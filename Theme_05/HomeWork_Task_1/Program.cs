namespace HomeWork_Task_1

{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Просим пользователя ввести предложение
            Console.WriteLine("Введите предложение:");
            
            //Считываем ввод и заносим в переменную
            String text = Console.ReadLine();
            Console.WriteLine("\nРазделяем его на слова...");
            
            //Вызываем метод splitText и сохраняем результат его работы в массив строк.
            String[] strings = splitText(text);
            
            //Вызываем метод printResult и передаем в него полученный массив.
            printResult(strings);

        }

        //Данный метод принимает строку и возвращает массив подстрок.
        //Метод Split разбивает исходную строку на слова, разделенные символом, переданным в аргументе.
        //В нашем случае это пробел.
        private static String[] splitText(String text)
        {
            return text.Split(' ');
        }

        //Данный метод выполняет построчный вывод содержимого переданного масива.
        private static void printResult(String[] Strings)
        {
            Console.WriteLine("\nВот что получилось:\n");
            foreach (var VARIABLE in Strings)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}