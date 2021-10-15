using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_004_04Map
{
    class Program
    {

        static void Print(char[,] Map)
        {
            for (int i = 0; i < Map.GetLength(0); i++)
            {
                for (int j = 0; j < Map.GetLength(1); j++)
                {
                    Console.Write(Map[i, j] == '.' ? ' ' : Map[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }

        static void ToColor(char[,] Map, int PosX, int PosY)
        {
            if (Map[PosX, PosY] == '.')
            {
                Map[PosX, PosY] = '+';              // "Закрашиваем" текущую ячейку
                ToColor(Map, PosX - 1, PosY);       // Просматриваем ячейку выше текущей
                ToColor(Map, PosX, PosY + 1);       // Просматриваем ячейку правее текущей
                ToColor(Map, PosX + 1, PosY);       // Просматриваем ячейку ниже текущей
                ToColor(Map, PosX, PosY - 1);       // Просматриваем ячейку левее текущей
            }
        }


        static void Main(string[] args)
        {
            char[,] map = new char[,]
             {
                {'.','+','+','.','+','+','.', },
                {'+','.','.','+','.','.','+', },
                {'+','.','.','.','.','.','+', },
                {'.','+','.','.','.','+','.', },
                {'.','.','+','.','+','.','.', },
                {'.','.','.','+','.','.','.', }
            };

            Print(map);
            Console.WriteLine();
            ToColor(map, 1, 1);
            Print(map);
        }
    }
}
