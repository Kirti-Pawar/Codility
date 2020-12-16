using System; 
using System.Collections.Generic; 

class GFG 
{ 
	// Returns true if arr[] has 
	// a subarray with sero sum 
	public static bool SubArrayExists(int[] arr) 
	{ 
		// Creates an empty HashSet hM 
		HashSet<int> hs = new HashSet<int>(); 
		// Initialize sum of elements 
		int sum = 0; 

		// Traverse through the given array 
		for (int i = 0; i < arr.Length; i++) 
		{ 
			// Add current element to sum 
			sum += arr[i]; 

			// Return true in following cases 
			// a) Current element is 0 
			// b) sum of elements from 0 to i is 0 
			// c) sum is already present in hash set 
			if (arr[i] == 0 || sum == 0 || hs.Contains(sum)) 
				return true; 

			// Add sum to hash set 
			hs.Add(sum); 
		} 

		// We reach here only when there is no subarray with 0 sum 
		return false; 
	} 

	// Main Method 
	public static void Main() 
	{ 
		int[] arr = { -3, 2, 3, 1, 6 }; 
		if (SubArrayExists(arr)) 
			Console.WriteLine("Found subarray"); 
		else
			Console.WriteLine("Not Found!"); 
	} 
} 
