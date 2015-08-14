using System;


namespace ass3
{
    class MedStudent : Student
    {
        string Branch;
        int InternalMarks;

        public MedStudent()
        {
            Branch = "";
            InternalMarks = 0;
        }

        public MedStudent(int i, string n, int a, int p, string b, int inter):base(i,n,a,p)
        {
            Branch = b;
            InternalMarks = inter;
        }

        public override void accept()
        {
            base.accept();
            Console.WriteLine("Enter the branch");
            Branch=Console.ReadLine();

            Console.WriteLine("Enter the internal marks");
            InternalMarks = int.Parse(Console.ReadLine());

            
        }

        public override void display()
        {
            Console.WriteLine("------Med Student-----");
            base.display();
            Console.WriteLine("\nBranch:" + Branch + "\nINternal marks:" + InternalMarks);
            calrank();
        }

        public override void calrank()
        {
            int rank =(int)per ;
            Console.WriteLine("\nRank:"+rank);
        }

    }
}
