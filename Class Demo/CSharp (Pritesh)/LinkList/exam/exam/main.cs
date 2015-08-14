using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam
{
    class main
    {
        public static void Main()
        {
            LinkList l1 = new LinkList();
            LinkList l2 = new LinkList();
            int index, data,choice;
            string ch="y";
            while (ch == "y" || ch == "Y")
            {
                Console.WriteLine("---Operations---");
                Console.WriteLine("1.Insert using indexer");
                Console.WriteLine("2.display");
                Console.WriteLine("3.Equals method");
                Console.WriteLine("Enter the choice");
                choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("ENter the index ");
                        index = int.Parse(Console.ReadLine());
                        Console.WriteLine("ENter the data");
                        data = int.Parse(Console.ReadLine());
                        l1[index] = data;
                        break;
                    case 2:
                        Console.WriteLine("Link list:");
                        Console.WriteLine(l1);
                        break;


                }

                Console.WriteLine("Wanna conti(y/n)");
                ch=Console.ReadLine();
            }

            
            
            Console.ReadLine();
        }
    }
}
