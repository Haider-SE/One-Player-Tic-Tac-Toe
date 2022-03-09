using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingAssignment
{
    class Program
    {  public delegate void Main_threading_delegate();
        static void Main(string[] args)
        {
            MultiThreadingClass start = new MultiThreadingClass();
            Main_threading_delegate s = new Main_threading_delegate(start.Event_generator);
            s += start.EventCaller;
            s(); //Here the Delegate call occurs;
            Console.Read();
        }
    }
}
