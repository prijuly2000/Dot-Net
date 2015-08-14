using System;

namespace _2
{
    class Program
    {
      public static void Main()
      {
          Myoffice m1 = new Myoffice(5);
          Programmer p1 = new Programmer("ppp", 10, 20, 30, 40, 50, 60, 70);
          Salesmgr s1 = new Salesmgr("sss", 10, 20, 30, 40, 50, 60);
          admin a1 = new admin("aaa", 10, 20, 30, 40, 50, 60);
          m1[0] = p1;
          m1[1] = s1;
          m1[2] = a1;

         Emp e1 = m1[0];
         Emp e2 = m1[1];
         Emp e3 = m1[2];
          Console.WriteLine(m1[0]);
          

          Console.ReadLine();

         

      }


     
    }
}
