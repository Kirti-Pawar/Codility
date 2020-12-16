using System;
using System.Collections.Generic;
using System.Linq;
namespace Demo
{
class Solution 
{
	public int[] solution(int[] A,int K) 
	{
       	 int temp;
      	 int  c=0;
  	 while(c<K)
        	 {
		for (int j = 0; j < A.Length-1; j++)
		{
			temp =A[0];
			A[0]=A[j+1];
			A[j+1]=temp;
		}
	c++;
		
	}
	return A;
	}
	
	static void Main()
	{
		Solution s = new Solution(); 
		int[] a = s.solution(new int[]{2,9,7,8,5},2);
		Console.WriteLine("Array after rotaion is : ");
		for(int i=0;i<a.Length;i++)
		{
			Console.Write(a[i]+" ");
		}
	}
}
}