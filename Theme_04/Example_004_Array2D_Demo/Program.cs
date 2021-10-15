using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_004_Array2D_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int col = int.Parse(Console.ReadLine());

            int[,] arr2d = new int[row, col];

            Random r = new Random();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr2d[i, j] = r.Next(10);
                    Console.Write($"{arr2d[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            string[,] table = new string[,] {
                                  { "00", "01", "02", "03" },
                                  { "10", "11", "12", "13" },
                                  { "20", "21", "22", "23" }
                                };

            Console.WriteLine();

            Console.WriteLine($"table.Rank = {arr2d.Rank}");
            Console.WriteLine($"table.GetLength(0) = {arr2d.GetLength(0)}");
            Console.WriteLine($"table.GetLength(1) = {arr2d.GetLength(1)}");

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write($"{table[i, j],3} ");
                }
                Console.WriteLine();
            }



        }
    }
}
