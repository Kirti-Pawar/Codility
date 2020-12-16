using System;
public class BugFixing3 {

	//check if the array contains every number from 1 to K atleast once
	public bool solution(int[] A, int K) {
		int n = A.Length;
		if (A[i]<K && A[0] != 1 || A[n - 1] < K)
			return false;
		for (int i = 0; i < n-1 ; i++) 
		{
			if (A[i] + 1 <A[i + 1])
			{
				return false;
			}
		}
		return true;	
	
               }
	
	public static void Main(string[] args) {
		int[] A = {1, 1, 2, 2, 3,3,5};
		int K = 5;
		Console.WriteLine(new BugFixing3().solution(A, K));
	}
}
