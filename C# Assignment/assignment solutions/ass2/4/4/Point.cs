using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4
{
    class Point
    {
        int x, y;
        public Point()
        {
            x = y = 0;
        }
        public Point(int a, int b)
        {
            x = a;
            y = b;
        }

        public void display()
        {
            Console.WriteLine("P(X,Y)="+" ( "+x+" , "+y+" )");
        }

        public void setx(int a)
        {
            x = a;
        }

        public void sety(int b)
        {
            y = b;
        }

        public int getx()
        {
            return x;
        }
        public int gety()
        {
            return y;
        }
        public static void Main()
        {
            Point p = new Point();
            Console.WriteLine("Enter the point(X,Y)");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            p.setx(x);
            p.sety(y);

            Console.WriteLine("P(X,Y)=" + " ( " + p.getx() + " , " + p.gety() + " )");
            Console.ReadLine();
        }
    }
}
