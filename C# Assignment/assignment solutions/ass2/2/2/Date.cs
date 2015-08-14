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

        public int getdd()
        {
            return dd;
        }
        public int getmm()
        {
            return mm;
        }
        public int getyy()
        {
            return yy;
        }

        public void setdd(int d)
        {
            dd = d ;
        }
        public void setmm(int m)
        {
            mm = m;
        }
        public void setyy(int y)
        {
            yy = y;
        }

        public static void Main()
        {
            Date d = new Date(3,12,1990);
            d.display();
            d.setdd(10);
            d.setmm(10);
            d.setyy(2010);

            Console.WriteLine("Date:"+d.getdd()+"-"+d.getmm()+"-"+d.getyy());
            Console.ReadLine();
        }
    }
}
