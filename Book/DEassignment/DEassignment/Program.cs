using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEassignment
{
    class Program
    {
        public delegate void del();
        static void Main(string[] args)
        {
            Class1 a = new Class1();

          
            del d = new del(a.Method1);

            d += a.Method2;
            d(); // Delegate call occur;
        }
    }
}
