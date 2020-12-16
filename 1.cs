using System;
namespace Demo
{
class D1
{
static void Main()
{
	int[] A=new int[]{1,4,1}; 
	int res1 =0;
	for (int i = 0; i < A.Length; i++)  
      	{ 
           		res1 = res1^ A[i]; 
		Console.Write(" "+res1);
        	} 
Console.WriteLine("\n"+res1);
}
}
}
