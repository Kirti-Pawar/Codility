using System;
namespace Demo
{
class D1
{
static void Main()
{
	int[] A=new int[]{1,4,1}; 
	int res =0;
	int result=0; 
	for (int i = 0; i < A.Length; i++)  
      	{ 
           		result = result^ A[i]; 
		Console.Write(" "+result);
        	} 
Console.WriteLine("\n"+result);
}
}
}
