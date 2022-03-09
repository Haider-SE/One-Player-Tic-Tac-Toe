using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handler_prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Incrementer incr = new Incrementer();
            Dozen doz = new Dozen(incr);
            incr.Event_raiser();

            System.Console.WriteLine("Number of dozen in defined loop is = {0}", doz.counter);

            System.Console.ReadKey();




        }
    }
}
