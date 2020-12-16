using System;

namespace Demo
{
	class Sample
	{
		public static int Arr(int[] a)
		{
			int sum =0;
			for(int i=0;i<a.Length;i++)
			{
				sum+=a[i];
			}
			return sum;
		}
		static void Main()
		{
			int res  = Arr(new int[]{1,3,4,2,7,6,5,9});
			Console.WriteLine("Sum of all the elements in the array is : "+res);
			Console.ReadKey();
		}
	}
}