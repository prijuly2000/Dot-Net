using System;

namespace _2
{
    class Person
    {
        string name;
        string dob,city;

        public Person()
        {
            name = "";
            dob = city = "";
        }

        public Person(string nm, string d,string c )
        {
            name = nm;
            dob = d;
            city = c;
        }

        public void accept()
        {
            Console.WriteLine("Enter the name ");
            name=Console.ReadLine();
            Console.WriteLine("Enter the dob ");
            dob = Console.ReadLine();
            Console.WriteLine("Enter the city ");
            city = Console.ReadLine();
        }

        public void display()
        {
            Console.WriteLine("name: "+name);
            Console.WriteLine("dob : "+dob);
            Console.WriteLine("city: "+city);
           
        }

        public string getname()
        {
            return name;
        }

        public string getdob()
        {
            return dob;
        }

        public string getcity()
        {
            return city;
        }

        public void setname(string nm)
        {
            name=nm;
        }
        public void setdob(string d)
        {
            dob=d;
        }
        public void setcity(string c)
        {
            city = c ;
        }

        public static void Main()
        {
            Person p = new Person();
            p.setname("pritesh");
            p.setdob("3-dec-1990");
            p.setcity("12mati");

            Console.WriteLine("Name:"+p.getname()+"\nDob:"+p.getdob()+"\ncity:"+p.getcity());
            
            Console.ReadLine();
        }
    }
}
