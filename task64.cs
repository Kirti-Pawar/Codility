using System;
using System.Linq;
namespace Demo
{
class Solution
{
	public int solution(int[] A)	
	{
	//93%
	int t = 0;
       	 Array.Sort(A);
       	 if (A.Length >= 3) 
        	 {
       	 	for (int i = 0; i < A.Length - 2; i++) 
        		{
            			if (A[i] + A[i + 1] > A[i + 2]  && A[i + 2] + A[i + 1]> A[i]  && A[i + 2] + A[i]> A[i + 1] )
               		 	t = 1;
        		}
    	}
    	return t;
	//100%
	long p,q,r;
	if(A.Length>2)
	{
		Array.Sort(A);
		for(int i=0;i<A.Length-2;i++)
		{
			p=A[i];
			q=A[i+1];
			r=A[i+2];
			if(p+q>r && q+r>p && r+p>q)
				return 1;
		}
	}
	return 0;
	}
	
	static void Main()
	{
	Solution s = new Solution();
	int r = s.solution(new int[]{3,4,1,2,2});
	Console.Write(r);
	}
}

}