using System;

namespace Demo
{
	class Sample
	{
		public static int[] Arr(int[] a)
		{
			Console.WriteLine("Array :");
			for(int i=0;i<a.Length;i++)
			{
				Console.Write(a[i]+" ");										
			}
			int n=0;
			int[] b = new int[a.Length];
			for(int i=0;i<a.Length;i++)
			{
				
				for(int j=0;j<(a.Length);j++)
				{
					if (a[i] > a[j])s
					 { 
                    					n= a[i]; 
						a[i] = a[j]; 
						a[j] = n;
               					 } 

				}
										
			}
		return a;
		
		}
		static void Main()
		{
			int[] res = Arr(new int[]{1,5,6,1,2,7,8,4,12,11});
			Console.WriteLine("\nSorted Array in descending order :");
			for(int i=0;i<res.Length;i++)
			{
				Console.Write(res[i]+" ");										
			}
			Console.ReadKey();
		}
	}
}