using System;
using System.Linq;
namespace Demo
{
	class Sample
	{
		public static void Arr(int[] a)
		{
			int count=0;
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
				if(count ==1)
				{
					Console.Write(a[i]+" ");
				}						
			}
		}
		static void Main()
		{
			Arr(new int[]{1,5,6,1});
			Console.ReadKey();
		}
	}
}