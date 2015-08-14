using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void f1()
        {
            try
            {
                throw new DivideByZeroException();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
                //Generalized Exception handler
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void f2()
        {
            try
            {
                int[] a = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine(a[10]);
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine("Inner Block");
                throw; //Re-Throw the exception
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Inner Block");
                throw; //Re-Throw the exception
            }          
        }
        static void Main1()
        {
            try
            {

                f2();
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine("Outer Block");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Inner Block");
            }

        }


        static void f3()
        {
            try
            {
                int[] a = new int[4];
                Console.WriteLine("Enter data");
                for (int i = 0; i < 4; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine(a[10]);
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine("Inner Block");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Inner Block");
                throw;
            } 
            finally  //Makes sure that this block will be executed
            {
                Console.WriteLine("Code which must be executed...");
            }
        }
        static void Main()
        {

            try
            {
                int x;
                Console.WriteLine("Enter a number");
                x = int.Parse(Console.ReadLine());
                if (x >= 18 && x <= 60)
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    throw new MyException();
                }
            }
            catch (MyException ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
