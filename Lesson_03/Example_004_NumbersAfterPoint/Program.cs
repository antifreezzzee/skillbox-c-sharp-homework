using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_004_NumbersAfterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            //double d = 123456.654321;
            //Console.WriteLine(d);                       // 123456.654321

            //string dFormated = d.ToString("#.###");     
            //Console.WriteLine(dFormated);               // 123456,654

            //Console.WriteLine("{0:0.000}", d);          // 123456,654

            //Console.WriteLine(d.ToString("#.###"));     // 123456,654


            //dFormated = d.ToString("#.## ## ## ## ##"); 
            //Console.WriteLine(dFormated);               // 123456,65 43 21

            //dFormated = d.ToString("### ###.## ## ## ## ##"); 
            //Console.WriteLine(dFormated);               // 123 456,65 43 21   

            //Console.WriteLine("{0:000 000 000.000 000 000}", d); // 000 123 456,654 321 000


            #region Замечание

            // В зависимости от настроек языкового стандарта программы
            // выводимые символы могут отличаться. 
            Console.WriteLine();
            var date = new DateTime(2025, 09, 28, 01, 30, 59);
            Console.WriteLine(date);                    // 
                                                        // 
                                                        //
            Console.ReadKey();
            Console.WriteLine($"{date:HH:mm}");         
            Console.WriteLine($"{date:yyyy-MM-dd}");  
            Console.WriteLine($"{date:yy.MM.dd}");      
            Console.WriteLine($"{date:dd.MM.yyy}");     



            #endregion



        }
    }
}
