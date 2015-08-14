using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SynchronizationDemo
{
    class ApplicationDocument
    {
        string header, body, footer;
        Printer p;
        public ApplicationDocument(string h, string b, 
            string f,Printer p)
        {
            header = h;
            body = b;
            footer = f;
            this.p = p;            
        }
        public void PrintDocument()
        {
            //Lock the resource
            Monitor.Enter(p);
           //Use the resource
            p.DoPrint(header, body, footer);
            //Release the resource
            Monitor.Exit(p);
        }
    }
}
