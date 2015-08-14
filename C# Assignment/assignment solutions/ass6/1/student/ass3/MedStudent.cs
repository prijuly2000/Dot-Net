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

        public override string ToString()
        {
            string str="------Med Student-----";
            str+=base.ToString();
            str+="\nBranch:" + Branch + "\nINternal marks:" + InternalMarks;
            int rank = (int)per;
            str+="\nRank:" + rank;
            return str;
        }

        public override void calrank()
        {
            int rank =(int)per ;
            Console.WriteLine("\nRank:"+rank);
        }

    }
}
