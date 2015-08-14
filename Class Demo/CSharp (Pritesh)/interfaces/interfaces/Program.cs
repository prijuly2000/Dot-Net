using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interfaces
{
    class main
    {
        static void Main()
        {
            IA p = new provider();
            p.FA();
            //p.FB();
            //p.FC();
            ((provider)p).FAA();
            Console.ReadLine();
        }
    }
}
