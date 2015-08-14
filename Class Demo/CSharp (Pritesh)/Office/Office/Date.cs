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

        public override string ToString()
        {
            string str = "\nDD/MM/YYYY = " + dd + ":" + mm + ":" + yy;
            return str;
        }

        public int DD    //property doesnt have this & [] & any name can be given. Here name can be different & can be overloaded
        {//property has get & set methods
            get
            {
                return dd;
            }

            set
            {
                dd = value;
            }
        }

        public int MM  // property doesnt have this & [] & any name can be given. Here name can be different & can be overloaded
        {// property has get & set methods
            get
            {
                return mm;
            }
            set
            {
                mm = value;
            }
        }

        public int YY   //property doesnt have this & [] & any name can be given. Here name can be different & can be overriden & can be abstract
        {// property has get & set methods
            get
            {
                return yy;
            }

            set
            {
                yy = value;
            }
        }

        public int this[int index] //indexer has [] & index (anyname) & contains this keyword. Here only data type changes but this is always constant
        {// indexer has get & set methods
            get
            {
                if (index == 0)
                    { return dd; }
                else if (index == 1)
                    { return mm; }
                else 
                { return yy; }
            }

            set
            {
                if (index == 0)
                { dd = value; }
                else if (index == 1)
                { mm = value; }
                else
                { yy = value; }

            }

        }
    }
}
