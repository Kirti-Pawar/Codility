using System;

namespace Demo
{
	class Sample
	{
		public static int Arr(int[] a)
		{
			int count=0;
			for(int i=0;i<a.Length;i++)
			{
				for(int j=i+1;j<a.Length;j++)
				{
					if(a[i]==a[j])
					{
						count++;
						
					}
					
				}
			
			}
			return count;
		}
		static void Main()
		{
			int res  = Arr(new int[]{1,5,1,5,6,8});
			
			Console.WriteLine("Number of duplicate elements in the array is : "+res);
			Console.ReadKey();
		}
	}
}