using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Assignment
{
    delegate void Handler__();
    class Publisher1
    {
        public event Handler__ Event1;///Create an event
        public event Handler__ Event2; //Create another event
        public void EventRaiser()
        {
            if (Event1 != null)
            {
                Event1();// invoke the event
                Event2();
            }
        }



    }
}
