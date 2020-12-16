using System;

namespace Demo
{
	class Sample
	{
		public static void Arr(int[] a)
		{
			int min=0;
			int max=0;

			for(int i=0;i<a.Length;i++)
			{
				
				for(int j=0;j<(a.Length);j++)
				{
					if(a[i]<a[j])
					{
						max=a[j];
					}

					if(a[i]>a[j])
					{
						min=a[j];
					}
				}
										
			}
		Console.WriteLine("Maximum element is : "+max);
		Console.WriteLine("Minimum element is : "+min);
		}
		static void Main()
		{
			Arr(new int[]{1,5,6,1});
			Console.ReadKey();
		}
	}
}