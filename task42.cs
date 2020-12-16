using System;
using System.Collections.Generic;
namespace Demo
{
class Solution
{
	public int[] solution(int N, int[] A) 
	{

	//77%
        	int[] b = new int[N];
        	int m1=0,m2=0;
        	for(int i=0;i<A.Length;i++)
        	{
            		if(A[i]>N)
            		{
                		for(int j=0;j<b.Length;j++)
                		{
                    			b[j]=m2;
                    
                		}
            		}
            		else if(A[i]>=1 && A[i]<=N)
            		{
                		b[A[i]-1]+=1;
                		m1=b[A[i]-1];
                		if(m1>m2)
                   			m2=m1;
            		}
        	}
       	return b;
	
	//100%
	/* int[] b= new int[N];
			int m1 = 0;
			int m2 = 0;
			int id = 0;

			for (int i = 0; i < A.Length; i++)
			{
				id = A[i] - 1;

				if (id == N)
				{
					m1 = m2;
				}
				else
				{
					b[id] = Math.Max(b[id], m1);
					b[id] += 1;

					if (m2 < b[id])
					{
						m2 = b[id];
					}
				}
			}

			for (int i = 0; i < b.Length; i++)
			{
				b[i] = Math.Max(b[i], m1);
			}

			return b;*/
    
	}
	
	static void Main()
	{
	Solution s = new Solution();
	int[] r = s.solution(5,new int[]{1,3,6,4,1,2});
	for(int j=0;j<r.Length;j++)
                {
                    Console.Write(r[j]+" ");
                }
	
	}
}

}