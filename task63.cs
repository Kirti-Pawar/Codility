using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");


using System;
using System.Linq;
namespace Demo
{
class Solution 
{
    	public int solution(int[] A) 
	{
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        long [] A1 = new long[A.Length];
        long [] A2 = new long[A.Length];
    
        for (int i = 0; i < A.Length; i++)
        {
            A1[Math.Max(0, (long)i - A[i])]++;
            A2[Math.Min(A.Length-1, (long)i + A[i])]++;
        }
        long r = 0;
        long d = 0;
        for (int i = 0; i <A.Length; i++)
        {
            if (A1[i] > 0)
            {
                r += d * A1[i] + (A1[i] * (A1[i] - 1) / 2);
                d += A1[i];
            }
            d -= A2[i];
        }
        if (r <= 10000000)
            return (int) r;
        else return -1;
    }
    }
	}
	
	static void Main()
	{
	Solution s = new Solution();
	int r = s.solution(new int[]{3,4,1,2,2});
	Console.Write(r);
	}
}

}