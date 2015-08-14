using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxUnboxDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            object obj;
            //Value type is converted into ref type => Boxing
            obj = x; //Allowed b'coz of is-a relationship
            //Upcasting going on
            //Console.WriteLine("x=" + x + "\tobj=" + obj);
            x = 20;
            Console.WriteLine("x=" + x + "\tobj=" + obj);

            //////////////////////////////////////////
            int y;
            y = (int)obj; //Downcasting
            Console.WriteLine(y); //Ref is converted into valuetype
            //unboxing

        }
    }
}
