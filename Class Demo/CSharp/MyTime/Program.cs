using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTime
{
    class Program
    {
        static void Main1(string[] args)
        {
            Time t1 = new Time(10, 20, 30);
            Time t2 = new Time(10, 20, 30);
           // t2 = t1;
            if (t1.Equals(t2))  
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

        static void Main2(string[] args)
        {
            Time t1 = new Time(10, 1, 20);
            Time t2 = new Time(1, 20, 30);
            Time t3;
            t3 = t1 + t2; // Time.operator+(t1,t2);
            if (t1 > t2)  //Time.operator>(t1,t2)
            {
                Console.WriteLine("t1 is greater");
            }
            else
            {
                Console.WriteLine("t2 is greater");
            }
        }

        static void Main3()
        {
            int x = 10;
            Time t;
            t = x;
            Console.WriteLine(t.ToString());

            x = (int)t; 
            Console.WriteLine(x);
        }

        static void Main()
        {
            Time t1 = new Time(1, 1, 2);
            Console.WriteLine(t1[10]);
        }

    }
}
