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
                Console.WriteLine(em);
                Console.WriteLine("-------------------------------\n\n");
            }
            
            /*
             * Date d1 = new Date();
            d1.DD = 20;
            d1.MM = 20;
            d1.YY = 20;
            
            Console.WriteLine("DD:MM:YY = "+d1.DD+":"+d1.MM+":"+d1.YY);
            d1[0] = 30;
            d1[1] = 30;
            d1[2] = 30;

            Console.WriteLine(d1[0]+" : "+d1[1]+" : "+d1[2]);
        
             */
            Console.ReadLine();
        
          
        }
    }
}
