using System;
namespace Demo
{
class D1
{
static void Main()
{
	int[] A=new int[]{1,4,1}; 
	int res =0;
	for (int i = 0; i < A.Length; i++)  
      	{ 
           		res = res ^ A[i]; 
		Console.Write(" "+res);
        	} 
Console.WriteLine("\n"+res);
}
}
}
