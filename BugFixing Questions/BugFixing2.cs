using System;

//return the minimal value that occurs in both the arrays
//if no match found return -1
class BugFixing2 {

	public int solution(int[] A, int[] B) {
        	int n = A.Length;
        	int m = B.Length;
	Array.Sort(A);
        	Array.Sort(B);
        	int i = 0;
        	for (int k = 0; k < n; k++) 
	{
	 	while (i < m  && B[i] < A[k])
        	        	i += 1;

            	    	if (A[k] == B[i])
                	return B[i];
	}
        	return -1;
    	}
	
	public static void Main(string[] args) {
		int[] A = { 4, 6, 7};
		int[] B = {2, 8,6,8,9};
		Console.WriteLine(new BugFixing2().solution(A, B));
	}
	
}
