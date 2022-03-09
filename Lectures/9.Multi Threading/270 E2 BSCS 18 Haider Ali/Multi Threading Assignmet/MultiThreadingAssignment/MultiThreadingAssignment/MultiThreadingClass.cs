using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace MultiThreadingAssignment
{
    class MultiThreadingClass
    {
        public delegate void threading_delegate_1();
        public delegate void threading_delegate_2();
        public event threading_delegate_1 Event_1;
        public event threading_delegate_1 Event_2;
        public void Event_generator()
        {

            Event_1 += thread_1;
            Event_2 += thread_2;
        }
        public void EventCaller()
        {
            Event_1();
            Event_2();
        }
        public void thread_1()
        {
            Thread t1 = new Thread(Table_2);
            Thread t2 = new Thread(Table_3);

            t1.Start();
            t2.Start();

        }
        public void thread_2()
        {
            Thread t3 = new Thread(Table_4);
            Thread t4 = new Thread(Table_5);

            t3.Start();
            t4.Start();

        }
        public void Table_2()
        {
            Console.WriteLine("Table of 2\n");
            for (int i = 1; i <= 10; i++)
            {
                System.Console.WriteLine(2 * i);
            }

        }
        public void Table_3()
        {
            Console.WriteLine("Table of 3");
            for (int i = 1; i <= 10; i++)
            {
                System.Console.WriteLine(3 * i);
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

            Console.WriteLine("Table of 5");
            for (int i = 1; i <= 10; i++)
            {

                System.Console.WriteLine(i * 5);
            }

        }
    }
}
