using System;

namespace Demo
{
	class Sample
	{
		public static int[] Arr(int[] a)
		{
			int[] b = new int[a.Length];
			
			for(int i=0;i<a.Length;i++)
			{
				b[i]=a[i];
			}
			return b;
		}
		static void Main()
		{
			int[] res  = Arr(new int[]{1,3,4,2,7,6,5,9});
			Console.WriteLine("Elements of the second array:  ");
			for(int i=0;i<res.Length;i++)
			{
				Console.Write(res[i]+" ");
			}
			
			Console.ReadKey();
		}
	}
}