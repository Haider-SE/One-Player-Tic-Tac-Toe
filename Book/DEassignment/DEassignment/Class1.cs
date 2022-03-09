using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEassignment
{
    class Class1
    {
        public delegate void del1();
        public delegate void del2();


        public event del1 Event1;
        public event del2 Event2;


        public void Method1()
        {

            Event1 += Table2;
            Event1 += Table3;
            Event2 += Table4;
            Event2 += Table5;


        }
        public void Method2()
        {


            Event1();
            Event2();
        }




        public void Table2()
        {
             for (int i = 1; i <= 10; i++)
            {

             System.Console.WriteLine(i * 2);

            }
            System.Console.WriteLine("------------------");
        }

        public void Table3()
        {

            for (int i = 1; i <= 10; i++)
            {

                System.Console.WriteLine(i * 3);
            }
            System.Console.WriteLine("------------------");
        }
        public void Table4()
        {
           
            for (int i = 1; i <= 10; i++)
            {

                System.Console.WriteLine(4 * i);
            }
            System.Console.WriteLine("------------------");
        }
        public void Table5()
        {
            int z = 0;
            int a = 0;
            for (int i = 1; i <= 10; i++)
            {

                System.Console.WriteLine(i * 5);
            }
            System.Console.WriteLine("------------------");
        }
    }
}
