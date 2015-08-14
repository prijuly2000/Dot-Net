using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    class main
    {
        public static void Main()
        {
            string ch="y";
            int choice,index;
            int size, i;
            MyCollege c = new MyCollege();
            while(ch=="y" || ch=="Y")
            {
                Console.WriteLine("----ops----");
                Console.WriteLine("1.Create list");
                Console.WriteLine("2.Insert student");
                Console.WriteLine("3.Display");
                Console.WriteLine("4.Delete student");
                Console.WriteLine("Enter the choice");
                choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Enter the size:");
                        size=int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("-----Students Info-----");
                        for (i = 0; i < size; i++)
                        {
                            Student s1 = new Student();
                            s1.accept();
                            c[i] = s1;
                        }
                        break;
                    case 2:
                        Console.WriteLine("New student");
                        Student s=new Student();
                        s.accept();
                        Console.WriteLine("Enter the index");
                        index=int.Parse(Console.ReadLine());
                        c[index]=s;
                        break;
                    case 3:
                        Console.WriteLine(c);
                        break;
                    case 4:
                        Console.WriteLine("Enter the student to delete");
                        index=int.Parse(Console.ReadLine());
                        Student s2=c[index];
                        Console.WriteLine("Deleted student");
                        Console.WriteLine(s2);
                        break;
                }
                Console.WriteLine("Wanna conti(y/n)");
                ch=Console.ReadLine();
            }
            Console.ReadLine();
    
        }
        
    }
    
}
