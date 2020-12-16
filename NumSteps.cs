using System;
using System.Linq;

namespace Demo
{
class Solution
{
	public int NumSteps(string s)
	{
		int d = Convert.ToInt32(s,2);
		int c=0;

		
		while(d>=2)
			{
				if(d%2==0)
				{
					d=(d)/2;
					c++;
				}
				else
				{
					d=(d+1);
					c++;
				}
				
			}
	return c;
	}

	static void Main()
	{
		Solution s = new Solution();
		int r = s.NumSteps("1101");
		Console.Write(r);
	}

}

}