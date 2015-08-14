using System;


namespace ass3
{
    class program
    {
        public static void Main()
        {
            EngStudent e1 = new EngStudent();
            e1.accept();

            MedStudent m1 = new MedStudent();
            m1.accept();

            Console.WriteLine(e1);
            Console.WriteLine(m1);
            Console.ReadLine();
        }
       

    }
}
