using System;


namespace OOPsConcept
{
    class MyDate
    {
        int dd, mm, yy;
        public MyDate()
        {
            dd = 0; 
            mm = 0;
            yy = 0;
        }
        public MyDate(int d, int m, int y)
        {
            dd = d;
            mm = m;
            yy = y;
        }
        public void Accept()
        {
            Console.WriteLine("Enter dd,mm and yy");
            dd = int.Parse(Console.ReadLine());
            mm = int.Parse(Console.ReadLine());
            yy = int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Date :" + dd + "/" + mm + "/" + yy);
        }

        public override string ToString()
        {
            string str = "\tDate : "+dd + "/" + mm + "/" + yy;
            return str;
        }

        public int day
        {
            get
            {
                return dd;
            }
            set
            {
                if (value >= 1 && value <= 31)
                {
                    dd = value;
                }
            }
        }

        public override bool Equals(object obj)
        {
            MyDate d = (MyDate)obj;
            if (this.dd == d.dd && 
                this.mm == d.mm && 
                this.yy == d.yy)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
    }
}
