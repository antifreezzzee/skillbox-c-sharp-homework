using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_006_JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. Массив массивов

            ////         0     1     2     3
            ////     ┌─────────────────────────┐
            ////     │ ┌───┐ ┌───┐ ┌───┐ ┌───┐ │
            ////  0  │ │ 1 │ │ 3 │ │ 0 │ │ 1 │ │
            ////     │ └───┘ └───┘ └───┘ └───┘ │
            ////     │ ┌───┐ ┌───┐ ┌───┐ ┌───┐ │
            ////  1  │ │ 1 │ │ 0 │ │ 3 │ │ 1 │ │
            ////     │ └───┘ └───┘ └───┘ └───┘ │
            ////     │ ┌───┐ ┌───┐ ┌───┐ ┌───┐ │
            ////  2  │ │ 2 │ │ 0 │ │ 1 │ │ 9 │ │
            ////     │ └───┘ └───┘ └───┘ └───┘ │
            ////     └─────────────────────────┘



            ////         0     1     2     3
            ////     ┌─────────────┐
            ////     │ ┌───┐ ┌───┐ │
            ////  0  │ │ 1 │ │ 3 │ │
            ////     │ └───┘ └───┘ └───────────┐
            ////     │ ┌───┐ ┌───┐ ┌───┐ ┌───┐ │
            ////  1  │ │ 1 │ │ 0 │ │ 3 │ │ 1 │ │
            ////     │ └───┘ └───┘ └───┘ └───┘ │
            ////     │ ┌───┐ ┌───┐ ┌───┐ ┌─────┘
            ////  2  │ │ 2 │ │ 0 │ │ 1 │ │
            ////     │ └───┘ └───┘ └───┘ │
            ////     └───────────────────┘

            // Зубчатые массивы являются массивами массивов
            // Они могут иметь неправильные размеры.
            // Размеры распределяются по одному за раз

            //int[,]
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[2];
            //jaggedArray[0,1]
            jaggedArray[0][0] = 1;
            jaggedArray[0][1] = 3;

            jaggedArray[1] = new int[4];
            jaggedArray[1][0] = 1;
            jaggedArray[1][1] = 0;
            jaggedArray[1][2] = 3;
            jaggedArray[1][3] = 1;

            jaggedArray[2] = new int[3];
            jaggedArray[2][0] = 2;
            jaggedArray[2][1] = 0;
            jaggedArray[2][2] = 1;


            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                { 
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine();
            }


        }
    }
}
