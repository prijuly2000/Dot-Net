using System;

namespace m
{
class A
{
    public static void f1()
    {
	Console.WriteLine("F1 function called");
    }	
}

delegate void MyDelegate();
class main
{
    public static void Main()
    {
	MyDelegate d=new MyDelegate(A.f1);
        d();	
    }
}

}