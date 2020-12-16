using System;

namespace Demo
{
	class Sample
	{
		public static void Arr(int[] a)
		{
			int count;
			for(int i=0;i<a.Length;i++)
			{
				count=0;
				for(int j=0;j<(a.Length);j++)
				{
					if(a[i]==a[j])
					{
						count=count+1;
					}
				}
			
				Console.WriteLine("Frequency of {0} in the array is {1}  ",a[i],count);						
			}
			
		}
		static void Main()
		{
			Arr(new int[]{1,5,1,6});
			Console.ReadKey();
		}
	}
}