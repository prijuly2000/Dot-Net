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

        public void calsal()
        {
            Console.WriteLine("salary="+(base.calsal()+comm));
        }
        public void display()
        {
            base.display();
            calsal();
        }

        public void accept()
        {
            base.accept();
            Console.WriteLine("enter the commission");
            comm=int.Parse(Console.ReadLine());
        }
    }
}
