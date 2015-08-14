using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    class Program
    {
        public static void Main()
        {
            admin a = new admin();
            Salesmgr s = new Salesmgr();
            Programmer p = new Programmer();
            Console.WriteLine("enter the info of admin");
            a.accept();
            Console.WriteLine("enter the info of salesmgr");
            s.accept();
            Console.WriteLine("enter the info of programmer");
            p.accept();

            Console.WriteLine("----- the info of admin---------");
            a.display();            
            Console.WriteLine("--------the info of salesmgr-----------");
            s.display();
            Console.WriteLine("----------the info of progrmr---------");
            p.display();
            
            Console.ReadLine();
        }
    }
}
