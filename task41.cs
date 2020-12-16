using System;
using System.Collections.Generic;
namespace Demo{
class Solution {
    public int solution(int X, int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
	//using array - 100%
         	int[] v = new int[X];
	int j = 0;
            	for (int i = 0; i < A.Length; i++)
            	{
                	if (v[A[i] - 1] == 0)
                	{
                   		v[A[i] - 1]+=1;
                    		j++;
                    		if (j == X) 
                        			return i;
                	}
            }
            return -1;


	//using list -63%
	/*List<int> list = new List<int>();
            	int j = 0;
            	for (int i = 0; i < A.Length; i++)
            	{
                	if (!list.Contains(A[i]))
               		{
                    		list.Add(A[i]);
                    		j++;
                   		if (j == X) 
                        			return i;
                	}
            	}
            return -1;*/
    }

static void Main()
{
Solution s = new Solution();
int r = s.solution(4, new int[]{1,1,1,2,4,2,3});
Console.Write(r);
}

}
}