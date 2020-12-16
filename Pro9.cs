using System;
using System.Collections.Generic;
namespace Demo
{
	class Sample
	{
		public static void Arr(int[] a)
		{

			List<int> even = new List<int>();
			List<int> odd = new List<int>();

			for(int i=0;i<a.Length;i++)
			{
				
				if(a[i]%2==0)
				{
					even.Add(a[i]);
				}

				else
				{
					odd.Add(a[i]);
				}
										
			}
		Console.WriteLine("Array of even numbers");
		foreach(int e in even)
			{
				Console.Write(e+" ");										
			}

		Console.WriteLine("\nArray of odd numbers");
		foreach(int o in odd)
			{
				Console.Write(o+" ");										
			}

		}
		static void Main()
		{
			Arr(new int[]{1,5,6,1,2,7,8,4,12,11});
			Console.ReadKey();
		}
	}
}