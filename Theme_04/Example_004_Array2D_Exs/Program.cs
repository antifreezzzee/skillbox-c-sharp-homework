using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_004_Array2D_Exs
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Элементы одномерного массива А из 9 чисел построчно расположить в матрице B[3×3]

            //int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[,] b = new int[3, 3];

            //int counterA = 0;

            //for (int i = 0; i < b.GetLength(0); i++)
            //{
            //    for (int j = 0; j < b.GetLength(1); j++)
            //    {
            //        b[i, j] = a[counterA++];
            //        Console.Write($"{b[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region В матрице Z[3×3] каждый элемент разделить на диагональный, стоящий в том же столбце.

            //
            //  1 2 3
            //  4 5 6
            //  7 8 9
            //Random r = new Random();

            //var Z = new double[3, 3];

            //Console.WriteLine("Исходная матрица Z[3x3]: ");

            //for (int i = 0; i < Z.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Z.GetLength(1); j++)
            //    {
            //        Z[i, j] = r.Next(1, 10);
            //        Console.Write($"{Z[i, j],6} ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Матрица Z[3x3] после преобразования: ");

            //for (int i = 0; i < Z.GetLength(0); i++)
            //{
            //    double div = Z[i, i];
            //    for (int j = 0; j < Z.GetLength(1); j++)
            //    {
            //        Z[i, j] /= div;
            //        Console.Write($"{Z[i, j],6} ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Для каждой строки матрицы A[4×4] найти сумму элементов.

            Random r = new Random();

            var A = new int[4, 4];

            Console.WriteLine("Исходная матрица A[4x4]: ");

            for (int i = 0; i < A.GetLength(0); i++)
            {
                int sum = 0;

                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = r.Next(1, 3);
                    sum += A[i, j];
                    Console.Write($"{A[i, j],2} ");
                }
                Console.WriteLine($" : {sum}");
            }

            #endregion
        }
    }
}
