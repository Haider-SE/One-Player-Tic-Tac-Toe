using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            MyChildClass oc = new MyChildClass();
            oc.ParentsMethod(oc.feild1);
            Console.Read();
        }
    }
}
