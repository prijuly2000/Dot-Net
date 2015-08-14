using System;


namespace _2
{
    class Emp:Person
    {
        int id;
        protected double basic;
        public Emp()
        {
            id = 0;
            basic = 0;
        }

        public Emp(string nm,int d,int m,int y,int i, int b):base(nm,d,m,y)
        {
            id = i;
            basic = b;
        }
        public virtual double calsal()
        {
            return basic;
        }
        public virtual new void accept()
        {
            Console.WriteLine("Enter the id");
            id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the salary");
            basic=int.Parse(Console.ReadLine());
            base.accept();
        }

        public virtual new void display()
        {
            
            Console.WriteLine("Id:"+id);
            Console.WriteLine("Basic salary:"+basic);
            base.display();
        }
        public override string ToString()
        {
            string str = "\nId:" + id;
            str+=base.ToString();
            str += "\nBasic salary:" + basic;
            return str;
        }

      

    }
}
