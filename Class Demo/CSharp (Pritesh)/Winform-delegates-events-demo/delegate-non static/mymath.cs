using System;

namespace delegates
{
	class math
	{
		public int addition(int x,int y)
		{
			return x+y;

		}
	
		public int subtraction(int x,int y)
		{
			return x-y;

		}
	

		public int multiplication(int x,int y)
		{
			return x*y;

		}

	}
	
	delegate int mathdelegate(int x,int y);

	class program
	{
		static void Main()
		{
			math m=new math();
			
			mathdelegate d=new mathdelegate(m.addition);
			Console.WriteLine(d(10,20));
			d+=m.subtraction;
			d+=m.multiplication;
			Console.WriteLine(d(10,20));


		}

	}

		


}