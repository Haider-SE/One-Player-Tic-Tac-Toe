using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher1 pub = new Publisher1();
            Subscriber1 s1 = new Subscriber1(pub);
            Subscriber2 S2 = new Subscriber2(pub);
            pub.EventRaiser();
            System.Console.ReadKey();





        }
    }
    
}
