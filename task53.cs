using System;
using Linq;

namespace Demo
{
class Solution
{
	public int solution(int[] A)
	{
		int start=0,end=1,beststart = start,sum=A[start]+A[end];
		double bestavg=sum/2.0,tmp,tmp2;

		for (var i = 2; i< A.Length;i++)
			{
				if ((tmp = (double)(sum += A[i]) / (i - start + 1)) < bestAvg)
				{
					bestAvg = tmp;

					bestStart = start;
				}
				if ((tmp2 = (A[i - 1] + A[i]) / 2.0) < bestAvg)
				{
					bestStart = start = i - 1;
					sum = A[i - 1] + A[i];
					bestAvg = tmp2;
				}
				else if (tmp2 < tmp)
				{
					start = i - 1;
					sum = A[start] + A[i];
				}
			}
			return bestStart;
	}
}
}