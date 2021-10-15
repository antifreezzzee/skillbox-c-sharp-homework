using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_006_JaggedArrayExs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Написать программу, моделирующую получение показаний метоостанции
            // Собирать и хранить информацию о температуре воздуха
            // В период с 9 ч утра до 21 ч вечера каждые 5 минут
            // В период с 21 ч вечера до 9 утра каждые 15 минут

            #region  int[,] dataTime 
            //Random r = new Random();

            //int[,] dataTime = new int[24, 12];

            //for (int i = 0; i < dataTime.GetLength(0); i++)
            //{
            //    Console.Write($"{i,3}ч. ");
            //    for (int j = 0; j < dataTime.GetLength(1); j++)
            //    {
            //        if (i >= 9 && i < 21) dataTime[i, j] = r.Next(20);
            //        else dataTime[i, j] = (j < 4) ? r.Next(20) : 0;

            //        Console.Write($"{dataTime[i, j],3} ");
            //    }
            //    Console.WriteLine();
            //}


            //Console.ReadKey();
            //Console.Clear();
            //for (int i = 0; i < dataTime.GetLength(0); i++)
            //{
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.Write($"{i,3}ч. ");
            //    for (int j = 0; j < dataTime.GetLength(1); j++)
            //    {
            //        if (i >= 9 && i < 21) Console.ForegroundColor = ConsoleColor.White;
            //        else Console.ForegroundColor = (j < 4) ? ConsoleColor.White : ConsoleColor.Red;
            //        Console.Write($"{dataTime[i, j],3} ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ForegroundColor = ConsoleColor.White;

            #endregion

            #region int[][] dataTime

            //Random r = new Random();
            //int[][] dataTime = new int[24][];

            //for (int j = 0; j < dataTime.Length; j++)
            //{
            //    dataTime[j] = (j >= 9 && j < 21) ? new int[12] : new int[4];
            //}

            //for (int i = 0; i < dataTime.Length; i++)
            //{
            //    Console.Write($"{i} ч. ");
            //    for (int j = 0; j < dataTime[i].Length; j++)
            //    {
            //        dataTime[i][j] = r.Next(20);
            //        Console.Write($"{dataTime[i][j],3} ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

        }
    }
}
