using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_04
{
	class Program
	{
		static void Main(string[] args)
		{
			// Задание 1.
			// Заказчик просит вас написать приложение по учёту финансов
			// и продемонстрировать его работу.
			// Суть задачи в следующем: 
			// Руководство фирмы по 12 месяцам ведет учет расходов и поступлений средств. 
			// За год получены два массива – расходов и поступлений.
			// Определить прибыли по месяцам
			// Количество месяцев с положительной прибылью.
			// Добавить возможность вывода трех худших показателей по месяцам, с худшей прибылью, 
			// если есть несколько месяцев, в некоторых худшая прибыль совпала - вывести их все.
			// Организовать дружелюбный интерфейс взаимодействия и вывода данных на экран

			// Пример
			//       
			// Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.
			//     1              100 000             80 000                 20 000
			//     2              120 000             90 000                 30 000
			//     3               80 000             70 000                 10 000
			//     4               70 000             70 000                      0
			//     5              100 000             80 000                 20 000
			//     6              200 000            120 000                 80 000
			//     7              130 000            140 000                -10 000
			//     8              150 000             65 000                 85 000
			//     9              190 000             90 000                100 000
			//    10              110 000             70 000                 40 000
			//    11              150 000            120 000                 30 000
			//    12              100 000             80 000                 20 000
			// 
			// Худшая прибыль в месяцах: 7, 4, 1, 5, 12
			// Месяцев с положительной прибылью: 10

			/* Создаем массивы для хранения
			 * дохода, расхода, прибыли, 
			 * сортированной по возрастанию прибыли,
			 * трех худших значений прибыли
			 */
			int[] profit = new int[12];
			int[] expend = new int[12];
			int[] margin = new int[12];
			int[] marginSort = new int[12];
			int[] worstMargin = new int[3];

			/* Создаем переменную, хранящую количество дней сположительной прибылью
			 */

			int positiveCount = 0;
			//Random random1 = new Random();

			/* Строковые переменные для удобства вывода
			 */
			String mounth = "Месяц";
			String prof = "Доход, тыс. руб.";
			String exp = "Расход, тыс. руб.";
			String marg = "Прибыль, тыс. руб.";

			/* Строковые переменные для форматированного
			 * вывода значений 
			 */
			String profitFormat = "";
			String expendFormat = "";
			String marginFormat = "";

			/* Заполняем массивы дохода и расхода.
			 * Сразу заполняем массив прибыли, сохраняя разность
			 * дохода и расхода. Если прибыль положительная, 
			 * увеличиваем счетчик месяцев с положительной прибылью
			 */
			for (int i = 0; i < 12; i++)
			{
				Console.Write($"\nВведите доход {i + 1} месяца, тыс.руб.: ");
				profit[i] = Int32.Parse(Console.ReadLine());
				//profit[i] = random1.Next(-100_000, 100_001);
				Console.Write($"Введите расход {i + 1} месяца, тыс.руб.: ");
				expend[i] = Int32.Parse(Console.ReadLine());
				//expend[i] = random1.Next(-100_000, 100_001);
				margin[i] = (profit[i] - expend[i]);
				if (margin[i] > 0) positiveCount++;
			}

			/* Выводим на экран таблицу
			 */
			Console.Clear();
			Console.WriteLine($"{mounth,5}{prof,23}{exp,23}{marg,23}");
			for (int i = 0; i < 12; i++)
			{
				/* Если значение равно нулю, выводим ноль.
				 * если нет, то выводим форматированное значение
				 */
				if (profit[i] == 0) profitFormat = "";
				else profitFormat = "### ###";
				if (expend[i] == 0) expendFormat = "";
				else expendFormat = "### ###";
				if (margin[i] == 0) marginFormat = "";
				else marginFormat = "### ###";
				int m = i + 1;
				Console.WriteLine($"{m,5}{profit[i].ToString(profitFormat),23}{expend[i].ToString(expendFormat),23}{margin[i].ToString(marginFormat),23}");
			}

			/* Создаем дубликат массива прибыли
			 * и сортируем его по возрастанию
			 */
			Array.Copy(margin, marginSort, 12);
			Array.Sort(marginSort);

			/* Присваиваем массиву худших значений прибыли значения:
			 * первому элементу первое значение сортированного массива,
			 * второму - предпоследнее, третьему последнее
			 */
			worstMargin[0] = marginSort[0];
			worstMargin[1] = marginSort[marginSort.Length - 2];
			worstMargin[2] = marginSort[marginSort.Length - 1];

			/* Создаем счетчик уникальных значений для сортированного массива.
			 * Так как первый элемент явно минимальный, присваиваем счетчику значение 1
			 */
			int count = 1;

			/* Проходим по сортированному массиву. Если текущий элемент
			 * не равен предыдущему, считаем его уникальным и увеличиваем счетчик.
			 * Как только счетчик переваливает за 2, останавливаем цикл.
			 */
			for (int i = 1; i < marginSort.Length; i++)
			{
				if (marginSort[i] != marginSort[i - 1])
				{
					worstMargin[count] = marginSort[i];
					count++;
					if (count == 3) break;
				}
			}

			/* Проходим по массиву прибыли и сравниваем значения
			 * с худшими значениями прибыли. Если есть совпадение,
			 * плюсуем к строке индекс значения + 1, чтобы получить номер месяца.
			 */
			String worstMounths = "Худшая прибыль в месяцах: ";
			for (int i = 0; i < margin.Length; i++)

			{
				if (margin[i] == worstMargin[0] || margin[i] == worstMargin[1] || margin[i] == worstMargin[2])
				{
					worstMounths += $"{i + 1} ";
				}
			}

			/* Выводим значения месяцев с худшей прибылью
			 * и количество месяцев с положительной прибылью
			 */
			Console.WriteLine($"{worstMounths}");
			Console.WriteLine($"Месяцев с положительной прибылью: {positiveCount}");
			Console.ReadKey();

			// * Задание 2
			// Заказчику требуется приложение строящее первых N строк треугольника паскаля. N < 25
			// 
			// При N = 9. Треугольник выглядит следующим образом:
			//                                 1
			//                             1       1
			//                         1       2       1
			//                     1       3       3       1
			//                 1       4       6       4       1
			//             1       5      10      10       5       1
			//         1       6      15      20      15       6       1
			//     1       7      21      35      35       21      7       1
			//                                                              
			//                                                              
			// Простое решение:                                                             
			// 1
			// 1       1
			// 1       2       1
			// 1       3       3       1
			// 1       4       6       4       1
			// 1       5      10      10       5       1
			// 1       6      15      20      15       6       1
			// 1       7      21      35      35       21      7       1
			// 
			// Справка: https://ru.wikipedia.org/wiki/Треугольник_Паскаля

			/* Очищаем экран.
			 * Создаем переменную n, которая будет хранить 
			 * количество "этажей" треугольника
			 * и просим пользователя ввести ее
			 * значение. Если значение не удовлетворяет условию,
			 * сообщаем об этом и просим ввести заново */
			Console.Clear();
			Console.WriteLine("Треугольник Паскаля\n");
			int n = 0;
			while (true)
			{
				Console.Write("Введите N: ");
				n = Int32.Parse(Console.ReadLine());
				if (n > 0 && n < 25) break;
				else Console.WriteLine("\nN должно быть в пределах от 0 до 25.\nПопробуйте еще раз.\n");
			}

			/* Создаем массив массивов который будет хранить
			 * n массивов */
			int[][] pascalsTriangle = new int[n][];

			/* Инициализируем массивы. В каждом i-ом массиве будет i+1 элемент.
			 * Сразу в первый и последний элемент задаем значение 1 */
			for (int i = 0; i < n; i++)
			{

				pascalsTriangle[i] = new int[i + 1];
				pascalsTriangle[i][0] = 1;
				pascalsTriangle[i][pascalsTriangle[i].Length - 1] = 1;

			}

			/* В первых двух этажах все элементы равны 1.
			 * Если этажей болше двух, то на третьем и последующем начинает
			 * работать формула треугольника Паскаля. Чтобы посчитать значение
			 * элемента, надо сложить стоящий точно над ним и точно над 
			 * предыдущим элементом */
			if (n > 2)
			{
				for (int i = 2; i < n; i++)
				{
					for (int j = 1; j < pascalsTriangle[i].Length - 1; j++)
					{
						pascalsTriangle[i][j] = pascalsTriangle[i - 1][j] + pascalsTriangle[i - 1][j - 1];
					}
				}
			}

			/* Делаем отступ и выводим в консоль треугольник */
			Console.WriteLine();
			for (int i = 0; i < n; i++)
			{
				int length = pascalsTriangle[i].Length;
				for (int j = 0; j < length; j++)
				{
					Console.Write($"{pascalsTriangle[i][j]} ");
				}
				Console.WriteLine();
			}
			Console.ReadKey();

			// 
			// * Задание 3.1
			// Заказчику требуется приложение позволяющщее умножать математическую матрицу на число
			// Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
			// Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матрицы_на_число
			// Добавить возможность ввода количество строк и столцов матрицы и число,
			// на которое будет производиться умножение.
			// Матрицы заполняются автоматически. 
			// Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
			//
			// Пример
			//
			//      |  1  3  5  |   |  5  15  25  |
			//  5 х |  4  5  7  | = | 20  25  35  |
			//      |  5  3  1  |   | 25  15   5  |
			//
			//
			// ** Задание 3.2
			// Заказчику требуется приложение позволяющщее складывать и вычитать математические матрицы
			// Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
			// Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Сложение_матриц
			// Добавить возможность ввода количество строк и столцов матрицы.
			// Матрицы заполняются автоматически
			// Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
			//
			// Пример
			//  |  1  3  5  |   |  1  3  4  |   |  2   6   9  |
			//  |  4  5  7  | + |  2  5  6  | = |  6  10  13  |
			//  |  5  3  1  |   |  3  6  7  |   |  8   9   8  |
			//  
			//  
			//  |  1  3  5  |   |  1  3  4  |   |  0   0   1  |
			//  |  4  5  7  | - |  2  5  6  | = |  2   0   1  |
			//  |  5  3  1  |   |  3  6  7  |   |  2  -3  -6  |
			//
			// *** Задание 3.3
			// Заказчику требуется приложение позволяющщее перемножать математические матрицы
			// Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
			// Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
			// Добавить возможность ввода количество строк и столцов матрицы.
			// Матрицы заполняются автоматически
			// Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
			//  
			//  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
			//  |  4  5  7  | х |  2  5  6  | = | 35  79  95  |
			//  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
			//
			//  
			//                  | 4 |   
			//  |  1  2  3  | х | 5 | = | 32 |
			//                  | 6 |  
			//

			while (true)
			{
				/* Очищаем экран.
				 * Создаём три двумерные матрицы.
				 * Две для хранения исходных и одну для 
				 * хранения результата операций.
				 * Создаем переменные для хранения данных:
				 * режима вычислений, количеств строк и столбцов, множителя.
				 * Создаем генератор псевдослучайных чисел.
				 */
				Console.Clear();
				int[,] matrix1, matrix2, matrixResult;
				int mode, rows1, columns1, rows2, columns2, multiplier;
				Random random = new Random();

				/* Выводим приветствие и предлагаем выбрать режим.
				 * Если введено неправильное число, сообщаем об этом и
				 * предлагаем ввести снова.
				 */
				Console.WriteLine("Калькулятор матриц\n\nКакую операцию необходимо выполнить?\n\n");
				Console.Write("1 - умножение матрицы на число\n2 - сложение матриц\n3 - вычитание матриц\n4 - перемножение матриц\n\nВведите число: ");

				while (true)
				{
					mode = Int32.Parse(Console.ReadLine());
					if (mode > 0 && mode < 5) break;
					else Console.Write("\nНеверный ввод, попробуйте еще раз:\n");
				}
				switch (mode)
				{
					/* Если выбран первый режим, создаем одну матрицу,
					 * получаем множитель и выполняем умножение на число.
					 * Необходимо каждый элемент умножить на множитель.
					 */
					case 1:
						{
							/* Ввод размера матрицы и множителя
							 */
							Console.Write("\nВведите число строк матрицы: ");
							rows1 = Int32.Parse(Console.ReadLine());
							Console.Write("Введите число столбцов матрицы: ");
							columns1 = Int32.Parse(Console.ReadLine());
							Console.Write("Введите множитель: ");
							multiplier = Int32.Parse(Console.ReadLine());
							matrix1 = new int[rows1, columns1];

							/* Заполнение и вывод на консоль исходной матрицы
							 */
							Console.WriteLine("\nИсходная матрица:\n");
							for (int i = 0; i < rows1; i++)
							{
								for (int j = 0; j < columns1; j++)
								{
									matrix1[i, j] = random.Next(-10, 11);
									Console.Write($"{matrix1[i, j]} ");
								}
								Console.WriteLine();
							}

							/* Расчет и вывод на консоль результата
							 */
							Console.WriteLine("\nРезультат:\n");
							for (int i = 0; i < rows1; i++)
							{
								for (int j = 0; j < columns1; j++)
								{
									matrix1[i, j] *= multiplier;
									Console.Write($"{matrix1[i, j]} ");
								}
								Console.WriteLine();
							}
							break;
						}
					/* Если выбран второй или третий режим, создаем две матрицы.
					 * Необходимое условие для сложения или вычитания матриц:
					 * числа строк и столбцов должны совпадать, т.е. 
					 * необходимы матрицы одинакового размера.
					 * Просим ввести размеры матриц.
					 * Если введены неправильные числа, сообщаем об этом и
					 * предлагаем ввести снова.
					 */
					case 2:
						{
							while (true)
							{
								Console.Write("\nВведите число строк матрицы 1: ");
								rows1 = Int32.Parse(Console.ReadLine());
								Console.Write("Введите число столбцов матрицы 1: ");
								columns1 = Int32.Parse(Console.ReadLine());
								Console.Write("\nВведите число строк матрицы 2: ");
								rows2 = Int32.Parse(Console.ReadLine());
								Console.Write("Введите число столбцов матрицы 2: ");
								columns2 = Int32.Parse(Console.ReadLine());
								if (rows1 == rows2 && columns1 == columns2) break;
								else Console.Write("\nДля данной операции необходимы матрицы одинакового размера.\nПопробуйте еще раз.");
							}
							matrix1 = new int[rows1, columns1];
							matrix2 = new int[rows2, columns2];
							matrixResult = new int[rows1, columns1];

							/* Заполнение и вывод на консоль исходных матриц
							 */
							Console.WriteLine("\nИсходная матрица 1:\n");
							for (int i = 0; i < rows1; i++)
							{
								for (int j = 0; j < columns1; j++)
								{
									matrix1[i, j] = random.Next(-10, 11);
									Console.Write($"{matrix1[i, j]} ");
								}
								Console.WriteLine();
							}
							Console.WriteLine("\nИсходная матрица 2:\n");
							for (int i = 0; i < rows2; i++)
							{
								for (int j = 0; j < columns2; j++)
								{
									matrix2[i, j] = random.Next(-10, 11);
									Console.Write($"{matrix2[i, j]} ");
								}
								Console.WriteLine();
							}

							/* Расчет и вывод на консоль результата
							 */
							Console.WriteLine("\nСумма матриц:\n");
							for (int i = 0; i < rows1; i++)
							{
								for (int j = 0; j < columns1; j++)
								{
									matrixResult[i, j] = matrix1[i, j] + matrix2[i, j];
									Console.Write($"{matrixResult[i, j]} ");
								}
								Console.WriteLine();
							}
							break;
						}
					/* Действия аналогичны режиму 2, за исключением расчета.
					 * Здесь происходит вычитание вместо сложения
					 */
					case 3:
						{
							while (true)
							{
								Console.Write("\nВведите число строк матрицы 1: ");
								rows1 = Int32.Parse(Console.ReadLine());
								Console.Write("Введите число столбцов матрицы 1: ");
								columns1 = Int32.Parse(Console.ReadLine());
								Console.Write("\nВведите число строк матрицы 2: ");
								rows2 = Int32.Parse(Console.ReadLine());
								Console.Write("Введите число столбцов матрицы 2: ");
								columns2 = Int32.Parse(Console.ReadLine());
								if (rows1 == rows2 && columns1 == columns2) break;
								else Console.Write("\nДля данной операции необходимы матрицы одинакового размера.\nПопробуйте еще раз.");
							}
							matrix1 = new int[rows1, columns1];
							matrix2 = new int[rows2, columns2];
							matrixResult = new int[rows1, columns1];
							Console.WriteLine("\nИсходная матрица 1:\n");
							for (int i = 0; i < rows1; i++)
							{
								for (int j = 0; j < columns1; j++)
								{
									matrix1[i, j] = random.Next(-10, 11);
									Console.Write($"{matrix1[i, j]} ");
								}
								Console.WriteLine();
							}
							Console.WriteLine("\nИсходная матрица 2:\n");
							for (int i = 0; i < rows2; i++)
							{
								for (int j = 0; j < columns2; j++)
								{
									matrix2[i, j] = random.Next(-10, 11);
									Console.Write($"{matrix2[i, j]} ");
								}
								Console.WriteLine();
							}
							Console.WriteLine("\nРазность матриц:\n");
							for (int i = 0; i < rows1; i++)
							{
								for (int j = 0; j < columns1; j++)
								{
									matrixResult[i, j] = matrix1[i, j] - matrix2[i, j];
									Console.Write($"{matrixResult[i, j]} ");
								}
								Console.WriteLine();
							}
							break;
						}
					/* Если выбран четвёртый режим, создаем две матрицы.
					 * Необходимое условие для перемножения двух матриц:
					 * число строк первой должно совпадать с числом столбцов второй.
					 * Просим ввести размеры матриц.
					 * Если введены неправильные числа, сообщаем об этом и
					 * предлагаем ввести снова.
					 */
					case 4:
						{
							while (true)
							{
								Console.Write("\nВведите число строк матрицы 1: ");
								rows1 = Int32.Parse(Console.ReadLine());
								Console.Write("Введите число столбцов матрицы 1: ");
								columns1 = Int32.Parse(Console.ReadLine());
								Console.Write("\nВведите число строк матрицы 2: ");
								rows2 = Int32.Parse(Console.ReadLine());
								Console.Write("Введите число столбцов матрицы 2: ");
								columns2 = Int32.Parse(Console.ReadLine());
								if (rows2 == columns1) break;
								else Console.Write("\nДля данной операции необходимы согласованные матрицы.\nЧисло столбцов первой матрицы должно равняться числу строк второй.\nПопробуйте еще раз.\n");
							}
							matrix1 = new int[rows1, columns1];
							matrix2 = new int[rows2, columns2];
							matrixResult = new int[rows1, columns2];

							/* Заполнение и вывод на консоль исходных матриц
							 */
							Console.WriteLine("\nИсходная матрица 1:\n");
							for (int i = 0; i < rows1; i++)
							{
								for (int j = 0; j < columns1; j++)
								{
									matrix1[i, j] = random.Next(-10, 11);
									Console.Write($"{matrix1[i, j]} ");
								}
								Console.WriteLine();
							}
							Console.WriteLine("\nИсходная матрица 2:\n");
							for (int i = 0; i < rows2; i++)
							{
								for (int j = 0; j < columns2; j++)
								{
									matrix2[i, j] = random.Next(-10, 11);
									Console.Write($"{matrix2[i, j]} ");
								}
								Console.WriteLine();
							}

							/* Расчет и вывод на консоль результата
							 */
							Console.WriteLine("\nРезультат:\n");
							for (int i = 0; i < rows1; i++)
							{
								for (int j = 0; j < columns2; j++)
								{
									/* Обнуляем значение текущего элемента искомой матрицы
									 */
									matrixResult[i, j] = 0;
									/* Вычисляем скалярное произведение i-ой строки первой матрицы
									 * и j-го столбца второй матрицы, заносим его в текущий элемент
									 * и выводим на консоль
									 */
									for (int k = 0; k < rows2; k++)
									{
										matrixResult[i, j] += (matrix1[i, k] * matrix2[k, j]);
									}
									Console.Write($"{matrixResult[i, j]} ");
								}
								Console.WriteLine();
							}
							break;
						}
					default: break;
				}

				/* Предлагаем посчитать еще раз 
				 */
				Console.Write("\nПосчитать ещё раз? Y/N: ");
				String answer = Console.ReadLine();
				if (!(answer == "Y" || answer == "y")) break;
			}
		}
	}
}
