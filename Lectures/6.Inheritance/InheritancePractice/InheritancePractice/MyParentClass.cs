using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class MyParentClass
    {
        public string feild1 = "This is parent class\n";
        virtual public void ParentsMethod(String value)
        {
            Console.WriteLine("Parent Method:{0}",value);
        }
    }
}
