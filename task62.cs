using System;
using System.Linq;
namespace Demo
{
class Solution
{
	public int solution(int[] A){

	//100%
	Array.Sort(A);
        	int m1 = A[A.Length-1]*A[A.Length-2]*A[A.Length-3];
        	int m2 = A[0]*A[1]*A[A.Length-1];
        	int res =0;
        	if(m1>m2)
            		res = m1;
        	else
            		res = m2;
        	return res;
	}
	
	static void Main()
	{
	Solution s = new Solution();
	int r = s.solution(new int[]{3,4,1,2,2});
	Console.Write(r);
	}
}

}