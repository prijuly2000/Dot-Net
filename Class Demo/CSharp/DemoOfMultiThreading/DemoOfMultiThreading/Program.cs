using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DemoOfMultiThreading
{
    class Program
    {
        static void Main1(string[] args)
        {
            Worker w = new Worker();
            ThreadStart ts = new ThreadStart(w.DoWork1);
            Thread t1 = new Thread(ts);
            t1.Start();
            w.DoWork2();
        }
        static void Main2(string[] args)
        {
            Worker w = new Worker();
            ParameterizedThreadStart ts = 
                new ParameterizedThreadStart(w.DoWork);
            Thread t1 = new Thread(ts);
            t1.Start("*********HAPPY DIWALI******");

            w.DoWork("###########################");
        }

        static void Main(string[] args)
        {
            Worker w = new Worker();
            ParameterizedThreadStart ts =
                new ParameterizedThreadStart(w.DoWork);
            Thread t1 = new Thread(ts);
            t1.IsBackground = true;

            t1.Start("*********HAPPY DIWALI******");

          
            w.DoWork("######");

            if (t1.Join(10000))
            {
                Console.WriteLine("Joined Successfully");
            }
            else
            {
                Console.WriteLine("Join Failed..");
            }

        }
    }
}
