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

        public override void display()
        {
            Console.WriteLine("----- the info of admin---------");
            base.display();
            calsal();
        
        }

        public override void accept()
        {
            Console.WriteLine("enter the info of admin");
            base.accept();
            Console.WriteLine("enter the incentive");
            incent = int.Parse(Console.ReadLine());
        }
        public override double calsal()
        {
            Console.WriteLine("the salary=" + (basic + incent));
            return 1;
        }
    }   
}
