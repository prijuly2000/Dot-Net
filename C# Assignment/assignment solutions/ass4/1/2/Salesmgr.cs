using System;

namespace _2
{
    class Salesmgr:Emp
    {
        double comm;
        public Salesmgr()
        {
            comm = 0;
        }
        public Salesmgr(string nm,int d,int m,int y,int i,int b,int c):base(nm,d,m,y,i,b)
        {
            comm = c;
        }

        public override double calsal()
        {
            Console.WriteLine("salary="+(basic+comm));
            return 1;
        }
        public override  void display()
        {
            Console.WriteLine("--------the info of salesmgr-----------");
            base.display();
            calsal();
        }

        public override  void accept()
        {
            Console.WriteLine("enter the info of salesmgr");
            base.accept();
            Console.WriteLine("enter the commission");
            comm=int.Parse(Console.ReadLine());
        }
    }
}
