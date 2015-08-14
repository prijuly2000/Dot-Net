using System;

namespace OOPsConcept
{
    class Program
    {
        //static void Main1()
        //{           
        //    Console.WriteLine("Hello World");
        //    MyDate d1; //d1 is reference of MyDate
        //    d1 = new MyDate();
        //   // d1.Accept();
        //    d1.Display();
        //}
        //static void Main2()
        //{
        //    Person p1; //Reference of Person
        //    p1 = new Person("Dhanajay", 24, 10, 1984);
        //    p1.Display();
        //}


        //static void Main3()
        //{
        //    Emp e1 = new Emp();
        //    e1.Display();

        //}
        //static void Main4()
        //{
        //    Emp e1 = new Emp("Ashwini", 24, 10, 1981, 101, 10000);
        //    e1.Display();
        //}

        //static void Main5()
        //{
        //    Programmer p1 = new Programmer("PPP", 10, 10, 1990, 101, 1000, 10, 100);
        //    SalesMgr s1 = new SalesMgr("SSS", 20, 10, 1980, 202, 2000, 200);
        //    Admin a1 = new Admin("AAA", 30, 10, 1980, 303, 3000, 300);

        //    p1.Display();
        //    s1.Display();
        //    a1.Display();
        //}

        static void Main6()
        {
            Emp[] allEmp; //Reference of an array
            allEmp = new Emp[3]; //Array of reference

            allEmp[0] = new Programmer("PPP", 10, 10, 1990, 101, 1000, 10, 100);
            allEmp[1] = new SalesMgr("SSS", 20, 10, 1980, 202, 2000, 200);
            allEmp[2] = new Admin("AAA", 30, 10, 1980, 303, 3000, 300);

            foreach (Emp e in allEmp)
            {               
               //Internally compiler calls ToString method on e
                //e.ToString()
                //System.object's ToString method returns the 
                //datatype depending on object at runtime
                Console.WriteLine(e);
                //Show the information of Pro or SM or Admin

            }
            
        }

        static void Main7()
        {
            MyDate d1 = new MyDate(12, 10, 2010);
            Console.WriteLine(d1.day);
            d1.day = 21;

        }

        public static void Main8()
        {
            MyOffice m1 = new MyOffice(4);
            Programmer p1 = new Programmer("PPP", 10, 10, 1990, 101, 1000, 10, 100);
            SalesMgr s1 = new SalesMgr("SSS", 20, 10, 1980, 202, 2000, 200);
            Admin a1 = new Admin("AAA", 30, 10, 1980, 303, 3000, 300);
           //[] cannot be used with non array
            m1[1] = p1;
            m1[3] = s1;

            Console.WriteLine(m1);

        }

        public static void Main9()
        {
            Programmer p1 = new Programmer("PPP", 10, 10, 1990, 101, 1000, 10, 100);
            Programmer p2 = new Programmer("PPP", 10, 10, 1990, 101, 1000, 10, 100);
            if (p1.Equals(p2))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

        }


        public static void AttendMeeting(Emp e)
        {
            if (e is Programmer)
            {
                Programmer p = (Programmer)e;
                p.Display();
            }
            else if (e is SalesMgr)
            {
                SalesMgr s = (SalesMgr)e;
                s.Display();
            }
            else if (e is Admin)
            {
                Admin a = (Admin)e;
                a.Display();
            }
        }
        public static void AttendMeeting1(Emp e)
        {
            Programmer p = e as Programmer;
            if (p != null)
            {
                p.Display();
            }
            SalesMgr s = e as SalesMgr;
            if (s != null)
            {
                s.Display();
            }
            Admin a = e as Admin;
            if (a != null)
            {
                a.Display();
            }
        }

        public static void Main()
        {
            Programmer p1 = new Programmer("PPP", 10, 10, 1990, 101, 1000, 10, 100);
            SalesMgr s1 = new SalesMgr("SSS", 20, 10, 1980, 202, 2000, 200);
            Admin a1 = new Admin("AAA", 30, 10, 1980, 303, 3000, 300);


            AttendMeeting1(s1);

        }
    }
}

