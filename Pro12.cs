using System;
namespace Demo
{
class Sample
{
	public static int Arr(int[] a)
	{
		int temp;
		for(int i=0;i<a.Length;i++)
		{
			for(int j=0;j<a.Length;j++)
			{
				if(a[i]<a[j])
				{
					temp=a[i];
					a[i]=a[j];
					a[j]=temp;
				}

			}

		}
		return a[a.Length-2];
	}

	static void Main()
	{
		int res = Sample.Arr(new int[]{3,9,2,6,10,5});
		Console.WriteLine("Second Largest element in the array is : "+res);
	}
}

}