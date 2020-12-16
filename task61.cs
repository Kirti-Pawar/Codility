/**/

using System;
using System.Linq;
namespace Demo
{
class Solution
{
	public int solution(int[] A){

	//100%
	/*int c = A.Distinct().Count();
	return c;*/
	
	//100%
	Array.Sort(A);
	int c=1;
	int crr = A[0];
	if(A.Length==0)
	{
		c=0;		
	}

        	for(int i=0;i<A.Length;i++)
        	{
           		if(crr!=A[i])
                    	{
			c++;
			crr=A[i];
        		}
		}
        	return c;
	}
	
	static void Main()
	{
	Solution s = new Solution();
	int r = s.solution(new int[]{3,4,1,2,2});
	Console.Write(r);
	}
}

}