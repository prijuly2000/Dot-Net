using System;


namespace _2
{
    class Date
    {
        int dd, mm, yy;
        public Date()
        {
            dd = mm = yy = 0;
        }

        public Date(int d,int m,int y)
        {
            dd = d;
            mm = m;
            yy = y;
        }

        public void display()
        {
            Console.WriteLine("DD/MM/YYYY = "+dd+":"+mm+":"+yy);
        }

        public void accept()
        {
            dd=int.Parse(Console.ReadLine());
            mm = int.Parse(Console.ReadLine());
            yy = int.Parse(Console.ReadLine());
        }
    }
}
