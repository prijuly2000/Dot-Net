using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ArrayListTech
{
    class Program
    {

        static void Main(string[] args)
        {
          //  int x = 10;
          //  Program p = new Program();
          //  object o = x;
            
          //  //Console.WriteLine(o);
          //  o = p;
          ////  Console.WriteLine(o);
          //  o = 123;
          //  //Console.WriteLine(o);
          // // Console.WriteLine(123.ToString());
          //  int j = (int)o;
          //  Console.WriteLine(j);

            ArrayList arr = new ArrayList();
            arr.Add(1.11); //boxing
            int a = (int)(double)arr[0];//unbxing
            Console.WriteLine(a);
        }
    }
}
