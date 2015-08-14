using System;

namespace _2
{
    class Programmer:Emp
    {
        double costPerHrs;
        int extraHrs;
        
        public Programmer()
        {
            costPerHrs = extraHrs=0;
        }

        public Programmer(string nm,int d,int m,int y,int i,int s,int c,int e):base(nm,d,m,y,i,s)
        {
            costPerHrs = c;
            extraHrs = e;
        }

        public void calsal()
        {
            Console.WriteLine("Total salary : "+(base.calsal() + extraHrs * costPerHrs));
        }

        public void display()
        {
            base.display();
            calsal();
        }

        public void accept()
        {
            base.accept();
            Console.WriteLine("Enter the extra hours");
            extraHrs=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the cost per hours");
            costPerHrs = int.Parse(Console.ReadLine());
        }

    }
}
