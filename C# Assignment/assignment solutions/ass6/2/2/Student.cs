using System;


namespace _2
{
    class Student
    {
        int id;
	    string name;
	    int age;
        double per;
        Student next;
        public Student()
        {
            id = 0;
            name = "";
            age = 0;
            per = 0;
            next = null;
        }

        public Student(int i, string n, int a, int p)
        {
            id = i;
            name = n;
            age = a;
            per = p;
            next = null;
        }

        public Student NEXT
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }
        public override string  ToString()
        {
            string str="Id:" + id + "\nName:"+name+"\nAge"+age+"\nPercentage:"+per;
            return str;
        }

        public void accept()
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

       
    }
}
