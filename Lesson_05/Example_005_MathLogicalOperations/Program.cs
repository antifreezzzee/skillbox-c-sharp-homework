using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_005_MathLogicalOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 30, x2 = 150,  // Координаты вершин прямоугольника
                y1 = 20, y2 = 90;

            int pA = 50, pB = 110;  // Координаты точки

            // Проверка условия принадлежности точки ограниченной области
            bool check = ((pA >= x1) && (pA <= x2)) && ((pB >= y1) && (pB <= y2));
            Console.WriteLine(check);
            Console.ReadKey();
            #region _
            Console.ReadKey();

            pA = 50; pB = 110;
            check = ((pA >= x1) && (pA <= x2)) && ((pB >= y1) && (pB <= y2));
            Console.WriteLine(check);

            #endregion

                        
        }
    }
}
