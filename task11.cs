using System;
namespace Demo
{
class Solution 
{
 	public int solution(int N)
	{
	string n = Convert.ToString(N,2);
	int c2=0,c1=0;

		for(int i=0;i<n.Length;i++)
		{
			
			if(n[i]=='0')
			{
				c1++;
			}
			else 
			{
				if(c1>c2)
				{
				c2=c1;
				
				}
			c1=0;
			}
		}
	return c2;
	
	}
	static void Main()
	{
		Solution s = new Solution(); 
		int a = s.solution(0);
		Console.WriteLine("Maximum BinaryGap is :"+a);
	}
}
}