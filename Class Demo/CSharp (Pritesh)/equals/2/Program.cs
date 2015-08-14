using System;

namespace _2
{
    class Program
    {
        public static void Main1()
        {
            Emp[] e;
             e = new Emp[3];
            
             e[0] = new admin();
             e[1] = new Salesmgr();
             e[2] = new Programmer();
            
             foreach (Emp em in e) 
             {
                
                 em.accept();
                 em.display();
                 Console.WriteLine(em);
                 Console.WriteLine("-------------------------------\n\n");
             }
           
             Date d1 = new Date();
             d1.DD = 20;
             d1.MM = 20;
             d1.YY = 20;
            
             Console.WriteLine("DD:MM:YY = "+d1.DD+":"+d1.MM+":"+d1.YY);
             d1[0] = 30;
             d1[1] = 30;
             d1[2] = 30;

             Console.WriteLine(d1[0]+" : "+d1[1]+" : "+d1[2]);
             Console.ReadLine();
              



        }

        public static void Main()
        {
            //Date class equals method
           /* Date d1 = new Date(10,10,2012);
            Date d2 = new Date(10, 10, 2012);
           // d2 = d1; //here address is cpied so o/p is equal
            

            if (d1.Equals(d2)) //here only address is checked instead of data so o/p is not equal
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }*/

            //Person class equals method
            /*
            Person p1 = new Person("p",10,10,2012);
            Person p2 = new Person("p", 10, 10, 2012);

            if (p1.Equals(p2))
            {
                Console.WriteLine("Equal Person");
            }
            else
            {
                Console.WriteLine("Not Equal person");
            }*/

            //Emp class equals method
            /*
            Emp e1 = new Emp("p", 10, 10, 2012,1,1000);
            Emp e2 = new Emp("p", 10, 10, 2012, 1, 1000);

            if (e1.Equals(e2))
            {
                Console.WriteLine("Equal Emps");
            }
            else
            {
                Console.WriteLine("Not Equal Emps");
            }*/

            //Programmer class equals method
            /*
            Programmer p1 = new Programmer("p", 10, 10, 2012, 1, 1000,100,10);
            Programmer p2 = new Programmer("p", 10, 10, 2012, 1, 1000, 100, 10);

            if (p1.Equals(p2))
            {
                Console.WriteLine("Equal Programmers");
            }
            else
            {
                Console.WriteLine("Not Equal Programmers");
            }*/


            Programmer p1 = new Programmer("p", 10, 10, 2012, 1, 1000,100,10);
            AttendMeeting(p1);

            Salesmgr s1 = new Salesmgr("sss", 10, 20, 30, 40, 50, 60);
            admin a1 = new admin("aaa", 10, 20, 30, 40, 50, 60);
            AttendMeeting(s1);

            Console.ReadLine();
        }

        public static void AttendMeeting(Emp e)
        {

            if (e is Programmer) //step 1,is only checks if e is programmer or not
            {
                e.display(); //step 2
            }
            else
            {
                Console.WriteLine("\n\n\nSalesmgr to Programmer Not possible");
            }

            Programmer p = e as Programmer; // as checks & typecasts e into programmer
            if (p!=null)
            {
                p.display();
            }

        }
    }
}
