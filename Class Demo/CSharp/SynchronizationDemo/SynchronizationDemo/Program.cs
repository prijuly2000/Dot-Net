using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SynchronizationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer();
            ApplicationDocument a1 = 
                new ApplicationDocument("Header1", "Body1", "Footer1", p);
            ApplicationDocument a2 =
                new ApplicationDocument("Header2", "Body2", "Footer2", p);
            ApplicationDocument a3 =
                new ApplicationDocument("Header3", "Body3", "Footer3", p);

            //a1.PrintDocument();
            //a2.PrintDocument();
            //a3.PrintDocument();

            ThreadStart ts1 = new ThreadStart(a1.PrintDocument);
            ThreadStart ts2 = new ThreadStart(a2.PrintDocument);
            ThreadStart ts3 = new ThreadStart(a3.PrintDocument);

            Thread t1 = new Thread(ts1);
            Thread t2 = new Thread(ts2);
            Thread t3 = new Thread(ts3);


            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
