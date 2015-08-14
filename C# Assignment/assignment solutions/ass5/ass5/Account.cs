using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ass5
{
    class Account
    {
        int id;
	    string name;
        int age;
        int balance;

        public Account()
        {
            balance=id = age = 0;
            name = "";
        }

        public Account(int i, string n, int a, int b)
        {
            id=i;
            name = n;
            age = a;
            balance = b;
        }

        public virtual void display()
        {
            Console.WriteLine("\nid:" + id + "\nName:" + name + "\nAge:" + age + "\nBalance:" + balance);
        }

        public virtual void accept()
        {
            Console.WriteLine("Enter the id");
            id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the balance");
            balance = int.Parse(Console.ReadLine());

        }

        public virtual double calbal()
        {
            return (double)balance;
        }



    }
}
