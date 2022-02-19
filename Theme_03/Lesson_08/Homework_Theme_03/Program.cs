using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Просматривая сайты по поиску работы, у вас вызывает интерес следующая вакансия:

            // Требуемый опыт работы: без опыта
            // Частичная занятость, удалённая работа
            //
            // Описание 
            //
            // Стартап «Micarosppoftle» занимающийся разработкой
            // многопользовательских игр ищет разработчиков в свою команду.
            // Компания готова рассмотреть C#-программистов не имеющих опыта в разработке, 
            // но желающих развиваться в сфере разработки игр на платформе .NET.
            //
            // Должность Интерн C#/
            //
            // Основные требования:
            // C#, операторы ввода и вывода данных, управляющие конструкции 
            // 
            // Конкурентным преимуществом будет знание процедурного программирования.
            //
            // Не технические требования: 
            // английский на уровне понимания документации и справочных материалов
            //
            // В качестве тестового задания предлагается решить следующую задачу.
            //
            // Написать игру, в которою могут играть два игрока.
            // При старте, игрокам предлагается ввести свои никнеймы.
            // Никнеймы хранятся до конца игры.
            // Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
            // Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
            // Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
            // введенное число вычитается из gameNumber
            // Новое значение gameNumber показывается игрокам на экране.
            // Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
            // Игра поздравляет победителя, предлагая сыграть реванш
            // 
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

            // *** Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером


            // Демонстрация
            // Число: 12,
            // Ход User1: 3
            //
            // Число: 9
            // Ход User2: 4
            //
            // Число: 5
            // Ход User1: 2
            //
            // Число: 3
            // Ход User2: 3
            //
            // User2 победил!

            // Переменные, хранящие имена игроков и имя игрока, 
            // совершающего ход в данный момент
            String user1, user2, currentTurn;

            // Переменные, хранящие оставшиеся очки и ход игрока
            int total, userTry, difficulty;
            
            // Создание генератора псевдослучайных чисел
            Random rand = new Random();

            // Строковые переменные для экрана заставки
            // и для экрана выхода из игры.
            // Нужны для того, чтобы посчитать длины строк
            // и вывести их по центру экрана
            String s1 = "Специально для Micarosppoftle\n";
            String s2 = "Игра \"Кто первый?\"\n";
            String s3 = "Нажмите любую клавишу, чтобы начать";
            String s4 = "Спасибо за игру!\n";
            String s5 = "Нажмите любую клавишу для выхода";

            // Показ заставки и ожидание нажатия любой клавиши
            Console.SetCursorPosition(Console.WindowWidth/2-s1.Length/2, Console.WindowHeight/2-1);
            Console.WriteLine(s1);
            Console.SetCursorPosition(Console.WindowWidth/2-s2.Length/2, Console.WindowHeight/2);
            Console.WriteLine(s2);
            Console.SetCursorPosition(Console.WindowWidth/2-s3.Length/2, Console.WindowHeight/2+1);
            Console.WriteLine(s3);
            Console.ReadKey();

            // Флаг, обозначающий конец игры.
            // Пока он не принимает значение true, 
            // выполняется главный игровой цикл
            bool gameOver = false;

            // Флаг, обозначающий игру против бота.
            bool withBot = false;

            // Иничиализация переменной total
            total = 0;

            // Вход в главный игровой цикл
            while (!gameOver)
            {
                Console.Clear();
                Console.WriteLine("Чтобы сыграть с ботом, введите \"B(b)\".\nЧтобы сыграть против друга, введите любой другой символ: ");
                
                String botPlay = Convert.ToString(Console.ReadLine());
                if (!(botPlay == "B" || botPlay == "b")) withBot = false;
                else withBot = true;

                if (withBot == false)
                {

                    // Убираем заставку и просим игроков ввести свои имена
                    Console.Clear();
                    Console.WriteLine("Игрок 1, представьтесь: ");
                    user1 = Console.ReadLine();
                    Console.WriteLine("Игрок 2, представьтесь: ");
                    user2 = Console.ReadLine();

                    // Предлагаем выбрать сложность
                    while(true)
                    {
                        Console.WriteLine("\nВыберите сложность:\n");
                        Console.WriteLine("1. Стандартная. Всего очков: 12-120. Ходы: 1, 2, 3, 4");
                        Console.WriteLine("2. Блиц-игра. Всего очков: 20-50. Ходы: 1, 2, 3");
                        Console.WriteLine("3. Убить время. Всего очков: 100-200. Ходы: 1, 2, 3, 4, 5");
                        Console.WriteLine("4. Хардкор. Всего очков: 150-300. Ходы: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
                        Console.WriteLine("5. Я все сделаю сам. Всего очков: Ручной ввод. Ходы: 1, 2, 3, 4\n");
                        Console.Write("Введите здесь число сложности: ");
                        difficulty = Convert.ToInt32(Console.ReadLine());
                        
                        // Если введено некорректное число,
                        // Сообщаем и просим ввести заново
                        if (difficulty != 1 && difficulty != 2 && difficulty != 3 && difficulty != 4 && difficulty != 5)
                        {
                            Console.Write("\nНеверный ввод. Попробуйте еще раз\n");
                            continue;
                        }
                        
                        else 
                        {
                            // Если сложность введена верно,
                            // генерируем количесво очков
                            switch (difficulty)
                            {
                            
                                case 1:
                                    total = rand.Next(12, 121);
                                    break;
                                case 2:
                                    total = rand.Next(20, 50);
                                    break;
                                case 3:
                                    total = rand.Next(100, 201);
                                    break;
                                case 4:
                                    total = rand.Next(150, 301);
                                    break;
                                case 5:
                                    Console.Write("\nВведите число очков: ");
                                    total = Convert.ToInt32(Console.ReadLine());
                                    break;
                            }
                            break;
                        }                         
                    }

                    // Очищаем экран, показываем ники игроков
                    // и количество очков
                    Console.Clear();
                    Console.WriteLine($"Игрок 1: {user1}\nИгрок 2: {user2}\nЧисло: {total}");

                    // Флаг, обозначающий конец текущего раунда.
                    // Когда один из игроков победит, примет
                    // значение true и игра предложит реванш
                    bool endRound = false;

                    // Первым ходит игрок 1
                    currentTurn = user1;

                    // Вход в цикл текущего раунда
                    while(!endRound)
                    {               
                        // Показываем оставшиеся очки и имя игрока, 
                        // совершающего ход в данный момент
                        Console.Write($"\nЧисло: {total}\nХод {currentTurn}: ");

                        // Получаем введенную с клавиатуры строку
                        // и приводим к целому числу
                        userTry = Convert.ToInt32(Console.ReadLine());

                        // Если ход игрока соответствует правилам
                        // выбранной сложности,
                        // то отнимаем его от оставшегося очков
                    
                        switch(difficulty){
                            
                            case 1:
                            case 5:
                                if(userTry == 1 || userTry == 2 || userTry == 3 || userTry == 4)
                                {
                                    total -= userTry;

                                    // Если после вычитания еще есть очки, то передаем
                                    // ход другому игроку
                                    if(total > 0)   
                                    {        
                                        
                                        // Изменяем значение переменной, хранящей ник игрока,
                                        // совершающего ход
                                        if(currentTurn == user1) currentTurn = user2;
                                        else currentTurn = user1;
                                    }  
                        
                                    // Если после вычитания очков больше нет,
                                    // то поздравляем победителя и завершаем
                                    // раунд, устанавливая флаг true переменной
                                    // endRound
                                    else 
                                    {                        
                                        Console.WriteLine($"{currentTurn} победил!\n");
                                        endRound = true;
                                    }                                      
                                }

                                // Если ход игрока не соответствует правилам,
                                // сообщаем об этом. Инициируем ход заново,
                                // вызывая следующую итерацию цикла текущего 
                                // раунда без смены игрока
                                else
                                {                    
                                    Console.WriteLine("Неверный ввод. Ведите число от 1 до 4\n");
                                    continue;
                                }
                                break;
                            case 2:
                                if(userTry == 1 || userTry == 2 || userTry == 3)
                                {
                                    total -= userTry;
                                    if(total > 0)
                                    {   
                                        if(currentTurn == user1) currentTurn = user2;
                                        else currentTurn = user1;
                                    }  
                                    else 
                                    {                      
                                        Console.WriteLine($"{currentTurn} победил!\n");
                                        endRound = true;
                                    }    
                                    
                                }
                                else
                                {                   
                                    Console.WriteLine("Неверный ввод. Ведите число от 1 до 3\n");
                                    continue;
                                }
                                break;
                            case 3:
                                if(userTry == 1 || userTry == 2 || userTry == 3 || userTry == 4 || userTry == 5)
                                {
                                    total -= userTry;
                                    if(total > 0)     
                                    {   
                                        if(currentTurn == user1) currentTurn = user2;
                                        else currentTurn = user1;
                                    }  
                                    else 
                                    {                      
                                        Console.WriteLine($"{currentTurn} победил!\n");
                                        endRound = true;
                                    }  
                                }
                                else
                                {                    
                                    Console.WriteLine("Неверный ввод. Ведите число от 1 до 5\n");
                                    continue;
                                }
                                break;
                            case 4:
                                if(userTry == 1 || userTry == 2 || userTry == 3 || userTry == 4 || userTry == 5 || userTry == 6 || userTry == 7 || userTry == 8 || userTry == 9 || userTry == 10)
                                {
                                    total -= userTry;
                                    if(total > 0)        
                                    {   
                                        if(currentTurn == user1) currentTurn = user2;
                                        else currentTurn = user1;
                                    }  
                                    else 
                                    {                        
                                        Console.WriteLine($"{currentTurn} победил!\n");
                                        endRound = true;
                                    }     
                                }
                                else
                                {                    
                                    Console.WriteLine("Неверный ввод. Ведите число от 1 до 10\n");
                                    continue;
                                }
                                break;
                        }                   
                    } 
                } 
                
                else                
                {
                    
                    // Убираем заставку и просим игрока ввести свое имя
                    Console.Clear();
                    Console.WriteLine("Игрок 1, представьтесь: ");
                    user1 = Console.ReadLine();
                    user2 = "[bot] Vedroid";

                    // Генерируем количество очков
                    total = rand.Next(12, 121);

                    // Очищаем экран, показываем ники игроков
                    // и количество очков
                    Console.Clear();
                    Console.WriteLine($"Игрок 1: {user1}\nИгрок 2: {user2}\nЧисло: {total}");

                    // Флаг, обозначающий конец текущего раунда.
                    // Когда один из игроков победит, примет
                    // значение true и игра предложит реванш
                    bool endRound = false;

                    // Первым ходит игрок
                    currentTurn = user1;

                    while(!endRound)
                    {
                        
                        // Показываем оставшиеся очки и имя игрока, 
                        // совершающего ход в данный момент
                        Console.Write($"\nЧисло: {total}\nХод {currentTurn}: ");
                        
                        // Проверяем, кто сейчас ходит
                        // Если игрок, то
                        if (currentTurn == user1){
                        
                            // Получаем введенную с клавиатуры строку
                            // и приводим к целому числу
                            userTry = Convert.ToInt32(Console.ReadLine());

                            // Если ход игрока соответствует правилам
                            // то отнимаем его от оставшегося очков
                            if(userTry == 1 || userTry == 2 || userTry == 3 || userTry == 4)
                            {
                                total -= userTry;

                                // Если после вычитания еще есть очки, то передаем
                                // ход другому игроку
                                if(total > 0)                        
                                {                       
                                    // Изменяем значение переменной, хранящей ник игрока,
                                    // совершающего ход
                                    currentTurn = user2;
                                }  
                        
                                // Если после вычитания очков больше нет,
                                // то поздравляем победителя и завершаем
                                // раунд, устанавливая флаг true переменной
                                // endRound
                                else 
                                {                        
                                    Console.WriteLine($"{currentTurn} победил!\n");
                                    endRound = true;
                                }                         
                            }

                            // Если ход игрока не соответствует правилам,
                            // сообщаем об этом. Инициируем ход заново,
                            // вызывая следующую итерацию цикла текущего 
                            // раунда без смены игрока
                            else
                            {                    
                                Console.WriteLine("Неверный ввод. Ведите число от 1 до 4\n");
                                continue;
                            }

                        } 
                        
                        // Если бот, то
                        else 
                        {                            
                            userTry = 0;

                            // Если количество очков больше 10,
                            // то бот ходит рандомно
                            if (total > 10) userTry = rand.Next(1, 5);

                            // Если количество очков от 5 до 10
                            else if (total >= 5 && total <= 10)
                            {
                                // Получаем остаток от деления количества очков
                                // на 4 и бот ходит соответственно
                                switch (total % 4){                                    
                                    case 0:
                                        userTry = 3;
                                        break;
                                    case 3:
                                        userTry = 2;
                                        break;
                                    case 2:
                                    case 1:
                                        userTry = 1;
                                        break;
                                }
                            }

                            // Если очков 4 и меньше, бот забирает победу
                            else userTry = 4;

                            // Выводим ход бота
                            Console.Write($"{userTry}\n");

                            total -= userTry;

                            // Если после вычитания еще есть очки, то передаем
                            // ход игроку
                            if(total > 0)                        
                            {                       
                                // Изменяем значение переменной, хранящей ник игрока,
                                // совершающего ход
                                currentTurn = user1;
                            }  
                        
                            // Если после вычитания очков больше нет,
                            // то поздравляем победителя и завершаем
                            // раунд, устанавливая флаг true переменной
                            // endRound
                            else 
                            {                        
                                Console.WriteLine($"{currentTurn} победил!\n");
                                endRound = true;
                            } 
                        }
                    }
                }

                // После завершения раунда предлагаем реванш.
                // Просим ввести букву. Если введена Y или y
                // основной цикл игры начинается сначала. 
                // Если введено  любое другое значение, 
                // устанавливаем флаг true переменной
                // gameOver
                Console.Write("Играть еще раз? Y/N");
                String rematch = Convert.ToString(Console.ReadLine());
                if (!(rematch == "Y" || rematch == "y")) gameOver = true;
            }

            // Благодарим игроков и выходим из игры.
            // Показываем экран выхода аналогично заставке
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth/2-s4.Length/2, Console.WindowHeight/2-1);
            Console.WriteLine(s4);
            Console.SetCursorPosition(Console.WindowWidth/2-s5.Length/2, Console.WindowHeight/2);
            Console.WriteLine(s5);
            Console.ReadKey();
        }
    }
}
