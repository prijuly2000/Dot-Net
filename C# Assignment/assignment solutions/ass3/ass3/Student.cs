using System;


namespace ass3
{
    abstract class Student
    {
        int id;
	    string name;
	    int age;
        protected double per;

        public Student()
        {
            id = 0;
            name = "";
            age = 0;
            per = 0;
        }

        public Student(int i, string n, int a, int p)
        {
            id = i;
            name = n;
            age = a;
            per = p;
        }

        public virtual void display()
        {
            Console.WriteLine("Id:" + id + "\nName:"+name+"\nAge"+age+"\nPercentage:"+per);
        }

        public virtual void accept()
        {
            Console.WriteLine("Enter Id:");
            id=int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter the name:");
            name=Console.ReadLine(); 
            Console.WriteLine("\nEnter the Age");
            age=int.Parse(Console.ReadLine()); 
            Console.WriteLine("\nEnter the Percentage:");
            per = double.Parse(Console.ReadLine());
        }

        public abstract void calrank();
    }
}
