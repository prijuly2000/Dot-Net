using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DemoOfMultiThreading
{
    class Worker
    {
        public void DoWork1()
        {
            string str = "HAPPY DIWALI...";
            foreach (char ch in str)
            {
                Console.Write(ch);
                Thread.Sleep(500);
            }
        }

        public void DoWork2()
        {
            string str = "BYE BYE PUNE ....";
            foreach (char ch in str)
            {
                Console.Write(ch);
                Thread.Sleep(500);
            }
        }

        public void DoWork(object obj)
        {
            string str = obj as string;
            foreach (char ch in str)
            {
                Console.Write(ch);
                Thread.Sleep(500);
            }
        }

    }
}
