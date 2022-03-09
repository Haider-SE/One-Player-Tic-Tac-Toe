using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Assignment
{
  
    class DelegateANDEventClass
    {
        public delegate void myhandler();
        public delegate void myhandler2();

        public event myhandler Event_1;
        public event myhandler Event_2;
        
        //this method is used to generate the event or you can say register the delegate 
        public void Event_generator()
        {
            Event_1 += Table_2;
            Event_1 += Table_3;
            Event_2 += Table_4;
            Event_2 += Table_5;
        }
        public void Event_Caller()
        {
            Event_1();
            Event_2();
        }
        public void Table_2()
        {
            Console.WriteLine("Table of 2");
            for (int i = 1; i <= 10; i++)
            {

                System.Console.WriteLine(i * 2);

            }

        }

        public void Table_3()
        {
            Console.WriteLine("Table of 3");
            for (int i = 1; i <= 10; i++)
            {

                System.Console.WriteLine(i * 3);
            }

        }
        public void Table_4()
        {
            Console.WriteLine("Table of 4");
            for (int i = 1; i <= 10; i++)
            {

                System.Console.WriteLine(4 * i);
            }
   
        }
        public void Table_5()
        {
            int z = 0;
            int a = 0;
            Console.WriteLine("Table of 5");
            for (int i = 1; i <= 10; i++)
            {

                System.Console.WriteLine(i * 5);
            }

        }
    }
}








