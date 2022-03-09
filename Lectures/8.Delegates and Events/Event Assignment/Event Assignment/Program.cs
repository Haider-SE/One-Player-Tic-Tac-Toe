using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Assignment
{
    
    class Program
    {
        public delegate void maindelegate();
        static void Main(string[] args)
        {
            DelegateANDEventClass a = new DelegateANDEventClass();


            maindelegate d = new maindelegate(a.Event_generator);

            d += a.Event_Caller;
            d(); // here the Delegate call occurs
            Console.Read();
        }
    }
}
