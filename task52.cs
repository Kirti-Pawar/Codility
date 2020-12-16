using System;
// you can also use other imports, for example:
 using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {

    class LinkedValue
	{
		public int value;
		public int? nextMinimum;
	}

    public int[] solution(string S, int[] P, int[] Q) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        Dictionary<char,int> impactMap = new Dictionary<char, int> {
			{'A', 1 },
			{'C', 2 },
			{'G', 3 },
			{'T', 4 },
		};
		LinkedValue []impact = new LinkedValue[S.Length];
		 Stack<LinkedValue> stack = new Stack<LinkedValue>();
		for (var i =0; i< S.Length;i++)
		{
			impact[i] = new LinkedValue
			{
				value = impactMap[S[i]],
				nextMinimum = null
			};
			while (stack.Count > 0 && impact[i].value < stack.Peek().value)
				stack.Pop().nextMinimum = i;
			if (impact[i].value > 1)
				stack.Push(impact[i]);
		}
		int []r = new int[P.Length];
		for (var i =0;i<P.Length;i++)
		{
			LinkedValue current = impact[P[i]];
			if (current.value > 1)
				while ((current.nextMinimum ?? Q[i] + 1) <= Q[i])
					current = impact[current.nextMinimum.Value];
			r[i] = current.value;
		}
		return r;
    }
}