namespace HomeWork_Task_2

{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Просим пользователя ввести предложение
            Console.WriteLine("Введите предложение:");
            
            //Считываем ввод и заносим в переменную
            String text = Console.ReadLine();
            Console.WriteLine("\nИнвертируем предложение...");
            
            //Выыодим значение, полученное в результате инвертирования слов впредложении
            Console.WriteLine($"Вот что получилось:\n{ReverseWords(text)}");
            
        }

        //Данный метод принимает аргументом строку. С помощью метода splitText делит её на слова,
        //затем склеивает их в обратном порядке, формируя и возвращая новую строку. 
        private static String ReverseWords(String text)
        {
            String[] stringsUntil = splitText(text);
            String stringsAfter = "";
            for (int i = stringsUntil.Length - 1; i >= 0; i--)
            {
                stringsAfter += stringsUntil[i] + " ";
            }
            return stringsAfter;
        }

        //Данный метод принимает строку и возвращает массив подстрок.
        //Метод Split разбивает исходную строку на слова, разделенные символом, переданным в аргументе.
        //В нашем случае это пробел.
        private static String[] splitText(String text)
        {
            return text.Split(' ');
        }
    }
}