using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Assignment
{
    class Subscriber1_
    {
        public Subscriber1_() { }
        public Subscriber1_(Publisher1 pub) {
            pub.Event1 += Table2;
            pub.Event1 += Table3;


        }
        
        public static void Table2()
        {
            Console.WriteLine("Table2");
            for (int i = 1; i <= 10; i++)
            {

                System.Console.WriteLine("2 *" + i + "=" + i * 2);
            }
        }
        public static void Table3()
        {
            Console.WriteLine("Table3");
            for (int i = 1; i <= 10; i++)
            {

                System.Console.WriteLine("3 *" + i + "=" + i * 3);
            }
        }
        





    }
}
