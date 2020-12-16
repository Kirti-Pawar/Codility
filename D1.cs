using System;

namespace Demo
{
	class Sample
	{
		public static int Add(int a,int b)
		{
			int c =0;
			c= a+b;
			return c;
		}
		static void Main()
		{
			Console.WriteLine("Welcome to Codility...");
			int d = Add(3,4);
			Console.WriteLine(d);
			Console.ReadKey();
		}
	}
}