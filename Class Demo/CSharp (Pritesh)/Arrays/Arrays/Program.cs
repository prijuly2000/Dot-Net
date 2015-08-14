using System;

namespace Arrays
{
    class Program
    {
        static void Main1(string[] args)
        {
            int[] allNum = new int[4] { 1, 2, 3, 4 };

            Console.WriteLine(allNum.Length);
            Console.WriteLine(allNum.Rank);



            Console.ReadLine();

        }
    
    
        static void Main2(string[] args)
        {
            int[,] allNum = new int[3,2]{{1,2},{3,4},{5,6}};

            Console.WriteLine(allNum.Length);
            Console.WriteLine(allNum.Rank);

            foreach (int x in allNum)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
    
        
        }
        static void Main(string[] args)
        {
            int[][] allNum = new int[4][];

            allNum[0] = new int[4] { 1, 2, 3, 4 };
            allNum[1] = new int[2] { 5, 6 };
            allNum[2] = new int[3] { 7, 8, 9};
            allNum[3] = new int[5] { 11, 12, 13, 14, 15 };


            foreach(int[] x in allNum)
            {
                foreach (int j in x)
                {
                    Console.WriteLine("\t" + j);
                }
                Console.WriteLine(x);
                
            }
                Console.ReadLine();
            
        }

        
    }
}
