using System;
using System.Collections.Generic;
using System.Linq;
namespace Demo
{
	class Sample
	{
		public static int Arr(int[] A)
		{
			//using dictionary-100%
			/*Dictionary<int, int> dict = new Dictionary<int, int>();
       			foreach(var i in A)
        			{
            				if (!dict.ContainsKey(i))
           				{
            					dict.Add(i, 1);
           				}
           				else
           				{
              					dict[i]++;
            				}
       			}
       		var query = dict.Where(k=>(k.Value % 2) != 0).ToDictionary(k=>k.Key, k=>k.Value);

        		foreach(var p in query)
       		{
            			return p.Key;
        		}

       		 return 0;    */ 
		

	//using List - 66%
	/*List<int> list = new List<int>();
			if (A == null || A.Length <= 0) return 0;
       			foreach(var i in A)
        			{
            				
            				if (!list.Contains(i))
           				{
            					list.Add(i);
           				}
           				else
           				{
              					list.Remove(i);
            				}
       			
       			}
       		
        		return list.FirstOrDefault(); */

		//using bitwise xor
		/*int res = 0; 
        		for (int i = 0; i < A.Length; i++)  
      		  { 
           			res = res ^ A[i]; 
			Console.WriteLine(res);
        		  } 
      		  return res; */

		//using array
		Array.Sort(A);
		for(int i=0;i<A.Length-1;)
		{
			if(A[i]==A[i+1])
			{
				i+=2;
			}
			else
			{
				break;
			}
		
		}
		return A[i];


	}   
		static void Main()
		{
			int p = Arr(new int[]{12,52,12,52,79,90,79});
			Console.Write(p);
			Console.ReadKey();
		}
	}
}