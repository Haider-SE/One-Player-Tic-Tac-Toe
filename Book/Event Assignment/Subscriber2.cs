using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Assignment
{
    class Subscriber2
    {
        public Subscriber2() { }
        public Subscriber2(Publisher1 pub)
        {
            pub.Event2 += Table4;
            pub.Event2 += Table5;

        }
        public static void Table4()
        {
            Console.WriteLine("Table4");
            for (int i = 1; i <= 10; i++)
            {

                System.Console.WriteLine("4 *" + i + "=" + i * 4);
            }
        }
        public static void Table5()
        {
            Console.WriteLine("Table5");
            for (int i = 1; i <= 10; i++)
            {

                System.Console.WriteLine("5 *" + i + "=" + i * 5);
            }
        }
       
    }
}
