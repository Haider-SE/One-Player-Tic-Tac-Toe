using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handler_prac
{
    public delegate void Handler();
    class Incrementer //Publisher
    {
        public event Handler CountADozen; // event declaration
        
       
        public void Event_raiser()
        {
            for (int i = 0; i < 400; i++)
            {
                if (i % 12 == 0 && CountADozen != null)
                {
                    
                    CountADozen(); // event invoke
                }
            }
        }

    }
}
