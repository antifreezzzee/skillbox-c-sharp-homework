using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_004
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заказчик просит написать программу, которая определяет текущую температуру 
            // и даёт рекомендацию по выбору одежды для прогулки

            Random rand = new Random();

            int temperature = rand.Next(30);    // Выдаёт от 0 до 30
            Console.WriteLine($"Текущая температура = {temperature}°с");

            if (temperature < 18)
            {
                Console.WriteLine("На улице прохладно, рекомендую взять куртку потеплее");
            }
            else
            {
                Console.WriteLine("На улице тепло, теплая куртка не понадобится");
            }
        }
    }
}
