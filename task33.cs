using System;
using System.Linq;
namespace Demo
{

class Solution
{
	public int solution(int[] A)
	{
		//100%
		int s1=A[0],s2=A.Sum()-s1;
		int min=Math.Abs(s1-s2);
		//for absolute value use Math.Abs()
		 if (A.Length == 2)
           		 {
                	 	return Math.Abs(A[0] - A[1]);
            		  }
		for(int i=1;i<A.Length-1;i++)
		{
			
			s1+=A[i];
			s2 -=A[i];
					
			//Console.WriteLine("s1:"+s1);
			//Console.WriteLine("s2:"+s2);
			 
			
		if(Math.Abs(s1-s2)<min)
			min=Math.Abs(s1-s2);
			
		}

		
		return min;

		//53%
		/*int min = Int32.MaxValue;
    		for (int i = 0; i < A.Length - 1; i++) {
               
       		int part1 = 0, part2 = 0;
        		for (int j = 0; j <= i; j++)
			 part1 += A[j];
        		for (int j = i + 1; j <= A.Length - 1; j++) 
			part2 += A[j];

        		int val = Math.Abs(part1 - part2);
       		 if (val < min) 	
			min = val;
  		  }
    		return min;*/

	}

	static void Main()
	{
		Solution s = new Solution();
		int m = s.solution(new int[]{3,1,2,4,3});
		Console.WriteLine(m);
	}

}

}