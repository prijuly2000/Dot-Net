using System;


namespace ass3
{
    class EngStudent:Student
    {
        string spl;
        int internalmarks;

        public EngStudent()
        {
            spl = "";
            internalmarks = 0;
        }

        public EngStudent(int i, string n, int a, int p, string b, int inter)
            : base(i, n, a, p)
        {
            spl = b;
            internalmarks = inter;
        }

        public override void accept()
        {
            base.accept();
            Console.WriteLine("Enter the spl");
            spl = Console.ReadLine();

            Console.WriteLine("Enter the internal marks");
            internalmarks = int.Parse(Console.ReadLine());
        }

        public override void display()
        {
            Console.WriteLine("------Engg Student-----");
            base.display();
            Console.WriteLine("Branch:" + spl + "\nINternal marks:" + internalmarks); 
            calrank();
        }

        public override void calrank()
        {
            int rank = (int)per;
            Console.WriteLine("Rank:" + rank);
        }
        
    }
}
