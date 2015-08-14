using System;

namespace _2
{
    class Person
    {
        string name;
        Date dob;

        public Person()
        {
            name = "";
            dob = new Date();
        }

        public Person(string nm, int d, int m, int y)
        {
            name = nm;
            dob = new Date(d,m,y);
        }

        public void accept()
        {
            Console.WriteLine("Enter the name ");
            name=Console.ReadLine();
            Console.WriteLine("Enter the date of birth");
            dob.accept();
        }

        public void display()
        {
        
            Console.WriteLine("Name:"+name);
            dob.display();
        }

        public override string ToString()
        {
            string str = "\nName:" + name;
            str+=dob.ToString();
            return str;
        }
    }
}
