using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace indexer__poperty
{
    class program
    {
        public static void Main()
        {
            Time t1 = new Time();
            
            //Use of Property 
            t1.HR = 10;
            t1.MIN = 10;
            t1.SEC = 10;
            Console.WriteLine("Property o/p : "+t1.HR+" : "+t1.MIN+" : "+t1.SEC);

            //Use of indexer
            t1[0] = 20;
            t1[1] = 20;
            t1[2] = 20;
            Console.WriteLine("Indexer o/p :"+t1[0]+" : "+t1[1]+" : "+t1[2]);
            Console.ReadLine();
        }
    }
}
