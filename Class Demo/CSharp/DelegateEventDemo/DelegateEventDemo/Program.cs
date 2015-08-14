using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateEventDemo
{

    //Category => Class for delegate
    delegate void MyDelegate();  //Step 1


    //step 1
    delegate int MyMathDelegate(int x,int y);

    class Program
    {

        //step 1
        static event MyDelegate e1; //To use it in main method
        static event MyMathDelegate e2;
        static void Main()
        {
            MyMath m1 = new MyMath();
            MyMathDelegate d1 = new MyMathDelegate(m1.Addition);
            MyMathDelegate d2 = new MyMathDelegate(m1.Subtraction);
            MyMathDelegate d3 = new MyMathDelegate(m1.Multiplication);
            e2 += d1;
            e2 += d2;
            e2 += d3;
            Console.WriteLine(e2(10, 20));
        }

















        public static void Main4()
        {
            MyDelegate d1 = new MyDelegate(f1);
            e1 += d1; //Registering the event with delegate 
            e1();
        }
        static void Main3()
        {
            MyDelegate d1 = new MyDelegate(f1);
            MyMath m1 = new MyMath();
            MyMathDelegate d2 = new MyMathDelegate(m1.Addition);
            d2 += m1.Subtraction;
            d2 += m1.Multiplication;
            //Multicast delegate


            Test(d1, d2);
        }
        static void Test(MyDelegate x, MyMathDelegate y)
        {
            x();
            Console.WriteLine(y(10, 20));
        }
        static void Main2(string[] args)
        {
            MyMath m1 = new MyMath();           
            MyMathDelegate d1 = new MyMathDelegate(m1.Addition);
            Console.WriteLine(d1(10, 20)); 
        }
        static void f1()
        {
            Console.WriteLine("f1 method is called");
        }
        static void Main1(string[] args)
        {

            MyDelegate d1 = new MyDelegate(f1);
            d1();
        }
    }
}
