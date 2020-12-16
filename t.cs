using System;
using System.Collections.Generic;
using System.Linq;
namespace Demo
{
	class Sample
	{
		public static int Arr(int[] A)
		{
			List<int> list = new List<int>();
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
       		
        		return list.FirstOrDefault();    

		/*int res = 0; 
        		for (int i = 0; i < A.Length; i++)  
      		  { 
           			res = res ^ A[i]; 
			Console.WriteLine(res);
        		  } 
      		  return res; */

		}
		static void Main()
		{
			int p = Arr(new int[]{12,52,12,52,79,90,79});
			Console.Write(p);
			Console.ReadKey();
		}
	}
}