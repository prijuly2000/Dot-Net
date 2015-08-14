using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ass5
{
    class program
    {
        public static void Main()
        {
            Current c1 = new Current();
            Saving s1 = new Saving();

            c1.accept();
            s1.accept();

            c1.display();
            s1.display();
           // Console.ReadLine();

        }
    }
}
