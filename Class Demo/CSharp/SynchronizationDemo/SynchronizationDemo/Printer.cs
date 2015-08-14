using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SynchronizationDemo
{
    class Printer
    {
        public void DoPrint(string header, string body,
            string footer)
        {
            Console.WriteLine(header);
            Thread.Sleep(2000);
            Console.WriteLine(body);
            Thread.Sleep(2000);
            Console.WriteLine(footer);
            Thread.Sleep(2000);
        }
    }
}

