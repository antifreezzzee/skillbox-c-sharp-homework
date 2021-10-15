using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_005_MultiArray
{
    class Program
    {
 
        static void Main(string[] args)
        {
            // 5. Многомерные массивы: использование, задание
            int[,,] matrix3D = new int[3, 4, 5];

            Console.WriteLine($"matrix3D.Rank = {matrix3D.Rank}");

            Console.WriteLine($"matrix3D.Length = {matrix3D.Length}");
            Console.WriteLine($"matrix3D.GetLength(0) = {matrix3D.GetLength(0)}");
            Console.WriteLine($"matrix3D.GetLength(1) = {matrix3D.GetLength(1)}");
            Console.WriteLine($"matrix3D.GetLength(2) = {matrix3D.GetLength(2)}");

            Random r = new Random();


            for (int i = 0; i < matrix3D.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3D.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix3D.GetLength(2); k++)
                    {
                        matrix3D[i, j, k] = r.Next(10);
                        Console.Write($"{matrix3D[i, j, k]} ");
                    }
                }
            }

            Console.WriteLine("\n\n");

            int[,,,] matrix4D = new int[3, 4, 5, 6];

            Console.WriteLine($"matrix4D.Rank = {matrix4D.Rank}");

            Console.WriteLine($"matrix4D.Length = {matrix4D.Length}");
            Console.WriteLine($"matrix4D.GetLength(0) = {matrix4D.GetLength(0)}");
            Console.WriteLine($"matrix4D.GetLength(1) = {matrix4D.GetLength(1)}");
            Console.WriteLine($"matrix4D.GetLength(2) = {matrix4D.GetLength(2)}");
            Console.WriteLine($"matrix4D.GetLength(3) = {matrix4D.GetLength(3)}");

            for (int i = 0; i < matrix4D.GetLength(0); i++)
            {
                for (int j = 0; j < matrix4D.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix4D.GetLength(2); k++)
                    {
                        for (int l = 0; l < matrix4D.GetLength(3); l++)
                        {
                            matrix4D[i, j, k, l] = r.Next(10);
                            Console.Write($"{matrix4D[i, j, k, l]} ");
                        }
                    }
                }
            }

            Console.WriteLine("\n\n");

            int[,,,,] matrix5D = new int[3, 4, 5, 6, 10];

            Console.WriteLine($"matrix5D.Rank = {matrix5D.Rank}");

            Console.WriteLine($"matrix5D.Length = {matrix5D.Length}");
            Console.WriteLine($"matrix5D.GetLength(0) = {matrix5D.GetLength(0)}");
            Console.WriteLine($"matrix5D.GetLength(1) = {matrix5D.GetLength(1)}");
            Console.WriteLine($"matrix5D.GetLength(2) = {matrix5D.GetLength(2)}");
            Console.WriteLine($"matrix5D.GetLength(3) = {matrix5D.GetLength(3)}");
            Console.WriteLine($"matrix5D.GetLength(4) = {matrix5D.GetLength(4)}");

            Console.WriteLine("\n\n");

            Console.ReadKey();

            double[,,,,,] matrix6D = new double[30, 43, 55, 61, 10, 7];

            Console.WriteLine($"matrix6D.Rank = {matrix6D.Rank}");

            Console.WriteLine($"matrix6D.Length = {matrix6D.Length}");

            Console.WriteLine($"memory: {(matrix6D.Length * sizeof(double)) }");

            Console.WriteLine($"matrix6D.GetLength(0) = {matrix6D.GetLength(0)}");
            Console.WriteLine($"matrix6D.GetLength(1) = {matrix6D.GetLength(1)}");
            Console.WriteLine($"matrix6D.GetLength(2) = {matrix6D.GetLength(2)}");
            Console.WriteLine($"matrix6D.GetLength(3) = {matrix6D.GetLength(3)}");
            Console.WriteLine($"matrix6D.GetLength(4) = {matrix6D.GetLength(4)}");
            Console.WriteLine($"matrix6D.GetLength(4) = {matrix6D.GetLength(5)}");
        }
    }
}
