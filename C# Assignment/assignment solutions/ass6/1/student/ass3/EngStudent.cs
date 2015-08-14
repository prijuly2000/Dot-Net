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

        public override string  ToString()
       {
            string str="------Engg Student-----";
            str+=base.ToString();
            str += "\nBranch:" + spl + "\nINternal marks:" + internalmarks;
            int rank = (int)Math.Ceiling(per / 10);
            str += "\nRank:" + rank;
            return str;
        }

        public override void calrank()
        {
            int rank = (int)per;
            Console.WriteLine("Rank:" + rank+"\n");
        }
        
    }
}
