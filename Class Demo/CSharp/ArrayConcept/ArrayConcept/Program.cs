using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayConcept
{
    class Program
    {
        static void Main1(string[] args)
        {
            int[] allNum = new int[4] { 1, 2, 3, 4 };
            foreach (int x in allNum)
            {
                Console.Write("\t" + x);
            }
            Console.WriteLine("Length=" + allNum.Length);
            Console.WriteLine("Rank=" + allNum.Rank);
        }
        static void Main2(string[] args)
        {
            int[,] allNum = new int[3, 2]{ { 1, 2 }, { 3, 4 },{5,6}};
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("\t" + allNum[i, j]);
                }
                Console.WriteLine();
            }
            
            //foreach (int x in allNum)
            //{
            //    Console.Write("\t" + x);
            //}
            Console.WriteLine("\nLength=" + allNum.Length);
            Console.WriteLine("Rank=" + allNum.Rank);

        }

        public static void Main()
        {
            int[][] allNum = new int[4][];
            allNum[0] = new int[3] ;
            allNum[1] = new int[2];
            allNum[2] = new int[4] ;
            allNum[3] = new int[1] ;
       //foreach is only used as ReadOnly  we cannot modify the elements
            //foreach (int[] x in allNum)
            //{
            //    foreach (int j in x)
            //    {
            //       int.Parse(Console.ReadLine()  )
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine("Enter the elements of the array...");
            for (int i = 0; i < allNum.Length; i++)
            {
                for (int j = 0; j < allNum[i].Length; j++)
                {
                    allNum[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("=======================");
            foreach (int[] x in allNum)
            {
                //foreach (int j in x)
                //{
                //    Console.Write("\t" + j);
                //}
                for (int j = 0; j < x.Length; j++)
                {
                    Console.Write("\t" + x[j]);
                }
                Console.WriteLine();
            }

        }
    }
}
