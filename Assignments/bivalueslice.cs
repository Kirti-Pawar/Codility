using System;
using System.Linq;
namespace Demo
{

class Solution
{
	public int solution(int[] a)
	{
		//int count = 0;
   		if(a.Length == 2) 
		{
			return 2;
  		}
		int maxLength = 0;
   		for(int i = 0; i<a.Length; i++)
		{
     			int firstNo = a[i];
     			int secondNo = firstNo;
      			for(int j=i+1;j<a.Length;j++)
		 	{
       	 			int currLength = j-i+1;
        				if(a[j]!=firstNo && a[j]!=secondNo)
				{
          					if(secondNo==firstNo) 
					{
         						 secondNo = a[j];
           					 } 	
					else 
					{
        					      break;
          					}
        
       				 }
     				if(currLength > maxLength) 
				{
         					 maxLength = currLength;
       				 }
        
     			 }
   	 	}
   	 return maxLength;

	}

	static void Main()
	{
		Solution s = new Solution();
		int m = s.solution(new int[]{5,4,4,5,0,12});
		Console.WriteLine(m);
	}

}

}