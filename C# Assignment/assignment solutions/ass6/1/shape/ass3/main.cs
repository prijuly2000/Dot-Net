using System;
using Anup_Ashu;
using ashu;

namespace ass3
{
    class main
    {
        public static void Main()
        {
            Shape[] s = new Shape[3];
            
            MyShape s2 = new MyShape(3);
            int r, l, b;
            
            Console.WriteLine("Enter the radius for circle : ");
            r=int.Parse(Console.ReadLine());
            s[0] = new Circle(r);

            Console.WriteLine("Enter the length & breadth for rectangle :");
            l=int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            s[1] = new Rectangle(l,b);

            Console.WriteLine("Enter the height & width for triangle");
            l = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            s[2] = new Triangle(l,b);

            s2[0] = s[0];
            s2[1] = s[1];
            s2[2] = s[2];

            Console.WriteLine("\n----Circle----");
            Console.WriteLine(s2[0]);

            Console.WriteLine("\n----Rectangle----");
            Console.WriteLine(s2[1]);
            
            Console.WriteLine("\n----Triangle----");
            Console.WriteLine(s2[2]);
            
            Console.ReadLine();
        }
    }
}
