using System;

namespace Demo
{

class Sample
{
	public int solution(int[] A)
	{
		Array.Sort(A);
		//int i=A[0]; -50%
		int i=1;  //100%
		foreach(int k in A)
		{
		   
		    if(k!=i)
		    {
			return i;
		     }
		    else
		    {
		    	i++;
		    }

		
		}
		return i;

		
	}

	static void Main()
	{
		Sample s = new Sample();
		int m = s.solution(new int[]{2,4,5});
		Console.Write(m);
	}

}

}