using System;

namespace Demo
{
	class Sample
	{
		public static int[] Arr(int[] a)
		{
			return a;
		}
		static void Main()
		{
			int[] f = Arr(new int[]{1,3,4,2,7,6,5,9});
			Console.WriteLine("Array Elemets");
			for(int i=0;i<f.Length;i++)
			{
				Console.WriteLine(f[i]);
			}
			//Console.WriteLine("\n"+a.Length);
			
			Console.WriteLine("\nReverse Array Elemets");
			
			/*Array.Reverse(f);
			for(int i=0;i<f.Length;i++)
			{
				Console.WriteLine(f[i]);
			}*/

			for(int i=(f.Length)-1;i>=0;i--)
			{
				Console.WriteLine(f[i]);
			}
			Console.ReadKey();
		}
	}
}