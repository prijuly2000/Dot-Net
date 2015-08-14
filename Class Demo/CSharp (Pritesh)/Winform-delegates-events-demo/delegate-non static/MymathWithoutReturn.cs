using System;

namespace delegates
{
	class math
	{
		public void addition(int x,int y)
		{
			Console.WriteLine("Sum:"+(x+y));

		}
	
		public void subtraction(int x,int y)
		{
			Console.WriteLine("Subtraction:"+(x-y));
		}
	

		public void multiplication(int x,int y)
		{
			Console.WriteLine("Multiplication:"+(x*y));
		}

	}
	
	delegate void mathdelegate(int x,int y);

	class program
	{
		static void Main()
		{
			math m=new math();
			
			mathdelegate d=new mathdelegate(m.addition);
			d(10,20);
			d+=m.subtraction;
			d+=m.multiplication;
			d(100,200);

		}

	}

		


}