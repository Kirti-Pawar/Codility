using System;
using System.Linq;
using System.Collections.Generic;
namespace Demo
{
class Solution
{
	public int solution(int[] A){
	//55%
	Array.Sort(A);
    	int k=1;
	for(int i=1;i<A.Length;i++)
	    {
		if(!A.Contains(i))
		{
			k = i;
            			break;
		}
		else
		{
			k = A[A.Length-1]+1;
		}
	}
	return k;

	//100%
	using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        HashSet<int> h = new HashSet<int>();

foreach (int val in A)
                if (val > 0)
                    h.Add(val);

int minpostive = 1;

foreach (int val in h)
 {
      if (val==minpostive)
                    do
                    {
                        minpostive++;
                    }
                    while (h.Contains(minpostive));
  }

 return minpostive;
    }
}	

	}
	
	static void Main()
	{
	Solution s = new Solution();
	int r = s.solution(new int[]{1,3});
	Console.Write(r);
	}
}

}