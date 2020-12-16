using System;
using System.Linq;
namespace Demo
{
class Solution
{
	public int solution(int[] A){
	int sum=0,sum1=0;
	for(int i=0;i<A.Length;i++)
	{
		if(A[i]>0)
		{
			sum+=A[i];
		}
	}

	if(sum%2==0)
		return sum;
	

    	for (int i=0; i < A.Length; ++i) 
	{
        		if (A[i] % 2 == 1 && (sum1 == 0 || A[i] < sum1)) 
		{
            			sum += sum1;
            			sum -= A[i];
            			sum1 = A[i];
        		}
   	}
    	return sum;
	}	
	
	static void Main()
	{
	Solution s = new Solution();
	int r = s.solution(new int[]{-2,2,-3,1,2});
	Console.Write(r);
	}
}

}