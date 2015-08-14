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
            Console.WriteLine("the salary=" + (base.calsal() + incent));
            return 1;
        }

        public override string ToString()
        {
            string str = "----- the info of admin---------\n";
            str+=base.ToString();
            str += "\nthe salary=" + (base.calsal() + incent);
            return str;
        }

        public int INC
        {
            get
            {
                return incent;
            }

            set
            {
                incent = value;
            }
        }


    }   
}
