using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example_752
{

    class Program
    {
        static void Main(string[] args)
        {
            #region Computer1

            //Computer1 computer1 = new Computer1("Computer 1");
 

            //computer1.ActivationBIOS();
            //computer1.ActivationOS();
            //computer1.Greeting();

            //computer1.Calculation();

            //computer1.Parting();
            //computer1.DeactivationOS();
            //computer1.DeactivationBIOS();

            //Console.ReadKey();
            //Console.WriteLine();

            #endregion

            #region Computer2
             

            //Computer2 computer2 = new Computer2("Computer 2");

            //computer2.PowerOff();
            //computer2.PowerOff();
            //computer2.PowerOff();

            //computer2.PowerOn();

            //Console.ReadKey();

             

            #endregion

            #region Computer3

            Computer3 computer3 = new Computer3("Computer 3");

            for (int i = 0; i < 3; i++)
            {
                computer3.Power();
                Console.WriteLine(computer3.Indicator);

                Console.ReadKey();
            }
         

            Console.ReadKey();
        

            #endregion

        }
    }
}
