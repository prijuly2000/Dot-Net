using System;


namespace _2
{
    class admin:Emp
    {
        int incent;

        public admin()
        {
            incent = 0;
        }
        public admin(string nm,int d,int m,int y,int i,int b,int inc):base(nm,d,m,y,i,b)
        {
            incent = inc;  
        }

        public void display()
        {
            base.display();
            calsal();
        
        }

        public void accept()
        {
            base.accept();
            Console.WriteLine("enter the incentive");
            incent = int.Parse(Console.ReadLine());
        }
        public void calsal()
        {
            Console.WriteLine("the salary=" + (base.calsal() + incent));
        }
    }   
}
