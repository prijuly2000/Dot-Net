using System;

namespace _2
{
    class Program
    {
        public static void Main()
        {
            Emp[] e;
            e = new Emp[3];
            
            e[0] = new admin();
            e[1] = new Salesmgr();
            e[2] = new Programmer();
            
            foreach (Emp em in e) 
            {
                em.accept();
                em.display();
            }
                                    
            Console.ReadLine();
          
        }
    }
}
