using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handler_prac
{
    class Dozen //Subscriber
    {
        public int counter {
            get;
            set;
        }
        public Dozen(Incrementer inc)
        {
            counter = 0;
            // function registration 
            inc.CountADozen += CounterGenerator;
        }

        void CounterGenerator() //event handler
        {
            counter++;
        }
    }
}
