using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OfficeUtility
{
    public class Person
    {
        string name;
        MyDate dob;
        public Person()
        {
            name = "";
            dob = new MyDate();
        }
        public Person(string nm,int d,int m,int y)
        {
            name = nm;
            dob = new MyDate(d,m,y);
        }
        public void Accept()
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            dob.Accept();
        }
        public void Display()
        {
            Console.WriteLine("Name=" + name);
            dob.Display();
        }

        public override string ToString()
        {
            string str = "\nName=" + name;
            str += dob.ToString();
            return str;
        }

        public override bool Equals(object obj)
        {
            Person p = (Person)obj;
            if (this.name == p.name && 
                this.dob.Equals(p.dob))
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
