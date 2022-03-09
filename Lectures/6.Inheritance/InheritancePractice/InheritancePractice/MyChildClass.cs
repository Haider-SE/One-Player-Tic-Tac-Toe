using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class MyChildClass:MyParentClass
    {
        new public string feild1 = "This is Child Class";
        override public void ParentsMethod(String value)
        {
            Console.WriteLine("Parent Method of child class:{0}",value);
        }
    }
}
