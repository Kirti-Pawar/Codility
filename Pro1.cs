using System;

namespace Demo
{
	class Sample
	{
		public static void Arr(int[] a)
		{
			for(int i=0;i<a.Length;i++)
			{
				Console.WriteLine(a[i]);
			}
		}
		static void Main()
		{
			Arr(new int[]{1,3,4,2,7,6,5,9});
			
			Console.ReadKey();
		}
	}
}