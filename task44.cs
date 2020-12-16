using System;
using System.Linq;
namespace Demo
{
class Solution
{
	public int solution(int[] A){
	//83%
	 Array.Sort(A);
	int k=0;
    	if(A.Length != A.Distinct().Count())
	{
		k = 0;
	}

	else{
	for(int i=1;i<A[A.Length-1];i++)
	{
		
		if(!A.Contains(i))
		{
			k = 0;
			break;
		}
		else
		{
			k=1;
		}
	}
	}
	return k;
	}
	
	static void Main()
	{
	Solution s = new Solution();
	int r = s.solution(new int[]{3,3});
	Console.Write(r);
	}
}

}

//100%
using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        var set = new HashSet<int>();
            int max = 1;
            int sum = A.Length;
            int length = A.Length;
            for (int i = 0; i < length; i++)
            {
                sum += i;

                sum -= A[i];

                set.Add(A[i]);

                if (A[i] > max)
                    max = A[i];
            }

            if (max != length || sum != 0 || set.Count != length)
                return 0;

            return 1;
    }
}